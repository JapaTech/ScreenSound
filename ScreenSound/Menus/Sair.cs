using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Menus.Bandas;
using ScreenSound.Modelos;

namespace ScreenSound.Menus
{
    internal class Sair : MenuBandas
    {
        public override void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
        {
            Console.WriteLine("Tchau tchau :)");
            PressioneUmaTecla();
        }
    }
}
