using System;
using System.IO;
using System.Linq;

namespace NoteAppNew
{
    class CryptSave
    {
        //Имя пользователя
        private static string User = Environment.UserName;
        //Ключ
        //public string Key;
        //Путь до места сохранения txt файла
        public string TextPath = $"C:/Users/{User}/Desktop/text.txt";
        //public CryptSave(string key)
        //{
        //    Key = key ?? "0000";
        //}
        //Метод сохранения файлов

        public void Save(string Text, string Where, string Key)
        {
            if (Text.Count() > 1)
            {
                if (File.Exists(Where))
                {
                    File.Create(Where).Close();
                }

                File.WriteAllText(Where, Encrypt(Text, Key));
            }
        }

        private string Cipher(string text, string secretKey)
        {
            //генератор повторений пароля
            string GetRepeatKey(string s, int n)
            {
                string r = s;
                while (r.Length < n)
                {
                    r += r;
                }

                return r.Substring(0, n);
            }

            string currentKey = GetRepeatKey(secretKey, text.Length);
            string res = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                res += ((char)(text[i] ^ currentKey[i])).ToString();
            }

            return res;
        }

        //шифрование текста
        public string Encrypt(string plainText, string Key)
        {
            return Cipher(plainText, Key);
        }

        //расшифровка текста
        public string Decrypt(string encryptedText, string Key)
        {
            return Cipher(encryptedText, Key);
        }
    }
}
