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
            var btViewSpinner = FindViewById<Button>(Resource.Id.btViewSpinner);
            // 1º 
            var btComp = FindViewById<Button>(Resource.Id.AutoComplet);

            //2º AULA AUTOCOMPLETE XML
            Button btCompXML = FindViewById<Button>(Resource.Id.AutoCompletXML);
            // EVENTO 
            //1º
            btComp.Click += (sender, arg) => {
                // fazer um link(chamar tela)
                StartActivity(typeof(ViewAutoCompletTextView));

            };

            //2º
            btCompXML.Click += (x, y) => {
                //chamando a tela autocompetxml(link)
                StartActivity(typeof(ViewAutoCompletTextViewXML));
            };

            btViewSpinner.Click += (seder, arg) =>
            {
                StartActivity(typeof(ViewSpinner));
            };

        }
    }
}