using System;
using System.Net;
//10
namespace _ProjetoPlaylist
{
    class Program
    {
        static void Main(String[] args)
        {
            Musica musica1 = new Musica();
            musica1.Nome = "Dont Worry now";
            musica1.Artista = "Mafia";
            musica1.Duracao = 5;
            musica1.Disponivel = true;
            Console.WriteLine(musica1.Descricao);
           
            Musica musica2 = new Musica();
            musica2.Nome = "Summer";
            musica2.Artista = "Calvin Harris";
            musica2.Duracao = 4;
            musica2.Disponivel = false;
            Console.WriteLine(musica2.Descricao);

            musica1.ExibirFixaTecnica();
            musica2.ExibirFixaTecnica();
        }
    }
}