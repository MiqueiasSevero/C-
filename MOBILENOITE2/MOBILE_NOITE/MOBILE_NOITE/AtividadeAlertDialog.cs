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

    [Activity(Label = "AtividadeAlertDialog", MainLauncher = true)]
    class AtividadeAlertDialog:Activity
    {

        Button bt_cadastrar;
        TextView nome;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtividadeAlertDialog);

            bt_cadastrar = FindViewById<Button>(Resource.Id.btPer);
            nome = FindViewById<TextView>(Resource.Id.campoNome);




            bt_cadastrar.Click += Bt_cadastrar_Click;
     

        }

        private void Bt_cadastrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}