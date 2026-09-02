using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public class AuthService : IAuthService
{
    private readonly AppDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthService(AppDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }
    public string? Login(LoginDto dto)
    {
        var user = _context.Users.FirstOrDefault(x => x.Email == dto.Email);
        if (user == null)
        {
            return null;
        }

        bool result = BCrypt.Net.BCrypt.Verify(dto.Password, user.PasswordHash);

        if (!result)
        {
            return null;
        }

        return CreateToken(user);

    }

    private string CreateToken(User user)
    {
        var jwtSettings = _configuration.GetSection("JwtSettings");

        // Token içerisine eklenecek kimlik bilgileri (Claims)
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Email, user.Email)
        };

        // appsettings.json dosyasındaki gizli anahtarı alıyoruz
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Secret"]!));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        // Token özelliklerini tanımlama
        var token = new JwtSecurityToken(
            issuer: jwtSettings["Issuer"],
            audience: jwtSettings["Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(double.Parse(jwtSettings["ExpirationInMinutes"]!)),
            signingCredentials: creds
        );

        // Token'ı string formata çeviriyoruz
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public bool Register(RegisterDto dto)
    {
        var user = _context.Users.FirstOrDefault(x => x.Email == dto.Email);

        if (user != null)
        {
            return false;
        }

        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(dto.Password);

        user = new User
        {
            Email = dto.Email,
            PasswordHash = hashedPassword
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        return true;
    }
}