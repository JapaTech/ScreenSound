using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas;

internal class MenuMusicas : Menu
{
    public virtual void Executar(List<Musica> musicas)
    {
        Console.Clear();
    }

    public virtual void Executar(List<Musica> musicas, string filtro)
    {
        Console.Clear();
    }

    
}
