namespace Exercicio_1
{
    public class Basico : Calculo
    {
        public double X { private get; set; }
        public double Y { private get; set; }

        public void Multiplicar()
        {
            R = X * Y;
        }
        public void Somar()
        {
            R = X + Y;
        }
        public void Dividir()
        {
            R = X / Y;
        }
        public void Subtrair()
        {
            R = X - Y;
        }
    }
}
