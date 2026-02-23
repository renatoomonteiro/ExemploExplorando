using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada: " + ex.Message);
            }

        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
           Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção!");
        }
    }
}

//Em 23/06/2024, foram feitas alterações no arquivo Program.cs para demonstrar o tratamento de exceções utilizando try-catch e o bloco finally, além de mostrar como usar o throw para lançar uma exceção personalizada. O código atualizado inclui a leitura de um arquivo e o tratamento de possíveis erros que podem ocorrer durante essa operação, como arquivo não encontrado ou diretório inexistente.
//Próxima aula: Fila na prática
//Exceções e Coleções com C#