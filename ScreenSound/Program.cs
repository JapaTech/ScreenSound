// See https://aka.ms/new-console-template for more information


Dictionary<string, List<int>> nomesDasBandas = new Dictionary<string, List<int>>();
nomesDasBandas.Add("Mamonas Assassinas", new List<int>());

List<int> numeroInteioro = new List<int>() { 0, 1, 2, 3, 4, 5};

void Cabecario()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

    Console.WriteLine("\nBoas vindas ao Screen Sound");
}

void ExibirMenu()
{
    Console.WriteLine();
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para listar todas banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média uma banda");
    Console.WriteLine("Digite -1 para sair");
}

void ExecutarMenu()
{
    Console.Write("\nEscolha uma opção: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ListarBandas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirNotaMedia();
            break;
        case -1:
            Console.WriteLine("Tchau");
            break;
        default:
            Console.WriteLine("Opção inválida: " + opcaoEscolhida);
            break;
    }
}

void ExibirTituloOpções(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string tracos =  string.Empty.PadLeft(quantidadeDeLetras, '-');
    Console.WriteLine(titulo);
    Console.WriteLine(tracos+ "\n");
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloOpções("REGISTRO DE BANDAS");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    nomesDasBandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    MenuInicial();
}
void ListarBandas()
{
    Console.Clear();
    ExibirTituloOpções("BANDAS CADASTRADAS");
    foreach (string nome in nomesDasBandas.Keys)
    {
        Console.WriteLine(nome);
    }
    Console.WriteLine("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    MenuInicial();
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloOpções("Avaliar uma banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (nomesDasBandas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"\nQual é a nota que você vai dar para a {nomeDaBanda}? ");
        int nota = int.Parse(Console.ReadLine()!);
        nomesDasBandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nVocê deu a nota {nota} para a banda {nomeDaBanda}");
        Thread.Sleep(3000);
        MenuInicial();
    }
    else
    {
        Console.WriteLine("\nBanda NÃO encontrada");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuInicial();
    }
}

void ExibirNotaMedia()
{
    Console.Clear();
    ExibirTituloOpções("Nota Média da Banda");
    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (nomesDasBandas.ContainsKey(nomeDaBanda))
    {  
        Console.WriteLine($"\nA banda {nomeDaBanda} tem a média de: {nomesDasBandas[nomeDaBanda].Average().ToString("F2")}");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuInicial();
    }
    else
    {
        Console.WriteLine("\n Banda NÃO encontrada");
        Console.WriteLine("Pressione qualquer tecla para continuar");
        Console.ReadKey();
        MenuInicial();
    }
}

void MenuInicial()
{
    Console.Clear();
    Cabecario();
    ExibirMenu();
    ExecutarMenu();
}

MenuInicial();

void QuatroOperacoesDeDoisNumeros()
{
    Console.Write("Digite um número: ");
    float numero1 = float.Parse(Console.ReadLine()!);
    Console.Write("\nDigite outro número: ");
    float numero2 = float.Parse(Console.ReadLine()!);

    Console.WriteLine($"\nSoma = {(numero1 + numero2)}");
    Console.WriteLine($"\nSubtracao = {(numero1 - numero2)}");
    Console.WriteLine($"\nMultiplicação= {(numero1 * numero2)}");
    Console.WriteLine($"\nDivisão= {(numero1 / numero2)}");
    Console.ReadKey();
}

void TotalDaLista()
{
    int soma = 0;

    foreach (int i in numeroInteioro)
    {
        soma += i;
    }

    Console.WriteLine("A soma dos números da lista é: " + soma);
    Console.ReadKey();
}

void NumerosParesDaLista()
{

    foreach (int i in numeroInteioro)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
    Console.ReadKey();
}