using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Vans : Automovel
    {
        public int qtdePessoas;
        public override void cadastrarAutomovel()
        {
            Console.WriteLine("-- Cadastro Van --");
            base.cadastrarAutomovel();
            Console.WriteLine("Quantidade de passageiros");
            qtdePessoas = int.Parse(Console.ReadLine());
        }

        public override void visualizarAutomovel()
        {
            base.visualizarAutomovel();
            Console.WriteLine("Quantidade de passageiros: {0}",qtdePessoas);


        }
    }
}
