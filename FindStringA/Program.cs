using System;
using System.Collections.Generic;
using System.Text;
using UnicodeInfo = System.Globalization.CharUnicodeInfo;


namespace FindStringA
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Para Sair do Programa digite 0 a qualquer momento.");

            // Estrutura em formato de Menu
            while (true)
            {

                Console.WriteLine("Digite qualquer frase ou palavra:");
                string? words = Console.ReadLine();
                string letter = "A";




                //Fecha o programa.
                if (words == "0")
                {
                    Console.WriteLine("Programa encerrado.");
                    break;
                }




                // Verifica se na verdade a string não é formada de números
                if (int.TryParse(words, out int number))
                {
                    Console.WriteLine("Digite uma palavra ou frase!!!");
                    continue;
                }

                /*Deixa todas letras da string words maiúsculas e retira
                os acentos para facilitar o processo de verificação*/

                words = DeleteAccentuation(words?.ToUpper() ?? "");

                if (words == null)
                {

                    Console.WriteLine("A string não pode ser nula!!!");
                    continue;

                }



                (int numberLetters, List<int> positionLetters) = CountLetters(words, letter);

                if (numberLetters == 1)
                {

                    Console.WriteLine($"{numberLetters.ToString()} letra A encontrada.");
                    Console.WriteLine($"Na {string.Join("º, ", positionLetters)}º posição.");


                }
                else if (numberLetters > 1)
                {
                    Console.WriteLine($"{numberLetters.ToString()} letras A encontradas.");
                    Console.WriteLine($"Nas posições: {string.Join("º, ", positionLetters)}º.");


                }
                else
                {

                    Console.WriteLine("Nenhuma letra A foi encontrada nessa sentença");


                }

            }


            //  função que guarda e lista os caracteres da string      
            static (int, List<int>) CountLetters(string words, string letter)
            {



                int qnt = 0;
                List<int> positionLetters = new List<int>();


                for (int i = 0; i < words.Length; i++)
                {




                    if (words[i].ToString() == letter)
                    {
                        qnt++;
                        positionLetters.Add(i + 1);
                    }

                }


                return (qnt, positionLetters);


            }


            /* Usando a biblioteca "System.Text" as regras funcionam para letras com acentuação
             se responsabilizando por deletar os acentos de palavras como: cão, pão, mamão, mãe, 
            fazendo com que até mesmo essas letras A sejam contabilizadas. */
            static string DeleteAccentuation(string setence)
            {

                string normalize = setence.Normalize(NormalizationForm.FormD);

                var construct = new StringBuilder();


                // navega e verifica por cada caractere
                foreach (var normaChar in normalize)
                {

                    var unicode = UnicodeInfo.GetUnicodeCategory(normaChar);

                    if (unicode != System.Globalization.UnicodeCategory.NonSpacingMark)
                    {

                        construct.Append(normaChar);


                    }


                }

                return construct.ToString().Normalize(NormalizationForm.FormC);

            }


        }




    }
}