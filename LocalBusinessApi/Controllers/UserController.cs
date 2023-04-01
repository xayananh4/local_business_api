using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LocalBusinessApi.Models;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LocalBusinessApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

    }




}
