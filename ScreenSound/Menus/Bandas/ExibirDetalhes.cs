using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class ExibirDetalhes : MenuBandas
{

    public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        base.Executar(bandasRegistradas, opcao);

        ExibirTituloDaOpcao("Exibir detalhes da banda");
        Console.Write("Digite o nome da banda que deseja conhecer melhor: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.Where(b => b.Nome == nomeDaBanda) != null)
        {
            Banda banda = bandasRegistradas.FirstOrDefault(b => b.Nome == nomeDaBanda)!;
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}.");
            Console.WriteLine(banda.Descricao);
            Console.WriteLine("\nDiscografia:");
            foreach (Album album in banda.Albuns)
            {
                Console.WriteLine($"{album.Nome} -> {album.Media}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }
        PressioneUmaTecla();
    }
}
