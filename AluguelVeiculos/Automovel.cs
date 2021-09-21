using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Automovel
    {
        private string modelo;
        private DateTime ano;
        private string placa;
        private string cor;
        private double renavam;
        private double km;
        private string marca;
        private string chassi;


        private void validaKm(double valor)
        {
            if (valor < 0)
            {
                km = 0; 
            } else
            {
                km = valor;
            }
        }

        public virtual void cadastrarAutomovel()
        {
            Console.WriteLine("Digite o modelo");
            modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano");
            ano = new DateTime(int.Parse(Console.ReadLine()), 1,1);
            Console.WriteLine("Digite o placa");
            placa = Console.ReadLine();
            Console.WriteLine("Digite o cor");
            cor = Console.ReadLine();
            Console.WriteLine("Digite o renavam");
            renavam = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o km");
            validaKm(double.Parse(Console.ReadLine()));
            Console.WriteLine("Digite o marca");
            marca = Console.ReadLine();
            Console.WriteLine("Digite o chassi");
            chassi = Console.ReadLine();

        }

        public virtual void visualizarAutomovel()
        {
            Console.WriteLine("Modelo: {0}",modelo);
            Console.WriteLine("Ano: {0}", ano.Year);
            Console.WriteLine("Placa: {0}", placa);
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Renavam: {0}", renavam);
            Console.WriteLine("km: {0}", km);
            Console.WriteLine("Marca: {0}", marca);
            Console.WriteLine("Chassi: {0}", chassi);
        }


    }
}
