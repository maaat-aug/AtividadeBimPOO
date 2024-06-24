namespace Exercicio_2
{
    public class Juridico : Cliente
    {
        public string CNPJ;

        public string InscricaoEstadual;

        public static List<Cliente> ClientesPJ;

        public override void Salvar(Cliente cliente)
        {
            ClientesPJ.Add(cliente);
        }

        public override void Imprimir()
        {
            foreach (Juridico cliente in ClientesPJ)
            {
                Console.WriteLine("Tipo: Jurídico");
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Inscrição Estadual: {cliente.InscricaoEstadual}\n");
            }
        }
    }
}
