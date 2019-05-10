using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число a1");
            double a1 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Введите число a2");
            double a2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число a3");
            double a3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число элементов N");
            int N = Convert.ToInt32(Console.ReadLine());

            int [] mas = new int[N];

            for(int i=0;i<N;i++)
            {
                Console.WriteLine("Введите {0} элемент массива",i);
                mas[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(mas[i]);
                Console.ReadKey();
            }

            double Function(int k)
            {

               return 0.7 * (k- 1) - 0.2 * (k - 2) + k* (k - 3);

            }
        }
    }
}
