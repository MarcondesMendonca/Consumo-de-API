﻿using Consumo_de_API.Modelos;

namespace Consumo_de_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
            Console.WriteLine($"- {genero}");
    }


public static void FiletarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
{
    var artistaPorGeneroMusical = musicas.Where(musica =>
        musica.Genero!.Contains(genero)).Select(musica =>
        musica.Artista).Distinct().ToList();

    Console.WriteLine($"Exibindo artistas por gênero musical >>>> {genero}");

    foreach(var artista in artistaPorGeneroMusical)
    {
        Console.WriteLine($"- {artista}");
    }
}

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals
            (nomeDoArtista)).ToList();

        Console.WriteLine(nomeDoArtista);

        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }

    }


}
