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


        public void Print()
        {
            Console.WriteLine($"Nome: {GetName()} \nVagas: {GetVaga()}\n");
        }
    }


}