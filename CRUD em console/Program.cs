using CRUD_em_console.model;
using System;

namespace CRUD_em_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Bem Vindo Ao CRUD em console ===");
            Console.WriteLine("\nEntre com qualquer tecla para continuar...");
            Console.ReadKey();

            try
            {

                int opc;

                do
                {
                    Console.Clear();
                    Console.WriteLine(" === Super Mercado Jardim Rodeio ===");
                    Console.WriteLine("\nAtividades - ");
                    Console.WriteLine("1 - Cadastrar Novo Produto");
                    Console.WriteLine("2 - Listagem de Produtos em Estoque");
                    Console.WriteLine("Entre com a opção desejada: ");
                    opc = int.Parse(Console.ReadLine());

                    while (opc > 2 || opc < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("ERRO!!! \nEntre com uma opção válida...");
                        Console.WriteLine("1 - Cadastrar Novo Produto");
                        Console.WriteLine("2 - Listagem de Produtos em Estoque");
                        opc = int.Parse(Console.ReadLine());
                    }

                    Console.Clear();

                    switch (opc)
                    {
                        case 1:

                            Console.WriteLine("=== Cadastro de Produtos ===");
                            Console.WriteLine("Entre com o nome do produto: ");
                            string nome = Console.ReadLine();

                            Console.WriteLine("Entre com o valor do produto: ");
                            double valor = double.Parse(Console.ReadLine());

                            Console.WriteLine("Entre com a quantidade a ser estocada: ");
                            int quantidade = int.Parse(Console.ReadLine());

                            Produto produto = new Produto(nome, valor, quantidade);
                            produto.Cadastrar();
                            Console.WriteLine("Produto Cadastrado com Sucesso!");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine("0 - Menu Principal");
                            Console.WriteLine("1 - Sair do Programa");
                            opc = int.Parse(Console.ReadLine());

                            while(opc < 0 || opc > 1)
                            {
                                Console.Clear();
                                Console.WriteLine("ERRO!!! \nEntre com uma opção válida...");
                                Console.WriteLine("0 - Menu Principal");
                                Console.WriteLine("1 - Sair do Programa");
                                opc = int.Parse(Console.ReadLine());
                            }

                            break;
                    }

                } while (opc == 0);

            }catch(FormatException e)
            {
                throw new Exception("Um erro referente ao tipo de variavel foi disparado " + e);
            }

        }
    }
}
