using System;

namespace Facudade
{

    public class Program
    {

        static int cont = 0;
        static int numMateria;
        static int numAluno;
        static Curso[] curso;
        static Candidato[] candidato;
        static Dictionary<int, Curso> cursoComId = new Dictionary<int, Curso>();

        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\lleon\OneDrive - sga.pucminas.br\2° semestre\Algoritmo e Estrutura de Dados\Trabalho\teste.txt"; // Caminho do arquivo

            // Usando um bloco "using" para garantir o fechamento automático do arquivo
            using (StreamReader reader = new StreamReader(arquivo))
            {
                string linha;
                int valor1 = 0;
                int valor2 = 0;


                while ((linha = reader.ReadLine()) != null)
                {
                    //Console.WriteLine(linha);

                    if (cont == 0)
                    {
                        string[] valores = linha.Split(';');


                        if (valores.Length < 2)
                        {
                            // Lançar exceção
                            throw new ArgumentException("A linha do arquivo deve ter pelo menos dois valores separados por ';'.", "linha");

                        }
                        else
                        {

                            CriaMateriaEAlunos(linha, valores);

                            cont++;

                        }// Add o numero de materias e alunos

                    }
                    else if (cont > 0 && cont <= numMateria)
                    {
                        string[] valores = linha.Split(';');

                        AddMaterias(linha, valores, valor1);

                        cont++;
                        valor1++;
                    }
                    else
                    {
                        string[] valores = linha.Split(';');

                        AddAluno(linha, valores, valor2);

                        cont++;
                        valor2++;

                    }
                }


                //foreach (KeyValuePair<int, Curso> curso in cursoComId.Values)
                //{
                //    Console.Write($"Id: {curso.Key}");
                //    Console.Write($"Materia: {curso.Value.GetNome()}");
                //    Console.Write($"Vagas: {curso.Value.GetVaga()}");

                //}

                foreach (var item in cursoComId)
                {
                    Console.WriteLine($"Curso com ID {item.Key}: {item.Value.GetName()}: {item.Value.GetVaga()}");
                }





                Console.ReadKey();
            }
        }


        static void CriaMateriaEAlunos(string linha, string[] valores)
        {
            try // Verificar se valores[0] é válido antes de converter para inteiro
            {
                numMateria = Convert.ToInt32(valores[0]);

                curso = new Curso[numMateria];

            }
            catch { Console.WriteLine("Erro: A string não é um número válido.??"); } // Exceção

            try
            {
                numAluno = Convert.ToInt32(valores[1]);

                candidato = new Candidato[numAluno];

            }
            catch { Console.WriteLine("Erro: A string não é um número válido.//"); } // Exceção

        }

        static void AddMaterias(string linha, string[] valores, int valor)
        {

            if (valores.Length == 3)
            {

                int id = Convert.ToInt32(valores[0]);
                string materia = valores[1];
                int vaga = Convert.ToInt32(valores[2]);

                curso[valor] = new Curso(materia, vaga);

                cursoComId[id] = curso[valor];


            }

            else { throw new ArgumentException("Erro: A string não é válido.!!"); } // Exceção

        }

        static void AddAluno(string linha, string[] valores, int valor)
        {

            try // Verificar se valores[0] é válido antes de converter para inteiro
            {

                if (valores.Length == 6)
                {
                    string nome = valores[0];
                    float redacao = Convert.ToSingle(valores[1]);
                    float matematica = Convert.ToSingle(valores[2]);
                    float lingaguen = Convert.ToSingle(valores[3]);
                    int opcao1 = Convert.ToInt32(valores[4]);
                    int opcao2 = Convert.ToInt32(valores[5]);

                    candidato[valor] = new Candidato(nome, redacao, matematica, lingaguen, opcao1, opcao2); // Add o candidatos na ordem da lista

                }
                else { throw new ArgumentException("Erro: A string não é válido.++"); } // Exceção



            }
            catch { Console.WriteLine("Erro: A string não é válido.**"); } // Exceção



            candidato[valor].Print();

        }
    }
}