using Consumo_de_API.Modelos;

namespace Consumo_de_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista de Artistas Ordenados");

        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}
