using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;

namespace Fundoo_note_application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBl iuserBl;
        public UserController(IUserBl iuserBl)
        {
            this.iuserBl = iuserBl;
        }
        [HttpPost("Register")]
        public IActionResult Registeration(Registeration registeration)
        {
            try
            {
                var result = iuserBl.UserRegisteration(registeration);
                if(result != null)
                {
                    return this.Ok(new { Sucess = true, message = "User Registeration Sucessful" });
                }
                else
                {
                    return this.BadRequest(new { Sucess = false, message = "User Registeration UnSucessful", data = result });
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
