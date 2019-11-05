using System;
using OrientaçãoObjetos.Models;

namespace OrientaçãoObjetos {

    class Program {
        private static object aluno2;

        static void Main (string[] args) {

            // declarando objeto
            AlunoModel aluno1 = new AlunoModel ();

            Console.Clear (); //Limpa o console

            for (int i = 0; i < 2; i++) {

                // Lendo o Nome do Aluno
                System.Console.WriteLine ("Nome do Aluno");
                aluno1.nome = Console.ReadLine ();

                // Lendo o RG do Aluno
                System.Console.WriteLine ("RG do Aluno");
                aluno1.rg = int.Parse (Console.ReadLine ());

                //Lendo a Idade do Aluno
                System.Console.WriteLine ("Idade do Aluno");
                aluno1.idade = int.Parse (Console.ReadLine ());

                //lendo o Curso Desejado
                System.Console.WriteLine (@"
                                 Cursos oferecidos nessa institutição!

                (1) Veterinário
                (2) Psicologia
                (3) Turismo
                (4) Publicidade e Propaganda
                (5) Medicina
                (6) Engenharia de Software
                (7) Administração
                (8) Letras
                (9) História 
                
                                 Escolha a Opção desejada");
                int opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {

                    case 1:
                        if (aluno1.nota > 45) {
                            System.Console.WriteLine ($@" 
                
                             Parabéns {aluno1.nome}
                   você foi selecionado para a 5ª turma de {aluno1.curso} 
                          para inicio de Janeiro de 2019
                    
            

                                                   Dados do Aluno: 
                 
                  Nome: {aluno1.nome}
                  Idade: {aluno1.idade}
                  RG: {aluno1.rg}
                  Curso: {aluno1.curso}
                  Nota Alcançada: {aluno1.nota} ");

                        } else {

                            System.Console.WriteLine ($@"
                                  Infelizmente {aluno1.nome} não foi aceito para cursar
                                 o curso de {aluno1.curso} esse semestre por nota de corte
                                                   abaixo da média
                                                   
                                                   


                                                    Dados do Aluno: 
                 
                  Nome: {aluno1.nome}
                  Idade: {aluno1.idade}
                  RG: {aluno1.rg}
                  Curso: {aluno1.curso}
                  Nota Alcançada: {aluno1.nota}");

                        }
                        break;

                }

                // Lendo a Nota do Aluno
                System.Console.WriteLine ("Nota do Aluno");
                aluno1.nota = int.Parse (Console.ReadLine ());

                if (aluno1.nota > 35) {
                    System.Console.WriteLine ($@" 
                
                             Parabéns {aluno1.nome}
                   você foi selecionado para a 5ª turma de {aluno1.curso} 
                          para inicio de Janeiro de 2019
                    
                


                                                   Dados do Aluno: 
                 
                  Nome: {aluno1.nome}
                  Idade: {aluno1.idade}
                  RG: {aluno1.rg}
                  Curso: {aluno1.curso}
                  Nota Alcançada: {aluno1.nota} ");

                } else {

                    System.Console.WriteLine ($@"
                                  Infelizmente {aluno1.nome} não foi aceito para cursar
                                 o curso de {aluno1.curso} esse semestre por nota de corte
                                                   abaixo da média
                                                   
                                                   


                                                    Dados do Aluno: 
                 
                  Nome: {aluno1.nome}
                  Idade: {aluno1.idade}
                  RG: {aluno1.rg}
                  Curso: {aluno1.curso}
                  Nota Alcançada: {aluno1.nota}");

                }

                //criando aluno dois

                AlunoModel aluno2 = new AlunoModel ();

                System.Console.WriteLine ("teu nome");
                aluno2.nome = Console.ReadLine ();

            }
        }
    }
}