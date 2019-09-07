using System;
using System.Collections.Generic;
using System.Text;

namespace AULA_C2
{
    class Veiculo
    {
        // caracteristicas atributos
        private string modeloVeiculo;
        private string corVeiculo;
        private string marcaVeiculo;
        private int anoFabric;
        private string placaVeiculo;
        private string tipoVeiculo;

        // metodos de atribuir

        public void setModeloVeiculo(string pModeloVeiculo)
        {
            this.modeloVeiculo = pModeloVeiculo;
        }
        public string getModeloVeiculo()
        {
            return this.modeloVeiculo;

        }
        public void setcorVeiculo(string pcorVeiculo)
        {
            this.corVeiculo = pcorVeiculo;
        }
        public string getcorVeiculo()
        {
            return this.corVeiculo;

        }
        public void setAnoFabric(int pAnoFabric)
        {
            this.anoFabric = pAnoFabric;
        }
        public int getAnoFabric()
        {
            return this.anoFabric;

        }
        public void setPlacaVeiculo(string pPlacaVeiculo)
        {
            this.placaVeiculo = pPlacaVeiculo;
        }
        public string getPlacaVeiculo()
        {
            return this.placaVeiculo;

        }
        public void setTipoVeiculo(string pTipoVeiculo)
        {
            this.tipoVeiculo = pTipoVeiculo;
        }
        public string getTipoVeiculo()
        {
            return this.tipoVeiculo;

        }
      

    }
}
