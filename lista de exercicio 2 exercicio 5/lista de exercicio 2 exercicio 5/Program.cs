using System;

namespace lista_de_exercicio_2_exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1;
            double a2;
            double mf;
            Console.WriteLine("Calculadora de Média. Digite sua Nota 1");
            a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite Sua Nota 2");
            a2 = double.Parse(Console.ReadLine());

            mf = (a1 * 0.4 + a2 * 0.6);
            if (mf > 5)
            {
                Console.WriteLine("Você passou! Sua nota foi" + mf);
            }

            else
            {
                Console.WriteLine("Oh não! Você Reprovou! Sua nota foi " + mf);
            }
        }
    }
    }

