using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace DengageSDK.Xamarin.Core
{
    public abstract partial class DengageSDKInternal
    {
        public static DengageSDKInternal _default;

        public static DengageSDKInternal _getDefaultInstance()
        {
            if (_default != null)
                return _default;

            return _default;
        }

        public delegate void PushNotificationRecieved(string pushJson);

        public delegate void PushClickListener(string pushJson);

        public abstract event PushNotificationRecieved recievedNotification;

        public abstract event PushClickListener openedNotification;


        public abstract void init(string dengageFirebaseIntegrationKey, string dengageHuaweiIntegrationKey,bool enableLogs);

        public abstract void setDengageFirebaseIntegrationKey(string dengageIntegrationKey);

        public abstract void setDengageHuaweiIntegrationKey(string dengageHuaweiIntegrationKey);

        public abstract void setContactKey(string contactKey);

        public abstract string getContactKey();

        public abstract void setUserPermission(bool permission);

        public abstract bool getUserPermission();

        public abstract string getToken();

        public abstract void setToken(string token);

        public abstract void setLogStatus(bool isVisible);

        public abstract void registerNotificationListeners();

        public abstract void pageView(Dictionary<string, object> data);

        public abstract void addToCart(Dictionary<string, object> data);

        public abstract void removeFromCart(Dictionary<string, object> data);

        public abstract void viewCart(Dictionary<string, object> data);

        public abstract void beginCheckout(Dictionary<string, object> data);

        public abstract void placeOrder(Dictionary<string, object> data);

        public abstract void cancelOrder(Dictionary<string, object> data);

        public abstract void addToWishList(Dictionary<string, object> data);

        public abstract void removeFromWishList(Dictionary<string, object> data);

        public abstract void search(Dictionary<string, object> data);

        public abstract void sendDeviceEvent(string tableName,Dictionary<string, object> daata);

        public abstract string getSubscription();

        //  handleNotificationActionBlock(callback: (notificationAction: DengageTypes["NotificationAction"]) => void): void; // iOS only,

        public abstract Task<Dictionary<string, object>> getInboxMessages(int number,int limit);

        public abstract void deleteInboxMessage(string id);

        public abstract void setInboxMessageAsClicked(string id);

        public abstract void setNavigation();

        public abstract void setNavigationWithName(string screenName);

        public abstract void onMessageRecieved(Dictionary<string, object> data);

        public abstract void setPartnerDeviceId(string adid);

        public abstract void showRealTimeInApp(string screenName, Dictionary<string, object> data);

        public abstract void setCity(string city);

        public abstract void setState(string state);

        public abstract void setCartAmount(string setCartAmount);

        public abstract void setCartItemCount(string count);

        public abstract void setCategoryPath(string path);

    }
}

