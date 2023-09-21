using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свое имя: ");
            string first_name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string second_name = Console.ReadLine();
            Console.Write($"Приветствую тебя {second_name} {first_name}");
            Console.ReadKey();
        }
    }
}
