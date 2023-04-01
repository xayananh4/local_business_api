using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Text;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LocalBusinessApi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UserController : ControllerBase
  {
    private readonly LocalBusinessApiContext _db;

    public UserController(LocalBusinessApiContext db)
    {
      this._db = db;
   
    }

    [HttpPost("Authenticate")]
    public async Task<IActionResult> Authenticate([FromBody] UserCred userCred)
    {
      var user = await _db.Users.FirstOrDefaultAsync(item => item.UserId == userCred.username && item.Password == userCred.password);
      return Ok();
    }


  }




}
