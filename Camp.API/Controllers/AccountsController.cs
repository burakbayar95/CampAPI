using Camp.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private ILoginService service;
        public AccountsController(ILoginService service)
        {
            this.service = service;

        }

        public IActionResult Get()
        {
            var result = service.GetAllAccounts();
            return Ok(result);
        }
    }
}
