using System;

class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string Nome)
    {
        Nome = Nome;
    }
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void Adicionar(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine("Lista de musica do album:");
        foreach (var musica in musicas)
        {
            Console.WriteLine("Música: "+musica.Nome);
        }

        Console.WriteLine("Duração total: "+DuracaoTotal);
    }
}