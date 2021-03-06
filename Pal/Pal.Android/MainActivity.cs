﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Firebase;
using Plugin.CurrentActivity;

namespace Pal.Droid
{
    [Activity(Label = "Pal", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        public static FirebaseApp app;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            InitiFirebaseAuth();
            Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void InitiFirebaseAuth() {
            var options = new FirebaseOptions.Builder()
                .SetApplicationId("1:561500824016:android:3e9713b097aad310")
                .SetApiKey("AIzaSyAuE_feaACvYJC9bhcLUoqeRlKLpbf4fq0")
                .SetProjectId("palproject-127b0")
                .SetStorageBucket("gs://palproject-127b0.appspot.com")
                .SetDatabaseUrl("https://palproject-127b0.firebaseio.com/")
                .Build();

            if (app == null) {
                app = FirebaseApp.InitializeApp(this,options, "Pal");
            }
        }



    }
}
