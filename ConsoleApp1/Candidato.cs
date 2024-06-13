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

        public float CalcularNotaMedia() { return ((GetNotaMedia() + GetNotaMatematica() + GetNotaLinguagem()) / 3); }


        // Foram adicionados métodos GetNome(), GetNotaMedia(), GetNotaRedacao(), GetNotaMatematica(), GetNotaLinguagem(),
        // GetOpcao1() e GetOpcao2() para acessar as propriedades privadas da classe, seguindo o princípio de encapsulamento.
        public string GetNome() { return Nome; }

        public float GetNotaMedia() { return NotaMedia; }

        public float GetNotaRedacao() { return NotaRedacao; }

        public float GetNotaMatematica() { return NotaMatematica; }

        public float GetNotaLinguagem() { return NotaLinguagem; }

        public int GetOpcao1() { return Opcao1; }

        public int GetOpcao2() { return Opcao2; }

        public void Print()
        {
            Console.WriteLine($"Nome: {GetNome()} \nMedia: {GetNotaMedia()} \nRedaçao: {GetNotaRedacao()} \nMatematica: {GetNotaMatematica()} \nLinhuagem: {GetNotaLinguagem()} \nOpação 1: {GetOpcao1()} \nOpação 2: {GetOpcao2()}\n");
        }
    }
}