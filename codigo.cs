
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<string> alunos = new List<string> { "Pedro", "Helena", "Carlos", "Ana", "Marcos" };

        Console.WriteLine("Alunos matriculados: Pedro, Helena, Carlos, Ana, Marcos");

        Console.WriteLine("\nDigite o nome do aluno que desistiu do curso:");
        string alunoDesistente = Console.ReadLine();

        alunos.Remove(alunoDesistente);


        Console.WriteLine("\nLista atualizada de alunos matriculados:");
        foreach (string aluno in alunos)
        {
            Console.WriteLine($"- {aluno}");
        }
    }
}
