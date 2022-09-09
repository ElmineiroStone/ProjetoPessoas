namespace ProjetoPessoas
{
    public class Aluno:Pessoa
    {
        private int matricula;
        private string curso;

        public virtual void PagarMensalidade()
        {
            Console.WriteLine("===== Alunos Pag/Mensalidade =====");
            Console.WriteLine("Pagando mensalidade do aluno " + Nome);
            Console.WriteLine("======================================\n");
        }
        public void CancelarMatricula()
        {
            Console.WriteLine("Matricula será cancelada");
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string Detalhes()
        {
            Console.WriteLine("======= Dados de Aluno =======");
            return "{" +
                "\n*" + " nome = " + Nome +
                "\n* idade = " + Idade +
                "\n* matricula = " + Matricula +
                "\n* curso = " + Curso +
                "\n* sexo = " + Sexo + "\n" + '}';
        }
    }
}