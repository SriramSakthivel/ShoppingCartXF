using Android.App;
using Android.OS;
using Xamarin.Forms.Platform.Android;

namespace ShoppingCart.Droid
{
    [Activity(Label = "ShoppingCart"
        , MainLauncher = true
        //, Theme = @"@style/AppTheme"
        )]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Xamarin.Forms.Forms.Init(this, bundle);
            App.Init(new DroidSetup());
            LoadApplication(new App());
        }
    }
}