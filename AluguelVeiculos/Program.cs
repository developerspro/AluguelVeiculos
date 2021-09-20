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
            Cliente c = new Cliente();
            Automovel auto = new Automovel();
            Utilitario util = new Utilitario();
            util.cadastrarAutomovel();
            util.visualizarAutomovel();

           // auto.cadastrarAutomovel();
            c.cadastrarCliente();
            c.mostrarCadastro();

            Locacao l = new Locacao();
            l.cadastrarLocacao(c.nomeCliente());
            Console.ReadKey();

    
        }
    }
}
