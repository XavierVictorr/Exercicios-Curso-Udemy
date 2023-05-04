//bibliotecas
using System;
using System.Globalization;
//nomedoprograma
namespace Retangulo {

    class Programa {
        static void Main(string[] args) {

          CultureInfo ci = CultureInfo.InvariantCulture;
            //declar~ç]ao das variaveis 
            string nome1, nome2;
            int idade1, idade2;
            double media;

            Console.WriteLine("dados da primeira pessoa : ");
            Console.WriteLine("nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("idade: ");
            idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("dados da segunda pessoa : ");
            Console.WriteLine("nome: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("idade: ");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;
            Console.WriteLine("A idade media de " + nome1 + " e " + nome2 + " eh de " + media.ToString("f1", ci) + " anos");


        }
    }
}
