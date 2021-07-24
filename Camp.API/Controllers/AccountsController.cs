using Camp.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Camp.API.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;

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

        [HttpGet] //get
        [Authorize(Roles ="admin")]
        public IActionResult Get()
        {
            var result = service.GetAllAccounts();
            return Ok(result);


        }
        [HttpPost]
        public IActionResult Login(UserLoginModel userLoginModel)
        {
            var user = service.GetUser(userLoginModel.UserName, userLoginModel.Password);

            if (user==null)
            {
                return BadRequest(new { message = "Hatalı kullanıcı adı veya şifre" });
            }
            string issiuer = "dxdiag";
            string audience = "dxdiag";
            var key = "ghostmojoghostmojoghostmojo";
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credantial = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(ClaimTypes.Role,user.Role)

            };
            var token = new JwtSecurityToken(
                issuer: issiuer,
                audience: audience,
                claims: claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credantial


                );

            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
            //TODO 1: JWT
        }

    }
}
