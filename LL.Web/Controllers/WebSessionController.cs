using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using LL.Web.Models;
using LL.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LL.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebSessionController : ControllerBase
    {
        private readonly LL.Web.Services.IWebSessionServices _services;

        public WebSessionController(IWebSessionServices services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("compute")]
        public async Task<ActionResult<double>> ComputeUserSession([FromBody]ViewModel.WebSessionItem input)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return await _services.ComputeUserSession(input);
        }
    }
}