using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Album
    {
        public string Nome { get; set; }

        public int DuracaoTotal => musicas.Sum(t => t.DuracaoSegundos);

        public List<Musica> musicas = new List<Musica>();
        
        public Album(string nome)
        {
            Nome = nome;
        }

        public void AdicionarMusica(Musica _musica)
        {
            musicas.Add(_musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Músicas do album {Nome} ({DuracaoTotal}s)" );
            foreach (var musica in musicas)
            {
                Console.WriteLine(musica.Nome);
            }
        }
    }
}
