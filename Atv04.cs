/*
Desenvolva um programa em C# que permita ao usuário escolher um número para gerar a sua tabuada.

O programa deve:
-solicitar ao usuário o número desejado;
-calcular e exibir a tabuada desse número;

Regras da atividade
- utilizar estrutura de repetição(while ou do/while) para exibir os cálculos;
- apresentar cada operação de forma organizada;
- mostrar a tabuada completa do número informado pelo usuário.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/

using System.Security.Cryptography.X509Certificates;

public static class Atv04
{
    public static void Executar()
    {
        int numero;
        int multiplicador = 1;


        Console.WriteLine("Digite o número desejado: ");
        numero = int.Parse(Console.ReadLine()!);


        while (multiplicador <= 10)
        {
            Console.WriteLine($"{numero} * {multiplicador} = {numero * multiplicador}");
            multiplicador++;

        }
    }
}