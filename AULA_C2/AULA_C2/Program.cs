using System;

namespace AULA_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa cadpessoa = new Pessoa("MIQUEIAS", true,'M',"xxxxx","05425545509",15200);
            cadpessoa.AtribuiEndereco("rua sss");
            cadpessoa.pCor = "Preto";
            cadpessoa.pTel = "11 4138-1580";
           


            Console.WriteLine(cadpessoa.RetEnd() +"\n"+ cadpessoa.pCor + "\n" + cadpessoa.pTel);



            Veiculo cadVeiculo = new Veiculo();

            cadVeiculo.
        

         

           

            Console.ReadKey();







        }
    }
}
