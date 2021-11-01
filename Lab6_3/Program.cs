using System;

namespace Lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку с фигурными скобками:");
            string s = Console.ReadLine();
            int indexFirst = s.IndexOf("{");
            int indexLast = s.IndexOf("}");
            while (indexFirst >= 0 && indexLast >= 0)
            {
                indexFirst = s.IndexOf("{");
                indexLast = s.IndexOf("}");
                if (s[indexFirst+1] == '{')
                {
                    indexLast = s.IndexOf("}")+1;
                    s = s.Remove(indexFirst, indexLast - indexFirst + 1);
                }
                if (indexFirst != -1)
                {
                    s = s.Remove(indexFirst, indexLast - indexFirst + 1);
                }
            }
            Console.WriteLine(s);
        }
    }
}
