public interface IAuthService
{
    bool Register(RegisterDto dto);
    string? Login(LoginDto dto);
}