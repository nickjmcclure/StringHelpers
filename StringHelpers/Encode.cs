using System;
using System.Text;
using System.Net;

namespace Nacho.Helpers.Encode
{
    public static class Encode
    {
        public static string Base64Encode(this string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(this string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string UrlEncode(this string instr)
        {
            return WebUtility.UrlEncode(instr);
        }

        public static string UrlDecode(this string instr)
        {
            return WebUtility.UrlDecode(instr);
        }
    }
}
