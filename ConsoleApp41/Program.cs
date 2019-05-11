using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice6
{
    class Program
    {
        static void PrintMas(double[]mas)
        {
            if (mas.Length == 0) return;
            else
                for(int i=0;i<mas.Length;i++)
                {
                    Console.WriteLine("Ваша последовательность");
                    Console.WriteLine(mas[i]);
                    
                }
        }
        static  double Function(double[]mas,int i)
        {
            if (i == 0)
            {
                return mas[0];
            }
            else
            if (i == 1)
            {
                return mas[1];
            }
            else
            if (i == 2)
            {
                return mas[2];
            }
            else
                return mas[i]= 0.7 * mas[i - 1] - 0.2 * mas[i - 2] + i * mas[i - 3];
        }

        static void Main(string[] args)
        {
            int a1, a2, a3, N;
            Console.WriteLine("Введите число a1");
            a1 = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите число a2");
            a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите число a3");
            a3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество элементов массива N");
            N = Convert.ToInt32(Console.ReadLine());

            try
            {
                double[] mas = new double[N];
                mas[0] = a1;
                mas[1] = a2;
                mas[2] = a3;

                int place = 3;

                while(place<mas.Length)
                {
                    Function(mas, place);
                    place++;

                }
                PrintMas(mas);

            }
            catch
            {
                Console.WriteLine("Был задан неверный размер массива");
            }


            

            
        }
    }
}
