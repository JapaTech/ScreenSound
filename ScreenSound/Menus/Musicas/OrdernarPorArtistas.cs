using ScreenSound.Modelos;

namespace ScreenSound.Menus.Musicas
{
    internal class OrdernarPorArtistas : MenuMusicas
    {
        public override void Executar(List<Musica> musicas, string filtro)
        {
            var musicasPorGenero = musicas.OrderBy(banda => filtro);

            foreach (var item in musicasPorGenero)
            {
                Console.WriteLine(item.Detalhes);
            }
        }
    }
}
