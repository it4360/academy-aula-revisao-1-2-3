using System;

namespace Aula_Revisão {
    public class Revisao {
        public DateTime dataInicio;
        public DateTime dataFim;
        public string local;
        public Professor professor;



        // ### Método

        // ## Método sem retorno e não recebe parametros
        public void Metodo1(){
            
        }

        // Exemplo: Método que informa que a aula iniciou
        public void DarAula(){
            Console.WriteLine("Iniciando aula...");
            Console.WriteLine("Aula começou.");
        }

        // ## Método sem retorno que recebe parametros
        public void Metodo2(int parametro1, string parametro2){

        }

        // Exemplo: Método que permite definir data e hora da aula
        public void DefinirDataAula(DateTime dataInicio, DateTime dataFim){
            this.dataInicio = dataInicio;
            this.dataFim = dataFim;
        }

        // ## Método com retorno que não recebe parametros
        public int Metodo3(){
            return 0;
        }

        // Exemplo: Método que devolve o nome do professor
        public string PegarNomeProfessor(){
            return this.professor.name;
        }

        // ## Método com retorno e que recebe parametros
        public int Metodo4(int parametro1, int parametro2){
            return 0;
        }

        // Exemplo: Método que altera o professor
        public Professor NovoProfessor(Professor novoProfessor){
            this.professor = novoProfessor;
            return this.professor;
        }

    }

}

