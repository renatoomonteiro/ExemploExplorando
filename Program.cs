using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Renato", sobrenome: "Monteiro");
//p1.Nome = "Renato";
//p1.Sobrenome = "Monteiro";
p1.Idade = 44;
p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
p2.Idade = 20;
p2.Apresentar();

Curso cursoDeIngles = new Curso(); 
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();