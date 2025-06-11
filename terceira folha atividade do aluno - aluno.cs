using System;

public class Aluno
{
    public string Nome { get; set; }
    public int Faltas { get; set; }
    public double Nota { get; set; }

    public Aluno(string nome, int faltas, double nota)
    {
        Nome = nome;
        Faltas = faltas;
        Nota = nota;
    }

    public string SituacaoNota()
    {
        if (Nota >= 7.0)
        {
            return "aprovado";
        }
        else
        {
            return "reprovado";
        }
    }

    public string SituacaoPresenca()
    {
        if (Faltas <= 5)
        {
            return "regular";
        }
        else
        {
            return "irregular";
        }
    }

    public bool EstaReprovadoPorNota()
    {
        return Nota < 7.0;
    }

    public bool EstaReprovadoPorFalta()
    {
        return Faltas > 5;
    }
}
