﻿namespace SchoolPro.Api.Auth
{
    public static class JwtAuth
    {
        public static NewToken GenerateToken(User user, Client client)
        {
            var expirationDate = DateTime.UtcNow.AddMinutes(SharedConfigurations.Minutes);

            //Recupera as configurações JWT
            var key = Encoding.UTF8.GetBytes(JwtSettings.SecretKey);
            var issuer = JwtSettings.JwtIssuer;
            var audience = JwtSettings.JwtAudience;

            //Monta o descritivo JWT que conterá todos os dados associados ao acesso, que serão incluídos no token
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Name!.ToString()),
                    new Claim(ClaimTypes.Email, user.Email!.ToString()),
                    new Claim(ClaimTypes.Role, user.Role!.Name!.ToString()),
                    new Claim(ClaimTypes.Hash, client.Id!.ToString()),
                }),
                Expires = expirationDate,
                Issuer = issuer,
                Audience = audience,

                //Define o algoritmo usado na criptografia da token
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };

            //Cria e assina digitalmente o token
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            NewToken newToken = new()
            {
                Token = tokenHandler.WriteToken(token),
                ExpirationDate = DateOnly.FromDateTime(DateTime.Now.AddDays(1))
            };

            //TODO: ENCRIPTAR O TOKEN POSTERIORMENTE
            return newToken;
        }
    }

    public class NewToken
    {
        public string Token { get; set; } = null!;
        public DateOnly ExpirationDate { get; set; }
    }
}
