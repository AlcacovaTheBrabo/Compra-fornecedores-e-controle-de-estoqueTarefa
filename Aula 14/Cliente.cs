using System;

namespace Aula14
{
    public class Cliente : IImprimivel
    {
        private string _nome;
        private string _cpf;

        public string Nome
        {
            get
            {
                return this._nome;
            }
        }

        public string Cpf
        {
            get
            {
                return this._cpf;
            }
        }

        public Cliente(string nome, string cpf)
        {
            this._nome = nome;
            this._cpf = cpf;
        }
        public void Imprimir()
        {
            Console.WriteLine("Nome:", this.Nome); 
            Console.WriteLine("CPF:", this.Cpf);
        }
    }
}