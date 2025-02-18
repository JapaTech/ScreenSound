using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(t => t.Duracao_ms);

    private List<Avaliacao> avaliacoes = new List<Avaliacao>();
    public IEnumerable<Avaliacao> Avaliacoes => avaliacoes;

    public double Media
    {
        get
        {
            if (avaliacoes.Count == 0) return 0;
            else return avaliacoes.Average(a => a.Nota);
        }
    }
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

    public void Avaliar(Avaliacao nota)
    {
        avaliacoes.Add(nota);
    }
}
