using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        const int maxAlunos = 5;
        List<Aluno> alunos = new List<Aluno>();

        int reprovadosPorNota = 0;
        int reprovadosPorFalta = 0;

        for (int i = 0; i < maxAlunos; i++)
        {
            Console.WriteLine($"cadastro do aluno {i + 1}:");

            Console.Write("nome: ");
            string nome = Console.ReadLine();

            Console.Write("quantidade de faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            Console.Write("nota final: ");
            double nota = double.Parse(Console.ReadLine());

            alunos.Add(new Aluno(nome, faltas, nota));

            Console.WriteLine();
        }


        Console.WriteLine("relatório Final!!!");

        foreach (Aluno aluno in alunos)
        {
            Console.WriteLine($"aluno: {aluno.Nome}");
            Console.WriteLine($" - situação da nota: {aluno.SituacaoNota()}");
            Console.WriteLine($" - situação de presença: {aluno.SituacaoPresenca()}");
            Console.WriteLine();

            if (aluno.EstaReprovadoPorNota()) reprovadosPorNota++;
            if (aluno.EstaReprovadoPorFalta()) reprovadosPorFalta++;
        }

        Console.WriteLine("resumo Final:");
        Console.WriteLine($"total de alunos reprovados por nota: {reprovadosPorNota}");
        Console.WriteLine($"total de alunos reprovados por falta: {reprovadosPorFalta}");
    }
}
