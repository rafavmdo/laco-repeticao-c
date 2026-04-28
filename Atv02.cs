/*
Em uma cantina escolar, o atendente registra o valor das compras realizadas pelos alunos.
O sistema:

- lê o valor de uma compra;
- soma esse valor ao total arrecadado;
- pergunta se deseja registrar outra compra;
- repete o processo até o usuário responder que não quer continuar.

Ao final, o programa mostra:
- a quantidade de compras registradas;
- o valor total arrecadado.

===========DESAFIO===========
O programa da cantina já registra o valor das compras, soma o total arrecadado e 
conta quantas compras foram realizadas. Modifique o código para que ele também exiba, 
ao final, o valor médio das compras registradas, mantendo o uso do do/while.
No cálculo da média, devem ser considerados apenas os valores válidos registrados.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/
using System.Net.Http.Headers;

public static class Atv02
{
    public static void Executar()
    {
        double valorCompra;
        double totalArrecadado = 0;
        int quantidadeCompras = 0;
        string continuar;

        do
        {
            Console.Write("Digite o valor da compra: R$ ");
            valorCompra = double.Parse(Console.ReadLine()!);

            if (valorCompra > 0)
            {
                totalArrecadado = totalArrecadado + valorCompra;
                quantidadeCompras = quantidadeCompras + 1;
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um valor maior que zero.");
            }

            Console.Write("Deseja registrar outra compra? (s/n): ");
            continuar = Console.ReadLine()!;
            Console.WriteLine();

        } while (continuar == "s" || continuar == "S");

        Console.WriteLine($"Quantidade de compras registradas: {quantidadeCompras}");
        Console.WriteLine($"Total arrecadado: R$ {totalArrecadado}");
        Console.WriteLine($"Total media: R$ {totalArrecadado / quantidadeCompras}");

    }
}

