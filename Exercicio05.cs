namespace RocketseatCSharpDesafio01;

internal class Exercicio05
{
    /// <summary>
    /// 1. Crie um programa em que o usuário precisa digitar a placa de um veículo 
    /// e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    /// 
    ///     - A placa deve ter 7 caracteres alfanuméricos;
    ///     - Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
    ///     - Os quatro últimos caracteres são números;
    /// 
    /// Ao final, o programa deve exibir "Verdadeiro" se a placa for válida e "Falso" caso contrário.
    /// </summary>
    public void Start()
    {
        Console.Write("Digite a placa do veículo: ");
        var placa = Console.ReadLine();

        if (placa?.Length != 7)
        {
            Console.WriteLine("Falso");
            return;
        }

        var numeros = "1234567890";
        var letras = "abcdefghijklmnopqrstuvxywz";

        for(int i = 0; i < placa.Length; i++)
        {
            if(i < 3)
            {
                if (!letras.Contains(placa[i].ToString().ToLower()))
                {
                    Console.WriteLine("Falso");
                    return;
                }
            }
            else
            {
                if(!numeros.Contains(placa[i]))
                {
                    Console.WriteLine("Falso");
                    return;
                }
            }
        }

        Console.WriteLine("Verdadeiro");
    }
}