using System;

class Program
{
    struct Heroi
    {
        public string nome;
        public int pontuacao;
    }

    Heroi[] herois = new Heroi[20];
    int[] equipe = new int[5];

    int quantidadeHerois = 0;
    int quantidadeEquipe = 0;

    static void Main(string[] args)
    {
        Program programa = new Program();

        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("===== MARVEL TEAM =====");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Calcular Pontuação");
            Console.WriteLine("4 - Exibir Equipe");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    programa.CadastrarHeroi();
                    break;

                case 2:
                    programa.SelecionarEquipe();
                    break;

                case 3:
                    programa.CalcularPontuacaoTotal();
                    break;

                case 4:
                    programa.ExibirEquipe();
                    break;

                case 0:
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    }

    void CadastrarHeroi()
    {
        if (quantidadeHerois >= herois.Length)
        {
            Console.WriteLine("Limite de heróis atingido!");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[quantidadeHerois].nome = Console.ReadLine();

        Console.Write("Pontuação do herói: ");
        herois[quantidadeHerois].pontuacao = int.Parse(Console.ReadLine());

        quantidadeHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    void SelecionarEquipe()
    {
        if (quantidadeHerois == 0)
        {
            Console.WriteLine("Nenhum herói cadastrado.");
            return;
        }

        Console.WriteLine("\nHeróis disponíveis:");

        for (int i = 0; i < quantidadeHerois; i++)
        {
            Console.WriteLine($"{i} - {herois[i].nome} ({herois[i].pontuacao} pts)");
        }

        quantidadeEquipe = 0;

        Console.Write("\nQuantos heróis deseja na equipe (máx. 5)? ");
        int qtd = int.Parse(Console.ReadLine());

        if (qtd > 5)
            qtd = 5;

        for (int i = 0; i < qtd; i++)
        {
            Console.Write($"Escolha o índice do herói {i + 1}: ");
            int indice = int.Parse(Console.ReadLine());

            if (indice >= 0 && indice < quantidadeHerois)
            {
                equipe[quantidadeEquipe] = indice;
                quantidadeEquipe++;
            }
            else
            {
                Console.WriteLine("Índice inválido!");
                i--;
            }
        }

        Console.WriteLine("Equipe montada com sucesso!");
    }

    void CalcularPontuacaoTotal()
    {
        if (quantidadeEquipe == 0)
        {
            Console.WriteLine("Nenhuma equipe criada.");
            return;
        }

        int total = 0;

        for (int i = 0; i < quantidadeEquipe; i++)
        {
            total += herois[equipe[i]].pontuacao;
        }

        Console.WriteLine($"Pontuação total da equipe: {total}");
    }

    void ExibirEquipe()
    {
        if (quantidadeEquipe == 0)
        {
            Console.WriteLine("Nenhuma equipe criada.");
            return;
        }

        int total = 0;

        Console.WriteLine("\n===== EQUIPE =====");

        for (int i = 0; i < quantidadeEquipe; i++)
        {
            int indice = equipe[i];

            Console.WriteLine(
                $"{i + 1} - {herois[indice].nome} ({herois[indice].pontuacao} pts)"
            );

            total += herois[indice].pontuacao;
        }

        Console.WriteLine($"\nPontuação Total: {total}");
    }
}