using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JogoSimpson
{
    class Simpson
    {
        public int qtdpontos, tempo;

      public void pontuacao(int pontos)
      {
          qtdpontos += pontos;

      }
      public int consultarpontos()
      {
          return qtdpontos;
      }
      public int Tempo(int t)
      {
          tempo += t;
          return tempo;
      }



    }
}
