using bingoapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bingoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                return Ok();

            }
            catch (Exception ex) {

                return Ok();

            }


        }
    }
}
