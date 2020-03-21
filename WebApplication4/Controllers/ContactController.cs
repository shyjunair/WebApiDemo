using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet, Route("api/Email")]
        public IActionResult Email()
        {
            try
            {
                return Ok ("Testing application");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet, Route("api/Square")]
        public IActionResult Square(int a)
        {
            try
            {
                return Ok(a * a);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}