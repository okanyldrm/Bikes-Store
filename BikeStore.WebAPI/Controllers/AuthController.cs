using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BikeStore.Business.Abstract;
using BikeStore.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BikeStore.WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {



        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody]LoginModel loginModel)
        {

            //String password = loginModel.Password;
            //String salt = loginModel.UserName;
            //ASCIIEncoding encoding = new ASCIIEncoding();


            //Byte[] textBytes = encoding.GetBytes(password);
            //Byte[] keyBytes = encoding.GetBytes(salt);
            //Byte[] hashBytes;

            //using (HMACSHA256 hash = new HMACSHA256(keyBytes))
            //    hashBytes = hash.ComputeHash(textBytes);
            //var hashPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            //var user = new User(); 
            ////user.user_id = loginModel.;
            //user.hash_password = hashPassword;
            //user.user_name = loginModel.UserName;





            if (loginModel.UserName=="admin" && loginModel.Password=="admin123")
            {
                var now = DateTime.UtcNow;
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub,loginModel.UserName),
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



        [HttpPost("register")]
        public IActionResult Register([FromBody] User registerModel)
        {

            String password = registerModel.hash_password;
            String salt = registerModel.user_name;
            ASCIIEncoding encoding = new ASCIIEncoding();

            Byte[] textBytes = encoding.GetBytes(password);
            Byte[] keyBytes = encoding.GetBytes(salt);
            Byte[] hashBytes;

            using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                hashBytes = hash.ComputeHash(textBytes);

            var hashPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

            var user = new User();
            user.user_id = registerModel.user_id;
            user.hash_password = hashPassword;
            user.user_name = registerModel.user_name;

            _userService.Add(user);

            return Ok(user);
        }
    }
}
