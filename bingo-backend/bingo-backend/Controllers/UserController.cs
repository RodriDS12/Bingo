using bingo_backend.Models;
using bingo_backend.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bingo_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        // Endpoint to create a user
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                if (user != null)
                {
                    user.Password = Encriptar.EncryptPassword(user.Password);
                    _context.Users.Add(user);
                    await _context.SaveChangesAsync();

                    return Ok(new { message = "User created successfully!" });
                }

                return BadRequest(new { message = "Invalid user data." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while creating the user.", error = ex.Message });
            }


        }
    }
}
