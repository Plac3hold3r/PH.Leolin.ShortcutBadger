
using Android.App;
using Android.Content;
using Leolin.Shortcutbadger;

namespace SampleApp
{
    internal class BadgeIntentService : IntentService
    {
        private int notificationId = 0;
        private NotificationManager _notificationManager;

        public BadgeIntentService() : base("BadgeIntentService")
        {
        }

        public override void OnStart(Intent intent, int startId)
        {
            base.OnStart(intent, startId);

            _notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
        }

        protected override void OnHandleIntent(Intent intent)
        {
            if (intent != null)
            {
                int badgeCount = intent.GetIntExtra("badgeCount", 0);

                _notificationManager.Cancel(notificationId);
                notificationId++;

                Notification.Builder builder = new Notification.Builder(ApplicationContext)
                    .SetContentTitle("Increment count");

                Notification notification = builder.Build();
                ShortcutBadger.ApplyNotification(ApplicationContext, notification, badgeCount);
                _notificationManager.Notify(notificationId, notification);
            }
        }
    }
}