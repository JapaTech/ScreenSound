
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound.Modelos;

internal class MusicasFavoritas
{
    public string NomePlaylist { get; set; }
    private string caminho = @"C:\Users\Jonathan\Desktop";
    public IEnumerable<Musica> MusicasFav => musicasFavoritas;
    private List<Musica> musicasFavoritas { get; set; }

    public MusicasFavoritas(string nomePlaylist, List<Musica> musicasFavoritas)
    {
        NomePlaylist = nomePlaylist;
        this.musicasFavoritas = musicasFavoritas;
    }

    public void AdicionarMusica(Musica musica)
    {
        musicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine("Essas snão as músicas favoritas de: " + NomePlaylist);
        foreach (var item in musicasFavoritas)
        {

        }
    }

    public void GerarArquivoJson()
    {
        string nomeDoArquivo = $"musica-favoritas-{NomePlaylist}.json";
        try
        {

            string json = JsonSerializer.Serialize(new
            {
                nome = NomePlaylist,
                musicas = musicasFavoritas
            });

            string caminhoCompleto = Path.Combine(caminho, nomeDoArquivo);

            File.WriteAllText(caminhoCompleto, json);
            Console.WriteLine("Arquivo json criado com sucesso");
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}
