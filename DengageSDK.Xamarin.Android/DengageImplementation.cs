using System;
using DengageSDK.Xamarin.Core;
using Com.Dengage.Sdk;
using Android.App;
using Android.Content;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DengageSDK.Xamarin.Android
{
	public partial class DengageImplementation :DengageSDKInternal
	{


   
        public override event PushNotificationRecieved recievedNotification;
        public override event PushClickListener openedNotification;

        public override void addToCart(Dictionary<string, object> data)
        {

            Dengage.Instance.AddToCart((IDictionary<string, Java.Lang.Object>)data, Application.Context);
        }

        public override void addToWishList(Dictionary<string, object> data)
        {
            Dengage.Instance.AddToWishList((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void beginCheckout(Dictionary<string, object> data)
        {
            Dengage.Instance.BeginCheckout((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void cancelOrder(Dictionary<string, object> data)
        {
            Dengage.Instance.CancelOrder((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void deleteInboxMessage(string id)
        {
            DengageManager.GetInstance(Application.Context).DeleteInboxMessage(id);
        }

        public override string getContactKey()
        {
            return DengageManager.GetInstance(Application.Context).Subscription.ContactKey;

        }

        public override Task<Dictionary<string, object>> getInboxMessages(int number, int limit)
        {
            throw new NotImplementedException();
        }

        public override string getSubscription()
        {
            return Dengage.Instance.Subscription.ToString();

        }

        public override string getToken()
        {
            return DengageManager.GetInstance(Application.Context).Token;
        }

        public override bool getUserPermission()
        {
            return (bool)DengageManager.GetInstance(Application.Context).UserPermission;
        }

        public override void init(string dengageFirebaseIntegrationKey, string dengageHuaweiIntegrationKey, bool enableLogs)
        {
            DengageManager.GetInstance(Application.Context).SetFirebaseIntegrationKey(dengageFirebaseIntegrationKey).SetHuaweiIntegrationKey(dengageHuaweiIntegrationKey).SetLogStatus((Java.Lang.Boolean)enableLogs).Init();

        }

        public override void onMessageRecieved(Dictionary<string, object> data)
        {
            DengageManager.GetInstance(Application.Context).OnMessageReceived((IDictionary<string, string>)data);
        }

        public override void pageView(Dictionary<string, object> data)
        {
            Dengage.Instance.PageView((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void placeOrder(Dictionary<string, object> data)
        {
            Dengage.Instance.Order((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void registerNotificationListeners()
        {
            IntentFilter intentFilter = new IntentFilter();

            intentFilter.AddAction("com.dengage.push.intent.RECEIVE");
            intentFilter.AddAction("com.dengage.push.intent.OPEN");
            Application.Context.RegisterReceiver(new OSPermissionObserver(),intentFilter);
        }

        public override void removeFromCart(Dictionary<string, object> data)
        {
            Dengage.Instance.RemoveFromCart((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void removeFromWishList(Dictionary<string, object> data)
        {
            Dengage.Instance.RemoveFromWishList((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void search(Dictionary<string, object> data)
        {
            Dengage.Instance.Search((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void sendDeviceEvent(string tableName, Dictionary<string, object> data)
        {
            Dengage.Instance.SendDeviceEvent(tableName, (IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void setCartAmount(string cartAmount)
        {
            Dengage.Instance.SetCartAmount(cartAmount);
        }

        public override void setCartItemCount(string count)
        {
            Dengage.Instance.SetCartItemCount(count);
        }

        public override void setCategoryPath(string path)
        {
            Dengage.Instance.SetCategoryPath(path);
        }

        public override void setCity(string city)
        {
            Dengage.Instance.SetCity(city);
        }

        public override void setContactKey(string contactKey)
        {
            Dengage.Instance.SetContactKey(contactKey);
        }

        public override void setDengageFirebaseIntegrationKey(string dengageIntegrationKey)
        {
            Dengage.Instance.SetFirebaseIntegrationKey(dengageIntegrationKey);
        }

        public override void setDengageHuaweiIntegrationKey(string dengageHuaweiIntegrationKey)
        {
            Dengage.Instance.SetFirebaseIntegrationKey(dengageHuaweiIntegrationKey);
            
        }

        public override void setInboxMessageAsClicked(string id)
        {
            Dengage.Instance.SetInboxMessageAsClicked(id);
        }

        public override void setLogStatus(bool isVisible)
        {
            Dengage.Instance.SetLogStatus(isVisible);
        }

        public override void setNavigation()
        {
            Dengage.Instance.SetNavigation(Platform.CurrentActivity, -1); 
        }

        public override void setNavigationWithName(string screenName)
        {
            Dengage.Instance.SetNavigation(Platform.CurrentActivity,screenName, -1);
        }

        public override void setPartnerDeviceId(string adid)
        {
            Dengage.Instance.SetPartnerDeviceId(adid);
        }

        public override void setState(string state)
        {
            Dengage.Instance.SetState(state);
        }

        public override void setToken(string token)
        {
            Dengage.Instance.OnNewToken(token);
        }

        public override void setUserPermission(bool permission)
        {
            Dengage.Instance.SetUserPermission(permission);
        }

        public override void showRealTimeInApp(string screenName, Dictionary<string, object> data)
        {
            Dengage.Instance.Search((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

        public override void viewCart(Dictionary<string, object> data)
        {
            Dengage.Instance.Search((IDictionary<string, Java.Lang.Object>)data, Application.Context);

        }

       
    }

   
}

