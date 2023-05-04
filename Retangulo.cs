using System;
using System.Globalization;

namespace Retangulo {

    class Programa {

        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            //AGORA É DECLARAR AS VARIÁVEIS 

            double largura, altura, area, perimetro, diagonal;

            Console.Write("base do retangulo : ");
            largura = double.Parse(Console.ReadLine(), CI);
            Console.WriteLine("altura do retangulo : ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimetro = 2 * (largura + altura);
            diagonal = Math.Sqrt(largura * largura + altura * altura);

            Console.WriteLine("area = " + area.ToString("f4", CI));
            Console.WriteLine("perimetro = " + perimetro.ToString("f4", CI));
            Console.WriteLine("diagonal = " + diagonal.ToString("f4", CI));

            
        }
    }
}



            