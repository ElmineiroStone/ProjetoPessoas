namespace ProjetoPessoas
{
    public abstract class Pessoa
    {
        public void FazerAniversario() {
            this.Idade++;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }


        public virtual string Detalhes()
        {
            return "Dados\n{" +
                "\n*" + " nome = " + Nome +
                "\n* idade = " + Idade +
                "\n* sexo = " + Sexo + "\n" + '}';
        }
    }
}
