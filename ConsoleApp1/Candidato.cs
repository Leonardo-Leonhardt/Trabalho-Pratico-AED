using System;

namespace Facudade
{

    public class Candidato
    {

        private string Nome;
        private float NotaMedia;
        private float NotaRedacao;
        private float NotaMatematica;
        private float NotaLinguagem;
        private int Opcao1;
        private int Opcao2;

        public Candidato(string nome, float notaRedacao, float notaMatematica, float notaLinguagem, int opcao1, int opcao2)
        {
            Nome = nome;
            NotaRedacao = notaRedacao;
            NotaMatematica = notaMatematica;
            NotaLinguagem = notaLinguagem;
            Opcao1 = opcao1;
            Opcao2 = opcao2;
            NotaMedia = CalcularNotaMedia();
        }

        public float CalcularNotaMedia() { return ((GetNotaRedacao() + GetNotaMatematica() + GetNotaLinguagem()) / 3); }

        // Foram adicionados métodos GetNome(), GetNotaMedia(), GetNotaRedacao(), GetNotaMatematica(), GetNotaLinguagem(),
        // GetOpcao1() e GetOpcao2() para acessar as propriedades privadas da classe, seguindo o princípio de encapsulamento.
        public string GetNome() { return Nome; }

        public float GetNotaMedia() { return (float)Math.Round(NotaMedia, 2); }

        public float GetNotaRedacao() { return NotaRedacao; }

        public float GetNotaMatematica() { return NotaMatematica; }

        public float GetNotaLinguagem() { return NotaLinguagem; }

        public int GetOpcao1() { return Opcao1; }

        public int GetOpcao2() { return Opcao2; }

        public void Print()
        {
            Console.WriteLine($"Nome: {GetNome()} {GetNotaMedia()} {GetNotaRedacao()} {GetNotaMatematica()} {GetNotaLinguagem()}");
        }

    }

    public class MergeSortCandidato
    {
        // Método para mesclar duas sublistas ordenadas de candidatos
        private static void Merge(Candidato[] candidatos, int left, int middle, int right)
        {
            // Encontrar os tamanhos das duas sublistas
            int n1 = middle - left + 1;
            int n2 = right - middle;

            // Criar arrays temporários para as sublistas
            Candidato[] leftArray = new Candidato[n1];
            Candidato[] rightArray = new Candidato[n2];

            // Copiar dados para os arrays temporários
            for (int x = 0; x < n1; x++)
            {
                leftArray[x] = candidatos[left + x];
            }
            for (int y = 0; y < n2; y++)
            {
                rightArray[y] = candidatos[middle + 1 + y];
            }

            // Mesclar as sublistas de volta para a lista original
            int i = 0; // Índice inicial da primeira sublista
            int j = 0; // Índice inicial da segunda sublista
            int k = left; // Índice inicial da lista original

            while (i < n1 && j < n2)
            {
                if (leftArray[i].GetNotaMedia() >= rightArray[j].GetNotaMedia())
                {
                    candidatos[k] = leftArray[i];
                    i++;
                }
                else
                {
                    candidatos[k] = rightArray[j];
                    j++;
                }
                k++;
            }


            // Copiar os elementos restantes da primeira sublista (se houver)
            while (i < n1)
            {
                candidatos[k] = leftArray[i];
                i++;
                k++;
            }

            // Copiar os elementos restantes da segunda sublista (se houver)
            while (j < n2)
            {
                candidatos[k] = rightArray[j];
                j++;
                k++;
            }
        }

        // Método para ordenar recursivamente o array de candidatos usando Merge Sort
        private static void MergeSortRecursive(Candidato[] candidatos, int left, int right)
        {
            if (left < right)
            {
                // Encontrar o ponto médio do array
                int middle = left + (right - left) / 2;

                // Classificar recursivamente as duas sublistas
                MergeSortRecursive(candidatos, left, middle);
                MergeSortRecursive(candidatos, middle + 1, right);

                // Mesclar as duas sublistas classificadas
                Merge(candidatos, left, middle, right);
            }
        }


        // Método para ordenar um array de candidatos usando Merge Sort
        public static void Sort(Candidato[] candidatos)
        {
            MergeSortRecursive(candidatos, 0, candidatos.Length - 1);
        }

    }
}
