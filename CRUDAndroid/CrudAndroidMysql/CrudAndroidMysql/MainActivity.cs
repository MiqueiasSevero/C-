using Android.App;
using Android.Widget;
//importar
using Android.OS;

using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;

namespace CrudAndroidMysql
{
    [Activity(Label = "CrudAndroidMysql", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Acessa();

        }
        private async void Acessa()
        {

            //caminho do servidor
            string uri = "http://10.131.45.51/CRUDAndroid/select.php";
            //Objeto uma estancia que permite fazer a conexão 
            HttpClient solicita = new HttpClient();
            //mandar a solicitação para o servidor e o servidor vai devolver a resposta assicrono 

            HttpResponseMessage resultado = await solicita.PostAsync(uri, null);

            // HttpResponseMessage - tem um  propriedade que indica a resposta 
            // servidor se foi bem sucedido

            Console.WriteLine("resposta do xampp" + resultado.IsSuccessStatusCode);

            //trazer conteudo

            var conteudo = await resultado.Content.ReadAsStringAsync();
            //mostrar os dados vindos do servidor 


            Console.WriteLine("Dados " + conteudo);

            //fazer a descompactação da resposta vinda em json

            List<SelectJson> listaRet = JsonConvert.DeserializeObject<List<SelectJson>>(conteudo);
            //ler os dados 
            foreach(SelectJson dados in listaRet)
            {
                Console.WriteLine(dados.ID_US + " " + dados.NOME_US);
            }

        }
    }
}

