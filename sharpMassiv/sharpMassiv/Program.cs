using System;

namespace sharpMassiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] A = new string[10];
            int[] A = new int[5];
            int[,] m = {{1 ,2}, 
                        {4, 5}};
            string s;
            int i = 0;

            Console.WriteLine("Введите элементы массива, после " +
            "каждой <Enter>, в конце <Enter> <Ctrl+z>");

            /*while(true)
            {
                s = Console.ReadLine();
                A[i] = s;
                if (s == null || i > 10)
                    break;
                i++;
            }*/

            while (true)
            {
                s = Console.ReadLine();
                if (s == null || i > (A.Length - 1))
                    break;
                A[i] = Convert.ToInt32(s);
                i++;
            }

            Console.WriteLine("Введено {0} строк", i);
            i = 0;

            foreach (int j in A)
                i += j;
   

            Console.WriteLine("Сумма элементов массива = {0, 3}", i);
            Console.Read();
        }
    }
}
