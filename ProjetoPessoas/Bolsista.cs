using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPessoas
{
    public class Bolsista:Aluno
    {
        private float bolsa;

        public void RenovarBolsa()
        {
            Console.WriteLine("===== Bolsistas Reno/Bolsas =====");
            Console.WriteLine("Renovando bolsa de " + Nome);
            Console.WriteLine("=================================");
        }

        public override void PagarMensalidade()
        {
            Console.WriteLine("===== Bolsistas Pag/Mensalidade =====");
            Console.WriteLine(Nome + " é Bolsista isento de pagamento");
            Console.WriteLine("======================================\n");
        }
        
        public float Bolsa
        {
            get { return bolsa; }
            set { bolsa = value; }
        }


        public override string Detalhes()
        {
            Console.WriteLine("\n======= Dados de Bolsista =======");
            return "{" +
                "\n*" + " nome = " + Nome +
                "\n* idade = " + Idade +
                "\n* bolsa = " + Bolsa +
                "\n* matricula = " + Matricula +
                "\n* curso = " + Curso +
                "\n* sexo = " + Sexo + "\n" + '}';
        }

    }
}
