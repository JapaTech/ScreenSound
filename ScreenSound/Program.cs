using System.Text.Json;
using System.Text.Json.Nodes;
using ScreenSound;
using ScreenSound.Menus;
using ScreenSound.Menus.Bandas;
using ScreenSound.Modelos;

using(HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        musicas[0].ExibirFichaTecnica();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: " + ex.Message);
    }
}

//Dictionary<string, List<int>> nomesDasBandas = new Dictionary<string, List<int>>();
//nomesDasBandas.Add("Mamonas Assassinas", new List<int>());

//Banda ira = new Banda("Ira!");
//ira.Avaliar(new Avaliacao(10));
//ira.Avaliar(new Avaliacao(8));
//ira.Avaliar(new Avaliacao(6));
//await ira.GerarDescricaoAsync();
//Banda beatles = new("The Beatles");

//Dictionary<string, Banda> bandasRegistradas = new();
//bandasRegistradas.Add(ira.Nome, ira);
//bandasRegistradas.Add(beatles.Nome, beatles);


//void Cabecario()
//{
//    Console.WriteLine(@"
//░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
//██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
//╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
//░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
//██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
//╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");

//    Console.WriteLine("\nBoas vindas ao Screen Sound");
//}

//Dictionary<int, MenuBandas> opcoes = new();
//opcoes.Add(1, new RegistrarBanda());
//opcoes.Add(2, new RegistrarAlbum());
//opcoes.Add(3, new MostrarBandas());
//opcoes.Add(4, new AvaliarBanda());
//opcoes.Add(5, new AvaliarAlbum());
//opcoes.Add(6, new ExibirDetalhes());
//opcoes.Add(-1, new Sair());


//void ExibirMenu()
//{
//    Console.WriteLine();
//    Console.WriteLine("Digite 1 para registrar uma banda");
//    Console.WriteLine("Digite 2 para registrar um album");
//    Console.WriteLine("Digite 3 para listar todas banda");
//    Console.WriteLine("Digite 4 para avaliar uma banda");
//    Console.WriteLine("Digite 5 para avaliar uma Album");
//    Console.WriteLine("Digite 6 para exibir detalhes de uma banda");
//    Console.WriteLine("Digite -1 para sair");
//}

//void ExecutarMenu()
//{
//    Console.Write("\nDigite a sua opção: ");
//    string opcaoEscolhida = Console.ReadLine()!;
//    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

//    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
//    {
//        MenuBandas menuASerExibido = opcoes[opcaoEscolhidaNumerica];
//        //menuASerExibido.Executar(bandasRegistradas);

//        if (opcaoEscolhidaNumerica > 0)
//        {
//            MenuInicial();
//        }
//    }
//    else
//    {
//        Console.WriteLine("Opção inválida");
//    }
//}



//void MenuInicial()
//{
//    Console.Clear();
//    Cabecario();
//    ExibirMenu();
//    ExecutarMenu();
//}

//MenuInicial();
