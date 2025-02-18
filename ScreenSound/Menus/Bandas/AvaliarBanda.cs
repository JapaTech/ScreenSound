using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class AvaliarBanda : MenuBandas
{
    public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        base.Executar(bandasRegistradas, opcao);

        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.Where(b => b.Nome == nomeDaBanda) != null)
        {
            Banda banda = bandasRegistradas.FirstOrDefault(b => b.Nome == nomeDaBanda)!;
            Console.Write($"Qual a nota que a banda {banda.Nome} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.Avaliar(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }

        PressioneUmaTecla();
    }
}
