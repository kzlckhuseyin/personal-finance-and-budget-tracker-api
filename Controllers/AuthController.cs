using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterDto dto)
    {
        var res = _authService.Register(dto);
        if (!res)
        {
            return BadRequest();
        }
        return Ok();
    }

    [HttpPost("login")]
    public IActionResult Login(LoginDto dto)
    {
        var token = _authService.Login(dto);
        if (token == null)
        {
            return Unauthorized();
        }

        return Ok(token);
    }

}