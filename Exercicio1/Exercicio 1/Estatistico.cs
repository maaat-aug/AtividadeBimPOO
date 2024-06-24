namespace Exercicio_1
{
    public class Estatistico : Calculo
    {
        public List<double> A { get; set; }

        public void Media()
        {
            double soma = 0;

            foreach(double num in A)
            {
                soma += num;
            }

            R = soma / A.Count;
        }
    }
}
