using System;
using System.Collections.Generic;
using System.Text;

namespace AULA_C2
{
    class Motocicleta : Veiculo
    {
        private int qtdRodas;
        private int qtdPessoa;

       
        public int Qtd {
            get {return this.qtdRodas; }
            set {this.qtdRodas = value; }

        }


    }
}
