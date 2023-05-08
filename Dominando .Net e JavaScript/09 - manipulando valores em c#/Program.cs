using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(Nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = new Pessoa(Nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
