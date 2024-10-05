using System.Security.Cryptography;
using System.Text;

namespace Gravatar
{
    public static class GravatarExtension
    {
        public static string ToGravatar(this string email, int size = 50)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains('@'))
            {
                return string.Empty;
            }

            // Normalizando o e-mail
            email = email.Trim().ToLower();
            var inputBytes = Encoding.ASCII.GetBytes(email);
            var hashBytes = MD5.HashData(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hashBytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return $"https://www.gravatar.com/avatar/{sb.ToString().ToLower()}?s={size}";
        }
    }
}
