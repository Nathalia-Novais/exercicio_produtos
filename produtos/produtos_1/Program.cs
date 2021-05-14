using System;

namespace produtos_1
{
    class Program
    {
        static bool voltarmenu = false;
        static string opcao;
        static int tamanhosarrays = 10;
        static int c = 0;
        static string resposta;
        static bool[] promocao = new bool[tamanhosarrays];
        static string promocaoresposta;
        static string[] nomes = new string[tamanhosarrays];
        static float[] valor = new float[tamanhosarrays];

        static bool repetircadastro = false;
        //  static string[] promocao = new string[tamanhosarrays];


        static void Main(string[] args)
        {
            do
            {
                Menu();
                opcao = Console.ReadLine();


                switch (opcao)
                {
                    case "1":
                             Cadastro();
                     break;

                    case "2":

                        Listar();

                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Obrigado por ter utilizado o nosso sistema ");
                        Console.ResetColor();
                        voltarmenu = true;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite uma opção válida");
                        Console.ResetColor();
                        break;
                }


            } while (!voltarmenu);

        }



        static void Menu()
        {

            Console.WriteLine(@"
 ================================                 
|    Selecione uma das opções:   |
|  ----------------------------- |
|    1- cadastrar produtos       |
|    2- Listar produtos          |
|    0- sair                     | 
==================================");

        }



        static void Cadastro()
        {
                do
                {
                   if (c < tamanhosarrays)
                   {
                       Console.WriteLine("cadastre o seu produto");

                    Console.WriteLine("Qual o nome do seu produto?");
                    nomes[c] = Console.ReadLine();

                    Console.WriteLine($"Qual o valor do(a) {nomes[c]}?");
                    valor[c] = float.Parse(Console.ReadLine());

                    Console.WriteLine($"O(a) {nomes[c]} está em promoção? (S/N)");
                    promocaoresposta = Console.ReadLine().ToLower();

                    if (promocaoresposta == "s")
                    {
                        promocao[c] = true;
                        Console.WriteLine("promoção");
                    }
                    else
                    {
                        promocao[c] = false;
                        Console.WriteLine("sem promoção");
                    }
                    
                    c++;

                    Console.WriteLine("Deseja cadastrar outro produto? (s/n)");
                    resposta = Console.ReadLine().ToLower(); 

                    if (resposta == "n")
                    {
                        repetircadastro = true;
                    }
                   }

                   else
                   {
                       Console.ForegroundColor = ConsoleColor.Red;
                       Console.WriteLine("O seu limite de cadastro está cheio ");
                       repetircadastro = true;
                       Console.ResetColor();
                   }
                  
                   
                  } while (!repetircadastro);
                    
        }

        static void Listar()
        {

          

            for (var i = 0; i < c; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($@"Nome:{nomes[i]}       
valor: R${valor[i]}     
Está em promoção:{promocao[i]}
");
  Console.ResetColor();
            }


         
        }

    }

}
