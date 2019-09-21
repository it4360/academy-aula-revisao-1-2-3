using System;

namespace Aula_Revisão {
    
    public class Chamado {
        public string codigo;
        public string descricao;
        public DateTime dataAbertura;
        public StatusChamado statusChamado;
        public Analista analista;

    }

    public enum StatusChamado {
        EmAberto = 1,
        EmAndamento = 2,
        Fechado = 3
    }

}