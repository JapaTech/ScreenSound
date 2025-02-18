using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas
{
    internal class FiltrarPorArtista : MenuMusicas
    {
        public override void Executar(List<Musica> musicas, string filtro)
        {
            base.Executar(musicas, filtro);
            ExibirTituloDaOpcao("Musicas do artista: " + filtro);

            var musicasDoArtista = musicas.Where(musica => musica.Artista.Equals(filtro)).ToList() ;

            int n = 1;
            foreach (var musica in musicasDoArtista) 
            {
                Console.WriteLine($"{n}. {musica.Nome}");
            }

        }
    }
}
