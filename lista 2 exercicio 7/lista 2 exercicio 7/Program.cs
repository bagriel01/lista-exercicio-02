using System;

namespace lista_2_exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Um determinado clube de futebol pretende classificar seus atletas em categorias e para
isto ele contratou um programador para criar um programa que executasse esta tarefa.
Para isso o clube criou uma tabela que continha a faixa etária do atleta e sua categoria. A
tabela está demonstrada abaixo:
IDADE CATEGORIA
De 05 a 10 Infantil
De 11 a 15 Juvenil
De 16 a 20 Junior
De 21 a 25 Profissional
Construa um algoritmo que solicite o nome e a idade de um atleta e imprima a sua categoria. */
            string nome;
            int idade;
            Console.WriteLine("Boas vindas ao Clube Bob Nelson Futebol Club!");
            Console.WriteLine("Vamos te classificar agora. Escreva o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Ok " +nome+ " Agora, digite sua idade.");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine(nome+ " , " + idade + " anos. Ok, Vamos te Classificar... Aguarde...");
            if ((idade > 4) && (idade < 10))
            {
                Console.WriteLine("Você pertence a categoria Infantil");

            }
            if ((idade > 11) && (idade < 15)) 
            {
                Console.WriteLine("Você pertence a categoria Juvenil");

            }
            if ((idade > 16) && (idade < 20))
            {
                Console.WriteLine("Você pertence a categoria Junior");

            }
            if ((idade > 21) && (idade < 25))
            {
                Console.WriteLine("Você pertence a categoria Profissional");

            }

        }
    }
}
