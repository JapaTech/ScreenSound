using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class AvaliarAlbum : MenuBandas
{

    public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.Select(b => b.Nome.Equals(nomeDaBanda)) != null)
        {
            Banda banda = bandasRegistradas.FirstOrDefault(b => b.Nome == nomeDaBanda);

            Console.Write("Agora digite o título do álbum: ");
            string tituloAlbum = Console.ReadLine()!;

            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual a nota que o álbum {tituloAlbum} merece: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.Avaliar(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {tituloAlbum}");
            }
            else
            {
                Console.WriteLine($"\nO álbum {tituloAlbum} não foi encontrado!");

            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
        }
        PressioneUmaTecla();
    }
}
