using System;

namespace Lab_6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите фразу палиндром: ");
            string s = Console.ReadLine();
            if (ItIsPalindrom(s))
                Console.Write("{0} - палиндром ",s);
            else
                Console.Write("{0} - не палиндром ", s);
            Console.ReadKey();

            static bool ItIsPalindrom(string s)
            {
                s = s.Replace(" ", "");
                bool b = true;
                for (int first = 0, last = s.Length - 1; first < last; ++first, --last)
                {
                    if (s[first] != s[last])
                        b = false;
                }
                return b;
            }
        }
    }
}
