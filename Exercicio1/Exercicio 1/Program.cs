using Exercicio_1;

Basico basico = new();

Console.Write("Digite o valor de X: ");
double X = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor de Y: ");
double Y = Convert.ToInt32(Console.ReadLine());

basico.X = X;
basico.Y = Y;

basico.Multiplicar();
Console.WriteLine($"\nO produto de {X} e {Y} é {basico.R}\n");

basico.Somar();
Console.WriteLine($"A soma de {X} e {Y} é {basico.R}\n");

basico.Dividir();
Console.WriteLine($"A divisão de {X} por {Y} é {basico.R}\n");

basico.Subtrair();
Console.WriteLine($"A diferença de {X} e {Y} é {basico.R}\n");

Estatistico estatistico = new Estatistico();

estatistico.A = [];

while (true)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1-Adicionar um número na lista");
    Console.WriteLine("2-Calcular a média dos números digitados");
    Console.WriteLine("3-Sair");

    int escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.Write("Digite o número a ser adicionado: ");
            double num = Convert.ToDouble(Console.ReadLine());

            estatistico.A.Add(num);
            break;

        case 2:
            estatistico.Media();
            Console.WriteLine($"A média é {estatistico.R}");
            break;

        case 3:
            return;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}