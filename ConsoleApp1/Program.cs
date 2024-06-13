public class Program
{

    static int cont = 0;
    static int numMateria;
    static int numAluno;

    static void Main(string[] args)
    {
        string arquivo = @"C:\Users\lleon\OneDrive - sga.pucminas.br\2° semestre\Algoritmo e Estrutura de Dados\Trabalho\teste.txt"; // Caminho do arquivo

        // Usando um bloco "using" para garantir o fechamento automático do arquivo
        using (StreamReader reader = new StreamReader(arquivo))
        {
            string linha;

            while ((linha = reader.ReadLine()) != null)
            {
                Console.WriteLine(linha);

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

                        // Cria o numero de materias e alunos
                        NumMateriaEAlunos(linha, valores);

                    }
                }
                else if (cont > 0 && cont <= numMateria)
                {

                    cont++;
                }
                else
                {

                    cont++;
                }

            }

            Console.ReadKey();
        }
    }


    static void NumMateriaEAlunos(string linha, string[] valores)
    {

        // Verificar se valores[0] é válido antes de converter para inteiro
        try
        {
            numMateria = Convert.ToInt32(valores[0]);

            Console.WriteLine($"Materias: {numMateria}");
        }
        catch
        {
            Console.WriteLine("Erro: A string não é um número válido.");
        }

        try
        {
            numAluno = Convert.ToInt32(valores[1]);

            Console.WriteLine($"Alunnos: {numAluno}");
        }
        catch
        {
            Console.WriteLine("Erro: A string não é um número válido.");
        }

        cont++;
    }


    static void CriarMaterias(string linha)
    {
        string[] materias = linha.Split(';');
        int id = Convert.ToInt32(materias[0]);
        string nomeMateria = materias[1];
        int vagas = Convert.ToInt32(materias[2]);

        Console.WriteLine("tt");
    }
}