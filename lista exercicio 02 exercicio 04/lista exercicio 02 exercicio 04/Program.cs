using System;

namespace lista_exercicio_02_exercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa em C# que leia 3 valores (considere que não serão informados
valores iguais) e escrever a soma dos 2 maiores. */
        int valor1;
        int valor2;
        int valor3;
        int valorf;
        int valorf1;
        int valorf2;
         

            Console.WriteLine("Digite valor 1");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite valor 2");
            valor2 = int.Parse(Console.ReadLine());
            while (valor2 == valor1) {
                Console.WriteLine("Valor Inválido, insira um valor que seja diferente do valor 1 ou 3");
                valor2 = int.Parse(Console.ReadLine());
             }
            Console.WriteLine("Digite o Valor 3");
            valor3 = int.Parse(Console.ReadLine());
            while (valor3 == valor1)
            {
                Console.WriteLine("Valor Inválido, insira um valor que seja diferente do valor 1 ou 2");
                valor3 = int.Parse(Console.ReadLine());
                break;
             }
            while (valor3 == valor2)
            {
                Console.WriteLine("Valor Inválido, insira um valor que seja diferente do valor 1 ou 2");
                valor3 = int.Parse(Console.ReadLine());
                break; }
             
        if (valor1>valor2)
            {
                valorf1 = valor1;

            }
        else
            { valorf1 = valor2;  }
        if (valor2>valor3)
            {
                valorf2 = valor2;

            }
        else
            { valorf2 = valor3;  }

            valorf = valorf1 + valorf2;
                    
            Console.WriteLine("O valor é " + valorf);
            }
        }   
    }

