using System;


namespace Triangulo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            TrianguloY triangulo = new TrianguloY();

            //triangulo equilatero
            triangulo.ladoA = 1;
            triangulo.ladoB = 1;
            triangulo.ladoC = 1;

            //condição de existência
            Valida trianguloInvalido = new Valida();
            trianguloInvalido.CondicaoExistencia(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            triangulo.Tipo(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            //triangulo isósceles
            triangulo.ladoA = 1;
            triangulo.ladoB = 2;
            triangulo.ladoC = 2;

            trianguloInvalido.CondicaoExistencia(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            triangulo.Tipo(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            //triangulo escaleno
            triangulo.ladoA = 1;
            triangulo.ladoB = 2;
            triangulo.ladoC = 3;

            trianguloInvalido.CondicaoExistencia(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            triangulo.Tipo(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            //triangulo invalido
            triangulo.ladoA = 7;
            triangulo.ladoB = 2;
            triangulo.ladoC = 3;

            trianguloInvalido.CondicaoExistencia(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

            triangulo.Tipo(triangulo.ladoA, triangulo.ladoB, triangulo.ladoC);

        }
    }
}

