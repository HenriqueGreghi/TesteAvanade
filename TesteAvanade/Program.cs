using System;

namespace TesteAvanade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool comprar = true;
            do
            {
                Console.WriteLine("Escolha um produto : ");
                Console.WriteLine("1 - tv 50'");
                Console.WriteLine("2 - Ipad");
                Console.WriteLine("3 - Videogame");
                Console.WriteLine("4 - Celular");
                Console.WriteLine("5 - Tablet");
                Console.WriteLine("6 - Notebook");
                Console.WriteLine("7 - fone de ouvido");
                Console.WriteLine("8 - Ir para pagamento");
                Console.WriteLine("9 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                while (comprar == true)

                    switch (opcao)
                    { 

                        case 1:
                            Console.WriteLine("tv 50'"); 
                            break;
                            
                        case 2:
                            Console.WriteLine("Ipad");
                            break;
                        case 3:
                            Console.WriteLine("Videogame");
                            break;
                        case 4:
                            Console.WriteLine("Celular");
                            break;
                        case 5:
                            Console.WriteLine("Tablet");
                            break;
                        case 6:
                            Console.WriteLine("Notebook");
                            break;
                        case 7:
                            Console.WriteLine("Fone de ouvido");
                            break;
                        case 8:
                            comprar = false;
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            comprar = false;
                            break;
                    }
            }while (comprar);

            

        }
    }
}
