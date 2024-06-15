using System;

namespace Facudade
{

    public class Curso
    {
        private string Name;
        private int Vaga;

        public Curso(string nome, int vaga)
        {
            Name = nome;
            Vaga = vaga;
        }

        public string GetName() { return Name; }

        public int GetVaga() { return Vaga; }


        public void Print() { Console.WriteLine($"Nome: {GetName()} \nVagas: {GetVaga()}\n"); }
    }


    public class ListaCurso
    {
        private List<Candidato> lista;

        public ListaCurso(Candidato candidato)
        {
            lista = new List<Candidato>();

            if (candidato == null)
            {
                throw new ArgumentException("Erro: Candidato inválido.!!");
            }
            else
            {
                lista.Add(candidato);
            }
        }

        public ListaCurso()
        {
            lista = new List<Candidato>();

                lista.Add(null);
            
        }



        public List<Candidato> GetLista() { return lista; }

        public void Print()
        {
            foreach (Candidato candidato in lista)
            {
                if (candidato != null) // Verificar se o candidato não é nulo
                {
                    candidato.Print(); // Chama o método Print() do candidato
                }
            }
        }


    }


}