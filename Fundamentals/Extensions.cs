using System;
using System.IO;

namespace Fundamentals
{
    public static class Extensions
    {
        public static string Replace(this string input, string needle, string haystack)
        {
            return input.Replace(needle, haystack);
        }
        public static string Reverse (this string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static byte[] ReadFully(this Stream input)
        {
            MemoryStream output = new MemoryStream();
            byte[] buffer = new byte[8192];
            int bytesRead;
            while((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0 )
            {
                output.Write(buffer, 0, bytesRead);
            }
            return output.ToArray();
        }
    }
}
