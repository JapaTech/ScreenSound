
using System.Text;


using System.Text.Json;



namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{


    public IEnumerable <Album> Albuns => albuns;
    private List<Album> albuns = new List<Album>();

    private List<Avaliacao> avaliacoes = new List<Avaliacao>();
    public IEnumerable<Avaliacao> Avaliacoes => avaliacoes;
    public string Nome { get; }
    public string Descricao { get; set; }
    public string Genero { get; set; }

    private readonly HttpClient _httpClient;
    private const string ApiUrl = "https://api.deepseek.com/v1/chat/completions";
    private const string ApiKey = "yourApiKey";

    public Banda(string nome)
    {
        Nome = nome;
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
    }

    public double Media
    {
        get
        {
            if (avaliacoes.Count == 0) return 0;
            else return avaliacoes.Average(a => a.Nota);
        }
    }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void Avaliar(Avaliacao avaliacao)
    {
        avaliacoes.Add(avaliacao);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine("Discografia da banda: " + Nome);
        foreach (Album album in albuns) 
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }

    public async Task GerarDescricaoAsync()
    {
        try
        {
            var requestBody = new
            {
                model = "deepseek-chat", // Modelo da DeepSeek
                messages = new[]
                {
                new { role = "user", content = $"Descreva a banda {Nome} de forma criativa e envolvente em um parágrafo de no máximo 5 linhas." }
            },
                temperature = 0.7,
                max_tokens = 150
            };

            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(ApiUrl, content);
            response.EnsureSuccessStatusCode();

            var responseJson = await response.Content.ReadAsStringAsync();
            var responseObject = JsonDocument.Parse(responseJson);

            Descricao = responseObject.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();
        }
        catch (Exception ex)
        {
            Descricao = $"Não foi possível gerar a descrição: {ex.Message}";
        }
    }
}
