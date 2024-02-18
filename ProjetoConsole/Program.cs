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
//List<string> ListaDeBandas = new List<string> { "Beatles", "U2", "Red Hot Chili Peppers" };
Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>();
BandasRegistradas.Add("Red Hot Chili Peppers", new List<int>());
BandasRegistradas.Add("Linkin Park", new List<int> { 10, 9, 8});
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
                AvaliarBanda();
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
    ExibirTituloDaOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que você quer registrar: ");
    string nomeDaBanda = Console.ReadLine()!;//colocando o ! indicamos que não queremos trabalhar com valor nulo
    BandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}
void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Bandas Registradas");

    if (BandasRegistradas.Keys.Count == 0)
    {
        Console.WriteLine("Esta Lista está vazia");
    }
    else
    {
        //percorrer em um for para exibir todas as bandas da lista
        var posicao = 1;
        //for (int i = 0; i < ListaDeBandas.Count; i++)
        //{
        //    var itensLista = ListaDeBandas[i].ToString();
        //    var posItem = posicao++;
        //    Console.WriteLine($"{posItem} - {itensLista}");
        //}
        foreach(string banda in BandasRegistradas.Keys)
        {
            var posItem = posicao++;
            Console.WriteLine($"{posItem} - {banda}");
        }
   }
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Selecione a banda que deseja avaliar: ");
    string NomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(NomeDaBanda))
    {   

    }
    else
    {
        Console.WriteLine($"A banda {NomeDaBanda} não localizada no dicionário");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    }

    Console.WriteLine();

}
void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

ExibirMenu();
