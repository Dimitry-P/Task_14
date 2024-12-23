using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14
{
    
    internal class Program
    {
        public static string phrase;
        //•	Задача 14: Напишите программу, которая считает количество слов в строке.
        static void Main(string[] args)
        {
            Console.Write("Введите строку:");
            phrase = Console.ReadLine();
            string[] pieces = phrase.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("количество слов в строке: "+pieces.Length) ;
            
        }
    }
}
