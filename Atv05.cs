/*
Melhore o programa do exercício 4 para que ele possa receber um número inteiro do usuário 
e mostrar a tabuada desse número. O programa deve continuar pedindo um número até que o 
usuário digite um número negativo, momento em que o programa deve ser encerrado.

Regras:
- utilizar do/while em um dos laços de repetição
- utilizar while em um dos laços de repetição
- apresentar cada operação de forma organizada
- mostrar a tabuada completa do número informado pelo usuário
*/

/*
Melhore o programa do exercício 4 para que ele possa receber um número inteiro do usuário 
e mostrar a tabuada desse número. O programa deve continuar pedindo um número até que o 
usuário digite um número negativo, momento em que o programa deve ser encerrado.

Regras:
- utilizar do/while em um dos laços de repetição
- utilizar while em um dos laços de repetição
- apresentar cada operação de forma organizada
- mostrar a tabuada completa do número informado pelo usuário
*/

public static class Atv05
{
    public static void Executar()
    {
        int numero;
        int multiplicador;

        do
        {
            Console.Write("Digite um número para fazer sua tabuada (ou um número negativo para sair):\n-> ");
            numero = int.Parse(Console.ReadLine()!);
            Console.Clear();


            if (numero >= 0)
            {
                Console.WriteLine($"Tabuada do {numero}: ");
                multiplicador = 1;


                while (multiplicador <= 10)
                {
                    Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");
                    multiplicador++;
                }
                Console.WriteLine();
            }


        } while (numero >= 0);
    }
}