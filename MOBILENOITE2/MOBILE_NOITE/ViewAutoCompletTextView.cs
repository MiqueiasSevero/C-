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
    [Activity(Label = "ViewAutoCompletTextView")]
    public class ViewAutoCompletTextView : Activity
    {

        static string[] estado = new string[] {
            "Acre","Alagoas","Amapá","Amazonas","Bahia","Ceará","Distrito Federal","Espírito Santo"


            };
        AutoCompleteTextView AutoC;
       static  ArrayAdapter <String> adaptador;

    protected override void OnCreate(Bundle savedInstanceState)


        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ViewAutoCompletTextView);
            AutoC = FindViewById<AutoCompleteTextView>(Resource.Id.AutoComplete);
            adaptador = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, estado);
            AutoC.Adapter = adaptador;


            
        }
    }
}