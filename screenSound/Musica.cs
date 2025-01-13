using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        public Genero genero;
        public string Nome { get; }
        public string Artista { get; }
        public int DuracaoSegundos { get; set; }
        public bool Disponivel { get; set; }
        public string Detalhes => $"A musica {Nome} pertence à {Artista}";

        public void ExibirFichaTecnica()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Artista: " + Artista);
            Console.WriteLine("Gênero: " + genero.Nome);
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
}
