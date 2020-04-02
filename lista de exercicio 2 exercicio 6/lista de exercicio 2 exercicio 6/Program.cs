using System;

namespace lista_de_exercicio_2_exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa em C# para ler três valores reais e informar se estes podem ou não
formar os lados de um triângulo, e qual tipo de triângulo seria: Equilátero, Isósceles ou
Escaleno. */
            int v1;
            int v2;
            int v3;
            Console.WriteLine("Informe um valor");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe valor 2");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe valor 3");
            v3 = int.Parse(Console.ReadLine());

            if ((v1 == v2) && (v2 == v3)) {
                Console.WriteLine("Este é um Triangulo Equilátero.");
            }
            if ((v1 == v2) && (v2 != v3))
            {
                Console.WriteLine("Este é um Triangulo Isóceles");
                         }
            if ((v1 != v2) && (v2 != v3))
            {

                Console.WriteLine("Este é um Triângulo Escaleno");
            }

        }
    }
}
