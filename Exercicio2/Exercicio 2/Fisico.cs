namespace Exercicio_2
{
    public class Fisico : Cliente
    {
        public string CPF;

        public static List<Cliente> ClientesPF;

        public override void Salvar(Cliente cliente)
        {
            ClientesPF.Add(cliente);
        }

        public override void Imprimir()
        {
            foreach(Fisico cliente in ClientesPF)
            {
                Console.WriteLine("Tipo: Físico");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.CPF}\n");
            }
        }
    }
}
