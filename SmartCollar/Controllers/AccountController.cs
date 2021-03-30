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

        public IActionResult Login(string user, string password)
        {
            var md5 = MD5.Create();
            var hash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(password)));
            var result = _service.Login(user, hash);

            if (result != null)
                return Ok(new { token = result });
            else
                return Unauthorized("Senha ou usuário errados.");
        }

        public IActionResult Register(string user, string password, string name)
        {
            var md5 = MD5.Create();
            var hash = Encoding.UTF8.GetString(md5.ComputeHash(Encoding.UTF8.GetBytes(password)));
            var result = _service.Register(user, hash, name);

            if (result)
                return Ok(new { token = _service.Login(user, password) });
            else
                return BadRequest(new { errorMessage = "Username já existente." });
        }

        public IActionResult Logout(string user, string token)
        {
            var result = _service.Logout(user, token);
            if (result)
                return Ok();
            else
                return Unauthorized("Senha ou usuário errados.");
        }
    }
}