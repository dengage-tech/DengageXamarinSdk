; ModuleID = 'obj/Debug/android/marshal_methods.arm64-v8a.ll'
source_filename = "obj/Debug/android/marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [278 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 58
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 22
	i64 210515253464952879, ; 2: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 47
	i64 232391251801502327, ; 3: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 80
	i64 277919213158076975, ; 4: Square.OkHttp3.LoggingInterceptor.dll => 0x3db5e0d488b122f => 25
	i64 295915112840604065, ; 5: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 81
	i64 316157742385208084, ; 6: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 52
	i64 435170709725415398, ; 7: Xamarin.GooglePlayServices.Location => 0x60a097471d687e6 => 116
	i64 634308326490598313, ; 8: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 67
	i64 687654259221141486, ; 9: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 113
	i64 702024105029695270, ; 10: System.Drawing.Common => 0x9be17343c0e7726 => 133
	i64 720058930071658100, ; 11: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 61
	i64 872800313462103108, ; 12: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 57
	i64 911299012640787987, ; 13: DengageTest123 => 0xca5959fac9e4e13 => 5
	i64 940822596282819491, ; 14: System.Transactions => 0xd0e792aa81923a3 => 131
	i64 996343623809489702, ; 15: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 105
	i64 1000557547492888992, ; 16: Mono.Security.dll => 0xde2b1c9cba651a0 => 138
	i64 1034384054734877684, ; 17: DengageSDK.Xamarin.Android.dll => 0xe5aded13fccf3f4 => 3
	i64 1120440138749646132, ; 18: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 110
	i64 1315114680217950157, ; 19: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 42
	i64 1425944114962822056, ; 20: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 1
	i64 1465843056802068477, ; 21: Xamarin.Firebase.Components.dll => 0x1457b87e6928f7fd => 93
	i64 1579468382457870329, ; 22: Xamarin.GooglePlayServices.Places.PlaceReport => 0x15eb66201e5cb7f9 => 117
	i64 1624659445732251991, ; 23: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 40
	i64 1628611045998245443, ; 24: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 69
	i64 1636321030536304333, ; 25: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 62
	i64 1795316252682057001, ; 26: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 41
	i64 1836611346387731153, ; 27: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 80
	i64 1837131419302612636, ; 28: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x197ecd4ad53dce9c => 108
	i64 1875917498431009007, ; 29: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 38
	i64 1981742497975770890, ; 30: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 68
	i64 2061151250911352171, ; 31: Huawei.Hms.Log => 0x1c9aae246aec556b => 16
	i64 2064708342624596306, ; 32: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 124
	i64 2136356949452311481, ; 33: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 73
	i64 2165725771938924357, ; 34: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 45
	i64 2262844636196693701, ; 35: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 57
	i64 2284400282711631002, ; 36: System.Web.Services => 0x1fb3d1f42fd4249a => 137
	i64 2329709569556905518, ; 37: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 65
	i64 2470498323731680442, ; 38: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 51
	i64 2479423007379663237, ; 39: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 85
	i64 2497223385847772520, ; 40: System.Runtime => 0x22a7eb7046413568 => 34
	i64 2547086958574651984, ; 41: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 37
	i64 2568489860015129477, ; 42: Huawei.Hms.Availableupdate.dll => 0x23a51beb53650385 => 12
	i64 2592350477072141967, ; 43: System.Xml.dll => 0x23f9e10627330e8f => 35
	i64 2624866290265602282, ; 44: mscorlib.dll => 0x246d65fbde2db8ea => 23
	i64 2694427813909235223, ; 45: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 77
	i64 2776255433543154418, ; 46: Huawei.Hmf.Tasks.dll => 0x26873d9b8a167af2 => 11
	i64 2960931600190307745, ; 47: Xamarin.Forms.Core => 0x2917579a49927da1 => 103
	i64 3017704767998173186, ; 48: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 110
	i64 3070901203286954241, ; 49: Square.OkIO.JVM => 0x2a9e085fc23d1101 => 26
	i64 3143515969535650208, ; 50: Xamarin.Firebase.Encoders => 0x2ba0031e85f0a9a0 => 95
	i64 3289520064315143713, ; 51: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 64
	i64 3303437397778967116, ; 52: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 39
	i64 3311221304742556517, ; 53: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 33
	i64 3344514922410554693, ; 54: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 127
	i64 3364695309916733813, ; 55: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 92
	i64 3411255996856937470, ; 56: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 114
	i64 3493805808809882663, ; 57: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 83
	i64 3522470458906976663, ; 58: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 82
	i64 3531994851595924923, ; 59: System.Numerics => 0x31042a9aade235bb => 32
	i64 3571415421602489686, ; 60: System.Runtime.dll => 0x319037675df7e556 => 34
	i64 3667526520489045555, ; 61: Huawei.Agconnect.AgconnectCore.dll => 0x32e5abf06212ee33 => 8
	i64 3716579019761409177, ; 62: netstandard.dll => 0x3393f0ed5c8c5c99 => 129
	i64 3727469159507183293, ; 63: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 79
	i64 3772598417116884899, ; 64: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 58
	i64 3859219695630330898, ; 65: Xamarin.GooglePlayServices.Ads.Identifier => 0x358eb3ddbc3cac12 => 112
	i64 4055376381221176420, ; 66: Huawei.Hms.NetworkGrs.dll => 0x3847975519328464 => 18
	i64 4063407939301069584, ; 67: DengageSDK.Xamarin.Android => 0x38641ffdef8ad310 => 3
	i64 4201423742386704971, ; 68: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 52
	i64 4239882675311405204, ; 69: Xamarin.Firebase.Encoders.JSON => 0x3ad716d44f44e894 => 96
	i64 4247996603072512073, ; 70: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 119
	i64 4335356748765836238, ; 71: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3c2a47fe48c7b3ce => 108
	i64 4525561845656915374, ; 72: System.ServiceModel.Internals => 0x3ece06856b710dae => 128
	i64 4602318871630440712, ; 73: Square.Retrofit2.ConverterGson => 0x3fdeb8a12e9be908 => 27
	i64 4636684751163556186, ; 74: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 87
	i64 4702770163853758138, ; 75: Xamarin.Firebase.Components => 0x4143988c34cf0eba => 93
	i64 4708653840312162517, ; 76: Square.OkHttp3 => 0x41587fb86215d8d5 => 24
	i64 4782108999019072045, ; 77: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 44
	i64 4794310189461587505, ; 78: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 37
	i64 4795410492532947900, ; 79: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 82
	i64 5142919913060024034, ; 80: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 104
	i64 5203618020066742981, ; 81: Xamarin.Essentials => 0x4836f704f0e652c5 => 90
	i64 5205316157927637098, ; 82: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 71
	i64 5348796042099802469, ; 83: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 72
	i64 5376510917114486089, ; 84: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 85
	i64 5408338804355907810, ; 85: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 84
	i64 5451019430259338467, ; 86: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 50
	i64 5507995362134886206, ; 87: System.Core.dll => 0x4c705499688c873e => 29
	i64 5692067934154308417, ; 88: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 89
	i64 5757522595884336624, ; 89: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 48
	i64 5814345312393086621, ; 90: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 77
	i64 5880868220621719076, ; 91: Huawei.Android.Hms.SecuritySsl.dll => 0x519d0a7d0d0a8624 => 10
	i64 5896680224035167651, ; 92: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 66
	i64 6085203216496545422, ; 93: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 105
	i64 6086316965293125504, ; 94: FormsViewGroup.dll => 0x5476f10882baef80 => 6
	i64 6092862891035488599, ; 95: Xamarin.Firebase.Measurement.Connector.dll => 0x548e32849d547157 => 101
	i64 6319713645133255417, ; 96: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 67
	i64 6401687960814735282, ; 97: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 65
	i64 6479910363780928313, ; 98: Huawei.Android.Hms.SecuritySsl => 0x59ed4424d188d339 => 10
	i64 6504860066809920875, ; 99: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 45
	i64 6548213210057960872, ; 100: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 55
	i64 6554405243736097249, ; 101: Xamarin.GooglePlayServices.Stats => 0x5af5ecd7aad901e1 => 118
	i64 6591024623626361694, ; 102: System.Web.Services.dll => 0x5b7805f9751a1b5e => 137
	i64 6659513131007730089, ; 103: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 61
	i64 6737082967062634076, ; 104: Xamarin.GooglePlayServices.Ads.Identifier.dll => 0x5d7eed43921a5e5c => 112
	i64 6876862101832370452, ; 105: System.Xml.Linq => 0x5f6f85a57d108914 => 36
	i64 6878582369430612696, ; 106: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x5f75a238802d2ad8 => 109
	i64 6894844156784520562, ; 107: System.Numerics.Vectors => 0x5faf683aead1ad72 => 33
	i64 6966524777701515715, ; 108: Square.Retrofit2.dll => 0x60ae116005db21c3 => 28
	i64 6975328107116786489, ; 109: Xamarin.Firebase.Annotations => 0x60cd57f4e07e7339 => 91
	i64 7026573318513401069, ; 110: Xamarin.Firebase.Encoders.Proto.dll => 0x618367346e3a9ced => 97
	i64 7036436454368433159, ; 111: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 63
	i64 7103753931438454322, ; 112: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 60
	i64 7345470581440696094, ; 113: Xamarin.GooglePlayServices.Places.PlaceReport.dll => 0x65f05a936adacf1e => 117
	i64 7385250113861300937, ; 114: Xamarin.Firebase.Iid.Interop.dll => 0x667dadd98e1db2c9 => 98
	i64 7476537270401454554, ; 115: Xamarin.Firebase.Encoders.JSON.dll => 0x67c1ff08f83f51da => 96
	i64 7488575175965059935, ; 116: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 36
	i64 7519520127843456963, ; 117: Square.Retrofit2 => 0x685ab3b7558257c3 => 28
	i64 7597461940722703533, ; 118: Dengage.Android.Binding.dll => 0x696f9b61cb539cad => 2
	i64 7635363394907363464, ; 119: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 103
	i64 7637365915383206639, ; 120: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 90
	i64 7654504624184590948, ; 121: System.Net.Http => 0x6a3a4366801b8264 => 31
	i64 7735352534559001595, ; 122: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 123
	i64 7784126582539947449, ; 123: Huawei.Hms.Base => 0x6c06c5e27ef80db9 => 13
	i64 7820441508502274321, ; 124: System.Data => 0x6c87ca1e14ff8111 => 130
	i64 7836164640616011524, ; 125: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 40
	i64 7904570928025870493, ; 126: Xamarin.Firebase.Installations => 0x6db2ad60fadca09d => 99
	i64 7940488133782528123, ; 127: Xamarin.GooglePlayServices.CloudMessaging => 0x6e3247e31d4fe07b => 115
	i64 7969431548154767168, ; 128: Xamarin.Firebase.Installations.dll => 0x6e991bc4e98e6740 => 99
	i64 8003335089973143038, ; 129: Square.OkHttp3.dll => 0x6f118edc6044a5fe => 24
	i64 8044118961405839122, ; 130: System.ComponentModel.Composition => 0x6fa2739369944712 => 136
	i64 8083354569033831015, ; 131: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 64
	i64 8103644804370223335, ; 132: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 132
	i64 8167236081217502503, ; 133: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 21
	i64 8187640529827139739, ; 134: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 126
	i64 8375317123763839630, ; 135: Huawei.Hms.Device => 0x743b1a8cbb30a28e => 14
	i64 8398329775253868912, ; 136: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 49
	i64 8400357532724379117, ; 137: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 76
	i64 8465511506719290632, ; 138: Xamarin.Firebase.Messaging.dll => 0x757b89dcf7fc3508 => 102
	i64 8518502242792458212, ; 139: Huawei.Hms.Device.dll => 0x7637cca8280347e4 => 14
	i64 8601935802264776013, ; 140: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 84
	i64 8626175481042262068, ; 141: Java.Interop => 0x77b654e585b55834 => 21
	i64 8639588376636138208, ; 142: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 75
	i64 8684531736582871431, ; 143: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 135
	i64 8822867224128132893, ; 144: Huawei.Android.Hms.SecurityEncrypt.dll => 0x7a711efeaa98171d => 9
	i64 8853378295825400934, ; 145: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 122
	i64 9208617599024262721, ; 146: DengageTest123.Android.dll => 0x7fcb94eabe406e41 => 0
	i64 9244338242424394172, ; 147: Huawei.Hms.NetworkGrs => 0x804a7ca72343d1bc => 18
	i64 9312692141327339315, ; 148: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 89
	i64 9324707631942237306, ; 149: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 41
	i64 9584844145778348050, ; 150: Dengage.Android.Binding => 0x850434f7c899d012 => 2
	i64 9662334977499516867, ; 151: System.Numerics.dll => 0x8617827802b0cfc3 => 32
	i64 9678050649315576968, ; 152: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 51
	i64 9711637524876806384, ; 153: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 72
	i64 9735414641753518179, ; 154: Xamarin.Firebase.Encoders.Proto => 0x871b240946daf063 => 97
	i64 9774216967140627647, ; 155: Xamarin.Firebase.Datatransport.dll => 0x87a4fe8bac0354bf => 94
	i64 9796610708422913120, ; 156: Xamarin.Firebase.Iid.Interop => 0x87f48d88de55ec60 => 98
	i64 9808709177481450983, ; 157: Mono.Android.dll => 0x881f890734e555e7 => 22
	i64 9825649861376906464, ; 158: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 48
	i64 9834056768316610435, ; 159: System.Transactions.dll => 0x8879968718899783 => 131
	i64 9875200773399460291, ; 160: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 113
	i64 9998632235833408227, ; 161: Mono.Security => 0x8ac2470b209ebae3 => 138
	i64 10038780035334861115, ; 162: System.Net.Http.dll => 0x8b50e941206af13b => 31
	i64 10200434532125394699, ; 163: Huawei.Hmf.Tasks => 0x8d8f3929a9f6470b => 11
	i64 10219142040998308282, ; 164: Huawei.Hms.Base.dll => 0x8dd1af8afef6e9ba => 13
	i64 10226222362177979215, ; 165: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 124
	i64 10229024438826829339, ; 166: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 55
	i64 10321854143672141184, ; 167: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 121
	i64 10352330178246763130, ; 168: Xamarin.Firebase.Measurement.Connector => 0x8faadd72b7f4627a => 101
	i64 10376576884623852283, ; 169: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 83
	i64 10406448008575299332, ; 170: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 127
	i64 10430153318873392755, ; 171: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 53
	i64 10810727582997339763, ; 172: Huawei.Hms.Availableupdate => 0x96076b758412de73 => 12
	i64 10847732767863316357, ; 173: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 42
	i64 11023048688141570732, ; 174: System.Core => 0x98f9bc61168392ac => 29
	i64 11037814507248023548, ; 175: System.Xml => 0x992e31d0412bf7fc => 35
	i64 11072526564452562534, ; 176: Square.OkIO.JVM.dll => 0x99a9843ee0457666 => 26
	i64 11162124722117608902, ; 177: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 88
	i64 11171845786728836392, ; 178: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x9b0a5e8d536aad28 => 115
	i64 11221835998582316105, ; 179: Huawei.Hms.Ui => 0x9bbbf86287309c49 => 20
	i64 11336891506707244397, ; 180: Xamarin.Firebase.Datatransport => 0x9d54bac28a6da56d => 94
	i64 11340910727871153756, ; 181: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 54
	i64 11376351552967644903, ; 182: Xamarin.Firebase.Annotations.dll => 0x9de0eb76829996e7 => 91
	i64 11392833485892708388, ; 183: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 78
	i64 11397523291644824557, ; 184: DengageSDK.Xamarin.Core.dll => 0x9e2c230c0dbb0bed => 4
	i64 11474967336136963068, ; 185: Huawei.Hms.Hatool => 0x9f3f45fec7a773fc => 15
	i64 11529969570048099689, ; 186: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 88
	i64 11578238080964724296, ; 187: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 63
	i64 11580057168383206117, ; 188: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 38
	i64 11597940890313164233, ; 189: netstandard => 0xa0f429ca8d1805c9 => 129
	i64 11672361001936329215, ; 190: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 60
	i64 12137774235383566651, ; 191: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 86
	i64 12346958216201575315, ; 192: Xamarin.JavaX.Inject.dll => 0xab593514a5491b93 => 120
	i64 12451044538927396471, ; 193: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 59
	i64 12466513435562512481, ; 194: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 70
	i64 12487638416075308985, ; 195: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 56
	i64 12538491095302438457, ; 196: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 46
	i64 12550732019250633519, ; 197: System.IO.Compression => 0xae2d28465e8e1b2f => 134
	i64 12700543734426720211, ; 198: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 47
	i64 12711617764981604187, ; 199: Huawei.Android.Hms.SecurityEncrypt => 0xb068bd021a45ff5b => 9
	i64 12828192437253469131, ; 200: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 125
	i64 12854524964145442905, ; 201: Xamarin.Firebase.Encoders.dll => 0xb26472594447b059 => 95
	i64 12876461035432930612, ; 202: Huawei.Hms.Hatool.dll => 0xb2b26116dd236d34 => 15
	i64 12963446364377008305, ; 203: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 133
	i64 13370592475155966277, ; 204: System.Runtime.Serialization => 0xb98de304062ea945 => 1
	i64 13371367526160083128, ; 205: Square.OkHttp3.LoggingInterceptor => 0xb990a3eba5f728b8 => 25
	i64 13401370062847626945, ; 206: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 86
	i64 13404347523447273790, ; 207: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 49
	i64 13454009404024712428, ; 208: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 111
	i64 13465488254036897740, ; 209: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 123
	i64 13491513212026656886, ; 210: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 43
	i64 13572454107664307259, ; 211: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 79
	i64 13624712646999482021, ; 212: DengageSDK.Xamarin.Core => 0xbd14b3f7332d1ea5 => 4
	i64 13647894001087880694, ; 213: System.Data.dll => 0xbd670f48cb071df6 => 130
	i64 13828521679616088467, ; 214: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 122
	i64 13829530607229561650, ; 215: Xamarin.Firebase.Installations.InterOp => 0xbfec5cd0b64f6b32 => 100
	i64 13959074834287824816, ; 216: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 59
	i64 13967638549803255703, ; 217: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 104
	i64 14124974489674258913, ; 218: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 46
	i64 14172845254133543601, ; 219: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 73
	i64 14196808902378936008, ; 220: Square.Retrofit2.ConverterGson.dll => 0xc505327a926656c8 => 27
	i64 14261073672896646636, ; 221: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 78
	i64 14486659737292545672, ; 222: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 66
	i64 14524915121004231475, ; 223: Xamarin.JavaX.Inject => 0xc992dd58a4283b33 => 120
	i64 14644440854989303794, ; 224: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 71
	i64 14678510994762383812, ; 225: Xamarin.GooglePlayServices.Location.dll => 0xcbb48bfaca7a41c4 => 116
	i64 14789919016435397935, ; 226: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 92
	i64 14792063746108907174, ; 227: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 111
	i64 14809388726477333247, ; 228: Xamarin.GooglePlayServices.Stats.dll => 0xcd8584954e5b22ff => 118
	i64 14852515768018889994, ; 229: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 54
	i64 14889905118082851278, ; 230: GoogleGson.dll => 0xcea391d0969961ce => 7
	i64 14890749653179496492, ; 231: Huawei.Hms.Log.dll => 0xcea691ea3d08f82c => 16
	i64 14987728460634540364, ; 232: System.IO.Compression.dll => 0xcfff1ba06622494c => 134
	i64 14988210264188246988, ; 233: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 56
	i64 15066237768853720495, ; 234: Huawei.Hms.NetworkCommon => 0xd116076d2a198daf => 17
	i64 15279429628684179188, ; 235: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 126
	i64 15370334346939861994, ; 236: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 53
	i64 15582737692548360875, ; 237: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 69
	i64 15609085926864131306, ; 238: System.dll => 0xd89e9cf3334914ea => 30
	i64 15777549416145007739, ; 239: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 81
	i64 15810740023422282496, ; 240: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 106
	i64 15930129725311349754, ; 241: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 119
	i64 15970968847468894606, ; 242: DengageTest123.Android => 0xdda4478c8836998e => 0
	i64 15992843576024808175, ; 243: Huawei.Hms.Ui.dll => 0xddf1fe7fa958baef => 20
	i64 16010501072521946958, ; 244: Huawei.Hms.NetworkCommon.dll => 0xde30b9e5efae674e => 17
	i64 16154507427712707110, ; 245: System => 0xe03056ea4e39aa26 => 30
	i64 16358326039458771190, ; 246: Huawei.Hms.Stats.dll => 0xe30472dcddf670f6 => 19
	i64 16423015068819898779, ; 247: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 125
	i64 16467346005009053642, ; 248: Xamarin.Google.Android.DataTransport.TransportApi => 0xe487c3f19e0337ca => 107
	i64 16505967687213018679, ; 249: Huawei.Hms.Stats => 0xe510fa28be686e37 => 19
	i64 16565028646146589191, ; 250: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 136
	i64 16621146507174665210, ; 251: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 50
	i64 16677317093839702854, ; 252: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 76
	i64 16822611501064131242, ; 253: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 132
	i64 16833383113903931215, ; 254: mscorlib => 0xe99c30c1484d7f4f => 23
	i64 16904434304620314439, ; 255: Huawei.Agconnect.AgconnectCore => 0xea989d6fbfd23f47 => 8
	i64 17024911836938395553, ; 256: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 39
	i64 17031351772568316411, ; 257: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 74
	i64 17037200463775726619, ; 258: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 62
	i64 17434242208926550937, ; 259: Xamarin.Google.Android.DataTransport.TransportRuntime => 0xf1f2deeb1f304b99 => 109
	i64 17522591619082469157, ; 260: GoogleGson => 0xf32cc03d27a5bf25 => 7
	i64 17544493274320527064, ; 261: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 44
	i64 17677828421478984182, ; 262: Xamarin.Firebase.Installations.InterOp.dll => 0xf5544349c68f29f6 => 100
	i64 17704177640604968747, ; 263: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 70
	i64 17710060891934109755, ; 264: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 68
	i64 17882897186074144999, ; 265: FormsViewGroup => 0xf82cd03e3ac830e7 => 6
	i64 17891337867145587222, ; 266: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 121
	i64 17892495832318972303, ; 267: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 106
	i64 17928294245072900555, ; 268: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 135
	i64 17945795017270165205, ; 269: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0xf90c457cc05cfed5 => 107
	i64 17986907704309214542, ; 270: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 114
	i64 18116111925905154859, ; 271: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 43
	i64 18121036031235206392, ; 272: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 74
	i64 18129453464017766560, ; 273: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 128
	i64 18232892474675394303, ; 274: DengageTest123.dll => 0xfd083f1a8ceb76ff => 5
	i64 18305135509493619199, ; 275: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 75
	i64 18337470502355292274, ; 276: Xamarin.Firebase.Messaging => 0xfe7bc8440c175072 => 102
	i64 18380184030268848184 ; 277: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 87
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [278 x i32] [
	i32 58, i32 22, i32 47, i32 80, i32 25, i32 81, i32 52, i32 116, ; 0..7
	i32 67, i32 113, i32 133, i32 61, i32 57, i32 5, i32 131, i32 105, ; 8..15
	i32 138, i32 3, i32 110, i32 42, i32 1, i32 93, i32 117, i32 40, ; 16..23
	i32 69, i32 62, i32 41, i32 80, i32 108, i32 38, i32 68, i32 16, ; 24..31
	i32 124, i32 73, i32 45, i32 57, i32 137, i32 65, i32 51, i32 85, ; 32..39
	i32 34, i32 37, i32 12, i32 35, i32 23, i32 77, i32 11, i32 103, ; 40..47
	i32 110, i32 26, i32 95, i32 64, i32 39, i32 33, i32 127, i32 92, ; 48..55
	i32 114, i32 83, i32 82, i32 32, i32 34, i32 8, i32 129, i32 79, ; 56..63
	i32 58, i32 112, i32 18, i32 3, i32 52, i32 96, i32 119, i32 108, ; 64..71
	i32 128, i32 27, i32 87, i32 93, i32 24, i32 44, i32 37, i32 82, ; 72..79
	i32 104, i32 90, i32 71, i32 72, i32 85, i32 84, i32 50, i32 29, ; 80..87
	i32 89, i32 48, i32 77, i32 10, i32 66, i32 105, i32 6, i32 101, ; 88..95
	i32 67, i32 65, i32 10, i32 45, i32 55, i32 118, i32 137, i32 61, ; 96..103
	i32 112, i32 36, i32 109, i32 33, i32 28, i32 91, i32 97, i32 63, ; 104..111
	i32 60, i32 117, i32 98, i32 96, i32 36, i32 28, i32 2, i32 103, ; 112..119
	i32 90, i32 31, i32 123, i32 13, i32 130, i32 40, i32 99, i32 115, ; 120..127
	i32 99, i32 24, i32 136, i32 64, i32 132, i32 21, i32 126, i32 14, ; 128..135
	i32 49, i32 76, i32 102, i32 14, i32 84, i32 21, i32 75, i32 135, ; 136..143
	i32 9, i32 122, i32 0, i32 18, i32 89, i32 41, i32 2, i32 32, ; 144..151
	i32 51, i32 72, i32 97, i32 94, i32 98, i32 22, i32 48, i32 131, ; 152..159
	i32 113, i32 138, i32 31, i32 11, i32 13, i32 124, i32 55, i32 121, ; 160..167
	i32 101, i32 83, i32 127, i32 53, i32 12, i32 42, i32 29, i32 35, ; 168..175
	i32 26, i32 88, i32 115, i32 20, i32 94, i32 54, i32 91, i32 78, ; 176..183
	i32 4, i32 15, i32 88, i32 63, i32 38, i32 129, i32 60, i32 86, ; 184..191
	i32 120, i32 59, i32 70, i32 56, i32 46, i32 134, i32 47, i32 9, ; 192..199
	i32 125, i32 95, i32 15, i32 133, i32 1, i32 25, i32 86, i32 49, ; 200..207
	i32 111, i32 123, i32 43, i32 79, i32 4, i32 130, i32 122, i32 100, ; 208..215
	i32 59, i32 104, i32 46, i32 73, i32 27, i32 78, i32 66, i32 120, ; 216..223
	i32 71, i32 116, i32 92, i32 111, i32 118, i32 54, i32 7, i32 16, ; 224..231
	i32 134, i32 56, i32 17, i32 126, i32 53, i32 69, i32 30, i32 81, ; 232..239
	i32 106, i32 119, i32 0, i32 20, i32 17, i32 30, i32 19, i32 125, ; 240..247
	i32 107, i32 19, i32 136, i32 50, i32 76, i32 132, i32 23, i32 8, ; 248..255
	i32 39, i32 74, i32 62, i32 109, i32 7, i32 44, i32 100, i32 70, ; 256..263
	i32 68, i32 6, i32 121, i32 106, i32 135, i32 107, i32 114, i32 43, ; 264..271
	i32 74, i32 128, i32 5, i32 75, i32 102, i32 87 ; 272..277
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
