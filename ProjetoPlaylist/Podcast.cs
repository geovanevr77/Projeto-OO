using System;

class Podcast
{
    private List<Episodio> episodio = new();
    public Podcast(int host, string nomePd)
    {
        Host = host;
        NomePd = nomePd;
    }

    private int Host { get; }

    public string NomePd { get;}

    public int TotalEpisodios => episodio.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("Podcast: " + NomePd + " apresentado por " + Host);

        foreach (Episodio episodio in episodios.OrderBy(0 => 0.Ordem);
        {
            Console.WriteLine(episodio.Resumo);
        }
        Console.WriteLine("Este episodio possui " + TotalEpisodios + " episodios.");
    }
}