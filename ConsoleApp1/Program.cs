string arquivo = @"C:\Users\lleon\OneDrive - sga.pucminas.br\2° semestre\Algoritmo e Estrutura de Dados\Trabalho\teste.txt"; // Caminho do arquivo

// Usando um bloco "using" para garantir o fechamento automático do arquivo
using (StreamReader reader = new StreamReader(arquivo))
{
    string linha;

    while ((linha = reader.ReadLine()) != null)
    {
        Console.WriteLine(linha);
    }

    Console.ReadKey();
}