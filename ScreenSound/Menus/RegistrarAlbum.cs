using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Menus.Bandas;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class RegistrarAlbum : MenuBandas
    {
        public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
        {
            //base.Executar(bandasRegistradas, opcao);
            //ExibirTituloDaOpcao("Registro de álbuns");
            //Console.Write("Digite a banda cujo álbum deseja registrar: ");
            //string nomeDaBanda = Console.ReadLine()!;
            //if (bandasRegistradas.ContainsKey(nomeDaBanda))
            //{
            //    Console.Write("Agora digite o título do álbum: ");
            //    string tituloAlbum = Console.ReadLine()!;
            //    Banda banda = bandasRegistradas[nomeDaBanda];
            //    banda.AdicionarAlbum(new Album(tituloAlbum));
            //    Console.WriteLine($"O álbum {tituloAlbum} de {nomeDaBanda} foi registrado com sucesso!");
            //    PressioneUmaTecla();
            //}
            //else
            //{
            //    Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            //    PressioneUmaTecla();
            //}
        }

    }
}
