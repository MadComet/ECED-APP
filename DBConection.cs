﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase;
using Firebase.Firestore;
using AndroidX.AppCompat.App;

namespace ECED_APP
{
    class DBConection : AppCompatActivity
    {
        FirebaseFirestore database;

        public static FirebaseFirestore GetDatabase()
        {
            FirebaseFirestore database;
            var options = new FirebaseOptions.Builder()
                .SetProjectId("eced-e3031")
                .SetApplicationId("eced-e3031")
                .SetApiKey("AIzaSyCcS9iPYxmtL6mbjv9poP_Fk37uWgbYkl8")
                .SetDatabaseUrl("https://eced-e3031.firebaseio.com")
                .SetStorageBucket("eced-e3031.appspot.com")
                .Build();

            var app = FirebaseApp.InitializeApp(this, options);
            database = FirebaseFirestore.GetInstance(app);

            return database;
        }

    }
}