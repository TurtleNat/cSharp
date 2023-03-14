using System;

namespace sharpMarch
{
    class Program
    {

        static void CountSimb(string c, out int v_a, out int v_b)
        {
            int a = 0, b = 0;

            switch (c)
            {
                case "a":
                    a = 1;
                    break;
                case "b":
                    b = 1;
                    break;

                default:
                    break;
            }
            v_a = a;
            v_b = b;
        }


        static int fact(int i)
        {
            if (i == 0)
                return (i + 1);
            else
            {
                i = i * fact(i - 1);
                return (i);
            }
        }
        public static void Main(string[] args)
        {
            string s;
            int v_a, v_b;
            while (true)
            {
                Console.WriteLine("Введите символ, <Enter> >");
                s = Console.ReadLine();
                if (s == null) // нажали <Ctrl>+<Z>
                    break;
                CountSimb(s, out v_a, out v_b); // Подсчет
                                                // количества
                                                // символов 'a', 'b'
                Console.WriteLine("Введен а = {0}, " +
                "введен b = {1} ", v_a, v_b);
                Console.WriteLine("Для продолжения нажмите " +
                "любой символ > ");

                int i = 3;
                int j;
                //j = fact(i);
                Console.WriteLine(fact(i));


                Console.ReadLine();
            }
        }
    }
}
