using  System ;

namespace  Aula14
{
    public  class  Fornecedor : IImprimivel
    {
         string  privada _nome ;
         string  privada _cpf ;

        public  string  Nome
        {
            obter
            {
                devolva  isso . _nome ;
            }
        }

        public  string  Cpf
        {
            obter
            {
                devolva  isso . _cpf ;
            }
        }

         Cliente público ( string  nome , string  cpf )
        {
            isso . _nome  =  nome ;
            isso . _cpf  =  cpf ;
        }
        public  void  Imprimir ()
        {
            Console . WriteLine ( " Nome:" , este . Nome );
            Console . WriteLine ( " CPF: " , este . Cpf );
        }
    }
}