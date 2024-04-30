// back sound
string mensagemDeBoasVindas = "\nBoas Vindas ao Back Music";
// List<string> listaBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"
█▄▄ ▄▀█ █▀▀ █▄▀   █▀ █▀█ █░█ █▄░█ █▀▄
█▄█ █▀█ █▄▄ █░█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoUsuario = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcaoUsuario);
    
    switch (opcaoNumerica) 
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine($"Você digitou a opção {opcaoNumerica}");
            break;    
        case -1: Console.WriteLine($"Você digitou a opção {opcaoNumerica}");
            break;
        default: Console.WriteLine("Opção Invalida");
            break;
            
    }

}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();

    ExibirTituloDaOpcao("Exibindo todas as bandas Registradas");

    // for (int i = 0; i < listaBandas.Count; i++)
    // {
    //     Console.WriteLine($"Bandas: {listaBandas[i]}");
    // }

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Bandas: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal:");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asterisco = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asterisco);
    Console.WriteLine(titulo);
    Console.WriteLine(asterisco + "\n");

}

void ExibirNotaBandas()
{

}

void AvaliarUmaBanda()
{
    
}
ExibirOpcoesDoMenu();