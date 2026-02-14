using ExemploExplorando.Models;
using System.Globalization;

//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); //Definindo a cultura para o formato de moeda dos Estados Unidos (en-US)
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// Pessoa p1 = new Pessoa(nome: "Renato", sobrenome: "Monteiro");
// //p1.Nome = "Renato";
// //p1.Sobrenome = "Monteiro";
// p1.Idade = 44;
// p1.Apresentar();

// Pessoa p2 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// p2.Idade = 20;
// p2.Apresentar();

// Curso cursoDeIngles = new Curso(); 
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

// string numero1 = "10"; 
// int numero2 = 20;

// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

decimal valorMontario = 1582.40M;

Console.WriteLine($"{valorMontario:C}"); //C de moeda (especificação da moeda do país de origem), D de decimal, F de float, P de porcentagem, etc.

Console.WriteLine(valorMontario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //C de moeda (especificação da moeda do país de origem), D de decimal, F de float, P de porcentagem, etc.

//Com apenas uma casa decimal
Console.WriteLine($"{valorMontario:C1}");

//Exibir sem o prefixo de moeda
Console.WriteLine($"{valorMontario:N2}"); //N de número, 2 de casas decimais, sem o prefixo de moeda. O formato N é usado para exibir números com separadores de milhar e casas decimais, mas sem o símbolo de moeda.

//Colocacar porcentagem
decimal valorPorcentagem = 0.2567M;
Console.WriteLine($"{valorPorcentagem:P2}"); //P de porcentagem, 2 de casas decimais. O formato P é usado para exibir valores como porcentagens.

double porcentagem = .3421;
Console.WriteLine(porcentagem.ToString("P2")); //P de porcentagem, 2 de casas decimais. O formato P é usado para exibir valores como porcentagens.

//Valor personalizado (máscara de formatação personalizada):

int numero = 123456789;
Console.WriteLine(numero.ToString("##-##-##-##")); //Valor personalizado, onde cada # representa um dígito do número. O formato personalizado permite criar uma representação personalizada do número, usando caracteres específicos para formatar a saída.


//Formatando o tipo DateTime

DateTime data = DateTime.Now;
Console.WriteLine(data);

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //dd de dia, MM de mês, yyyy de ano. O formato personalizado para datas permite criar uma representação personalizada da data, usando caracteres específicos para formatar a saída.


Console.WriteLine(data.ToShortTimeString()); //Exibe apenas a hora no formato curto (HH:mm). O método ToShortTimeString() é usado para exibir apenas a parte da hora de um objeto DateTime, no formato curto.


DateTime data2 = DateTime.Parse("2024-06-15 14:30");
Console.WriteLine(data2.ToString("dd/MM/yyyy HH:mm")); //dd de dia, MM

//Datetime com TryParse

string dataString = "2022-04-17 18:00";

DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data3);

Console.WriteLine(data);

//Validando o retorno do TryParse

bool sucesso = DateTime.TryParseExact(dataString, 
                        "yyyy-MM-dd HH:mm", 
                        CultureInfo.InvariantCulture, 
                        DateTimeStyles.None, out DateTime data4);

if(sucesso){
    Console.WriteLine($"Data convertida com sucesso: {data4}");
}else{
    Console.WriteLine("Falha ao converter a data.");
}   

