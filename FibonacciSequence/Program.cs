using System;

namespace FibonacciSequence
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Para Sair do Programa digite X a qualquer momento.");
            while (true)
            {

                Console.WriteLine("Digite o numero que você quer encontrar:");
                string? numberString = Console.ReadLine();

                //Fecha o programa.
                if (numberString?.ToUpper() == "X")
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }


                // Garante que o valor inserido seja um inteiro.
                if (!int.TryParse(numberString, out int numberSearch) || numberSearch < 0)
                {


                    Console.WriteLine("Digite um número inteiro positivo!!!");
                    continue;



                }



                // Determinam o cálculo necessário para a sequência de Fibonacci.
                int previousNumber = 0;
                int currentNumber = 1;

                // Cálcula a posição dos números na sequência.
                int countLoop = 0;
                int numberPos = 0;
                int numberForLine = 0;
                bool find = false;


                if (previousNumber == numberSearch)
                {
                    find = true;
                    numberPos = 1;
                }


                /*Decidi trocar a função for por uma função while, 
                para que eu pudesse encerrar a função assim
                 que o valor fosse encontrado ou ultrapassado*/
                while (true)
                {


                    // essa função só serve para alinhar as linhas no Console
                    if (countLoop == 0)
                    {

                        Console.Write($"{previousNumber},{currentNumber},");
                        numberForLine++;


                    }
                    else
                    {

                        Console.Write($"{currentNumber},");
                        numberForLine++;
                    }
                    if (numberForLine == 5)
                    {

                        Console.WriteLine();
                        numberForLine = 0;

                    }


                    int nextNumber = currentNumber + previousNumber;
                    previousNumber = currentNumber;

                    currentNumber = nextNumber;

                    if (previousNumber == numberSearch)
                    {
                        find = true;
                        break;
                    }
                    if (nextNumber > numberSearch)
                    {
                        break;
                    }



                    countLoop++;
                }
                Console.WriteLine();


                // Diz se o valor foi achado ou não
                if (find)
                {
                    numberPos = countLoop + 2;
                    Console.WriteLine($"O numero {numberSearch} foi encontrado na Sequência Fibonacci");
                    Console.WriteLine($"Na {numberPos}º posição");
                    Console.WriteLine("A sequência irá parar");

                }
                else
                {

                    Console.WriteLine($"O numero {numberSearch} não foi encontrado na Sequência Fibonacci");

                }



            }
        }
    }




}