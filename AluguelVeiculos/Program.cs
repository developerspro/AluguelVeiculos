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
            Carro cr = new Carro();
            Esporte es = new Esporte();
            es.cadastrarAutomovel();
            es.visualizarAutomovel();

            cr.cadastrarAutomovel();
            cr.visualizarAutomovel();
            

           // auto.cadastrarAutomovel();
            c.cadastrarCliente();
            c.mostrarCadastro();
            util.cadastrarAutomovel();
            util.visualizarAutomovel();

            Locacao l = new Locacao();
            l.cadastrarLocacao(c.nomeCliente());
            Console.ReadKey();

    
        }
    }
}
