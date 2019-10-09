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

        EditText edit_nome, edit_rua, edit_cidade,edit_numero,edit_senha, edit_bairro;
        Button bt_cad;
        RadioButton rd_f, rd_m;
        TextView mostrar;
        string estado;


        protected override void OnCreate(Bundle savedInstanceState)


        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AtividadeForm);

             sp = FindViewById<Spinner>(Resource.Id.sp_estado);
             edit_nome = FindViewById<EditText>(Resource.Id.edit_nome);
             edit_rua = FindViewById<EditText>(Resource.Id.edit_rua);
             edit_cidade = FindViewById<EditText>(Resource.Id.edit_cidade);
             edit_numero = FindViewById<EditText>(Resource.Id.edit_numero);
             edit_senha = FindViewById<EditText>(Resource.Id.edit_senha);
             edit_bairro = FindViewById<EditText>(Resource.Id.edit_bairro);
             bt_cad = FindViewById<Button>(Resource.Id.bt_cad);
             rd_f = FindViewById<RadioButton>(Resource.Id.rd_f);
             rd_m = FindViewById<RadioButton>(Resource.Id.rd_m);
             
            mostrar = FindViewById<TextView>(Resource.Id.mostra_dados);



            // Create your application here

            adpter = ArrayAdapter.CreateFromResource(this, Resource.Array.estadoXML, Android.Resource.Layout.SimpleExpandableListItem1);
            sp.Adapter = adpter;

            bt_cad.Click += Bt_cad_Click;
            sp.ItemSelected += Sp_ItemSelected;
        }

        private void Sp_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            estado = sp.GetItemAtPosition(e.Position).ToString();
        }

        private void Bt_cad_Click(object sender, EventArgs e)
        {
            if( rd_f.Checked)
            {
                mostrar.Text = " Nome: " + edit_nome.Text + "\n Sexo : Feminino" + "\n Rua:" + edit_rua.Text + "\n Numero:" + edit_numero.Text 
                    + "\n Bairro:" + edit_bairro.Text + "\n Cidade:" + edit_cidade.Text + "\n estado:" + estado;
                (mostrar.Text).ToUpper(); 
            }
            if (rd_m.Checked)
            {
                mostrar.Text = " Nome: " + edit_nome.Text + "\n Sexo : MAsculino" + "\n Rua:" + edit_rua.Text + "\n Numero:" + edit_numero.Text
                   + "\n Bairro:" + edit_bairro.Text + "\n Cidade:" + edit_cidade.Text + "\n estado:" + estado ;
                (mostrar.Text).ToUpper();

            }
        }
    }
}