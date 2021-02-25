using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float num1 = 0, num2 = 0;
                String escolha1 = "", escolha2;
                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.WriteLine("\t\t\t\t\t   |         ENTRADA        |");
                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.WriteLine("\t\t\t\t\t   | Informe o 1° valor     |");
                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.Write("\t\t\t\t\t   >>> ");
                num1 = float.Parse(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.WriteLine("\t\t\t\t\t   |         ENTRADA        |");
                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.WriteLine("\t\t\t\t\t   | Informe o 2° valor     |");
                Console.WriteLine("\t\t\t\t\t   |------------------------|");
                Console.Write("\t\t\t\t\t   >>> ");
                num2 = float.Parse(Console.ReadLine());
                Console.Clear();

                String escolha = Operacoes.menuOperacoes(num1, num2, escolha1);
                Operacoes.condicaoOperacoes(escolha, num1, num2);
                int aux = 0;
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("\t\t\t\t\t   |--------------------------|");
                    Console.WriteLine("\t\t\t\t\t   |          OPÇÕES          |");
                    Console.WriteLine("\t\t\t\t\t   |--------------------------|");
                    Console.WriteLine("\t\t\t\t\t   | Sim = s                  |");
                    Console.WriteLine("\t\t\t\t\t   | Não = n                  |");
                    Console.WriteLine("\t\t\t\t\t   |--------------------------|");
                    Console.WriteLine("\t\t\t\t\t   | deseja sair?             |");
                    Console.WriteLine("\t\t\t\t\t   |--------------------------|");
                    Console.Write("\t\t\t\t\t   >>>");
                    escolha2 = Console.ReadLine().ToLower();
                    Console.Clear();

                    if (escolha2 == "s")
                    {
                        Console.Clear();
                        Console.WriteLine("\t\t\t\t\t   +----------------------------------------------+");
                        Console.WriteLine("\t\t\t\t\t   |Desenvolvido pro Daniel Schinaider de Oliveira|");
                        Console.WriteLine("\t\t\t\t\t   +----------------------------------------------+");
                        aux = 2;
                        break;
                    }
                    else if (escolha2 == "n")
                    {
                        break;
                    }
                }

                if(aux == 2)
                {
                    break;
                }
            }
        }
    }

    class Operacoes
    {

        public static String menuOperacoes(float num1, float num2, String escolha)
        {

            Console.WriteLine("\t\t\t\t\t   |------------------------------|");
            Console.WriteLine("\t\t\t\t\t   |Calculadora desenvolvida em C#|");
            Console.WriteLine("\t\t\t\t\t   |------------------------------|");
            Console.WriteLine("\t\t\t\t\t   | Soma - (som)                 |");
            Console.WriteLine("\t\t\t\t\t   | Subtração - (sub)            |");
            Console.WriteLine("\t\t\t\t\t   | Divisão - (div)              |");
            Console.WriteLine("\t\t\t\t\t   | Multiplicação - (mult)       |");
            Console.WriteLine("\t\t\t\t\t   |------------------------------|");
            Console.WriteLine("\t\t\t\t\t   |Informe sua escolha:          |");
            Console.WriteLine("\t\t\t\t\t   |------------------------------|");
            Console.Write("\t\t\t\t\t   >>>");
            escolha = Console.ReadLine();
            Console.Clear();

            return escolha;
        }

        public static void condicaoOperacoes(String escolha, float num1, float num2)
        {
            float resultado;
            switch (escolha.ToLower())
            {
                case "som":
                    resultado = Operacoes.Soma(num1, num2);
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t   +---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   | CONTA   | " + num1 + "+" + num2 );
                    Console.WriteLine("\t\t\t\t\t   |---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   |Resultado| " + resultado );
                    Console.WriteLine("\t\t\t\t\t   +--------------------------+");
                    break;
                case "sub":
                    resultado = Operacoes.subtracao(num1, num2);
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t   +---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   | CONTA   | " + num1 + "-" + num2);
                    Console.WriteLine("\t\t\t\t\t   |---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   |Resultado| " + resultado);
                    Console.WriteLine("\t\t\t\t\t   +--------------------------+");
                    break;
                case "div":
                    resultado = Operacoes.divisao(num1, num2);
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t   +---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   | CONTA   | " + num1 + "÷" + num2);
                    Console.WriteLine("\t\t\t\t\t   |---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   |Resultado| " + resultado);
                    Console.WriteLine("\t\t\t\t\t   +--------------------------+");
                    break;
                case "mult":
                    resultado = Operacoes.multiplicacao(num1, num2);
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t   +---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   | CONTA   | " + num1 + "x" + num2);
                    Console.WriteLine("\t\t\t\t\t   |---------+----------------+");
                    Console.WriteLine("\t\t\t\t\t   |Resultado| " + resultado);
                    Console.WriteLine("\t\t\t\t\t   +--------------------------+");
                    break;
                default:
                    Console.WriteLine("\t\t\t\t\t   Informe uma operação válida!");
                    break;
            }
        }

        public static float Soma(float num1, float num2)
        {
            return num1 + num2;
        }
        public static float subtracao(float num1, float num2)
        {
            return num1 - num2;
        }
        public static float divisao(float num1, float num2)
        {
            return num1 / num2;
        }
        public static float multiplicacao(float num1, float num2)
        {
            return num1 * num2;
        }

    }
}


