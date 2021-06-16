using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Chronus.Library
{
    public class Conversion
    {
        public static string Base64ToString(string s)
        {
            var b = Convert.FromBase64String(s);
            return Encoding.GetEncoding("ISO-8859-1").GetString(b);
        }

        public static string StringToBase64(string s)
        {
            return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(s));
        }

        public static string ConvertToBase64(string arquivo)
        {
            var b = File.ReadAllBytes(arquivo);
            return Convert.ToBase64String(b);
        }

        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            var bf = new BinaryFormatter();
            var ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }

        public static System.IO.MemoryStream StringToStream(string s)
        {
            var byteArray = Encoding.UTF8.GetBytes(s);
            return new MemoryStream(byteArray);
        }

        public static Image ByteArrayToImage(byte[] b)
        {
            return Image.FromStream(new MemoryStream(b));
        }

        public static byte[] ImageToByteArray(object img)
        {
            return (byte[])new ImageConverter().ConvertTo(img, typeof(byte[]));
        }

        public static byte[] StreamToByteArray(Stream st)
        {
            using (var ms = new MemoryStream())
            {
                st.CopyTo(ms);
                return ms.ToArray();
            }
        }

        public static int DateTimeToInt(DateTime data)
        {
            return (int)(data.Date - new DateTime(1900, 1, 1)).TotalDays + 2;
        }

        public static DateTime IntToDateTime(int data)
        {
            return new DateTime(1900, 1, 1).AddDays(data - 2);
        }
    }
}
