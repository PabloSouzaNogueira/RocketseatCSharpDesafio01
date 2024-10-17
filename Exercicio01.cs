namespace RocketseatCSharpDesafio01;

internal class Exercicio01
{
    /// <summary>
    /// Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas 
    /// personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
    /// </summary>
    public void Start()
    {
        Console.Write("Digite seu nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(string.Format("Olá, {0}! Seja muito bem-vindo!", nome));
    }
}