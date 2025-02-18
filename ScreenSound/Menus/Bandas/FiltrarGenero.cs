using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Bandas
{
    internal class FiltrarGenero : MenuBandas
    {
        public void Executar(Dictionary<string, Banda> bandasRegistradas, string filtro)
        {
            var bandas = bandasRegistradas.Where(banda => banda.Value.Genero == filtro);
            foreach (var item in bandas) 
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
