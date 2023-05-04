using System;

namespace program {

    class Program {
        static void Main(string[] args) {

            int x, y;

            Console.WriteLine("digite dois numeros : ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
            if (x < y) {
                    Console.WriteLine("crescente");
                }
            else {
                    Console.WriteLine("decrescente");
                }
                Console.WriteLine("digite outros dois numeros : ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}

