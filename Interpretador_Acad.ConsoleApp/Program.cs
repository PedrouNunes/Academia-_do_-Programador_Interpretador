using System;
using System.IO;

namespace Interpretador_Acad.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = @"\n
 __  __ __   __  __      __  __     
|__ |__   | |__||__|   | __| __||__|
 __||__|  | |__| __|   ||__  __|   |

 __      __  __      __  __  __  __ 
 __||__|   ||__|   | __||__ |__ |__|
 __|   |   ||__|   ||__  __||__| __|

 __  __  __  __  __      __  __     
 __| __||__ |__ |__||__|   ||__|   |
 __||__  __||__| __|   |   ||__|   |

 __  __  __  __  __  __      __     
|  | __||__ |__    ||__|   ||__||__|
|__||__  __||__|   ||__|   | __|   |
            ";

        StringReader linhas = new StringReader(entrada);
        linhas.ReadLine();

        string l1 = linhas.ReadLine();
        Console.WriteLine(l1);

        string l2 = linhas.ReadLine();
        Console.WriteLine(l2);

        string l3 = linhas.ReadLine();
        Console.WriteLine(l3);

        linhas.ReadLine();

        string l4 = linhas.ReadLine();
        Console.WriteLine(l4);

        string l5 = linhas.ReadLine();
        Console.WriteLine(l5);

        string l6 = linhas.ReadLine();
        Console.WriteLine(l6);

        linhas.ReadLine();

        string l7 = linhas.ReadLine();
        Console.WriteLine(l7);

        string l8 = linhas.ReadLine();
        Console.WriteLine(l8);

        string l9 = linhas.ReadLine();
        Console.WriteLine(l9);
        linhas.ReadLine();

        string l10 = linhas.ReadLine();
        Console.WriteLine(l10);

        string l11 = linhas.ReadLine();
        Console.WriteLine(l11);

        string l12 = linhas.ReadLine();
        Console.WriteLine(l12);

        linhas.ReadLine();

        Console.WriteLine("\n");

        char[] primeiraLinha = l1.ToCharArray();
        char[] segundaLinha = l2.ToCharArray();
        char[] terceiraLinha = l3.ToCharArray();
        char[] quartaLinha = l4.ToCharArray();
        char[] quintaLinha = l5.ToCharArray();
        char[] sextaLinha = l6.ToCharArray();
        char[] setimaLinha = l7.ToCharArray();
        char[] oitavaLinha = l8.ToCharArray();
        char[] nonaLinha = l9.ToCharArray();
        char[] decimaLinha = l10.ToCharArray();
        char[] decimaprimeiraLinha = l11.ToCharArray();
        char[] decimasegundaLinha = l12.ToCharArray();


        String conjunto1 = "", conjunto2 = "", conjunto3 = "";
        for (int i = 0; i < primeiraLinha.Length; i++)
        {
            conjunto1 = conjunto1 + primeiraLinha[i];
            conjunto2 = conjunto2 + segundaLinha[i];
            conjunto3 = conjunto3 + terceiraLinha[i];

            if (conjunto1 == " __ " && conjunto2 == "|  |" && conjunto3 == "|__|")
            {
                Console.Write("0");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }

            if (conjunto1 == "    " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("1");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }

            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == "|__ ")
            {
                Console.Write("2");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }

            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == " __|")
            {
                Console.Write("3");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }

            if (conjunto1 == "    " && conjunto2 == "|__|" && conjunto3 == "   |")
            {
                Console.Write("4");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == " __|")
            {
                Console.Write("5");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == "|__|")
            {
                Console.Write("6");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "__  " && conjunto2 == "  | " && conjunto3 == "  | ")
            {
                Console.Write("7");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == "|__|")
            {
                Console.Write("8");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == " __|")
            {
                Console.Write("9");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
        }

        Console.WriteLine();

        for (int j = 0; j < quartaLinha.Length; j++)
        {
            conjunto1 = conjunto1 + quartaLinha[j];
            conjunto2 = conjunto2 + quintaLinha[j];
            conjunto3 = conjunto3 + sextaLinha[j];

            if (conjunto1 == " __ " && conjunto2 == "|  |" && conjunto3 == "|__|")
            {
                Console.Write("0");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("1");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == "|__ ")
            {
                Console.Write("2");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == " __|")
            {
                Console.Write("3");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "|__|" && conjunto3 == "   |")
            {
                Console.Write("4");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == " __|")
            {
                Console.Write("5");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == "|__|")
            {
                Console.Write("6");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("7");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == "|__|")
            {
                Console.Write("8");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == " __|")
            {
                Console.Write("9");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
        }

        Console.WriteLine();

        for (int j = 0; j < oitavaLinha.Length; j++)
        {
            conjunto1 = conjunto1 + setimaLinha[j];
            conjunto2 = conjunto2 + oitavaLinha[j];
            conjunto3 = conjunto3 + nonaLinha[j];

            if (conjunto1 == " __ " && conjunto2 == "|  |" && conjunto3 == "|__|")
            {
                Console.Write("0");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("1");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == "|__ ")
            {
                Console.Write("2");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == " __|")
            {
                Console.Write("3");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "|__|" && conjunto3 == "   |")
            {
                Console.Write("4");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == " __|")
            {
                Console.Write("5");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == "|__|")
            {
                Console.Write("6");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("7");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == "|__|")
            {
                Console.Write("8");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == " __|")
            {
                Console.Write("9");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
        }


        Console.WriteLine();

        for (int j = 0; j < decimaLinha.Length; j++)
        {
            conjunto1 = conjunto1 + decimaLinha[j];
            conjunto2 = conjunto2 + decimaprimeiraLinha[j];
            conjunto3 = conjunto3 + decimasegundaLinha[j];

            if (conjunto1 == " __ " && conjunto2 == "|  |" && conjunto3 == "|__|")
            {
                Console.Write("0");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("1");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == "|__ ")
            {
                Console.Write("2");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == " __|" && conjunto3 == " __|")
            {
                Console.Write("3");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == "    " && conjunto2 == "|__|" && conjunto3 == "   |")
            {
                Console.Write("4");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == " __|")
            {
                Console.Write("5");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__ " && conjunto3 == "|__|")
            {
                Console.Write("6");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "   |" && conjunto3 == "   |")
            {
                Console.Write("7");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == "|__|")
            {
                Console.Write("8");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
            if (conjunto1 == " __ " && conjunto2 == "|__|" && conjunto3 == " __|")
            {
                Console.Write("9");
                conjunto1 = "";
                conjunto2 = "";
                conjunto3 = "";
            }
        }
        }
    }
}
