using System;
using System.Globalization;

namespace SomaVetor {
    class Prgram {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            int n;
            double soma, media;

            Console.Write("Quantos numeros voce vai digitar ? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("digite um numero : ");
                vet[i] = double.Parse(Console.ReadLine(), ci);
            }
            Console.WriteLine();
            Console.Write("valores = ");
            for (int i = 0;i < n; i++) {
                Console.Write(vet[i] + " ");
            }
            Console.WriteLine();

            soma = 0;
            for (int i = 0; i < n; i ++) {
                soma = soma + vet[1];
            }
            Console.WriteLine("soma = " + soma.ToString("f2" , ci));

            media = soma / n;
            Console.WriteLine("media = " + media.ToString("f2", ci));
        }
    }
}