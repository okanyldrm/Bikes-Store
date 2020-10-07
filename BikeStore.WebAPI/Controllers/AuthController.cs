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
        public IActionResult Login([FromBody]LoginModel model)
        {

            if (model.UserName=="admin" && model.Password=="admin123")
            {

                var now = DateTime.UtcNow;
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,model.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()), 
                };
                var singningkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureKey"));
             
                var tokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = singningkey,
                    ValidateIssuer = true,
                    ValidIssuer = "localhost",
                    ValidAudience = "cather-wong",
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    RequireExpirationTime = true,
                };
                var jwt = new JwtSecurityToken(
                    issuer:"localhost",
                    audience:"cather-wong",
                    claims:claims,
                    notBefore:now,
                    expires:now.AddDays(1),
                    signingCredentials:new SigningCredentials(singningkey,SecurityAlgorithms.HmacSha256)
                    );
                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                var responseJson = new
                {
                    access_token = encodedJwt,
                    expires_in = (int) TimeSpan.FromMinutes(2).TotalSeconds
                };

                return Ok(responseJson);
            }
            return Unauthorized();
        }
    }
}
