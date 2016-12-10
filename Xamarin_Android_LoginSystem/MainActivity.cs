using Android.App;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace Xamarin_Android_LoginSystem
{
    [Activity(Label = "Xamarin_Android_LoginSystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        
        private Button mBtnSignUp;
        private ProgressBar mProgressBar;


        protected override void OnCreate(Bundle bundle)
        {


            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mBtnSignUp = FindViewById<Button>(Resource.Id.btnSignUp);
            mProgressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);

            mBtnSignUp.Click += (object sender, System.EventArgs e) =>
            {
                // Pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");

                signUpDialog.mOnSignUpComplete += SignUpDialog_mOnSignUpComplete;
            };
        }

        private void SignUpDialog_mOnSignUpComplete(object sender, OnSignUpEventArgs e)
        {
            mProgressBar.Visibility = Android.Views.ViewStates.Visible;
            Thread thread = new Thread(ActLikeARequest);
            thread.Start();
        }

        private void ActLikeARequest()
        {
            Thread.Sleep(3000);
            RunOnUiThread( () => mProgressBar.Visibility = Android.Views.ViewStates.Invisible );
        }

    }
}

