using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartCollar.Services;

namespace SmartCollar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IService _service;

        public AccountController(IService service)
        {
            _service = service;
        }


        [HttpPost("[action]")]
        public IActionResult Login([FromBody] AccountDTO account)
        {
            var md5 = MD5.Create();
            var hash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(account.password)));
            var result = _service.Login(account.user, hash);

            if (result != null)
                return Ok(new { token = result });
            else
                return Unauthorized("Senha ou usuário errados.");
        }


        [HttpPost("[action]")]
        public IActionResult Register([FromBody]AccountDTO account)
        {
            var md5 = MD5.Create();
            var hash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(account.password)));
            var result = _service.Register(account.user, hash, account.name);

            if (result)
                return Ok(new { token = _service.Login(account.user, hash) });
            else
                return BadRequest(new { errorMessage = "Username já existente." });
        }


        [HttpPost("[action]")]
        public IActionResult Logout([FromBody] AccountDTO account)
        {
            var result = _service.Logout(account.user, account.token);
            if (result)
                return Ok();
            else
                return Unauthorized("Senha ou usuário errados.");
        }

        public class AccountDTO
		{
            public string user { get; set; }
            public string token { get; set; }
            public string name { get; set; }
            public string password { get; set; }
        }
    }
}