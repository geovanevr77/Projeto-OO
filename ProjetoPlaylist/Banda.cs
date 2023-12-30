using System;

class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        nome = nome;
    }
    public string NomeBanda { get; }

    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine("Discografia: "+ NomeBanda);
        foreach (Album album in albums)
        {
            Console.WriteLine("Album: "+album.Nome+" ("+album.DuracaoTotal+")");
        }
    }

}