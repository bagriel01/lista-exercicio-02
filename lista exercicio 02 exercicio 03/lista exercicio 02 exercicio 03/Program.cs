using System;

namespace lista_exercicio_02_exercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um posto está vendendo combustíveis com a seguinte tabela de descontos:
             Álcool até 20 litros, desconto de 3 % por litro
              acima de 20 litros, desconto de 5 % por litro
               Gasolina até 20 litros, desconto de 4 % por litro
                acima de 20 litros, desconto de 6 % por litro
                 Escreva um programa em C# que leia o número de litros vendidos e o tipo de combustível
 (codificado da seguinte forma: A - álcool, G - gasolina), calcule e imprima o valor a ser pago pelo
     cliente sabendo - se que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$
 2,90.*/
            double gasolina;
            double Alcool;
            int litros;
            int vari;
            Console.WriteLine("Favor, Declarar primeiro qual produto o cliente está adquirindo: 1- Gasolina ou 2-Alcool?");
            vari = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a quantidade de litros o cliente está comprando");
            litros = int.Parse(Console.ReadLine());

            while (vari == 1)
            {
                if (litros > 20)
                {
                    gasolina = 3.30 * litros - (3.30 * 0.06 * litros);
                }
                else 
                {
                    gasolina = 3.30 * litros - (3.30 * 0.04 * litros);

                }
                Console.WriteLine("O Cliente Pagou " + gasolina, "pelo litro de gasolina.");
                break;
                }
            while (vari == 2)
            {
                if (litros > 20)
                {
                    Alcool = 2.90 * litros - (2.90 * 0.05 * litros);
                }
                else
                {
                    Alcool = 2.90 * litros - (2.90 * 0.03 * litros);

                }
                Console.WriteLine("O Cliente Pagou " + Alcool, "pelo litro de Alcool.");
                break;
            }
            
            
}        }
    }

