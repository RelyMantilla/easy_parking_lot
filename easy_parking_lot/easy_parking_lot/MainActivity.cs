using Android.App;
using Android.Widget;
using Android.OS;

namespace easy_parking_lot
{
    [Activity(Label = "easy_parking_lot", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}

