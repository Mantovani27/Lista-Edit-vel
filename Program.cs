using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lista_Editável
{
    internal class Program
    {
       public static Dictionary<int, string> Lista = new Dictionary<int, string>();
        static void Main(string[] args)
        {
           
            int chave = 0;
           

            bool menu = true;
            while ( menu == true)
            {

                Console.Clear();
                Console.WriteLine("O que você gostaria de fazer");
                Console.WriteLine();
                int opcao = ReceberOpcao();
                if (opcao == 1)
                {
                    Console.WriteLine("Adicione um item.");
                    string escritoNoConsole = Console.ReadLine();
                    Lista.Add(chave++, escritoNoConsole);
                    Console.WriteLine("Pressione qualquer tecla.");
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {

                }
                else if (opcao == 3)
                {

                }
                else if (opcao == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Lista de Itens");
                    foreach (var item in Lista)
                    {
                        Console.WriteLine(item.Key +"-"+ item.Value);
                        Console.WriteLine("Pressione qualquer tecla.");
                        Console.ReadKey();
                    }
                }
                else if (opcao == 5)    
                {
                    Console.WriteLine("Até mais!");
                    menu = false;
                }
                else
                {

                }
            }
            

            



        }
        public static int ReceberOpcao()
        {

            Console.WriteLine("1 Adicionar Item");
            Console.WriteLine("2 Remover Item");
            Console.WriteLine("3 Editar Item");
            Console.WriteLine("4 Listar Itens");
            Console.WriteLine("5 Sair");

          

            return Convert.ToInt32(Console.ReadLine());
       
        }
    }

}
