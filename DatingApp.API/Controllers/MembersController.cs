using DatingApp.API.Data;
using DatingApp.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MembersController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<User[]>> GetMembers()
    {
        return await context.Users.ToArrayAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetMemberById(string id)
    {
        User? user =  await context.Users.FirstOrDefaultAsync(user => user.Id == id);

        if (user is null)
        {
            return NotFound();
        }

        return user;
    }

}
