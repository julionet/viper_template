using System.Security.Cryptography;
using System.Text;

namespace Chronus.Library
{
    public class Security
    {
        private Security() { }

        public static string GetMD5(string s)
        {
            var md5 = MD5.Create();

            var inputBytes = Encoding.ASCII.GetBytes(s);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("X2"));
            }
            return (sb.ToString().ToUpper());
        }
    }
}
