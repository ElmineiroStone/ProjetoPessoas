using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoas
{
    public class Funcionario:Pessoa
    {
        private string setor;
        private bool trabalhando;

        public void MudarTrabalho()
        {
            trabalhando = !trabalhando;
        }

        public string Setor { get; set; }
        public bool Trabalhando { get; set; }

        public override string Detalhes()
        {
            Console.WriteLine("\n======= Dados de Funcionario =======");
            return "{" +
                "\n*" + " nome = " + Nome +
                "\n* idade = " + Idade +
                "\n* sexo = " + Sexo +
                "\n* setor = " + Setor +
                "\n* trabalhando = " + Trabalhando + "\n" + '}';
        }
    }
}
