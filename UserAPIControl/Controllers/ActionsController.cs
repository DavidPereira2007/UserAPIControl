using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserAPIControl.Data;
using UserAPIControl.DTOs;
using UserAPIControl.Models;


namespace UserAPIControl.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ActionsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ActionsController(AppDbContext context)
    {
        _context = context;
    }

    [Authorize]
    [HttpGet("profile")]
    public IActionResult Profile()
    {
        return Ok("Protected route.");
    }

    [HttpPost("DeleteUser")]
    public async Task<IActionResult> DeleteUser(LoginDto dto)
    {
        var user =
            await _context.Users
                .FirstOrDefaultAsync(u => u.Name == dto.Name);
        if (user == null)
        {
            return NotFound("User not found.");
        }
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return Ok("User deleted.");
    }


}