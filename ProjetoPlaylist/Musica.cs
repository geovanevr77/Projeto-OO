using System.Security.Cryptography.X509Certificates;

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string Descricao => "A musica " + Nome + " pertence a banda " + Artista; // é o GET, SOMENTE LEITURA (LAMBDA =>)


    public void ExibirFixaTecnica()
    {
        Console.WriteLine("Nome: "+Nome);
        Console.WriteLine("Artista: "+Artista);
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
  