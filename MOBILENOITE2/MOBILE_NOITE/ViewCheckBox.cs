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
    [Activity(Label = "ViewCheckBox")]
    public class ViewCheckBox : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ViewCheckBox);


            // Create your application here

            var chk_php = FindViewById<CheckBox>(Resource.Id.chk_php);
            var chk_java = FindViewById<CheckBox>(Resource.Id.chk_java);
            var chk_mysql = FindViewById<CheckBox>(Resource.Id.chk_mysql);
            var chk_c = FindViewById<CheckBox>(Resource.Id.chk_c);
            var chk_cobol = FindViewById<CheckBox>(Resource.Id.chk_cobol);
            var chk_css = FindViewById<CheckBox>(Resource.Id.chk_css);
            var chk_angula = FindViewById<CheckBox>(Resource.Id.chk_angula);
            var chk_react = FindViewById<CheckBox>(Resource.Id.chk_react);
            var chk_vue = FindViewById<CheckBox>(Resource.Id.chk_vue);
            var chk_js = FindViewById<CheckBox>(Resource.Id.chk_js);
            var chk_jquery = FindViewById<CheckBox>(Resource.Id.chk_jquery);


            //delegate
            chk_php.Click += (alpha, omega) => {
                if (chk_php.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_php.Text);
                    alert.Show();
                } 
            };

            chk_java.Click += (alpha, omega) => {
                if (chk_java.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_java.Text);
                    alert.Show();
                }
            };

            chk_mysql.Click += (alpha, omega) => {
                if (chk_mysql.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_mysql.Text);
                    alert.Show();
                }
            };

            chk_c.Click += (alpha, omega) => {
                if (chk_c.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_c.Text);
                    alert.Show();
                }
            };

            chk_cobol.Click += (alpha, omega) => {
                if (chk_cobol.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_cobol.Text);
                    alert.Show();
                }
            };

            chk_css.Click += (alpha, omega) => {
                if (chk_css.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_css.Text);
                    alert.Show();
                }
            };

            chk_angula.Click += (alpha, omega) => {
                if (chk_angula.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_angula.Text);
                    alert.Show();
                }
            };

            chk_react.Click += (alpha, omega) => {
                if (chk_react.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_react.Text);
                    alert.Show();
                }
            };

            chk_vue.Click += (alpha, omega) => {
                if (chk_vue.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_vue.Text);
                    alert.Show();
                }
            };


            chk_js.Click += (alpha, omega) => {
                 if (chk_js.Checked)
                 {
                     AlertDialog.Builder alert = new AlertDialog.Builder(this);
                     alert.SetMessage(chk_js.Text);
                     alert.Show();
                 }
             };
            chk_jquery.Click += (alpha, omega) => {
                if (chk_jquery.Checked)
                {
                    AlertDialog.Builder alert = new AlertDialog.Builder(this);
                    alert.SetMessage(chk_jquery.Text);
                    alert.Show();
                }
            };

        }

      
    }
}