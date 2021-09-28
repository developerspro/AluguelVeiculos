using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Menu
    {

        public string menu()
        {
            Console.Clear();
            Console.WriteLine("1 -Cadastrar Cliente");
            Console.WriteLine("2 -Cadastrar Carro");
            Console.WriteLine("3 -Cadastrar Van");
            Console.WriteLine("4 -Cadastrar Utilitário");
            Console.WriteLine("5 -Fazer uma Locacao");
            Console.WriteLine("6 -Listar Cliente");
            Console.WriteLine("Q -Sair");
            Console.WriteLine("Escolha uma opcao:");
            string opcao;
            opcao = Console.ReadLine();
            return opcao.ToUpper();

        }

    }
}
