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
    [Activity(Label = "WiewAlertDialog",MainLauncher = false, Icon ="@drawable/PROJETO")]
    public class WiewAlertDialog : Activity
    {
        Button btAlert, btToast, btYesNo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // cs chamar o xml
            SetContentView(Resource.Layout.WiewAlertDialog);
            // pegar  o botão do xml
            btToast = FindViewById<Button>(Resource.Id.btToast);
            btAlert = FindViewById<Button>(Resource.Id.btAlert);
            btYesNo = FindViewById<Button>(Resource.Id.btAlertaOkNo);

            // EVENTO DO BOTÃO
            btToast.Click += BtToast_Click;
            btAlert.Click += BtAlert_Click;
            btYesNo.Click += BtYesNo_Click;




        }

        private void BtYesNo_Click(object sender, EventArgs e)
        {
            //objeto
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            //titulo
            alerta.SetTitle("Yes No");
            // icon 
            alerta.SetIcon(Android.Resource.Drawable.IcMenuSave);

            //ms
            alerta.SetMessage("Deseja Salvar");

            //yes no

            alerta.SetPositiveButton("Yes",(senderAlert, arg) => {

                Toast.MakeText(this, "Salvo!", ToastLength.Short).Show() ;
                



            });
            alerta.SetNegativeButton("No", (senderAlert, arg) =>
             {
                 Toast.MakeText(this, "Não foi Salvo!", ToastLength.Short).Show();
             });


            //show 


            alerta.Show();

        }

        private void BtToast_Click(object sender, EventArgs e)
        {
            // MENSAGEM NUVENS
            Toast.MakeText(this, "ALERTA DE MENSAGEM",
                ToastLength.Long).Show();
        }
         private void BtAlert_Click(object sender, EventArgs e)
        {
            // objeto alert
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);

            // titulo para caixa do alerta
            alerta.SetTitle("Título da Caixa");
            //mensagem da caixa de alerta
            alerta.SetMessage("Alerta de mensagem");
            //icones da caixa
            alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            //exibir 
            alerta.Show();

        }

    }
}