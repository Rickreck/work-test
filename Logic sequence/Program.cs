using System;


namespace LogicSequence
{

    class Program
    {

        static void Main()
        {

            Console.WriteLine("Questão a)");
            Console.WriteLine();
            //questão a)


            int x = 2;
            int sequencia = 0;
            /* sequenciaPercorrida é igual número total de 
            casas percorrida menos o ponto inicial*/
            int sequenciaPercorrida = 4;
            int inicioSequencia = 1;
            Console.WriteLine(inicioSequencia);

            for (int i = 1; i <= sequenciaPercorrida; i++)
            {

                sequencia = inicioSequencia + x;
                inicioSequencia = sequencia;


                Console.WriteLine(sequencia);
            }

            Console.WriteLine();
            Console.WriteLine("Questão b)");
            Console.WriteLine();
            //questão b)

            x = 0;
            sequencia = 0;
            sequenciaPercorrida = 6;
            inicioSequencia = 2;
            Console.WriteLine(inicioSequencia);

            for (int i = 1; i <= sequenciaPercorrida; i++)
            {

                x = inicioSequencia;
                sequencia = inicioSequencia + x;
                inicioSequencia = sequencia;


                Console.WriteLine(sequencia);
            }

            //questão c)
            Console.WriteLine();
            Console.WriteLine("Questão c)");
            Console.WriteLine();


            x = 0;
            sequencia = 0;
            sequenciaPercorrida = 7;
            inicioSequencia = 0;

            Console.WriteLine(inicioSequencia);

            for (int i = 1; i <= sequenciaPercorrida; i++)
            {


                inicioSequencia++;
                x = inicioSequencia * inicioSequencia;



                Console.WriteLine(x);
            }

            //questão d)
            Console.WriteLine();
            Console.WriteLine("Questão d)");
            Console.WriteLine();


            x = 4;
            sequencia = 0;
            sequenciaPercorrida = 4;
            inicioSequencia = 4;
            Console.WriteLine(inicioSequencia);



            for (int i = 1; i <= sequenciaPercorrida; i++)
            {

                x = inicioSequencia * inicioSequencia;
                inicioSequencia++;
                inicioSequencia++;




                Console.WriteLine(x);
            }

            //questão e)
            Console.WriteLine();
            Console.WriteLine("Questão e)");
            Console.WriteLine();
            x = 0;
            sequencia = inicioSequencia + x;
            sequenciaPercorrida = 7;
            inicioSequencia = 1;




            for (int i = 1; i <= sequenciaPercorrida; i++)
            {

                sequencia = inicioSequencia + x;
                x = inicioSequencia;

                inicioSequencia = sequencia;

                Console.WriteLine(x);
            }



            //questão f)
            Console.WriteLine();
            Console.WriteLine("a questão f se trata de uma pegadinha aonde");
            Console.WriteLine("todos némeros escritos de forma extensa começam com a letra D)");
            Console.WriteLine("ou seja, para representa-los seria necessário criar um conjusto de strings)");
            Console.WriteLine();
        }


    }





}