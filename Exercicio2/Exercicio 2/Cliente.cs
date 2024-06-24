namespace Exercicio_2
{
    public abstract class Cliente
    {
        public string Nome;

        public abstract void Salvar(Cliente cliente);
        public abstract void Imprimir();
    }
}
