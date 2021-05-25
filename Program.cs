using System;

namespace RetContorno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 1, numero2 = 1, largura, altura;

            Console.WriteLine("------Retângulo Contornado------");
            Console.Write("Largura..: ");
            largura = int.Parse(Console.ReadLine());

            Console.Write("Altura...: ");
            altura = int.Parse(Console.ReadLine());

            if (largura < 0 || largura > 10 || altura < 0 || altura > 10)
            {
                Console.WriteLine("Digite apenas números de 0 a 10.");
            }
            else
            {
                Console.WriteLine();

                while (numero1 <= altura)
                {
                    while (numero2 <= largura)
                    {
                        if (numero1 == 1 || numero1 == altura || numero2 == 1 || numero2 == largura)
                        {
                            Console.Write("* ");
                        }
                        else
                        {
                            Console.Write("  ");
                        }
                        numero2++;
                    }
                    numero2 = 1;
                    numero1++;
                    Console.WriteLine();
                }
            }
        }
    }
}
