using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin_Android_LoginSystem
{
    [Activity(Label = "Xamarin_Android_LoginSystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private Button mBtnSignUp;

        protected override void OnCreate(Bundle bundle)
        {


            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);

            mBtnSignUp.Click += (object sender, System.EventArgs e) =>
            {
                // Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");
            };
        }
    }
}

