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
void ExibirMensagemBoasVindas()
{
    Console.WriteLine(logo);
    Console.WriteLine(mensagem);
}

void ExibirMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcao = Console.ReadLine()!;
    
    
    int opcaoEscolhida = int.Parse(opcao);
    switch (opcaoEscolhida)//em parênteses coloca quem é o alvo da verificação
    {
        case 1: Console.WriteLine(" Você escolheu a opção " + opcaoEscolhida);
            break;
        case 2: Console.WriteLine(" Você escolheu a opção " + opcaoEscolhida);
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
        default: Console.WriteLine("Opção Inválida");
            break;
    }
}
ExibirMensagemBoasVindas();
ExibirMenu();
