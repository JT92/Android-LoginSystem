using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin_Android_LoginSystem
{
    [Activity(Label = "Xamarin_Android_LoginSystem", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
        }
    }
}

