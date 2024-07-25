using System;

namespace AdivinheONumero
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo ao jogo 'Adivinhe o Número'!");
                Console.WriteLine("Escolha o nível de dificuldade:");
                Console.WriteLine("1. Fácil (1 a 10)");
                Console.WriteLine("2. Médio (1 a 50)");
                Console.WriteLine("3. Difícil (1 a 100)");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                
                string escolha = Console.ReadLine();

                if (escolha == "4")
                {
                    break;
                }

                int min = 1, max = 10;
                switch (escolha)
                {
                    case "1":
                        max = 10;
                        break;
                    case "2":
                        max = 50;
                        break;
                    case "3":
                        max = 100;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        continue;
                }

                // Geração do número aleatório
                Random random = new Random();
                int numeroSecreto = random.Next(min, max + 1);
                int tentativas = 0;
                bool acertei = false;

                Console.WriteLine($"Estou pensando em um número entre {min} e {max}. Tente adivinhar!");

                while (!acertei)
                {
                    Console.Write("Digite seu palpite: ");
                    int palpite;

                    // Validação de entrada
                    if (!int.TryParse(Console.ReadLine(), out palpite) || palpite < min || palpite > max)
                    {
                        Console.WriteLine($"Por favor, digite um número entre {min} e {max}.");
                        continue;
                    }

                    tentativas++;

                    if (palpite < numeroSecreto)
                    {
                        Console.WriteLine("O número é maior.");
                    }
                    else if (palpite > numeroSecreto)
                    {
                        Console.WriteLine("O número é menor.");
                    }
                    else
                    {
                        acertei = true;
                        Console.WriteLine($"Parabéns! Você acertou o número {numeroSecreto} em {tentativas} tentativas.");
                    }
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
            }
        }
    }
}