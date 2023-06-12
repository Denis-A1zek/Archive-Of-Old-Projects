using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;


namespace Jukov.EncodeDecode
{
    public partial class Encode : Form
    {
        Cipher textCipher;

        public Encode()
        {
            InitializeComponent();

            textCipher = new Cipher();
        }

        private void buttonOpenCaesar_Click(object sender, EventArgs e)
        {
            textCipher.Type = MyEnum.CipherType.Caesar;
            textModeVisible.Text = "Режим шифрования: Цезарь";
            textBoxKey.Text = "Введите ключ";
        }

        private void buttonVigenere_Click(object sender, EventArgs e)
        {
            textCipher.Type = MyEnum.CipherType.Vigener;
            textModeVisible.Text = "Режим шифрования: Виженера";
            textBoxKey.Text = "Введите пароль";
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuiOSSwitch1_Click(object sender, EventArgs e)
        {
            if (switchModeCipher.Value)
                buttonEncode.Text = "Шифровать";
             else
                buttonEncode.Text = "Дешифровка";
        }

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            switch (textCipher.Type)
            {
                case MyEnum.CipherType.Caesar:
                    var caesar = new Caesar();

                    caesar.Key = caesar.Parse(textBoxKey.Text);
                    caesar.Text = textBoxEncoder.Text;

                    if (switchModeCipher.Value && caesar.Text != null)
                    {
                        caesar.Mode = MyEnum.CipherMode.Encode;
                        textSecondBox.Text = caesar.CaesarEncrypt();
                    }                       
                    else if (!switchModeCipher.Value && caesar.Text != null)
                    {
                        caesar.Mode = MyEnum.CipherMode.Decode;
                        textSecondBox.Text = caesar.CaesarDecrypt();
                    }                       
                    else
                        return;
                    break;
                case MyEnum.CipherType.Vigener:
                    var vigener = new Vigener();

                    vigener.Password = textBoxKey.Text;
                    vigener.Text = textBoxEncoder.Text;

                    if (switchModeCipher.Value && vigener.Text != null)
                    {
                        vigener.Mode =  MyEnum.CipherMode.Encode;
                        textSecondBox.Text = vigener.Encrypt();
                    }
                    else if (!switchModeCipher.Value && vigener.Text != null)
                    {
                        vigener.Mode = MyEnum.CipherMode.Decode;
                        textSecondBox.Text = vigener.Decrypt();
                    }
                    break;
                default:
                    MessageBox.Show("Выберите тип шфирования", "Ошибка выбора шифрования", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(textSecondBox.Text);
                streamWriter.Close();
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            var fromAddress = new MailAddress("diplomkolledz@gmail.com", "Никита");

            if(textMailBox.Text.Contains("@"))
            {
                var toAddress = new MailAddress(textMailBox.Text);
                var mail = new MailMessage(fromAddress, toAddress);

                mail.Subject = "Шифрование";
                mail.Body = textSecondBox.Text;

                var smtp = new SmtpClient("smtp.gmail.com", 587);

                smtp.Credentials = new NetworkCredential("diplomkolledz@gmail.com", "Z7T-qRm-T5y-uzb");
                smtp.EnableSsl = true;
                smtp.Send(mail);
                MessageBox.Show($"Сообщение отправлено по адресу: {textMailBox.Text}", "Успешно",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show($"Неверный адрес: {textMailBox.Text}", "Отклонено", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "doc files (*.doc)|*.doc|All files (*.*)|*.*";

            if(openDialog.ShowDialog() == DialogResult.OK)
            {
                object file = openDialog.FileName;

                var wordApp = new Microsoft.Office.Interop.Word.Application();
                var wordDoc = wordApp.Documents.Open(ref file);

                string text = "";

                for (int i = 0; i < wordDoc.Paragraphs.Count; i++)
                {
                    text += "\r\n" + wordDoc.Paragraphs[i + 1].Range.Text;
                    textModeVisible.Text = $"Загрузка слов {i+1} из {wordDoc.Paragraphs.Count}";
                }
                textModeVisible.Text = $"Загружено успешно {wordDoc.Paragraphs.Count} слов";
                textBoxEncoder.Text = text;
                wordDoc.Close();
                wordApp.Quit();


            }

        }
    }
}
