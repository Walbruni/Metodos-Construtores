using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodosConstrutores.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno) // void indica a criação de um método sem nenhum retorno (nesse caso é somente para add os alunos)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados() // esse método exige retorno, pois quero saber a quantidade dos alunos - por isso o int 
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno); // o proprio metodo Remove ja retorna um booleano
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}"); 

            for (int count = 0; count < Alunos.Count; count++)
            {
                // string texto = "Número " + count + " - " + Alunos[count].NomeCompleto; // sinal de + para concatenação strings 
                string texto = $"Número {count + 1} - {Alunos[count].NomeCompleto}"; // sinal de $ para interpolação de strings
                // count + 1 para a contagem do aluno nao começar do zero (não soma na variavel, é apenas para exibição em tela)
                Console.WriteLine(texto);
            }

        }
    }
}