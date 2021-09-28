using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Menu menu = new Menu();
            Cliente cliente = new Cliente();
            do
            {
                opcao = menu.menu();
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrar Cliente");
                        cliente.cadastrarCliente();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Cadastrar Carro");
                        Carro carro = new Carro();
                        carro.cadastrarAutomovel();
                        break;
                    case "3":
                        Console.WriteLine("Cadastrar Van");
                        Vans van = new Vans();
                        van.cadastrarAutomovel();
                        break;
                    case "4":
                        Console.WriteLine("Cadastrar Utilitario");
                        Utilitario utilitario = new Utilitario();
                        utilitario.cadastrarAutomovel();
                        break;
                    case "5":
                        Console.WriteLine("Fazer a Locaçao");
                        Locacao locacao = new Locacao();
                        locacao.cadastrarLocacao();
                        break;
                    case "6":
                        cliente.mostrarCadastro();
                        Console.ReadKey();
                        break;
                    case "Q":
                        Console.WriteLine("Encerrando o programa");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida!");
                        break;
                }
            } while (opcao != "Q");
            //Environment.Exit(0);
        }
    }
}
