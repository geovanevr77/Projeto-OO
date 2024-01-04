using System;
using System.Net;

namespace _ProjetoPlaylist
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Musica musica1 = new Musica();
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
             musica2.ExibirFixaTecnica();*/

            /*Banda coldplay = new Banda("Coldplay");

            Album albumDoColdplay = new Album("Paradise");

            Musica musica1 = new Musica(coldplay, "Yellow")
            {
                Duracao = 5,
                Disponivel = true,
            };
            

            Musica musica2 = new Musica(coldplay, "The Scientist")
            {
                Duracao = 4,
                Disponivel = false,
            };

            Musica musica3 = new Musica(coldplay, "Viva la Vida")
            {
                Duracao = 6,
                Disponivel = true,
            };

            albumDoColdplay.Adicionar(musica1);
            albumDoColdplay.Adicionar(musica2);
            albumDoColdplay.Adicionar(musica3);

            musica1.ExibirFixaTecnica();
            musica2.ExibirFixaTecnica();
            musica3.ExibirFixaTecnica();

            albumDoColdplay.ExibirMusicas();
            coldplay.AdicionarAlbum(albumDoColdplay);
            coldplay.ExibirDiscografia();*/

            Episodio ep1 = new(45, 1, "Técnicas de facilitação");
            ep1.AdicionarConvidados("Jonny");
            ep1.AdicionarConvidados("Aline");
            Console.WriteLine(ep1.Resumo);

            Episodio ep2 = new(35, 2, "Técnicas de facilitação");
            ep2.AdicionarConvidados("Leandro");
            ep2.AdicionarConvidados("Priscila");

            Podcast podcast = new("Podcast de natal", "Diego");
            podcast.AdicionarEpisodio(ep1);
            podcast.AdicionarEpisodio(ep2);
            podcast.ExibirDetalhes();

        }
    }
}