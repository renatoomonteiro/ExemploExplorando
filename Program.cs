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

// bool sucesso = DateTime.TryParseExact(dataString, 
//                         "yyyy-MM-dd HH:mm", 
//                         CultureInfo.InvariantCulture, 
//                         DateTimeStyles.None, out DateTime data4);

// if(sucesso){
//     Console.WriteLine($"Data convertida com sucesso: {data4}");
// }else{
//     Console.WriteLine("Falha ao converter a data.");
// }   

//Realizando a leitura de um arquivo
//Exceções e Coleções com C#

string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

/*
Tratando uma exceção (Utilizando o Try Catch para capturar e 
lidar com exceções que podem ocorrer durante a leitura do arquivo, 
como o arquivo não existir ou problemas de permissão.
O bloco try contém o código que pode gerar uma exceção, 
e o bloco catch captura a exceção e permite que você lide com ela de maneira apropriada, 
como exibir uma mensagem de erro para o usuário.)
Exceções e Coleções com C#
*/
// try
// {
//     string[] linhas2 = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//     Console.WriteLine("Arquivo lido com sucesso!\nConteúdo do arquivo:");
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo.\nArquivo não encontrado! {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo.\nCaminho do diretório não encontrado! {ex.Message}");
// }catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica! {ex.Message}");
// }

/*
Entendendo o bloco finally
Exceções e Coleções com C#
*/

try
{
    string[] linhas2 = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
    Console.WriteLine("Arquivo lido com sucesso!\nConteúdo do arquivo:");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo.\nArquivo não encontrado! {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo.\nCaminho do diretório não encontrado! {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica! {ex.Message}");
}
finally
{
    Console.WriteLine("Bloco finally executado!"); //O bloco finally é sempre executado, independentemente de uma exceção ter sido lançada ou não. 
                                                   // Ele é útil para garantir que certas ações sejam realizadas, como liberar recursos ou fechar conexões, 
                                                   // mesmo que ocorra um erro durante a execução do código.
}

//Usando o Throw
//Exceções e Coleções com C#

new ExemploExcecao().Metodo1();

//Em 23/06/2024, foram feitas alterações no arquivo Program.cs para demonstrar o tratamento de exceções utilizando try-catch e o bloco finally, além de mostrar como usar o throw para lançar uma exceção personalizada. O código atualizado inclui a leitura de um arquivo e o tratamento de possíveis erros que podem ocorrer durante essa operação, como arquivo não encontrado ou diretório inexistente.
//Próxima aula: Fila na prática
//Exceções e Coleções com C#

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

//removendo um item da fila

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (var item in fila)
{
    Console.WriteLine(item);
}
//O método Dequeue() é usado para remover e retornar o elemento no início da fila. 
// Ele segue a ordem FIFO (First In, First Out), ou seja, o primeiro elemento adicionado à fila será o primeiro a ser removido.


//Pilha na prática



Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);


Console.WriteLine("Pilha na prática");
foreach (var item in pilha)
{
    Console.WriteLine(item);
}

//removendo um item da pilha
Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}");

pilha.Push(20);
foreach (var item in pilha)
{
    Console.WriteLine(item);
}

//Introdução Dictionary
//Um dicionário é uma coleção de pares chave-valor, onde cada chave é única e está associada a um valor.
//Ele é útil para armazenar e acessar dados de forma eficiente, permitindo que você recupere um valor com base em sua chave correspondente. 
//O dicionário é implementado na classe Dictionary<TKey, TValue> em C#.

Dictionary<string, string> estados = new Dictionary<string, string>();
//<chave, valor>
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine("Dicionário de estados:");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//ele garante que todo elemento seja único, ou seja, não permite chaves duplicadas.
//estados.Add("SP", "São Paulo"); //Isso gerará uma exceção do tipo ArgumentException, indicando que a chave "SP" já existe no dicionário.

//Tentando adicionar uma chave duplicada usando o método Add() resultará em uma exceção do tipo ArgumentException, indicando que a chave já existe no dicionário.
//A Key não pode ser duplicada, mas o valor pode ser repetido. Ou seja, você pode ter chaves diferentes associadas ao mesmo valor, mas não pode ter chaves duplicadas no dicionário.
//estados.Add("BA", "Bahia");

//Removendo e alterando elementos

estados.Remove("BA"); //Removendo o elemento com a chave "BA"


Console.WriteLine("Exibindo o dicionário após a remoção do elemento com a chave 'BA':");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//Alterar o valor de uma chave existente
estados["MG"] = "Minas Gerais - Atualizado";

Console.WriteLine("Exibindo o dicionário após a atualização do valor da chave 'MG':");
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//Verificando a existência de uma chave ou valor

string chave = "BA";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine("A chave existe no dicionário.");
}
else
{
    Console.WriteLine("A chave não existe no dicionário.");
}

string valor = "Bahia";
Console.WriteLine($"Verificando o valor: {valor}");

if (estados.ContainsValue(valor))
{
    Console.WriteLine("O valor existe no dicionário.");
}
else
{
    Console.WriteLine("O valor não existe no dicionário.");
}

//Exibir valor de uma chave específica
Console.WriteLine(estados["MG"]);