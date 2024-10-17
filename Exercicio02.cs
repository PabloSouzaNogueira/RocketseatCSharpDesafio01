using System;

namespace RocketseatCSharpDesafio01;

internal class Exercicio02
{
    /// <summary>
    /// Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário 
    /// e ao final exiba o nome completo.
    /// </summary>
    public void Start()
    {
        Console.Write("Digite seu nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine();

        Console.Write("Digite seu sobrenome: ");
        var sobrenome = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(string.Format("Seu nome completo é: {0} {1}", nome, sobrenome));
    }
}