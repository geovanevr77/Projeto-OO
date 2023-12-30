using System.Security.Cryptography.X509Certificates;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => "A musica " + Nome + " pertence a banda " + Artista; // é o GET, SOMENTE LEITURA (LAMBDA =>)


    public void ExibirFixaTecnica()
    {
        Console.WriteLine("Nome: "+Nome);
        Console.WriteLine("Artista: "+Artista.NomeBanda);
        Console.WriteLine("Duração: "+Duracao);

        if(Disponivel) 
        {
            Console.WriteLine("Está disponível");
        }
        else
        {
            Console.WriteLine("Não está disponível");
        }

    }
}
  