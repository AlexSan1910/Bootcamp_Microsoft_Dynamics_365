using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pessoa

namespace Couse{
    class Curso{
        static void Main(string[] args){
            public string Nome{get; set;}
            public List<Pessoa> Alunos {get; set;}

            public void AdicionarAluno(Pessoa aluno){
                Alunos.Add(aluno);
            }

            public int ObterQuantidadeAlunosMatriculados(){
                int quantidade = Alunos.Count;
                return quantidade;
            }

            public bool RemoverAluno(Pessoa aluno){
                return Alunos.Remove(aluno);
            }

            public void ListarAlunos(){
                Console.WriteLine($"Alunos do curso: {Nome}");

                // mudando a concatenação desse codigo para melhor visualização do usuario.
                for(int count = 0; count < Alunos.Count; count++ )
                {
                    string texto = "N " + count + " " + Alunos[count].NomeCompleto;
                    Console.WriteLine(Alunos[count].NomeCompleto);
                }
            }
        }
    }
}