using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using T_Zaika.Business.BusinessModels.User;
using T_Zaika.Business.Service.User;
using T_Zaika.Utilities.Helper.Security;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace T_Zaika.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IUserLoginService userLoginService;
        public LoginController(IConfiguration _config, IUserLoginService _userLoginService)
        {
             this.config = _config;
            this.userLoginService = _userLoginService;
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public IActionResult Login([FromBody] UserLoginModel userLoginModel)
        //{
        //    IActionResult response = Unauthorized();
        //    userLoginModel.Password = EncryptHelper.EnCrypt(userLoginModel.Password);
        //    UserSessionDetails userSessionDetails = this.userLoginService.Authenticate(userLoginModel);
        //    if (userSessionDetails != null)
        //    {
        //        var tokenString = GenerateJWT(userSessionDetails);
        //        response = Ok(new
        //        {
        //            token = tokenString,
        //            userDetails = userSessionDetails,
        //        });
        //    }
        //    return response;
        //}


        //private string GenerateJWT(UserSessionDetails userSessionDetails)
        //{
        //    var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:SecretKey"]));
        //    var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub, userSessionDetails.UserName),
        //        new Claim("firstName", userSessionDetails.UserName),
        //        new Claim("role",userSessionDetails.RoleName),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //    };

        //    var token = new JwtSecurityToken(
        //        issuer: config["Jwt:Issuer"],
        //        audience: config["Jwt:Audience"],
        //        claims: claims,
        //        expires: DateTime.Now.AddMinutes(30),
        //        signingCredentials: credentials
        //    );
        //    return new JwtSecurityTokenHandler().WriteToken(token);
        //}

        // GET: api/<LoginController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LoginController>
        [HttpPost]
        public IActionResult Post([FromBody] UserLoginModel userLoginModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
       
                    userLoginModel.Password = EncryptHelper.EnCrypt(userLoginModel.Password);
                    UserSessionDetails userSessionDetails = this.userLoginService.Authenticate(userLoginModel);

                    if (userSessionDetails != null)
                    {

                        var tokenHandler = new JwtSecurityTokenHandler();
                        var key = Encoding.ASCII.GetBytes(config["Jwt:SecretKey"]);
                        var tokenDescriptor = new SecurityTokenDescriptor
                        {
                            Subject = new ClaimsIdentity(new Claim[]
                            {
                                        new Claim(ClaimTypes.Name, userSessionDetails.UserId.ToString())
                            }),
                            Expires = DateTime.UtcNow.AddDays(1),
                            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                                SecurityAlgorithms.HmacSha256Signature)
                        };
                        var token = tokenHandler.CreateToken(tokenDescriptor);
                        userLoginModel.Token = tokenHandler.WriteToken(token);

                        // remove password before returning
                        userLoginModel.Password = null;
                        userLoginModel.Usertype = userSessionDetails.RoleId;

                        return Ok(userLoginModel);

                    }
                    else
                    {
                        userLoginModel.Password = null;
                        userLoginModel.Usertype = 0;
                        return Ok(userLoginModel);
                    }
                }
                userLoginModel.Password = null;
                userLoginModel.Usertype = 0;
                return Ok(userLoginModel);
            }
            catch (Exception)
            {

                throw;
            }
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
