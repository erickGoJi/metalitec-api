using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using biz.admin.Repository;
using biz.admin.Repository.User;
using biz.admin.Services.Email;
using CryptoHelper;
using dal.admin.DBContext;
using dal.admin.Repository.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace dal.admin.Repository.User
{
    public class UserRepository:GenericRepository<biz.admin.Models.User>, IUserRepository
    {
        private IConfiguration _config;
        private IEmailService _emailService;

        public UserRepository(MetalitecDataContext context, IConfiguration config, IEmailService emailService) : base(context)
        {
            _config = config;
            _emailService = emailService;
        }
        
        public string HashPassword(string password)
        {
            return Crypto.HashPassword(password);
        }
        public bool VerifyPassword(string hash, string password)
        {
            return Crypto.VerifyHashedPassword(hash, password);
        }

        public string BuildToken(biz.admin.Models.User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddMinutes(1),
                // Issuer = ,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public string SendMail(string emailTo, string body, string subject)
        {
            EmailModel email = new EmailModel();
            email.To = emailTo;
            email.Subject = subject;
            email.Body = body;
            email.IsBodyHtml = true;

            return _emailService.SendEmail(email);
        }
    }
}