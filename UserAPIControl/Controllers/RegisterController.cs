using UserAPIControl.Data;
using UserAPIControl.Models;
using UserAPIControl.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace UserAPIControl.Controllers;

[ApiController]
[Route("api/[controller]")]

public class RegisterController : ControllerBase
{
        private readonly AppDbContext _context;

        public RegisterController(AppDbContext context)
        {
            _context = context;
        }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        var userExists =
            await _context.Users
                .AnyAsync(u => u.Name == dto.Name);

        if (userExists)
        {
            return BadRequest("User already exists.");
        }

        string passwordHash =
            BCrypt.Net.BCrypt.HashPassword(dto.Password);

        var user = new User
        {
            Name = dto.Name,
            PasswordHash = passwordHash
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return Ok("User created.");
    }
}

