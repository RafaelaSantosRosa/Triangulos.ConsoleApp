using System;

namespace Triangulo.ConsoleApp
{
    public class Valida
    {
        public void CondicaoExistencia(int ladoA, int ladoB, int ladoC)
        {
            if (ladoA > ladoB + ladoC)
                ApresentaMensagem();

            else if (ladoB > ladoA + ladoC)
                ApresentaMensagem();

            else if (ladoC > ladoA + ladoB)
                ApresentaMensagem();
        }

        private static void ApresentaMensagem()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Triângulo inválido");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}