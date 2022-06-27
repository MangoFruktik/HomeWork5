using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static void LinesToWords(string s)
        {
            string[] word = s.Split(' ');
            foreach (var wr in word)
            {
                Console.WriteLine(wr);
            }
           
        }
        static void Exit()
        {
            Console.WriteLine("\nДля выхода нажмите любую клавишу...");
            Console.ReadKey();
        }

        static void Iodawords(string i)
        {
            LinesToWords(i);
            string[] word1 = i.Split(' ');
            for (int d = word1.Length - 1; d >= 0; d--)
                Console.Write(word1[d] + " ");
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение и нажмите Enter: ");
            string s = Console.ReadLine();
            LinesToWords(s);
            
            Console.WriteLine("Введите предложение для создания предложения Йоды");
            string i = Console.ReadLine();
            Iodawords(i);
            Exit();
        }
    }
}
