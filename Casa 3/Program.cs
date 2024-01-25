using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rettangolo rettangolo = new Rettangolo();
            rettangolo.Base = int.Parse(Console.ReadLine());
            rettangolo.Altezza = int.Parse(Console.ReadLine());
            Console.WriteLine("A: {0}", rettangolo.Area());
            Console.WriteLine("2P: {0}", rettangolo.Perimetro());

            Rettangolo quadrato = new Rettangolo();
            rettangolo.Base = int.Parse(Console.ReadLine());
            rettangolo.Altezza = rettangolo.Base;
            Console.WriteLine("A: {0}", rettangolo.Area());
            Console.WriteLine("2P: {0}", rettangolo.Perimetro());


        }
    }
}
