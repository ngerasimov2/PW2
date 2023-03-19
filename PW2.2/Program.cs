namespace PW2._2
{
    class Numbers
    {
        // Приватное поле n, изначально равное 0
        private int n = 0;
        // Специальный метод SetNumber
        public bool SetNumber(int number)
        {
            // Если устанавливаемое значение number = n + 1, вернуть true
            if (number == n + 1)
            {
                n = number;
                return true;
            }
            // В противном случае обнулить и вернуть false
            else
            {
                n = 0;
                return false;
            }
        }
        // Публичный метод, который возвращает ожидаемое значение n, т. е n + 1
        public int GetNumber()
        {
            return n + 1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание экземпляра класса myNumbers класса Numbers
            Numbers myNumbers = new Numbers();

            // Бесконечный цикл
            while (true)
            {
                // Выводится строка "Введите число и ожидаемое значение n из метода GetNumber()"
                Console.WriteLine($"Введите число {myNumbers.GetNumber()}: ");

                // input заполяется из консоли и конвертируется в int для метода SetNumber
                int input = int.Parse(Console.ReadLine());

                // Если SetNumber = false
                if (!myNumbers.SetNumber(input))
                {
                    Console.WriteLine("Неверное число, начните сначала");
                }
            }
        }
    }
}