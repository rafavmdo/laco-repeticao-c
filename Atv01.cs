/*
Durante o desenvolvimento de um sistema interno para uma pequena empresa, 
foi criada uma calculadora simples para ajudar em conferências rápidas de valores, 
como soma de despesas, subtração de descontos, multiplicação de quantidades por preço unitário 
e divisão de valores entre setores ou pessoas.

Na versão atual do programa, o usuário escolhe a operação digitando números de 1 a 4. 
Porém, para deixar o sistema mais próximo do uso real e mais intuitivo, 
foi solicitado que essa escolha passe a ser feita pelos símbolos matemáticos da operação.

A partir de agora, o sistema deve receber:

+ para soma
- para subtração
x para multiplicação
/ para divisão

Sua tarefa é alterar o programa para que ele deixe de trabalhar com opções numéricas 
e passe a reconhecer diretamente os símbolos das operações. Para isso, 
será necessário ajustar toda a lógica necessária para que a calculadora continue funcionando 
corretamente.

O programa deverá solicitar a operação desejada, pedir os dois valores, 
realizar o cálculo correspondente, exibir o resultado, tratar tentativas de divisão por zero, 
informar quando uma operação inválida for digitada e permitir novos cálculos enquanto o usuário 
desejar continuar.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.
*/
using System.Security.Cryptography.X509Certificates;

public static class Atv01
{
    public static void Executar()
    {
        double numero1;
        double numero2;
        double resultado = 0;
        string opcao;
        string continuar = "s";

        while (continuar == "s" || continuar == "S")
        {
            Console.Clear();
            Console.WriteLine("=== CALCULADORA ===");
            Console.WriteLine("+ - Soma");
            Console.WriteLine("- - Subtração");
            Console.WriteLine("x - Multiplicação");
            Console.WriteLine("/ - Divisão");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            Console.Write("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine()!);

            Console.Write("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine()!);

            if (opcao == "+")
            {
                resultado = numero1 + numero2;
                Console.WriteLine($"Resultado da soma: {resultado}");
            }
            else if (opcao == "-")
            {
                resultado = numero1 - numero2;
                Console.WriteLine($"Resultado da subtração: {resultado}");
            }
            else if (opcao == "x")
            {
                resultado = numero1 * numero2;
                Console.WriteLine($"Resultado da multiplicação: {resultado}");
            }
            else if (opcao == "/")
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                }
                else
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();
            Console.Write("Deseja fazer outro cálculo? (s/n): ");
            continuar = Console.ReadLine()!;
        }

        Console.WriteLine("Programa encerrado.");
    }
}