using BussinesLogic.DTOs.User;
using BussinesLogic.Interfaces;
using Data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService service) 
        {
            this.service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]UserRegisterDto model)
        {
            try
            {
                await service.RegisterAsync(model);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]UserLoginDto model)
        {
            try
            {
                var user = await service.LoginAsync(model);
                return Ok(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser([FromRoute]string id)
        {
            try
            {
                var user = await service.GetUserAsync(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = service.GetUsers();
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
