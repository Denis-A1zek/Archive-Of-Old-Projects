using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jukov.EncodeDecode
{
    class Caesar : Cipher
    {

        private StringBuilder CodeEncode()
        {
            var value = new StringBuilder();
            var alphabet = GetFullAlfabetRus();
            var lengthOfAlfabet = alphabet.Length;
            
            for (int i = 0; i < Text.Length; i++)
            {
                var buffer = Text[i];
                var index = alphabet.IndexOf(buffer);

                if (index < 0)
                    value.Append(Text[i]);
                else if(Mode == CipherMode.Decode)
                    value.Append(alphabet[(lengthOfAlfabet + index - Key) % lengthOfAlfabet]);
                else
                    value.Append(alphabet[(lengthOfAlfabet + index + Key) % lengthOfAlfabet]);
            }
            return value;
        }

        public string CaesarEncrypt() => CodeEncode().ToString();

        public string CaesarDecrypt() => CodeEncode().ToString();
      
    }
}
