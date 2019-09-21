using System;

namespace Aula_Revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // ### Exercícios
            // Você é contratado para fazer um sistema de chamados de suporte.
            // O sistema deve conter as seguintes funcionalidades:
            // 1. Cadastro de novo chamado
            // - O chamado deve conter data de abertura, descrição, status e código do chamado          
            // - Status possíveis do chamado: Aberto, Em andamento, Fechado.  
            // 2. Cadastro de novo analista de suporte
            // - O analista deve conter nome, e-mail, data de nascimento e código do analista.
            // 3. Associar chamado à analista
            // - Para associar um chamado a um analista, é necessário o código do analista e o código do chamado.
            // - Antes de solicitar o código do chamado ou do analista, deve ser exibido uma lista dos mesmos para que 
            // o usuário possa identificar o chamado e o analista no momento do associação.
            // - Somente chamados em aberto podem ser associados a analistas.
            // - A lista de chamados exibidas deve mostrar apenas os chamados que estão em aberto.
            // - Quando o chamado for associado a um analista, o status do chamado deve mudar para em andamento.
            // 4. Fechar chamado
            // - Somente chamados que estão em andamento podem ser fechados.
            // - Listar todos os chamados em andamento para que o usuário selecione o chamado 
            // que deseja fechar através de seu código.
            // - O status do chamado deve mudar para Fechado
            // 5. Sair do sistema.

            // Observações
            // O número total de chamados é 10.
            // O número total de analistas é 3.



            // ########### SISTEMA DE CHAMADOS DO MAL ###########
            string opcao;
            Chamado[] chamados = new Chamado[1];
            int quantidadeChamados = 0;

            Analista[] analistas = new Analista[1];
            int quantidadeAnalistas = 0;

            do {

                Console.WriteLine("O que deseja fazer ?");
                Console.WriteLine("1. Cadastro de novo chamado");
                Console.WriteLine("2. Cadastro de novo analista de suporte");
                Console.WriteLine("3. Associar chamado à analista");
                Console.WriteLine("4. Fechar chamado");
                Console.WriteLine("5. Sair");

                opcao = Console.ReadLine();

                

                // Cadastar chamado.
                if(opcao == "1"){
                    if(quantidadeChamados < 1)
                    {
                        // Pegar todas as informações que compoem um chamado.
                        Chamado chamado = new Chamado {
                            dataAbertura = DateTime.Now,
                            statusChamado = StatusChamado.EmAberto,
                            codigo = Guid.NewGuid().ToString()
                        };

                        Console.WriteLine("Qual a descrição do chamado ?");
                        chamado.descricao = Console.ReadLine();

                        // Adicionar o chamado na lista de chamados.
                        chamados[quantidadeChamados] = chamado;
                        quantidadeChamados++;
                    } else {
                        Console.WriteLine("Voce atingiu o maximo de chamados. Espera porra.");
                    }
                }
                else if(opcao == "2"){
                    if(quantidadeAnalistas < 1){
                        Analista analista = new Analista{
                            codigo = Guid.NewGuid().ToString()
                        };

                        Console.WriteLine("Qual o nome do analista?");
                        analista.nome = Console.ReadLine();
                        Console.WriteLine("Qual o e-mail do analista?");
                        analista.email = Console.ReadLine();

                        analistas[quantidadeAnalistas] = analista;
                        quantidadeAnalistas++;
                    } else {
                        Console.WriteLine("Voce atingiu o maximo de analistas. Ta bom ja, chega.");
                    }
                }
                else if(opcao == "3"){
                    
                }
                else if(opcao == "4"){
                    
                }
                else if(opcao == "5"){
                    
                }
                else {
                    Console.WriteLine("VATITOMANOCU RAPA. Burro do caralho, pega aqui.");
                }

            } while(opcao != "5");


        }

        public void Revisao(){
            // ### Variável e tipos
            int a = 10;
            string b = "string";
            double c = 1.2;
            bool d = true;
            // Objeto de classe
            Revisao objetoRevisao = new Revisao();
            // Enum
            TiposAula enumTipoAula = TiposAula.Revisao;
            // Array
            int[] arrayDeInteiro = new int[10];
            // Array de objeto
            Revisao[] revisaoArray = new Revisao[10];


            // ### Métodos comuns para trabalhar com console

            // Escrever no console
            Console.WriteLine("texto");
            

            // Solicitar digitação no console
            Console.ReadLine();

            // Solicitar digitação no console e atribuir valor digitado à uma variável
            string textoDigitado = Console.ReadLine();

            // ### Converter valores

            // Converter int em string
            int numero = 10;
            string numeroComoTexto = Convert.ToString(numero);

            // Converter string em int
            string numeroComoTexto2 = "10";
            int numero2 = Convert.ToInt32(numeroComoTexto2);


            // ### Condições

            // # Condicional 1
            if (a > 10)
            {
                // O código colocado dentro deste escopo será executado 
                //apenas se o valor de "a" for maior que 10
            }

            // # Condicional 2
            if (a > 10)
            {
                // O código colocado dentro deste escopo será executado apenas 
                // se o valor de "a" for maior que 10
            }
            else
            {
                // O código colocado dentro deste escopo será executado apenas 
                // se o valor de "a" for menor ou igual a 10
            }

            // # Condicional 3
            if (a > 20)
            {
                // O código colocado dentro deste escopo será executado apenas 
                // se o valor de "a" for maior que 20
            }
            else if (a > 10 && a < 20 || a == 30) // Pode ter quantos else ifs precisam.
            {
                // O código colocado dentro deste escopo será executado apenas 
                // se o valor de "a" for maior que 10
            }
            else
            {
                // O código colocado dentro deste escopo será executado apenas 
                // se o valor de "a" for menor ou igual a 10
            }

            // # Condicional 4
            switch (a)
            {
                case 10:
                    // O código colocado dentro deste escopo será executado apenas 
                    // se o valor de "a" for igual a 10
                    break;
                case 20:
                    // O código colocado dentro deste escopo será executado apenas 
                    // se o valor de "a" for igual a 20
                    break;
                default:

                    break;
            }

            // # Condicional 5
            switch (enumTipoAula)
            {
                case TiposAula.Normal:
                    // O código colocado dentro deste escopo será executado apenas 
                    // se o valor de "enumTipoAula" for "Normal"
                    break;
                case TiposAula.Revisao:
                    // O código colocado dentro deste escopo será executado apenas 
                    // se o valor de "enumTipoAula" for "Revisao"
                    break;
                default:
                    break;
            }

            // ### Laços de repetição (for, while e do while)
            
            // # While 1
            bool @continue = true;
            while(@continue) {
                // O código dentro deste escopo será executado 
                // enquanto a condição for verdadeira
            }

            // # While 2
            int contador = 0;
            while(contador < 10){
                // O código dentro deste escopo será executado enquanto a condição for verdadeira
                // O contador vai somar 1 sempre que executar essa parte do código, até ele chegar 
                // em 10 e parar.
                contador++;
            }

            // # For 1
            for (int i = 0; i < 10; i++)
            {
                // O código dentro deste escopo será executado enquanto "i" for menor que 10
                // Toda vez que o código dentro deste escopo for executado, i terá um incremento de 1.
                // É basicamente a mesma lógica do while acima.
            }

            // # For 2 
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    // O código dentro deste escopo será executado 10 vezes para cada itereção no for acima.
                    // Se o for de cima vai acontecer 10 vezes, este for acontecerá 100 vezes.
                }
            }

            // # Do while 
            bool continuar = false;
            do
            {
                // É a mesma coisa que o while.
                // A diferença é que o código dentro deste escopo é executado pelo menos uma vez,
                // pois a condição se encontra no final, e não no início.
                // Enquanto a condição for verdadeira, o código dentro deste escopo será executado.
            } while (continuar);
            
            // ### Array

            // Declarar um array
            int[] arrayDeInt = new int[10];
            string[] arrayDeString = new string[10];
            bool[] arrayDeBool = new bool[10];
            double[] arrayDeDouble = new double[10];
            Revisao[] arrayDeRevisao = new Revisao[10];
            TiposAula[] arrayDeEnum = new TiposAula[10];

            // Atribuir valor a posição do array
            arrayDeInt[0] = 1;
            arrayDeInt[1] = 2;
            arrayDeInt[2] = 3;
            arrayDeInt[3] = 4;
            arrayDeInt[4] = 5;
            arrayDeInt[5] = 6;
            arrayDeInt[6] = 7;
            arrayDeInt[7] = 8;
            arrayDeInt[8] = 9;
            arrayDeInt[9] = 10;

            // Iterar um array
            for (int i = 0; i < arrayDeInt.Length; i++)
            {
                // O for vai passar por cada posição do array.
                // A variável "i" define a posição do array que será acessada.
                int valorAtual = arrayDeInt[0];
            }

            // ### Orientação a objetos

            // ## Abstração
            // Feita através de classes e objetos.

            // ## Classes e objetos

            // Classe: É a receita do bolo.
            // Objeto: É o bolo.
            // Campo: Peso, tamanho, sabor (caracteristicas especificas)
            // Método: Assar (ações)

            // Analogia a banco de dados.
            // Classe = Tabela.
            // Objeto = Registro da tabela. (Linha da tabela)
            // Campos = Colunas da tabela.
            // Métodos = Procedures, Functions

            // Como instanciar um objeto
            Revisao rev = new Revisao();

            // Como atribuir valor aos campos de um objeto
            rev.dataInicio = DateTime.Now;
            rev.dataInicio = DateTime.Now;
            rev.local = "IT4 Solution - 3 andar";
            rev.professor = new Professor();

            // Como atribuir valor aos campos de um objeto no momento que ele é instanciado
            Revisao rev2 = new Revisao {
                dataInicio = DateTime.Now,
                dataFim = DateTime.Now,
                local = "IT4 Solution - 3 andar",
                professor = new Professor()
            };

            // # Arrays de objeto
            Revisao[] arrayDeRevisao2 = new Revisao[10];
            
            // Exemplo com array: atribuição de valores às posições do array

            arrayDeRevisao2[0] = new Revisao {
                dataFim = DateTime.Now,
            };
            arrayDeRevisao2[1] = new Revisao();
            arrayDeRevisao2[2] = new Revisao();
            arrayDeRevisao2[3] = new Revisao();
            arrayDeRevisao2[4] = new Revisao();
            arrayDeRevisao2[5] = new Revisao();
            arrayDeRevisao2[6] = new Revisao();
            arrayDeRevisao2[7] = new Revisao();
            arrayDeRevisao2[8] = new Revisao();
            arrayDeRevisao2[9] = new Revisao();
            
            // Atribuir valor a campo de um objeto dentro de um array
            arrayDeRevisao2[0].dataInicio = DateTime.Now;
            arrayDeRevisao2[0].dataFim = DateTime.Now;
            arrayDeRevisao2[0].local = "IT4 Solution - 3 andar";
            arrayDeRevisao2[0].professor = new Professor();

            // Iterar array de objeto
            for (int i = 0; i < arrayDeRevisao2.Length; i++)
            {
                // O for vai passar por cada posição do array.
                // A variável "i" define a posição do array que será acessada.
                Revisao valorAtual = arrayDeRevisao2[i];
            }

            // # Métodos
            Revisao revisaumm = new Revisao();

            // Método sem retorno e não recebe parametros
            // Não é possível atribuir a uma variável o retorno do método, porque ele não tem retorno.
            revisaumm.Metodo1();
            revisaumm.DarAula();

            // Método sem retorno que recebe parametros
            // Não é possível atribuir a uma variável o retorno do método, porque ele não tem retorno.
            revisaumm.Metodo2(0, "");
            revisaumm.DefinirDataAula(DateTime.Now, DateTime.Now);

            // Método com retorno que não recebe parametros
            revisaumm.Metodo3();
            revisaumm.PegarNomeProfessor();
            // atribuir retorno do método a uma variavel
            int retornoMetodo3 = revisaumm.Metodo3();
            string retorno = revisaumm.PegarNomeProfessor();

            // Método com retorno e que recebe parametros
            revisaumm.Metodo4(0, 0);
            revisaumm.NovoProfessor(new Professor());
            // atribuir retorno do método a uma variavel
            int retornoMetodo4 = revisaumm.Metodo4(0, 0);
            Professor nomeNovoProfessor = revisaumm.NovoProfessor(new Professor());

            // ### NAMESPACE
        }
    }
}
