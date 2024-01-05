using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosConstrutores.Models
{
    public class Pessoa // nesse exemplo a classe pessoa possui duas propriedades chamadas Nome e Idade
    {
        public Pessoa() // nao existe limite de construtores 
        {

        }
        public Pessoa(string nome, string sobrenome) // o construtor, por padrão, fica logo abaixo da classe (recebe o mesmo nome da classe)
        {
            Nome = nome; // o Nome com a letra maiuscula se refere à propriedade Nome e passa a atribui-lo ao nome do parametro do construtor 
            Sobrenome = sobrenome;
        }

        private string _nome; // private significa que somente essa classe Pessoa poderá acessar 
        private int _idade;

        public string Nome 
        {
            get => _nome.ToUpper(); // o metodo ToUpper serve para converter o nome para maiusculo  
            // o simbolo => é mais utilizável para validações mais simples como nesse caso  

            set 
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio"); // o codigo nao sera executado caso o valor de Nome esteja vazio 
                }

                _nome = value;
            }
            
        } // get e set são indicativos de propriedades
        // o get serve para obter valor (somente para leitura)
        // o set serve para atribuir valor

        public string Sobrenome {get; set;}

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // essa propriedade só possui get (e não precisa deixa-lo expresso, ja entende que é somente get)

        public int Idade 
        { 
            get => _idade;

            set 
            {
                if (value < 0)
                { 
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}