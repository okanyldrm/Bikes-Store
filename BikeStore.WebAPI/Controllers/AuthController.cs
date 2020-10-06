using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using BikeStore.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;


namespace BikeStore.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {


        [HttpPost("login")]
        public IActionResult Index([FromBody]LoginModel model)
        {

            if (model.UserId=="admin" && model.Password=="admin123")
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,model.UserId),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()), 
                };
                var singningkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"));
                var token = new JwtSecurityToken(
                    issuer:"oko.com",
                    audience:"oko.com",
                    expires: DateTime.Now.AddDays(1),
                    claims:claims,
                    signingCredentials:new Microsoft.IdentityModel.Tokens.SigningCredentials(singningkey,SecurityAlgorithms.HmacSha256)
                    
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }
    }
}
