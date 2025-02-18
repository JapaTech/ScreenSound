using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas;

internal class FiltrarArtistasPorGenero : MenuMusicas
{
    public override void Executar(List<Musica> musicas, string filtro)
    {
        base.Executar(musicas, filtro);
        Console.WriteLine($"Mostrando artistas que tem música: {filtro}");
        var artistasDoGenero = musicas.OrderBy(musica => musica.Artista)
            .Where(musica => musica.Genero.Contains(filtro))
            .Select(musica => musica.Artista)
            .Distinct();

        foreach (var item in artistasDoGenero)
        {
            Console.WriteLine("- " + item);
        }
    }
}
