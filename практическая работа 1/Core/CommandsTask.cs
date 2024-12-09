using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа_1.Core
{
    internal class CommandsTask
    {
        static ProverkaType proverkaType = new ProverkaType();
        public void Task1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Число {i}");
            }
            return;
        }
        public void Task2()
        {
            for (int i = 2; i <= 20; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine($"Число {i}");
                }

            }
        }
        public void Task3()
        {
            int R = 0;
            for (int i = 1; i <= 15; i++)
            {
                if ((i % 2) != 0)
                {
                    R += i;
                }
            }
            Console.WriteLine($"Cумма нечетных чисел {R}");
        }
        public void Task4()
        {
            int R = proverkaType.Type<int>("Введите число для таблицы умножения ==>");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{R} * {i}={R * i}");
            }
        }
        public void Task5()
        {
            int R = proverkaType.Type<int>("Введите число для факториала ==>");
            int V = 1;
            for (int i = 1; i <= R; i++)
            {
                Console.WriteLine($"Факториал числа {R} = {V *= i}");

            }
        }
        public void Task6()// Я лох, я не сделал
        {
            int R = proverkaType.Type<int>("Введите число ==>");
            for (int i = 1; i <= 10; i++)
            {
                if (R % i == 0)
                {
                    if (i != 1 && i != R)
                    {
                        Console.WriteLine($"не натуральное число {R}");
                    }
                    else
                    {
                        Console.WriteLine($"это натуральное число {R}");
                    }
                }
                else
                {
                    Console.WriteLine($"не натуральное число {R}");
                }
            }
        }
        public void Task7()
        {
            string V = null;
            string R = Console.ReadLine();
            Console.Write("Введите строку: ");

            for (int i = R.Length - 1; i >= 0; i--)
            {
                V += R[i].ToString();
            }
            Console.WriteLine(V);
        }
        public void Task8()
        {
            string V = Console.ReadLine();
            string R = "уеаоэяиюё";
            int count = 0;
            int Index = 0;
            while (Index < V.Length)
            {
                if (R.Contains(V[Index]))
                {
                    count++;
                }
                Index++;
            }
            Console.WriteLine(count);
        }
        public void Task9()
        {
            string V = null;
            string R = Console.ReadLine();
            Console.Write("Введите строку: ");

            for (int i = R.Length - 1; i >= 0; i--)
            {
                V += R[i].ToString();
            }
            V.ToLower();
            R.ToLower();

            if (V == R)
            {
                Console.WriteLine("это полиндром");
            }
            else
            {
                Console.WriteLine("это не полиндром");
            }
        }
        public void Task10()
        {
            string V = Console.ReadLine();
            char O = ' ';
            char Z = '_';
            string result = null;
            int Index = 0;
            while (Index < V.Length)
            {
                if (V[Index] == O)
                {
                    result += Z;
                }
                else
                {
                    result += V[Index]; 
                }
                Index++;
            }
            Console.WriteLine(result);

            V = V.Replace(" ", "_");
            Console.WriteLine(V);
        }
        public void Task11()
        {
            Console.Write("Введите строку: ");
            string a = Console.ReadLine();
            string reversed = "";
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reversed += a[i];
            }
            Console.WriteLine("Строка в обратном порядке: " + reversed);
        }
        public void Task12()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int X = 0;

            Console.WriteLine("Угадайте число от 1 до 100:");

            while (X != number)
            {
                X = int.Parse(Console.ReadLine());

                if (X < number)
                {
                    Console.WriteLine("Слишком мало, попробуйте снова.");
                }
                else if (X > number)
                {
                    Console.WriteLine("Слишком много, попробуйте снова.");
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы угадали!");
                }
            }
        }
        public void Task13()
        {
            Random random = new Random();
            int number = random.Next(1, 101);
            int guess = 0;

            Console.WriteLine("Угадайте число от 1 до 100:");

            while (guess != number)
            {
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Слишком мало, попробуйте снова.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Слишком много, попробуйте снова.");
                }
                else
                {
                    Console.WriteLine("Поздравляю, вы угадали!");
                }
            }
        }
        public void Task14()
        {
            Console.WriteLine("Числа, кратные 3 и 5 в диапазоне от 1 до 100: ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Task15()
        {
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("Hello, World!");
                count++;
            }
        }
    }
}
