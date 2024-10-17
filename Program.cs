namespace RocketseatCSharpDesafio01;

public class Program
{
    static void Main()
    {
        var exercicioValido = true;

        Console.WriteLine("Olá!");
        Console.WriteLine("Para facilitar, criei um único projeto contendo todos os exercícios do desafio.");
        Console.WriteLine();
        Console.WriteLine("Selecione o exercício desejado, digitando o número de sua referência:");

        do
        {
            exercicioValido = true;

            Console.WriteLine();
            Console.WriteLine("Exercício 1");
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Exercício 3");
            Console.WriteLine("Exercício 4");
            Console.WriteLine("Exercício 5");
            Console.WriteLine("Exercício 6");
            Console.WriteLine();
            Console.Write("Digite o número do exercício: ");
            var exercicio = Console.ReadLine();
            Console.Clear();

            switch (exercicio)
            {
                case "1":
                    new Exercicio01().Start();
                    break;
                case "2":
                    new Exercicio02().Start();
                    break;
                case "3":
                    new Exercicio03().Start();
                    break;
                case "4":
                    new Exercicio04().Start();
                    break;
                case "5":
                    new Exercicio05().Start();
                    break;
                case "6":
                    new Exercicio06().Start();
                    break;
                default:
                    Console.WriteLine("Ooops! Não temos esse exercício, favor digitar um número de exercício existente.");
                    exercicioValido = false;
                    break;
            }

        } while (!exercicioValido);
    }
}