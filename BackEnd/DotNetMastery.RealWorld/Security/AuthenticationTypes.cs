using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace DotNetMastery.RealWorld.Security
{
    public static class AuthenticationTypes
    {
        #region 1. Basic Authentication
        // Transmits username:password encoded in Base64 via the Authorization header
        // Header: Authorization: Basic <base64-encoded-string>
        public static bool VerifyBasicAuthentication(string authHeader, string expectedUser, string expectedPass)
        {
            if (string.IsNullOrWhiteSpace(authHeader) || !authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            string encodedCredentials = authHeader.Substring("Basic ".Length).Trim();
            byte[] credentialBytes = Convert.FromBase64String(encodedCredentials);
            string credentials = Encoding.UTF8.GetString(credentialBytes);

            string[] parts = credentials.Split(':', 2);
            if (parts.Length != 2) return false;

            string username = parts[0];
            string password = parts[1];

            return username == expectedUser && password == expectedPass;
        }
        #endregion

        #region 2. API Key Authentication
        // Transmits a pre-shared secret via header (e.g., X-API-KEY) or query string
        // Typically used for server-to-server or third-party service communication
        public static bool VerifyApiKey(string providedApiKey, string systemApiKey)
        {
            if (string.IsNullOrWhiteSpace(providedApiKey))
            {
                return false;
            }

            // Using constant-time/safe comparison to prevent timing attacks
            return string.Equals(providedApiKey, systemApiKey, StringComparison.Ordinal);
        }
        #endregion

        #region 3. Cookie-Based Authentication
        // Used primarily in traditional server-rendered web applications (MVC / Razor Pages)
        // The server validates credentials, creates an encrypted session/cookie, and sends it to the browser
        public static ClaimsPrincipal CreateCookiePrincipal(string username, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, role)
            };

            var identity = new ClaimsIdentity(claims, "CookieAuthScheme");
            return new ClaimsPrincipal(identity);
        }
        #endregion

        #region 4. Token-Based Authentication (JWT - JSON Web Token)
        // Modern standard for REST APIs, microservices, and SPAs (Angular/React)
        // Stateless: The server validates the cryptographic signature without querying the database each time
        private const string SecretKey = "YourSuperSecretKeyMustBeAtLeast32BytesLong!";

        public static string GenerateJwtToken(string userId, string username, string role)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userId),
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.Role, role),
                    new Claim("Department", "Engineering") // Custom claim
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static ClaimsPrincipal? ValidateJwtToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(SecretKey);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false, // Set to true with valid issuer in production
                ValidateAudience = false, // Set to true with valid audience in production
                ClockSkew = TimeSpan.Zero
            };

            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                return principal;
            }
            catch
            {
                return null; // Token invalid, expired, or tampered with
            }
        }
        #endregion
    }
}