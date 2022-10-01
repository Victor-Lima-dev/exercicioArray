using System;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Estudante[] vetor = new Estudante[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int numeroQuartos = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i+1} - Aluguel");
                Console.WriteLine("Digite o nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o email:");
                string email = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Digite o quarto");
                int quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Estudante(nome, email);
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] != null)
                {
                    Console.WriteLine("Quarto Alugado: " + i );
                }
            }









        }
    }
}