using Android.App;
using Android.Widget;
using Android.OS;

namespace MOBILENOITE2
{
    [Activity(Label = "MOBILENOITE2", MainLauncher = true)]
    public class MainActivity : Activity


    {
        Button btn;




        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // pegar uma referancia identificador

            btn = FindViewById<Button>(Resource.Id.btn01);

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this,"olá",ToastLength.Short).Show();
        }
    }
}

