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
    [Activity(Label = "AULAS", MainLauncher = true)]
    public class AULAS : Activity
    {
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.AULAS);


            var BtAutoComplet = FindViewById<Button>(Resource.Id.AutoComplet);
            var BtAtividadeAlertDialog = FindViewById<Button>(Resource.Id.AtividadeAlertDialog);
            var BtAtividadeRadioButonImageView = FindViewById<Button>(Resource.Id.AtividadeRadioButonImageView);
            var BtViewAutoCompletTextView = FindViewById<Button>(Resource.Id.ViewAutoCompletTextView);
            var BtViewImageView = FindViewById<Button>(Resource.Id.ViewImageView);
            var BtViewRadioButton = FindViewById<Button>(Resource.Id.ViewRadioButton);
            var BtWidgetAula01 = FindViewById<Button>(Resource.Id.WidgetAula01);
            var BtWiewAlertDialog = FindViewById<Button>(Resource.Id.WiewAlertDialog);
            //delegate
            BtAutoComplet.Click += (senderArg, arg) =>
            {
                // fazer um link para outra tela

                StartActivity(typeof(ViewAutoCompletTextView));
            };
            BtAtividadeAlertDialog.Click += (senderArg, arg) => {

                StartActivity(typeof(Atividade_AlertDialog));

            };


            
        }
    }
}