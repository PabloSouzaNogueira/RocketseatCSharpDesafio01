namespace RocketseatCSharpDesafio01;

internal class Exercicio03
{
    /// <summary>
    /// Crie um programa com 2 valores do tipo "double" já declarados que retorne:
    ///     - A soma entre esses dois números;
    ///     - A subtração entre os dois números;
    ///     - A multiplicação entre os dois números;
    ///     - A divisão entre os dois números(vale uma verificação se o segundo número é 0!);
    ///     - A média entre os dois números.
    /// </summary>
    public void Start()
    {
        Console.Write("Digite o 1º número: ");
        var numero1 = InformarNumero();

        Console.Write("Digite o 2º número: ");
        var numero2 = InformarNumero();

        Console.WriteLine(string.Format("Os números são: {0} e {1}", numero1, numero2));
        Console.WriteLine();
        Console.WriteLine(string.Format("Soma: {0}", numero1 + numero2));
        Console.WriteLine(string.Format("Subtração: {0}", numero1 - numero2));
        Console.WriteLine(string.Format("Multiplicação: {0}", numero1 * numero2));
        Console.WriteLine(string.Format("Divisão: {0}", numero1 / numero2));
        Console.WriteLine(string.Format("Média: {0}", (numero1 + numero2) / 2));
    }

    private double InformarNumero()
    {
        bool numeroValido;
        do
        {
            numeroValido = double.TryParse(Console.ReadLine(), out double numero);

            Console.Clear();

            if (!numeroValido)
            {
                Console.WriteLine();
                Console.Write("O número digitado não é um double, por favor, digite o número novamente: ");
            }
            else
            {
                return numero;
            }

        } while (!numeroValido);

        return 0;
    }
}