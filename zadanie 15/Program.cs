using System;

namespace zadanie_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart(10);
            arith.setStep(2);
            Console.WriteLine("арифметическая прогрессия:");
            Console.WriteLine( arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            arith.reset();
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            GeomProgression geom = new GeomProgression();
            geom.setStart(6);
            geom.setStep(2);
            Console.WriteLine("геометрическая прогрессия:");
            Console.WriteLine( geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            geom.reset();
            Console.WriteLine(geom.getNext());
            Console.WriteLine(geom.getNext());
            Console.ReadKey();
        }
    }
}
