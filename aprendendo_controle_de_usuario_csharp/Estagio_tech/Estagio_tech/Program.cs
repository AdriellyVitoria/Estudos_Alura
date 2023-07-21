using System;

class Estagio_tech
{
    static void Main(string[] args)
    {
        //Console.Write("Digite uma frase: ");
        //string frase = Console.ReadLine().ToLower();


        //Console.Write("Digite um caractere: ");
        //char caractere = Console.ReadKey().KeyChar;
        //Console.WriteLine();

        //int[] posicoes = new int[frase.Length];

        //int quantidade_caractere = 0;

        //for (int i = 0; i < frase.Length; i++)
        //{
        //    if (frase[i] == caractere)
        //    {
        //        posicoes[quantidade_caractere] = i;
        //        quantidade_caractere++;
        //    }
        //}

        //if (quantidade_caractere > 0)
        //{
        //    Array.Resize(ref posicoes, quantidade_caractere);
        //    Console.WriteLine($"O caractere '{caractere}' aparece nas posições: {string.Join(", ", posicoes)}");
        //}
        //else
        //{
        //    Console.WriteLine($"O caractere '{caractere}' não foi encontrado na frase.");
        //}
        static void Main(string[] args)
        {
            Console.Write("Digite o ano de nascimento: ");
            int ano_nascimento = int.Parse(Console.ReadLine()!);


            Console.Write("Digite o ano atual: ");
            int ano_atual = int.Parse(Console.ReadLine()!);


            int idade = ano_atual - ano_nascimento;


            Console.WriteLine("Sua idade é: " + idade);
        }
}



