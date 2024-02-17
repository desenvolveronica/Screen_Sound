//https://fsymbols.com/generators/zalgo/
//usando @ vc mostra a string literal
string logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";
string mensagem = "Bem Vindo ao Screen Sound!";
List<string> ListaDeBandas = new List<string>();
void ExibirLogo()
{
    Console.WriteLine(logo);
    Console.WriteLine(mensagem);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcao = Console.ReadLine()!;
    
    
    try
    {
        int opcaoEscolhida = int.Parse(opcao);

        switch (opcaoEscolhida)//em parênteses coloca quem é o alvo da verificação
        {
            case 1:
                RegistrarBanda();
                break;
            case 2:
                MostrarBandasRegistradas();
                break;
            case 3:
                Console.WriteLine(" Você escolheu a opção " + opcaoEscolhida);
                break;
            case 4:
                Console.WriteLine(" Você escolheu a opção " + opcaoEscolhida);
                break;
            case -1:
                Console.WriteLine(" Você escolheu a opção " + opcaoEscolhida);
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Digite uma opção do menu");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirMenu();
    }
   
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Registro de Bandas");
    Console.WriteLine("*********************\n");

    Console.Write("Digite o nome da banda que você quer registrar: ");
    string nomeDaBanda = Console.ReadLine()!;//colocando o ! indicamos que não queremos trabalhar com valor nulo
    ListaDeBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine("*********************");
    Console.WriteLine("Bandas Registradas");
    Console.WriteLine("*********************\n");
    if (ListaDeBandas.Count == 0)
    {
        Console.WriteLine("Esta Lista está vazia");
    }
    else
    {
        //percorrer em um for para exibir todas as bandas da lista
        var posicao = 1;
        for (int i = 0; i < ListaDeBandas.Count; i++)
        {
            var itensLista = ListaDeBandas[i].ToString();
            var posItem = posicao++;
            Console.WriteLine($"{posItem} - {itensLista}");
        }
    }
    
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

ExibirMenu();
