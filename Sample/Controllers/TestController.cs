using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Repository.Data;
using Sample.Services;

namespace Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        public readonly IUserService<Models.User> _Service;

        public TestController(IUnitOfWork uow)
        {
            _Service = new UserService<Models.User>(uow);
        }

        public IActionResult Index()
        {
            return Ok(_Service.GetList());
        }

        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] Models.User user)
        {
            return Ok(_Service.Insert(user));
        }
    }
}
