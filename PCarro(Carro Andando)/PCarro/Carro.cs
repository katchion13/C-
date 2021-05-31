using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCarro
{
    class Carro
    {
        public string marca;
        public string comustivel;
        public int velocidade;

        public void movimentar(int aceleracao)
        {
            velocidade += aceleracao;        
        }
        public void re()
        {
            if(velocidade > 0)
        {
            velocidade--;
             }

        }
        public void parar()
        { 
        velocidade =0;
        }
        public int consultar()
        {
            return velocidade; 
        }
    }
}
