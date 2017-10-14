using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using Leolin.Shortcutbadger;

namespace SampleApp
{
    [Activity(
        MainLauncher = true,
        Label = "@string/app_name",
        Icon = "@mipmap/ic_launcher")]
    public class MainActivity : Activity
    {
        private EditText _numInput;
        private Button _btnSetBadge;
        private Button _launchNotification;
        private Button _removeBadgeBtn;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            _numInput = FindViewById<EditText>(Resource.Id.numInput);

            _btnSetBadge = FindViewById<Button>(Resource.Id.btnSetBadge);
            _btnSetBadge.Click += Button_Click;

            _launchNotification = FindViewById<Button>(Resource.Id.btnSetBadgeByNotification);
            _launchNotification.Click += LaunchNotification_Click;

            _removeBadgeBtn = FindViewById<Button>(Resource.Id.btnRemoveBadge);
            _removeBadgeBtn.Click += RemoveBadgeBtn_Click;

            //find the home launcher Package
            Intent intent = new Intent(Intent.ActionMain);
            intent.AddCategory(Intent.CategoryHome);
            ResolveInfo resolveInfo = PackageManager.ResolveActivity(intent, PackageInfoFlags.MatchDefaultOnly);
            var currentHomePackage = resolveInfo.ActivityInfo.PackageName;

            TextView textViewHomePackage = FindViewById<TextView>(Resource.Id.textViewHomePackage);
            textViewHomePackage.Text = "launcher:" + currentHomePackage;
        }

        private void RemoveBadgeBtn_Click(object sender, System.EventArgs e)
        {
            bool success = ShortcutBadger.RemoveCount(this);

            Toast.MakeText(ApplicationContext, "success=" + success, ToastLength.Short)
                .Show();
        }

        private void LaunchNotification_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(_numInput.Text, out int badgeCount))
            {
                Finish();

                var intent = new Intent(this, typeof(MainActivity));
                intent.PutExtra("badgeCount", badgeCount);
                StartService(intent);
            }
            else
            {
                Toast.MakeText(ApplicationContext, "Error input", ToastLength.Short)
                    .Show();
            }
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(_numInput.Text, out int badgeCount))
            {
                bool success = ShortcutBadger.ApplyCount(this, badgeCount);
                Toast.MakeText(ApplicationContext, "Set count=" + badgeCount + ", success=" + success, ToastLength.Short)
                    .Show();
            }
            else
            {
                Toast.MakeText(ApplicationContext, "Error input", ToastLength.Short)
                    .Show();
            }
        }
    }
}