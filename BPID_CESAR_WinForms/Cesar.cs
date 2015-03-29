using System;
using System.Text;

namespace BPID_CESAR_WinForms
{
    class Cesar
    {
        public static readonly int NUMBER_SYMBOLS_IN_ALPHABET = 128;
        public static string Encrypt(string text, int shift)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var symbol in text)
            {
                sb.Append(Char.ConvertFromUtf32((symbol + shift) % NUMBER_SYMBOLS_IN_ALPHABET));
            }
            return sb.ToString();
        }
        public static string Decrypt(string cipher, int shift)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var symbol in cipher)
            {
                sb.Append(Char.ConvertFromUtf32((symbol + NUMBER_SYMBOLS_IN_ALPHABET - shift) % NUMBER_SYMBOLS_IN_ALPHABET));
            }
            return sb.ToString();
        }
    }
}
