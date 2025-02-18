using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas;

internal class ExibirTodosGenerosMusicais : MenuMusicas
{
    public override void Executar(List<Musica> musicas)
    {
        base.Executar(musicas);
        ExibirTituloDaOpcao("Todos os generos musicais");
        var todosGeneros = musicas.OrderBy(musica => musica.Genero).Select(musica => musica.Genero)
            .Distinct().ToList();

        int n = 1; 
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"{n}. {genero}");
            n++;
        }
    }
}
