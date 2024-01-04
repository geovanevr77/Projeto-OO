using System;

class Episodio
{
    private List<string> convidados = new();
    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get;  }
    public int Ordem { get;  }
    public string Titulo { get;  }
    public string Resumo => "Ordem: "+Ordem+" Titulo: "+Titulo+" (Duração: "+Duracao+"min)"+string.Join(", ",convidados);

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}