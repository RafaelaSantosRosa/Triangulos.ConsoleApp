using System;

namespace Triangulo.ConsoleApp
{
    public class TrianguloY
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;

        public void Tipo(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA == ladoB && ladoA == ladoC)
            {
                Console.WriteLine("Triângulo Equilátero");
                Console.ReadLine();
            }
            else if (ladoA != ladoB && ladoB != ladoC && ladoC != ladoA)
            {
                Console.WriteLine("Triângulo Escaleno");
                Console.ReadLine();
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                Console.WriteLine("Triângulo Isósceles");
                Console.ReadLine();
            }
        }
    }
}