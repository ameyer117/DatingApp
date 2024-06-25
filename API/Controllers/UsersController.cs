using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController(ApplicationDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<ApplicationUser>>> GetUsers()
    {
        return await context.Users.ToListAsync();
    }
    
    [HttpGet("{id:int}")]
    public async Task<ActionResult<ApplicationUser?>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);

        if (user is null)
            return NotFound();

        return user;
    }
}