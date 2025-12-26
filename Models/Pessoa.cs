using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        
        private string _nome;

        private int _idade;
        
        public string Nome 
        {
            //  get retorna o nome em maiúsculo
            // => sintaxe simplificada para métodos com uma única expressão
            get => _nome.ToUpper(); 

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                else
                {
                    _nome = value;
                }
            }
        }



        public int Idade 
        { 
            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser negativa");
                }
                else
                {
                    _idade = value;
                }
            } 
        }

        public void apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}