using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace ScreenSound.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Nome { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao_ms { get; set; }
    [JsonPropertyName("genre")]
    public int DuracaoSegundos => Duracao_ms * 1000;
    public string Genero { get; set; }

    [JsonPropertyName("year")]
    public string AnoString { get; set; }
    public int Ano {
        get
        {
            return int.Parse(AnoString);
        } 
    }
    public bool Disponivel { get; set; }
    public string Detalhes => $"A musica {Nome} pertence à {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Artista: " + Artista);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Duracao: " + DuracaoSegundos);

        if (Disponivel)
        {
            Console.WriteLine("Disponível no seu plano");
        }
        else
        {
            Console.WriteLine("Adquira um plano superior");
        }
    }
}
