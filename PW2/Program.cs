namespace PW2
{
    class QuadraticEquation
    {
        // Приватные поля класса
        private double a;
        private double b;
        private double c;
        private double root1;
        private double root2;
        private double discriminant;
        
        // Конструктор класса
        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        // Доступ к приватным полям класса
        public double GetA()
        {
            return a;
        }
        public double GetB()
        {
            return b;
        }
        public double GetC()
        {
            return c;
        }
        public double GetRoot1()
        {
            return root1;
        }
        public double GetRoot2()
        {
            return root2;
        }
        // Вычисление дискриминанта
        private void CalculateDiscriminant()
        {
            discriminant = b * b - 4 * a * c;
        }
        // Вычисление корней
        public void CalculateRoots()
        {
            CalculateDiscriminant();

            if (discriminant > 0) // Если дискриминант больше 0
            {
                root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            }
            if (discriminant == 0) // Если дискриминант равен 0
            {
                root1 = -b / (2 * a);
                root2 = 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Экземпляр класса QuadraticEquation
            QuadraticEquation myQuadraticEquation = new QuadraticEquation(-19, 3, 23);

            // Вычисление корней
            myQuadraticEquation.CalculateRoots();

            // Если корни не равны 0 (дискриминант больше 0)
            if (myQuadraticEquation.GetRoot1() != 0 && myQuadraticEquation.GetRoot2() != 0)
            {
                Console.WriteLine($"Корни уравнения {myQuadraticEquation.GetA()}x^2 + {myQuadraticEquation.GetB()}x + {myQuadraticEquation.GetC()} = 0: \nКорень 1: {myQuadraticEquation.GetRoot1()} \nКорень 2: {myQuadraticEquation.GetRoot2()}");
            }
            // Если корень 2 равен 0 (дискриминант равен 0)
            else if (myQuadraticEquation.GetRoot1() != 0 && myQuadraticEquation.GetRoot2() == 0)
            {
                Console.WriteLine($"Дискриминант равен 0. Корень уравнения {myQuadraticEquation.GetA()}x^2 + {myQuadraticEquation.GetB()}x + {myQuadraticEquation.GetC()} = 0: \nКорень 1: {myQuadraticEquation.GetRoot1()}");
            }
            // Если корней нет (дискриминант меньше 0)
            else
            {
                Console.WriteLine($"Уравнение {myQuadraticEquation.GetA()}x^2 + {myQuadraticEquation.GetB()}x + {myQuadraticEquation.GetC()} = 0 не имеет корней.");
            }

            Console.ReadKey(true);
        }
    }
}