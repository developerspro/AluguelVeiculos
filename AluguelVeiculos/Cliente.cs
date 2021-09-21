using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Cliente
    {
        private string nome;
        private double cpf;
        private double cep;
        private double cnh;
        private double telefone;
        private string email;

        public void cadastrarCliente()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF");
            cpf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CEP");
            cep = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CNH");
            cnh = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Telefone");
            telefone = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o email");
            email = Console.ReadLine();

        }

        public void mostrarCadastro()
        {
            Console.WriteLine("--- Cadastro ---");
            Console.WriteLine("Nome:{0}", nome);
            Console.WriteLine("CPF:{0}", cpf);
            Console.WriteLine("CEP:{0}", cep);
            Console.WriteLine("CNH:{0}", cnh);
            Console.WriteLine("telefone:{0}", telefone);
            Console.WriteLine("email:{0}", email);
        }

        public string nomeCliente()
        {
            return nome;
        }


    }
}
