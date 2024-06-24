namespace Exercicio_2
{
    public class Cadastro
    {
        public void GerarMenu()
        {
            bool loop = true;

            Fisico.ClientesPF = [];
            Juridico.ClientesPJ = [];

            while (loop)
            {
                Fisico fisico = new();
                Juridico juridico = new();

                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("1-Cadastrar um cliente físico");
                Console.WriteLine("2-Cadastrar um cliente jurídico");
                Console.WriteLine("3-Listar todos os clientes");
                Console.WriteLine("4-Sair");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        fisico.Nome = Console.ReadLine();

                        Console.Write("Digite o CPF do cliente: ");
                        fisico.CPF = Console.ReadLine();

                        fisico.Salvar(fisico);
                        break;

                    case 2:
                        Console.Write("Digite o nome do cliente: ");
                        juridico.Nome = Console.ReadLine();

                        Console.Write("Digite o CNPJ do cliente: ");
                        juridico.CNPJ = Console.ReadLine();

                        Console.Write("Digite a inscrição estadual do cliente: ");
                        juridico.InscricaoEstadual = Console.ReadLine();

                        juridico.Salvar(juridico);
                        break;

                    case 3:
                        fisico.Imprimir();
                        juridico.Imprimir();
                        break;

                    case 4:
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
