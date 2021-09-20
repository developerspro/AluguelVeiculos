using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Automovel
    {
        public string modelo;
        public DateTime ano;
        public string placa;
        public string cor;
        public double renavam;
        public double km;
        public string marca;
        public string chassi;

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
            km = double.Parse(Console.ReadLine());
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
