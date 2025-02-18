using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas;

internal class ExibirTodosArtistas : MenuMusicas
{
    public override void Executar(List<Musica> musicas)
    {
        base.Executar(musicas);
        ExibirTituloDaOpcao("Exibindo todos artistas");
        
        var artistas = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();

        foreach (var artista in artistas) 
        {
            Console.WriteLine("- " + artista);
        }
    }
}
