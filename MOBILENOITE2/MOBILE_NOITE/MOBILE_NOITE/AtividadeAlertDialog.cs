using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{

    [Activity(Label = "AtividadeAlertDialog", MainLauncher = false , Icon = "@drawable/PROJETO")]
    class AtividadeAlertDialog:Activity
    {

        Button bt_cadastrar;
        EditText nome;
        TextView mostrar;


        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtividadeAlertDialog);

            bt_cadastrar = FindViewById<Button>(Resource.Id.btPer);
            nome = FindViewById<EditText>(Resource.Id.campoNome);
            mostrar = FindViewById<TextView>(Resource.Id.mostrar);
            



            bt_cadastrar.Click += Bt_cadastrar_Click;
     

        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);

            alerta.SetTitle("Opção!");

            alerta.SetMessage("Deseja mostar o seu nome");

            alerta.SetPositiveButton("Yes", (senderArg, arg) => {
        //  . Text atribui ou pega 
                mostrar.Text = nome.Text;
                nome.Text = "";



            });
            alerta.SetNegativeButton("No", (senderArg, arg) => {
            // duas formas de limpar
                mostrar.Text = "";
                nome.Text = String.Empty;


            });

            alerta.Show();
        }
    }
}