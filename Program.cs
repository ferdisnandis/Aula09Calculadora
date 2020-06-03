using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calculadora = new CalculadoraCientifica();
            Console.WriteLine("Digite o primeiro número: ");
            calculadora.n1 = Int32.Parse( Console.ReadLine() );
            
            Console.WriteLine("Digite o segundo número: ");
            calculadora.n2 = Int32.Parse( Console.ReadLine() );

            Console.WriteLine("Qual operação deseja fazer? \n 1= Somar \n 2= Subtrair \n 3= Dividir \n 4= Multiplicar \n 5= Média");
            int resposta = Int32.Parse( Console.ReadLine() );
            switch (resposta)
        {
            case 1:
            Console.WriteLine( "O resultado da soma é " + calculadora.Somar() );
            break;

            case 2:
            Console.WriteLine( "O resultado da substração é " + calculadora.Subtrair() );
            break;

            case 3:
            Console.WriteLine( "O resultado da divisão é " + calculadora.Dividir() );
            break;

            case 4:
            Console.WriteLine( "O resultado da multiplicação é " + calculadora.Multiplicar() );
            break;

            case 5:
            Console.WriteLine( "O resultado da média é " + calculadora.Media() );
            break;


            }
        }
        }
}
//a = somar
//b = subtrair
//c = multiplicar
//d = dividir