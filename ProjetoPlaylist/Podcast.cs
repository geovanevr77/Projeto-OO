using System;

class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(int host, string nomePd)
    {
        Host = host;
        NomePd = nomePd;
    }

    private int Host { get; }

    public string NomePd { get;}

    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Podcast: " + NomePd + " apresentado por " + Host);

        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine("Este episodio possui " + TotalEpisodios + " episodios.");
    }
}