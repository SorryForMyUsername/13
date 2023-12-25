using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Вычислить значение функции для целых аргументов двумя способами (1-й способ: полный условный оператор; 2-й способ: тернарная операция)
            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //double y = 0;
            //1 способ
            //if (x > 0) {
            //    y = Math.Pow(Math.Sin(x), 2);
            //}
            //else {
            //    y = 1 - 2 * Math.Sin(Math.Pow(x, 2));
            //}
            //Console.WriteLine($"y = {y:F2}");
            //2 способ
            //y = x > 0 ? Math.Pow(Math.Sin(x), 2) : 1 - 2 * Math.Sin(Math.Pow(x, 2));
            //Console.WriteLine($"y = {y:F2}");

            //Задача 2.Используя двузначное случайное число, вывести на экран информацию о четности или нечетности этого числа с использованием тернарной операции.
            //Console.Write("Введите двухзначное число: ");
            //int two_digit_number = int.Parse(Console.ReadLine());
            //string even = two_digit_number % 2 == 0
            //    ? $"Число {two_digit_number} - чётное"
            //    : $"Число {two_digit_number} - нечётное";
            //Console.WriteLine(even);

            //Задача 3. Даны три целых положительных числа. Если все они четные, каждое число увеличить на 1; если хотя бы одно из них четное, уменьшить на 1; если четных чисел нет, каждое число увеличить в 2 раза.
            //try
            //{
            //    Console.Write("Первое положительное число: ");
            //    uint x = uint.Parse(Console.ReadLine());
            //    Console.Write("Второе положительное число: ");
            //    uint y = uint.Parse(Console.ReadLine());
            //    Console.Write("Третье положительное число: ");
            //    uint z = uint.Parse(Console.ReadLine());
            //    if (x % 2 == 0 & y % 2 == 0 & z % 2 == 0)
            //    {
            //        x++;
            //        y++;
            //        z++;
            //    }
            //    else if (x % 2 == 0 | y % 2 == 0 | z % 2 == 0)
            //    {
            //        x--;
            //        y--;
            //        z--;
            //    }
            //    else
            //    {
            //        x *= 2;
            //        y *= 2;
            //        z *= 2;
            //    }
            //    Console.WriteLine($"Первое число равно {x}\n" +
            //                      $"Второе число равно {y}\n" +
            //                      $"Третье число равно {z}");
            //}
            //catch
            //{
            //    Console.WriteLine("Неправильно введено число!");
            //}

            //Задание 4. Используя случайное число в диапазоне от -20 до 20, вывести на экран название месяца в году.
            //Random rnd = new Random();
            //int number = rnd.Next(-20, 20);
            //Console.WriteLine(number);
            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Феварь");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Юиль");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default:
            //        Console.WriteLine("Error");
            //        break;
            //}

            Console.ReadKey();
        }
    }
}
