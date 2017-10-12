using Android.App;
using Android.OS;

namespace SampleApp
{
    [Activity(Label = "SampleApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.activity_main);

            //EditText numInput = FindViewById<EditText>(R.id.numInput);

            //Button button = FindViewById<Button>(R.id.btnSetBadge);
            //            button.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View v)
            //            {
            //                int badgeCount = 0;
            //                try
            //                {
            //                    badgeCount = Integer.parseInt(numInput.getText().toString());
            //                }
            //                catch (NumberFormatException e)
            //                {
            //                    Toast.makeText(getApplicationContext(), "Error input", Toast.LENGTH_SHORT).show();
            //                }

            //                boolean success = ShortcutBadger.applyCount(MainActivity.this, badgeCount);

            //                Toast.makeText(getApplicationContext(), "Set count=" + badgeCount + ", success=" + success, Toast.LENGTH_SHORT).show();
            //            }
            //        });

            //        Button launchNotification = (Button)findViewById(R.id.btnSetBadgeByNotification);
            //        launchNotification.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View v)
            //        {
            //            int badgeCount = 0;
            //            try
            //            {
            //                badgeCount = Integer.parseInt(numInput.getText().toString());
            //            }
            //            catch (NumberFormatException e)
            //            {
            //                Toast.makeText(getApplicationContext(), "Error input", Toast.LENGTH_SHORT).show();
            //            }

            //            finish();
            //            startService(
            //                new Intent(MainActivity.this, BadgeIntentService.class).putExtra("badgeCount", badgeCount)
            //                );
            //            }
            //});

            //        Button removeBadgeBtn = (Button)findViewById(R.id.btnRemoveBadge);
            //removeBadgeBtn.setOnClickListener(new View.OnClickListener() {
            //            @Override
            //            public void onClick(View view)
            //{
            //    boolean success = ShortcutBadger.removeCount(MainActivity.this);

            //    Toast.makeText(getApplicationContext(), "success=" + success, Toast.LENGTH_SHORT).show();
            //}
            //        });


            //        //find the home launcher Package
            //        Intent intent = new Intent(Intent.ACTION_MAIN);
            //intent.addCategory(Intent.CATEGORY_HOME);
            //        ResolveInfo resolveInfo = getPackageManager().resolveActivity(intent, PackageManager.MATCH_DEFAULT_ONLY);
            //String currentHomePackage = resolveInfo.activityInfo.packageName;

            //TextView textViewHomePackage = (TextView)findViewById(R.id.textViewHomePackage);
            //textViewHomePackage.setText("launcher:" + currentHomePackage);
            //        }
            //    }
        }
    }
}