using AisApi.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AisApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public List<UserDto> UserList = new List<UserDto>()
        {
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,      
            new UserDto{Id = 1, Name="ceyhun" }  ,
        };
        [HttpGet("get-user")]
        public IActionResult Get()
        {
            //api sorgu atdi......
            return Ok(UserList);
        }

        [HttpPost]
        public IActionResult Create(int id , string name)
        {
            var user = new UserDto
            {
                Id = id,
                Name = name
            };
            UserList.Add(user);
            return Created("",user);
        }
    }
}
