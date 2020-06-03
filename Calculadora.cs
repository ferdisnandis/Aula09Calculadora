namespace Aula09Calculadora
{
    public class Calculadora
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public int resultado;

        public int Somar(){
            return n1 + n2;

        }
        public int Subtrair(){
            return n1 - n2;
        }
        public int Dividir(){
            return n1/n2;
        }
        public int Multiplicar(){
            return n1*n2;
        }
    }
}