using System;
using System.Collections.Generic;
using System.Text;

namespace AULA_C2
{
    class Caminhao: Motocicleta
    {
        private int eixos;
        private string combustivel;
        private string capacidadePeso;

        public int GetSetEixos
        {
            get { return this.eixos;}
            set {this.eixos = value; }
        }
        public string GetSetCombustivel
        {
            get { return this.combustivel; }
            set { this.combustivel = value; }
        }
        public string GetSetCapPeso
        {
            get { return this.capacidadePeso; }
            set { this.capacidadePeso = value; }
        }
    }
}
