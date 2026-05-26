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

}