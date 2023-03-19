namespace PW2._3
{
    class Caesar
    {
        // Приватное поле, где находится сдвиг (по умолчанию 1)
        private int shift = 1;
        // Конструктор класса
        public Caesar(int shift)
        {
            this.shift = shift;
        }
        // Метод шифрования
        public string Encrypt(string text)
        {
            string caesarText = ""; // Строка caesarText для хранения зашифрованного текста
            foreach (char c in text) // Для каждой буквы в string text
            {
                if (char.IsLetter(c)) // Если это буква
                {
                    char shiftedChar = (char)(((int)char.ToUpper(c) + shift - 1040) % 32 + 1040); // Сдвинутая буква по шифру Цезаря с указанным сдвигом shift. (1040 - начало символов русского алфавита в Unicode)
                    caesarText += shiftedChar; // Заполнение caesarText сдвинутыми буквами
                }
                else // Если символ не является буквой
                {
                    caesarText += c; // Заполняется без изменений
                }
            }
            return caesarText; // Возвращается зашифрованный текст
        }
        // Метод расшифровки
        public string Decrypt(string caesarText) 
        {
            string text = ""; // Строка text для хранения расшифрованного текста
            foreach (char c in caesarText) // Для каждой буквы в string caesarText
            {
                if (char.IsLetter(c)) // Если это буква
                {
                    char shiftedChar = (char)(((int)char.ToUpper(c) - shift - 1040 + 32) % 32 + 1040); // Сдвинутая буква по шифру Цезаря с указанным сдвигом shift. (1040 - начало символов русского алфавита в Unicode)
                    text += shiftedChar; // Заполнение text сдвинутыми буквами
                }
                else // Если символ не является буквой
                {
                    text += c; // Заполняется без изменений
                }
            }
            return text; // Возвращается расшифрованный текст
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра myCaesar класса Caesar со свдигом в 1 букву
            Caesar myCaesar = new Caesar(1);

            string text = "ОПК СТИ НИТУ МИСИС"; // Текст, который нужно зашифровать
            string caesarText = "ПРЛ ТУЙ ОЙУФ НЙТЙТ"; // Зашифрованный текст

            Console.WriteLine($"Текст: {text}"); // Текст, который нужно зашифровать
            Console.WriteLine($"Зашифрованный текст: {myCaesar.Encrypt(text)}"); // Зашифрованный текст

            Console.WriteLine($"Текст: {caesarText}"); // Зашифрованный текст
            Console.WriteLine($"Расшифрованный текст: {myCaesar.Decrypt(caesarText)}"); // Расшифрованный текст

            Console.ReadKey(true);
        }
    }
}