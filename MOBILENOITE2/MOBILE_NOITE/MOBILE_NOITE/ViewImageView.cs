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
using Android.Graphics.Drawables;

namespace MOBILE_NOITE
{
    [Activity(Label = "ViewImageView", MainLauncher = false, Icon = "@drawable/PROJETO")]
    class ViewImageView : Activity {
        ImageButton img01, img02, img03;
        ImageView imgCentral;
        Drawable caminho;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //chamar a tela do xml
            SetContentView(Resource.Layout.ViewImageView);

            //referenciar os elementos xml com c#

            img01 = FindViewById<ImageButton>(Resource.Id.imgBt1);
            img02 = FindViewById<ImageButton>(Resource.Id.imgBt2);
            img03 = FindViewById<ImageButton>(Resource.Id.imgBt3);

            imgCentral = FindViewById<ImageView>(Resource.Id.imgCentral);

            //evento do botão
            img01.Click += Img01_Click;
            img02.Click += Img02_Click;
            img03.Click += Img03_Click;

        }

        private void Img03_Click(object sender, EventArgs e)
        {
            //colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.pessoa);

            // colocar na imagem maior 

            imgCentral.SetImageDrawable(caminho);

        }

        private void Img02_Click(object sender, EventArgs e)
        {
            //colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.logo01);

            // colocar na imagem maior 

            imgCentral.SetImageDrawable(caminho);
        }

        private void Img01_Click(object sender, EventArgs e)
        {

            //colocar a referencia do caminho da imagem grande
            caminho = Resources.GetDrawable(Resource.Drawable.android);

            // colocar na imagem maior 

            imgCentral.SetImageDrawable(caminho); 

            
        }
    }
}