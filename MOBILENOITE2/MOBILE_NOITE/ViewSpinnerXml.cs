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
    [Activity(Label = "ViewSpinnerXml")]
    public class ViewSpinnerXml : Activity
    {
        Spinner sp;
        TextView lbl;
        ArrayAdapter adapter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.ViewSpinner);
            // Pegar o Spinner

            sp = FindViewById<Spinner>(Resource.Id.sp01);

            lbl = FindViewById<TextView>(Resource.Id.lb_sp);

            //Criar array 

            adapter = ArrayAdapter.CreateFromResource(this, Resource.Array.estadoXML, Android.Resource.Layout.SimpleListItem1);

            sp.Adapter = adapter;

            sp.ItemSelected += Sp_ItemSelected;




        }

        private void Sp_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            Spinner cvsp = (Spinner)sender;
            //usar pegar o a posição pelo evento ItemSelectedEventArgs
            //lbl.text = e.Position.ToString();

            // pegar posição peo objeto sender <= nome gen
            // lbl.Text = cvsp.SelectedItemPosition.ToString() + " - "+ cvsp.SelectedItem;
            lbl.Text = cvsp.SelectedItemPosition.ToString()+ " - " + cvsp.GetItemAtPosition(e.Position).ToString();   
        }
    }
}