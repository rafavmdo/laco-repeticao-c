/*
Um estacionamento deseja registrar a entrada de veículos durante o dia. 
Para cada veículo que entrar, o atendente deve informar a placa. 
O sistema deve continuar pedindo novas placas enquanto o 
operador desejar continuar o atendimento.

Ao final, o programa deve mostrar:
- a quantidade total de veículos registrados.

Regras da atividade
- o programa deve usar while para repetir o cadastro das placas;
- após cada tentativa de cadastro, o programa deve perguntar se o operador deseja continuar;
- ao final, exibir a quantidade de veículos registrados com sucesso.

Observação: Vestigios de uso de IA, atividade zerada, 
ou código copiado de terceiros sem a devida citação, serão penalizados.

*/
public static class Atv03
{
    public static void Executar()
    {
        Console.Clear();
        string placaCarro;
        int quantidadeCarros = 0;
        string continuar;

        Console.WriteLine("Gostaria de registrar alguma placa? s/n");
        continuar = Console.ReadLine()!;

        while (continuar == "s" || continuar == "S")
        {
            Console.Clear();
            Console.WriteLine("Qual é a placa do carro? ");
            placaCarro = Console.ReadLine()!;
            quantidadeCarros++;
            Console.WriteLine("Gostaria de registrar alguma placa? s/n");
            continuar = Console.ReadLine()!;
            Console.Clear();
        }
        Console.WriteLine($"Total de placas registradas: {quantidadeCarros}");
    }
}