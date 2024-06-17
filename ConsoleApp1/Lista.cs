using System;

namespace Facudade
{
    public class ListaDeAprovados
    {
        private List<Candidato>[] candidatos;
        private FilaLinear[] fila;
        private int[] limites;


        public ListaDeAprovados(int numeroDeCursos, int[] limites)
        {
            candidatos = new List<Candidato>[numeroDeCursos];
            fila = new FilaLinear[numeroDeCursos];
            this.limites = limites;

            for (int i = 0; i < numeroDeCursos; i++)
            {
                candidatos[i] = new List<Candidato>();
                fila[i] = new FilaLinear();
            }
        }

        public bool AddCandidato(Candidato candidato, int indiceLista)
        {
            if (indiceLista >= 0 && indiceLista < candidatos.Length)
            {
                if (candidatos[indiceLista].Count < limites[indiceLista])
                {

                    candidatos[indiceLista].Add(candidato);

                    return true;
                }
                else
                {
                    fila[indiceLista].Inserir(candidato);

                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public List<Candidato>[] GetCandidatos() { return candidatos; }

        public FilaLinear[] GetFila() { return fila; }


        public bool ImprimirArquivo(string arquivo)
        {
            using (StreamWriter writer = new StreamWriter(arquivo))
            {
                Console.WriteLine("Selecionados");

                for (int i = 0; i < candidatos.Length; i++)
                {
                    foreach (Candidato candidato in candidatos[i])
                    {
                        candidato.Print();
                    }

                    fila[i].ImprimirArquivo(arquivo);

                }
                return true;

            }
        }
    }
}