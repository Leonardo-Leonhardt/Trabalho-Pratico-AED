using System;

namespace Facudade
{

    public class FilaLinear
    {
        private Candidato[] fila;
        private int inicio;
        private int fim;

        public FilaLinear()
        {
            fila = new Candidato[10];
            inicio = 0;
            fim = 0;
        }

        public Candidato[] GetCandidato() { return fila; }

        public int GetInicio() { return inicio; }

        public int GetFim() { return fim; }

        public bool EstaCheia() { return inicio == fim; }

        public bool EstaVazia() { return (fim + 1) % GetCandidato().Length == inicio; }

        public bool Inserir(Candidato candidato)
        {
            if (!EstaCheia())
            {
                fila[fim] = candidato;

                fim = (fim + 1) % GetCandidato().Length;

                return true;
            }
            else { return false; }

        }

        public bool Remover()
        {
            if (!EstaVazia())
            {
                inicio = (inicio + 1) % GetCandidato().Length;

                return true;
            }
            else { return false; }

        }

        public bool ImprimirArquivo(string arquivo)
        {
            using (StreamWriter writer = new StreamWriter(arquivo))
            {
                do
                {
                    writer.WriteLine($"{fila[inicio].GetNome()};{fila[inicio].GetNotaMedia()};{fila[inicio].GetNotaRedacao()};{fila[inicio].GetNotaMatematica()};{fila[inicio].GetNotaLinguagem()}");

                    inicio = (inicio + 1) % GetCandidato().Length;


                } while (inicio != fim);
                return true;

            }
            return false;

        }
    }
}