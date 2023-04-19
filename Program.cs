using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double soma;

            Console.Write("Coloque o valor em °c: ");
            n1 = double.Parse(Console.ReadLine());

            soma = ((n1 / 5) * 9) + 32;

            Console.WriteLine("o valor em °f é = {0}", soma);

        }
    }
}
