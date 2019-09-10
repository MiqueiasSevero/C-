using System;
using System.Collections.Generic;

namespace AULA_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pessoa cadpessoa = new Pessoa("MIQUEIAS", true,'M',"xxxxx","05425545509",15200);
             cadpessoa.AtribuiEndereco("rua sss");
             cadpessoa.pCor = "Preto";
             cadpessoa.pTel = "11 4138-1580";



             Console.WriteLine(cadpessoa.RetEnd() +"\n"+ cadpessoa.pCor + "\n" + cadpessoa.pTel);



             Veiculo cadVeiculo = new Veiculo();

             cadVeiculo.setAnoFabric(99);
             cadVeiculo.setcorVeiculo("vermelho");
             cadVeiculo.setModeloVeiculo("civic");
             cadVeiculo.setTipoVeiculo("sedan");
             cadVeiculo.setPlacaVeiculo("sdf-2554");
             cadVeiculo.setMarcaVeiculo("honda");

             Console.WriteLine("MARCA: " + cadVeiculo.getMarcaVeiculo() + "\n"+ "MODELO: " + cadVeiculo.getModeloVeiculo() +"\n" +
         "COR: " + cadVeiculo.getcorVeiculo() +"\n"+ "ANO: " + cadVeiculo.getAnoFabric() +"\n"+  "TIPO: " + cadVeiculo.getTipoVeiculo() +"\n" +
                 "PLACA: " + cadVeiculo.getPlacaVeiculo()  );
 */
            /*
            Motocicleta Moto01 = new Motocicleta();
            Moto01.setcorVeiculo("PRATA");
            Moto01.setModeloVeiculo("FAN 125");
            String Ms = Moto01.Velocidade(120);
            Moto01.Qtd = 2;



            Console.WriteLine( " " + Ms + "\n Rodas: " + Moto01.Qtd );

        


            */
            Caminhao caminhao01 = new Caminhao();
            caminhao01.setcorVeiculo("amarelo");
            caminhao01.setAnoFabric(1997);
            caminhao01.setMarcaVeiculo("WOLKSVAGEM");
            caminhao01.setModeloVeiculo("24-254");
            caminhao01.GetSetCapPeso = "2500kg";
            caminhao01.GetSetCombustivel = "Diesel";
            caminhao01.GetSetEixos = 11;


            Console.WriteLine(" COR: " + caminhao01.getcorVeiculo() +"\n ANO FABRIC: "+ caminhao01.getAnoFabric() +"\n MARCA: " + caminhao01.getMarcaVeiculo() +"\n MODELO: " + 
                caminhao01.getModeloVeiculo() +"\n CAPACIDADE PESO: " + caminhao01.GetSetCapPeso +"\n COMBUSTIVEL: " + caminhao01.GetSetCombustivel +"\n EIXOS: " + caminhao01.GetSetEixos );




           Console.ReadKey();







        }
    }
}
