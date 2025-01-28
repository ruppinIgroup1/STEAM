using Microsoft.AspNetCore.Mvc;
using STEAM.Models;
using System.Xml.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace STEAM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // POST api/<UsersController>
        [HttpPost("AddNewUser")]
        public int AddNewUser(string Name, string Email, string Password)
        {
            UserClass user = new UserClass();
            return user.AddNewUser(Name, Email, Password);
        }
        [HttpPost("LoginUser/{Email}/{Password}")]
        public UserClass LoginUser(string Email, string Password)
        {
            UserClass user = new UserClass();
            return user.LoginUser(Email, Password);
        }


        // GET: api/<UsersController>
        [HttpGet]
        public Object MyUsers()
        {
            UserClass user = new UserClass();
            return user.MyUsers();
        }
        //public Object GetUsersWithGameDetails()
        //{
        //    UserClass user = new UserClass();
        //    return user.GetUsersWithGameDetails();
        //}

            // GET api/<UsersController>/5
            [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("api/GetUsersWithGameDetails")]
        public IActionResult GetUsersWithGameDetails()
        {
            DBservices dbs = new DBservices();
            Object result = dbs.GetUsersWithGameDetails();
            return Ok(result);
        }


        // PUT api/<UsersController>/5
        [HttpPut("updateUser/{id}")]
        public int UpdateUser(int id, [FromBody] UserClass user)
        {
            DBservices dbs = new DBservices();
            return dbs.UpdateUser(id, user.Email, user.Password, user.Name);
        }

        [HttpPut("UpdateUserisActive/{Id}/{IsActive}")]
        public int UpdateUserisActive(int Id, bool IsActive)
        {
            DBservices dbs = new DBservices();
            return dbs.UpdateUserisActive(Id, IsActive);
        }


            // DELETE api/<UsersController>/5
            [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
