using System.Security.Cryptography;
using System.Text;

namespace Nacho.Helpers.Hash
{
    public static class Hash
    {
        public static string getMD5Hash(string instr)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(instr));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static string toMD5Hash(this string instr)
        {
            return getMD5Hash(instr);
        }
    }
}
