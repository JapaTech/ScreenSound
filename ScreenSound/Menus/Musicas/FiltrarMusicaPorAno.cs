using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas
{
    internal class FiltrarMusicaPorAno : MenuMusicas
    {
        public override void Executar(List<Musica> musicas, string filtro)
        {
            ExibirTituloDaOpcao("Músicas do ano" + filtro);

            base.Executar(musicas, filtro);
            int ano = int.Parse(filtro);
            var musicaPorAno = musicas.Where(m => m.Ano == ano).OrderBy(m => m.Artista)
                .Select(m => m.Nome)
                .Distinct().
                ToList();

            foreach (var item in musicaPorAno)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}
