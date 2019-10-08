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
    [Activity(Label = "AtividedeForm")]
    public class AtividedeForm : Activity
    {

        Spinner sp;
        ArrayAdapter adpter;

        protected override void OnCreate(Bundle savedInstanceState)


        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtividadeForm);

            sp = FindViewById<Spinner>(Resource.Id.sp_estado);
            EditText edit_nome = FindViewById<EditText>(Resource.Id.edit_nome);
            EditText edit_rua = FindViewById<EditText>(Resource.Id.edit_rua);
            EditText edit_cidade = FindViewById<EditText>(Resource.Id.edit_cidade);
            EditText edit_numero = FindViewById<EditText>(Resource.Id.edit_numero);
            EditText edit_senha = FindViewById<EditText>(Resource.Id.edit_senha);
            EditText edit_bairro = FindViewById<EditText>(Resource.Id.edit_bairro);
            Button bt_cad = FindViewById<Button>(Resource.Id.bt_cad);
            RadioButton rd_f = FindViewById<RadioButton>(Resource.Id.rd_f);
            RadioButton rd_m = FindViewById<RadioButton>(Resource.Id.rd_m);



            // Create your application here

            adpter = ArrayAdapter.CreateFromResource(this, Resource.Array.estadoXML, Android.Resource.Layout.SimpleExpandableListItem1);
            sp.Adapter = adpter;

            bt_cad.Click += Bt_cad_Click;
        }

        private void Bt_cad_Click(object sender, EventArgs e)
        {
            if()
            {

            }
        }
    }
}