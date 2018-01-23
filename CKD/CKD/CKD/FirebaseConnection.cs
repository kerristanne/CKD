using System;
using System.Collections.Generic;
using System.Text;
using Firebase;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Analytics;
using Firebase.Database.Query;

namespace CKD
{
    class FirebaseConnection
    {
        private static FirebaseConnection instance;

        public static User curUser;

        public static ChildQuery dataNode;
        public static ChildQuery usersNode;
        static FirebaseApp fireApp;
        public static FirebaseAuth auth;

    }
}
