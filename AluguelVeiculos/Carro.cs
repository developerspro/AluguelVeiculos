using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Carro : Automovel
    {
        public int portaMala;

        public override void cadastrarAutomovel()
        {
            Console.WriteLine("-- Cadastro Carro --");
            base.cadastrarAutomovel();
            Console.WriteLine("Tamanho do porta malas");
            portaMala = int.Parse(Console.ReadLine());

        }

        public override void visualizarAutomovel()
        {
            base.visualizarAutomovel();
            Console.WriteLine("Tamanho do porta malas:{0}",portaMala);

        }
    }
}
