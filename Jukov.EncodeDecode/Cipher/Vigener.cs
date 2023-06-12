using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukov.EncodeDecode
{
    class Vigener : Cipher
    {
        private string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }

            return p.Substring(0, n);
        }

        private StringBuilder CodeEncode()
        {
            var gamma = GetRepeatKey(Password, Text.Length);
            var value = new StringBuilder();
            var fullAlfabetLength = GetFullAlfabetRus().Length;
            var letters = GetFullAlfabetRus();

            for (int i = 0; i < Text.Length; i++)
            {
                var letterIndex = letters.IndexOf(Text[i]);
                var codeIndex = letters.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    value.Append(Text[i].ToString());
                }
                else if(Mode == CipherMode.Decode)            
                    value.Append(letters[(fullAlfabetLength + letterIndex + (-1 * codeIndex)) % fullAlfabetLength].ToString());
                else
                    value.Append(letters[(fullAlfabetLength + letterIndex + (1 * codeIndex)) % fullAlfabetLength].ToString());
            }       

            return value;    
        }

        public string Encrypt() => CodeEncode().ToString();

        public string Decrypt() => CodeEncode().ToString();
    }
}
