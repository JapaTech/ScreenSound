using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas;

internal class MenuBandas : Menu
{
    public virtual void Executar(IEnumerable<Banda> bandasRegistradas, string opcao)
    {
        Console.Clear();
    }

}
