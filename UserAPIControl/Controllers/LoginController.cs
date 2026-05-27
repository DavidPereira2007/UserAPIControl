using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserAPIControl.Data;
using UserAPIControl.DTOs;
using UserAPIControl.Models;
using UserAPIControl.Services;


namespace UserAPIControl.Controllers;

[ApiController]
[Route("api/[controller]")]

public class LoginController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly TokenService _tokenService;

    public LoginController(AppDbContext context, TokenService tokenService)
    {
        _context = context;
        _tokenService = tokenService;
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        var user =
            await _context.Users
                .FirstOrDefaultAsync(u => u.Name == dto.Name);

        if (user == null)
        {
            return Unauthorized("Invalid credentials.");
        }

        bool validPassword =
            BCrypt.Net.BCrypt.Verify(
                dto.Password,
                user.PasswordHash
            );

        if (!validPassword)
        {
            return Unauthorized("Invalid credentials.");
        }

        string token = _tokenService.GenerateJwtToken(user);

        return Ok(token);
    }

}
