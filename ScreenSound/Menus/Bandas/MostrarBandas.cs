using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class MostrarBandas : MenuBandas
{
    public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        base.Executar(bandasRegistradas, opcao);
        //ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        //foreach (string banda in bandasRegistradas.Keys)
        //{
        //    Console.WriteLine($"Banda: {banda}");
        //}

        //PressioneUmaTecla();
    }
}
