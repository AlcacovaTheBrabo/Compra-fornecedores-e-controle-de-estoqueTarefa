using  System ;
usando o  sistema . Coleções . Genérico ;
using  Aula14 ;

namespace  Aula14
{
public  class  Estoque
{
     Dicionário privado < Produto , int > _itens ;

     Dicionário público < Produto , int > Itens
    {
        get { return  this . _itens ; }
    }

    público  duplo  total
    {
        obter
        {
             somatorio  duplo =  0 ;
            // somatorio de valor total de cada item multiplicado pela quantidade de itens no carrinho
            foreach ( KeyValuePair < PRODUTO , int > parOrdenado  no  presente . _itens )
                somatorio  + =  parOrdenado . Chave . CalculaValorTotal () *  parOrdenado . Valor ;

            retorno  somatorio ;
        }
    }

     Estoque público ()
    {
        isso . _itens  =  novo  Dicionário < Produto , int > ();
    }
    
    public  void  Adicionar ( Produto  item , int  quantidade )
    {
        if ( this . _itens . ContainsKey ( item ))
            isso . _itens [ item ] =  isso . _itens [ item ] +  quantidade ;
        senão
            isso . _itens [ item ] =  quantidade ;
    }

    public  void  Adicionar ( item Produto  )
    {
        isso . Adicionar ( item , 1 );
    }
    
    public  void  Adicionar ( List < Produto > itens )
    {
        foreach ( item var  em itens )  
        {
            isso . Adicionar ( item );
        }
    }
    
    public  void  Adicionar ( Dicionário < Produto , int > itens )
    {
        foreach ( KeyValuePair < Produto , int > parOrdenado  em  itens )
        {
            isso . Adicionar ( parOrdenado . Key , parOrdenado . Value );
        }
    }

    public  void  ImprimirCarrinho ()
    {
        Console . WriteLine ( " ======== ESTOQUE ======== " );
        foreach ( KeyValuePair < PRODUTO , int > parOrdenado  no  presente . _itens )
        {
            parOrdenado . Chave . Imprimir ();
            Console . WriteLine ( " Quantidade: {0} " , parOrdenado . Valor );
            Console . WriteLine ( " Subtotal:R$ " , parOrdenado . Value  *  parOrdenado . Key . CalculaValorTotal ());
        }
        Console . WriteLine ( " Total do estoque:  R $  " , este . Total );
 
    }
}
}