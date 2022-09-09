using ProjetoPessoas;

Aluno a1 = new()
{
    Nome = "Paulo",
    Idade = 33,
    Sexo = "M",
    Matricula = 11119726,
    Curso = "Csharp"
};
a1.PagarMensalidade();


Bolsista b1 = new()
{
    Nome = "Jubileu",
    Idade = 17,
    Sexo = "M",
    Matricula = 11117529,
    Curso = "Informática",
    Bolsa = 12.5f
};
b1.PagarMensalidade();

Professor p1 = new()
{
    Nome = "Cláudio",
    Idade = 45,
    Sexo = "M",
    Especialidade = "Matemática",
    Salario = 2500.75f
};

Funcionario f1 = new()
{
    Nome = "Fabiana",
    Idade = 32,
    Sexo = "F",
    Setor = "Estoque",
    Trabalhando = true
};

Console.WriteLine(a1.Detalhes());
Console.WriteLine(b1.Detalhes());
Console.WriteLine(p1.Detalhes());
Console.WriteLine(f1.Detalhes());




