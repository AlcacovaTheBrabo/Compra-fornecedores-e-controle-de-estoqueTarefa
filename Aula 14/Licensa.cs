using Aula14;
using System;

namespace Aula14
{
public class Licensa : Produto
{
    
    protected string _chaveAtivacao;

    public string ChaveAtivacao
    {
        get { return this._chaveAtivacao; }
    }

    public Licensa(string nome, double preco, string chaveAtivacao)
    {
        this._nome = nome;
        this._preco = preco;
        this._chaveAtivacao = chaveAtivacao;
    }

    public override double CalculaValorTotal()
    {
        return this._preco;
    }

    public override void Imprimir()
    {
        Console.WriteLine("Software:", this.Nome); 
        Console.WriteLine("Valor:tR$ ", this.CalculaValorTotal());
    }
}
}