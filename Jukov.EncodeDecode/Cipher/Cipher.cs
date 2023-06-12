using System.Windows.Forms;

namespace Jukov.EncodeDecode
{
    class Cipher : MyEnum
    {
     
        public int Key { get; set; }

        public string Password { get; set; }

        public string Text { get; set; }

        public CipherType Type { get; set; }

        public CipherMode Mode { get; set; }

        public const string ALFABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        public int Parse(string text)
        {
            int value;
            if (int.TryParse(text, out value))
            {
                if(value == 0)
                {
                    MessageBox.Show("Ключ не может быть равне 0", "Ошибка нуля",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return 0;
                }
                else
                    return value;

            }
            else
                MessageBox.Show("Введите ключ", "Ошибка ввода ключа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }

        public static string GetFullAlfabetRus()
        {
            return ALFABET + ALFABET.ToLower();
        }

       
    }
}
