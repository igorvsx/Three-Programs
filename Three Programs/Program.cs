namespace Three_Programs
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Выберите программу, которую хотите запустить:" +
                " \n1. Угадай число" +
                " \n2. Таблица умножения" +
                " \n3. Вывод делителей числа" +
                " \n4. Выйти из программы");
        }
        static void RandomNumber()
        {
            Random rand = new Random();
            int value = rand.Next(0, 100);
            Console.WriteLine("Угадай число от 0 до 100");
            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < value)
                {
                    Console.WriteLine("Надо больше");
                }
                else if (number > value)
                {
                    Console.WriteLine("Надо меньше");
                }
                else
                {
                    Console.WriteLine("Вы угадали!!");
                    break;
                }
            }
        }
        static void Table()
        {
            int[,] table = new int[10, 10];
            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 1; j < table.GetLength(1); j++)
                {
                    table[i, j] = i * j;
                }
            }
            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 1; j < table.GetLength(1); j++)
                {
                    Console.Write($"{table[i, j]} \t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        static void Divisors()
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.Write($"{i} \t");
                }
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Menu();
            int action = Convert.ToInt32(Console.ReadLine());
            while (action < 4)
            {
                if (action == 1)
                {
                    RandomNumber();
                }
                else if (action == 2)
                {
                    Table();
                }
                else if (action == 3)
                {
                    Divisors();
                }
                Menu();
                action = Convert.ToInt32(Console.ReadLine());
            }
            Environment.Exit(0);
        }
    }
}