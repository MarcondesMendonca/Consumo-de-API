using Consumo_de_API.Filtros;
using Consumo_de_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiletarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Michael Jackson");

        //var musicasPreferidasDoMarcondes = new MusicasPreferidas("Marcondes");

        //musicasPreferidasDoMarcondes.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoMarcondes.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidasDoMarcondes.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidasDoMarcondes.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoMarcondes.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidasDoMarcondes.ExibirMusicasFavoritas();

        var musicasPreferidasEmilly = new MusicasPreferidas("Emy");

        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasEmilly.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidasEmilly.ExibirMusicasFavoritas();

        musicasPreferidasEmilly.GerarArquivoJson();

       
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
 