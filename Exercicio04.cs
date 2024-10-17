namespace RocketseatCSharpDesafio01;

internal class Exercicio04
{
    /// <summary>
    /// Crie um programa em que o usuário digita uma ou mais palavras e é exibido a 
    /// quantidade de caracteres que a palavra inserida tem.
    /// </summary>
    public void Start()
    {
        Console.Write("Digite a(s) palavra(s): ");
        var palavras = Console.ReadLine();

        var contador = 0;

        for (int i = 0; i < palavras.Length; i++)
        {
            if (palavras[i] != ' ')
                contador++;
        }

        Console.WriteLine();
        Console.WriteLine(string.Format("Número de caracteres (ignorando os espaços): {0}", contador));
    }
}