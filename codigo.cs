
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> alunos = new List<string> { "Pedro", "Helena", "Carlos", "Ana", "Marcos" };

        Console.WriteLine("Alunos matriculados: Pedro, Helena, Carlos, Ana, Marcos");

        Console.WriteLine("\nDigite o nome do aluno que desistiu do curso:");
        string alunoDesistente = Console.ReadLine()?.Trim() ?? "";
        int indice = alunos.FindIndex(aluno => string.Equals(aluno, alunoDesistente, StringComparison.OrdinalIgnoreCase));
        if (alunoDesistente.Length == 0)
        {
            Console.WriteLine("Nenhum nome informado.");
        }
        else if (indice < 0)
        {
            Console.WriteLine("Aluno não encontrado.");
        }
        else
        {
            alunos.RemoveAt(indice);
        }


        Console.WriteLine("\nLista atualizada de alunos matriculados:");
        foreach (string aluno in alunos)
        {
            Console.WriteLine($"- {aluno}");
        }
    }
}
