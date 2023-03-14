using System;

namespace sharp_function
{
    class Program
    {
        ///  Введение строки с клавиатуры и вывод либо кол-ва символов
        ///  либо 0 если символов больше 10.
       /* static string str;
        static int getline(ref string s, int lim)
        {
            int i;
            s = Console.ReadLine();
            i = s.Length;
            if (i > lim) i = 0;
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод строки с ограничением" + "по ее длине\n");
            int lim = 10;
            Console.WriteLine("Введите строку\n");
            int i = getline(ref str, lim);
            Console.WriteLine("Строка: {0}   длина строки: {1}", str, i);
        }*/



        /// Выделение подстроки из строки.
        static string substr(string s, int i, int count)
        {
            int j = 0;
            string r = s.Remove(j, i - 1);

            int part1 = count;
            int part2 = (s.Length - i) - (count - 1);
            string r1 = r.Remove(part1, part2);
            return r;
       }


        /// <summary>
        /// Вставляет в строку copy строку int с позиции i count символов.
        /// </summary>
        static string inp, copy;
        static string MyCopy(string inp, ref string copy, int i, int count)
        {
            int j = 1;
            substr(inp, j, count);
            string r1 = copy.Insert(i - 1, inp);
            return r1;

        }

        /* public static void Main(string[] args)
         {
             string s = "";
             while (true)
             {
                 Console.WriteLine("Введите строку");
                 s = Console.ReadLine();
                 if (s == null)
                     break;

                 Console.WriteLine("Введите позицию начала подстроки");
                 string r = Console.ReadLine();
                 int i = System.Convert.ToInt32(r);
                 Console.WriteLine("Введите количество символов подстроки");
                 r = Console.ReadLine();
                 int j = System.Convert.ToInt32(r);

                 Console.WriteLine("Выделенная подстрока: {0}", substr(s, i, j));
             }
         }*/

        public static void Main(string[] args)
        {
            Console.WriteLine("Введите строку  в которую нужно вставить другую строку");
            copy = Console.ReadLine();
            string s = "";
            while (true)
            {
                Console.WriteLine("Введите вставляемую строку");
                s = Console.ReadLine();
                if (s == null) break;

                Console.WriteLine("Введите позицию начала" + "вставки >");
                string r = Console.ReadLine(); 
                int i = System.Convert.ToInt32(r);

                Console.WriteLine("Введите количество " + "символов вставки >");
                r = Console.ReadLine(); 
                int j = System.Convert.ToInt32(r);

                Console.WriteLine("Вставить начиная с символа {0} {1} символов\nПодстрока: {2}", i, j, MyCopy(s, ref copy, i, j));
                // Console.WriteLine("Для продолжения нажмите любую клавишу > ");
                // Console.Read();
            } // while
        } // Main()
    } // class
} // using
            