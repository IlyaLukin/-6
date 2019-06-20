using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice6
{
    class Program
    {
        static bool ok = false;
        static bool NeMonoton = true;
        static void PrintMas(double[]mas)
        {
            Console.WriteLine("Ваша последовательность");
            if (mas.Length == 0) return;
            else
                for(int i=0;i<mas.Length;i++)
                {
                    Console.WriteLine(mas[i]+" "); 
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

        static void NeChetnost(double [] mas)
        {
            int Length=0;
            for (int i = 1; i < mas.Length + 1; i++)
            {
                if (i % 2 != 0)
                {
                    Length++;
                }
                else continue;
            }

            double [] NeChetMas = new double[Length];
            int count= 0;
            for (int i = 1; i < mas.Length + 1; i++)
            {
                if (i % 2 != 0)
                {
                    NeChetMas[count] = mas[i - 1];
                    count++;
                }
                else continue;
            }
            PrintMas(NeChetMas);

            for(int i=1;i< NeChetMas.Length;i++)
            {
                if (NeChetMas[i - 1] < NeChetMas[i])
                {
                    ok = false;
                    NeMonoton = false;
                   
                }
                else if (NeChetMas[i - 1] > NeChetMas[i])
                {
                    ok = true;
                    NeMonoton = false;
                   
                }
                else NeMonoton = true;
            }
        }

        static void Main(string[] args)
        {
            int a1, a2, a3, N;
           
             do
            {
                Console.WriteLine("Введите число a1");
                string name = Console.ReadLine();
                ok = int.TryParse(name, out a1);
            } while (!ok);

            do
            {
                Console.WriteLine("Введите число a2");
                string name = Console.ReadLine();
                ok = int.TryParse(name, out a2);
            } while (!ok);

            do
            {
                Console.WriteLine("Введите число a3");
                string name = Console.ReadLine();
                ok = int.TryParse(name, out a3);
            } while (!ok);
    
            do
            {
                Console.WriteLine("Введите количество элементов массива N");
                string name = Console.ReadLine();
                ok = int.TryParse(name, out N);
            } while (!ok);
            
            try
            {
                double[] mas1 = new double[N];
                mas1[0] = a1;
                mas1[1] = a2;
                mas1[2] = a3;

                int place = 3;

                while(place<mas1.Length)
                {
                    Function(mas1, place);
                    place++;

                }
                PrintMas(mas1);

                Console.WriteLine("Массив с нечетными элементами");
                NeChetnost(mas1);
            }
            catch
            {
                Console.WriteLine("Был задан неверный размер массива");
            }

            Console.WriteLine();

            Console.WriteLine("Определение последовательности на монотонность");
            if (ok == false && NeMonoton == false) Console.WriteLine("Монотонная неубывающая последовательность возрастает");
            else if (ok == true && NeMonoton == false) Console.WriteLine("Монотонная убывающая последовательность");
            else Console.WriteLine("Не монотонная");
            Console.ReadKey();
        }
    }
}
