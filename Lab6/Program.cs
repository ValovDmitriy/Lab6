using System;
using System.Text;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение без знаков припинания:");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(new char[] { ' ' });
            int max = 0;
            foreach (string s in words)
            {
                int a = s.Length;
                if (a> max)
                {
                    max = a;
                }
            }
            Console.WriteLine("Самое длинное слово из  {0} букв",max);
        }
    }
}
