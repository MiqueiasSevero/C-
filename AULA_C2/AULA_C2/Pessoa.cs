using System;
using System.Collections.Generic;
using System.Text;

namespace AULA_C2
{
    class Pessoa


    {
        //variavel , campo, atributos

        //visibilidade, tipo e nome

        public string nome;
        public bool ativido;
        public char sexo;
        public decimal salario;
        public string rg;
        public string cpf;
        private string end;
        private string cor;



        // construtor vai inicializar a 
        public Pessoa () {


        }

        public Pessoa(string pNome,bool pAtiv, char pSexo,string pRg, string pCpf,  decimal pSalario )
        {

            this.nome = pNome;
            this.ativido = pAtiv;
            this.sexo = pSexo;
            this.rg = pRg;
            this.cpf = pCpf;
            this.salario = pSalario;

            Console.WriteLine(this.nome);
            


        }
        //met atribui
        public void AtribuiEndereco(string pEnd)
        {
            this.end = pEnd;
           

        }
        //met retorna

        public String RetEnd()
        {
            return this.end;
        }


        //propriedade manual
         public string pCor
        {
            get { return this.cor; }
            set { this.cor = value;  }
        }

        //propriedade automatico

        public string pTel
        {get;set;}


    }
}
;