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

        static void Main(string[] args)
        {
            string arquivo = @"C:\Users\lleon\OneDrive - sga.pucminas.br\2° semestre\Algoritmo e Estrutura de Dados\Trabalho\teste.txt"; // Caminho do arquivo

            // Usando um bloco "using" para garantir o fechamento automático do arquivo
            using (StreamReader reader = new StreamReader(arquivo))
            {
                string linha;

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

                        AddMaterias(linha, valores);

                        cont++;

                    }
                    else
                    {
                        string[] valores = linha.Split(';');
                        int valor = 0;

                        AddAluno(linha, valores, valor);

                        valor++;
                        cont++;

                    }
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

        static void AddMaterias(string linha, string[] valores)
        {

            if (valores.Length == 3)
            {

                int id = Convert.ToInt32(valores[0]);
                string materia = valores[1];
                int vagas = Convert.ToInt32(valores[2]);

            }

            else { throw new ArgumentException("Erro: A string não é válido.!!"); } // Exceção


            for (int i = 0; i < curso.Length; i++)
            {

            }

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