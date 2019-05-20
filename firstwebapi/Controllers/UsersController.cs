using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstwebapi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace firstwebapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private User[] users = new User[]
        {
            new User {id = 1, name = "choo", email="12@waht.com", phone= "0111", role=1},
            new User {id = 1, name = "cho2312o", email="maels@waht.com", phone= "1230111", role=2},
            new User {id = 1, name = "c6jhoo", email="12fvd@waht.com", phone= "0115511", role=3},
        };

        //GET: api/users
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return users;
        }


    }
}