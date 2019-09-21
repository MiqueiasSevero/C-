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
    [Activity(Label = "ViewRadioButton", MainLauncher = true, Icon = "@drawable/PROJETO")]
    public class ViewRadioButton : Activity
    {

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            

            base.OnCreate(savedInstanceState);

            // Create your application here

            //Chamando o layuot
            SetContentView(Resource.Layout.ViewRadioButton);
        }
    }
}