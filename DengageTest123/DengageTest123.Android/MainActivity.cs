using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using DengageSDK.Xamarin;
using Com.Dengage.Sdk;
using Firebase;
namespace DengageTest123.Droid
{
    [Activity(Label = "DengageTest123", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            //Firebase.FirebaseApp.InitializeApp(this);
            // FirebaseApp.InitializeApp(this);
            //  DengageManager.GetInstance(ApplicationContext).SetFirebaseIntegrationKey("L99iAkJ_s_l_hFEGQnfrqECJAJCl030qcvHVvXL1YQN2YK0WSiA8SLtb63qcWhY9wScEJq0aDocmKHy38wybAFAG_p_l_tZNXkWN15XwmF0iGJFEpd48qF_p_l_eMjalp06l_s_l_2wjqDp5dPw3_p_l_r97jWQm_p_l_WBZ2Nk_s_l_hw_e_q__e_q_").SetHuaweiIntegrationKey("jjjk").SetLogStatus((Java.Lang.Boolean)true).Init();
            //DengageCoordinator.Default.init("bbkj", "njkj", true);
            //  DengageManager.GetInstance(ApplicationContext).OnNewToken("dasdasdad");
            //DengageManager.GetInstance(ApplicationContext).SetContactKey("testingXadasdmarin");
            //Dengage.Instance.SetContactKey("hasnainTestingjnkjn");
            DengageManager.GetInstance(ApplicationContext).SetNavigation(this);
         
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
