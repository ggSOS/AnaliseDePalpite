namespace Ambiente1
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[] numerosSecretos = [6, 9, 69, 1, 2, 3, 69, 9, 6];

            while (true)
            {
                Console.WriteLine("Bem vindo ao jogo de palpites de números ímpares(números megativos encerram o programa)!");
                int tentativas = 0;
                foreach(int numero in numerosSecretos)
                {
                    tentativas++;
                    Console.Write("Qual o seu palpite sobre o {0}º numero da lista?\n\t- ", tentativas);
                    int palpite = int.Parse(Console.ReadLine());
                    if (palpite < 0)
                    {
                        Console.WriteLine("Ok, encerrando Programa!");
                        return;
                    }
                    if (palpite % 2 == 0)
                    {
                        Console.WriteLine("É palpite de números ímpares amigo, pare e reflita.");
                        continue;
                    }
                    if (palpite == numero)
                    {
                        Console.WriteLine("Acertou o {0}º número ---> {1}!", tentativas, numero);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Não acertou, tente outro!");
                        continue;
                    }
                }
                Console.WriteLine("\nReiniciando o jogo...\n");
            }
        }
    }
}