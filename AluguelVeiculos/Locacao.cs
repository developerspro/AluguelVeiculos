using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Locacao
    {
        public double valorTotal;
        public DateTime duracao;
        public string descricao;
        public DateTime datainicial;
        public DateTime datafinal;
        public double multa;
        public string nomeCliente; 

        public void cadastrarLocacao(string n)
        {
            nomeCliente = n;
            datainicial = DateTime.Now;
            Console.WriteLine(datainicial.Date);
            Console.WriteLine("Digite o motivo da locacao");
            descricao = Console.ReadLine();
        }

        public void cadastrarMulta()
        {
            Console.WriteLine("Informe o valor da multa");
            multa = double.Parse(Console.ReadLine());
            if (multa > 0)
            {

            } else
            {
                multa = 0;
            }
        }

        public void mostrarMulta()
        {
            Console.WriteLine("Total da Multa R${0}, total a pagar{1}", multa,valorTotal);
        }

        public void mostrarTotal()
        {
            Console.WriteLine("Valor Total, locacao + multa : {0}", multa + valorTotal);
        }

        public void registrarDevolucao()
        {
            datafinal = DateTime.Now;
            Console.WriteLine(" Devolvido em{0}", datafinal.Date);
        }
    }
}
