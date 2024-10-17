namespace RocketseatCSharpDesafio01;

internal class Exercicio06
{
    /// <summary>
    /// Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    ///     - Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    ///     - Apenas a data no formato "01/03/2024".
    ///     - Apenas a hora no formato de 24 horas.
    ///     - A data com o mês por extenso.
    /// </summary>
    public void Start()
    {
        var formatoValido = true;

        Console.WriteLine("Escolha o formato para exibir a data atual:");

        do
        {
            formatoValido = true;

            Console.WriteLine();
            Console.WriteLine("1 - Data no formato dd/MM/yyyy");
            Console.WriteLine("2 - Data com o mês por extenso (dd de MMMM de yyyy)");
            Console.WriteLine("3 - Data no formato MM/dd/yyyy");
            Console.WriteLine("4 - Data com dia da semana por extenso (dddd, dd de MMMM de yyyy)");
            Console.WriteLine();

            Console.Write("Digite o número do formato desejado: ");
            var formato = Console.ReadLine();
            Console.Clear();

            var data = DateTime.Now;

            switch (formato)
            {
                case "1":
                    Console.WriteLine(data.ToLongDateString() + " " + data.ToLongTimeString());
                    break;
                case "2":
                    Console.WriteLine(data.ToShortDateString());
                    break;
                case "3":
                    Console.WriteLine(data.ToShortTimeString());
                    break;
                case "4":
                    Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy"));
                    break;
                default:
                    Console.WriteLine("Ooops! Não temos essa opção de formato, favor digitar uma opção de formato existente.");
                    break;
            }

        } while (!formatoValido);
    }
}