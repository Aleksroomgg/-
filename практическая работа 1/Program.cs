using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using практическая_работа_1.Core;

namespace практическая_работа_1
{
    internal class Program
    {
        static ProverkaType proverkaType = new ProverkaType(); 
        static ClassSwitch classSwitch = new ClassSwitch();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. числа от 1 до 10\n2. все четные числа от 2 до 20\n3. сумма нечетных чисел\n4. таблица умножения\n5. факториал числа\n6. все простые числа через while\n7. перевернуть строку через for\n8. подсчитать количество гласных букв с помощью while\n9. полиндром через for\n10. замена пробелов на подчеркивание через while\n11. перевернуть строку\n12. числа фибоначи\n13. случайное число\n14. числа кратные 3 и 5\n15. 10 раз Hello world\n ");
                
                classSwitch.GG(proverkaType.Type<int>("Введите номер задания: "));
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
