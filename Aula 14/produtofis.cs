using System;

namespace Aula14
{
    public class ProdutoFisico : Produto
    {

        private double _frete;

        public double Frete
        {
            get { return this._frete; }
        }
        public ProdutoFisico(string nome, double preco, double frete)
        {
            this._nome = nome;
            this._preco = preco;
            this._frete = frete;
        }

        public override double CalculaValorTotal()
        {
            return this._frete + this._preco;
        }
        public override void Imprimir()
        {
            Console.WriteLine("Produto:", this.Nome); 
            Console.WriteLine("Preço:R$ "}", this._preco);
            Console.WriteLine("Frete:R$", this._frete);
            Console.WriteLine("Valor:R$", this.CalculaValorTotal());
        }
    }
}