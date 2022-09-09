using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoas
{
    public class Professor:Pessoa
    {
        private string especialidade;
        private float salario;

        public void ReceberAumento(float aum)
        {
            salario = (salario / aum) * salario;
        }

        public string Especialidade { get; set; }
        public float Salario { get; set; }

        public override string Detalhes()
        {
            Console.WriteLine("\n======= Dados de Professor =======");
            return "{" +
                "\n*" + " nome = " + Nome +
                "\n* idade = " + Idade +
                "\n* sexo = " + Sexo +
                "\n* especialidade = " + Especialidade +
                "\n* salario = " + Salario + "\n" + '}';
        }
    }
}
