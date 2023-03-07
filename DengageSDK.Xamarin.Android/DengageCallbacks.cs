using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Content;
using DengageSDK.Xamarin.Core;

using Org.Json;
using Laters;
using DengageSDK.Xamarin.Android;

namespace DengageSDK.Xamarin.Android
{
    public partial class DengageImplementation
   {
        private class JavaLaterProxy<TResult> : Java.Lang.Object, ILater<TResult> {
            public event Action<TResult> OnComplete {
                add => _later.OnComplete += value;
                remove => _later.OnComplete -= value;
            }

            public TaskAwaiter<TResult> GetAwaiter() {
                return _later.GetAwaiter();
            }

            protected Later<TResult> _later = new Later<TResult>();
        }

        private static DengageImplementation _instance;

        public DengageImplementation() {
            if (_instance != null) {
                Debug.WriteLine("Additional instance of OneSignalAndroid created.");
            }

            _instance = this;
        }

        
        private sealed class OSPermissionObserver : Com.Dengage.Sdk.Push.NotificationReceiver {
            /// <param name="stateChanges">OSPermissionStateChanges</param>
            public override void OnReceive(Context context, Intent intent)
            {
                base.OnReceive(context, intent);

                if (intent.Action.GetHashCode() == -825236177)

                {
                    //  _instance
                    _instance.recievedNotification.Invoke("");
                   
                }
                else if (intent.Action.GetHashCode() == -520704162)

                {
                    _instance.openedNotification.Invoke("");
                }

            }


        }



    }
}
