using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Utilitario : Automovel
    {
        public double cargaMax;
        private bool bau;
        private string tembau;

        public override void cadastrarAutomovel()
        {
            Console.WriteLine("-- Cadastro Utilitário --");
            base.cadastrarAutomovel();
            Console.WriteLine("Carga maxima");
            cargaMax = double.Parse(Console.ReadLine());
            Console.WriteLine("Tem bau?[s/n]");
            tembau = Console.ReadLine();
            if (tembau.ToLower().Equals("s"))
            {
                bau = true;
            } else
            {
                bau = false;
            }

        }
        public override void visualizarAutomovel()
        {
            base.visualizarAutomovel();
            Console.WriteLine("Carga maxima: {0}",cargaMax);
            if (bau == true)
            {
                tembau = "sim";
            } else
            {
                tembau = "nao";
            }
            Console.WriteLine("Tem bau:{0}",tembau);


        }
    }

}
