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
    [Activity(Label = "ViewImageView", MainLauncher = true, Icon = "@drawable/PROJETO")]
    class ViewImageView:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //chamar a tela do xml
            SetContentView(Resource.Layout.ViewImageView);

        }


    }
}