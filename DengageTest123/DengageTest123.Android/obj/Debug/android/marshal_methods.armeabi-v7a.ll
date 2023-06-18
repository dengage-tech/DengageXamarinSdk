; ModuleID = 'obj/Debug/android/marshal_methods.armeabi-v7a.ll'
source_filename = "obj/Debug/android/marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [278 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 67
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 111
	i32 57263871, ; 2: Xamarin.Forms.Core.dll => 0x369c6ff => 103
	i32 87783800, ; 3: Xamarin.GooglePlayServices.Ads.Identifier => 0x53b7978 => 112
	i32 101534019, ; 4: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 81
	i32 103834273, ; 5: Xamarin.Firebase.Annotations.dll => 0x63062a1 => 91
	i32 120558881, ; 6: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 81
	i32 134690465, ; 7: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 124
	i32 165246403, ; 8: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 47
	i32 182336117, ; 9: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 82
	i32 209110150, ; 10: Square.OkHttp3.LoggingInterceptor => 0xc76c486 => 25
	i32 209399409, ; 11: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 45
	i32 229731493, ; 12: Huawei.Hms.NetworkGrs => 0xdb16ca5 => 18
	i32 230216969, ; 13: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 62
	i32 232815796, ; 14: System.Web.Services => 0xde07cb4 => 137
	i32 243898057, ; 15: DengageSDK.Xamarin.Android.dll => 0xe8996c9 => 3
	i32 261689757, ; 16: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 50
	i32 278686392, ; 17: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 66
	i32 280482487, ; 18: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 60
	i32 318968648, ; 19: Xamarin.AndroidX.Activity.dll => 0x13031348 => 37
	i32 321597661, ; 20: System.Numerics => 0x132b30dd => 32
	i32 342366114, ; 21: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 64
	i32 441335492, ; 22: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 49
	i32 442521989, ; 23: Xamarin.Essentials => 0x1a605985 => 90
	i32 450948140, ; 24: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 59
	i32 465846621, ; 25: mscorlib => 0x1bc4415d => 23
	i32 469710990, ; 26: System.dll => 0x1bff388e => 30
	i32 476646585, ; 27: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 60
	i32 485140951, ; 28: Xamarin.Google.Android.DataTransport.TransportRuntime => 0x1ceaa9d7 => 109
	i32 486930444, ; 29: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 71
	i32 495452658, ; 30: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x1d8801f2 => 109
	i32 507148113, ; 31: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0x1e3a7751 => 107
	i32 526420162, ; 32: System.Transactions.dll => 0x1f6088c2 => 131
	i32 527452488, ; 33: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 124
	i32 542030372, ; 34: Xamarin.GooglePlayServices.Stats => 0x204eba24 => 118
	i32 605376203, ; 35: System.IO.Compression.FileSystem => 0x24154ecb => 135
	i32 627609679, ; 36: Xamarin.AndroidX.CustomView => 0x2568904f => 55
	i32 663517072, ; 37: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 87
	i32 665787137, ; 38: Huawei.Hms.Log.dll => 0x27af1b01 => 16
	i32 666292255, ; 39: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 42
	i32 690569205, ; 40: System.Xml.Linq.dll => 0x29293ff5 => 36
	i32 691348768, ; 41: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 126
	i32 700284507, ; 42: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 121
	i32 702630279, ; 43: Huawei.Hms.NetworkGrs.dll => 0x29e14987 => 18
	i32 714456728, ; 44: Square.OkIO.JVM.dll => 0x2a95be98 => 26
	i32 720511267, ; 45: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 125
	i32 775507847, ; 46: System.IO.Compression => 0x2e394f87 => 134
	i32 809851609, ; 47: System.Drawing.Common.dll => 0x30455ad9 => 133
	i32 843511501, ; 48: Xamarin.AndroidX.Print => 0x3246f6cd => 78
	i32 846667644, ; 49: Xamarin.Firebase.Installations.dll => 0x32771f7c => 99
	i32 882434999, ; 50: Xamarin.Firebase.Installations.InterOp.dll => 0x3498e3b7 => 100
	i32 896577948, ; 51: Dengage.Android.Binding.dll => 0x3570b19c => 2
	i32 928116545, ; 52: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 111
	i32 956575887, ; 53: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 125
	i32 967690846, ; 54: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 64
	i32 974778368, ; 55: FormsViewGroup.dll => 0x3a19f000 => 6
	i32 996733531, ; 56: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3b68f25b => 108
	i32 1012816738, ; 57: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 80
	i32 1035644815, ; 58: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 41
	i32 1036359102, ; 59: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x3dc595be => 115
	i32 1042160112, ; 60: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 105
	i32 1052210849, ; 61: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 68
	i32 1067306892, ; 62: GoogleGson => 0x3f9dcf8c => 7
	i32 1084122840, ; 63: Xamarin.Kotlin.StdLib => 0x409e66d8 => 123
	i32 1098259244, ; 64: System => 0x41761b2c => 30
	i32 1141947663, ; 65: Xamarin.Firebase.Measurement.Connector.dll => 0x4410bd0f => 101
	i32 1149099989, ; 66: Huawei.Android.Hms.SecuritySsl => 0x447ddfd5 => 10
	i32 1175144683, ; 67: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 85
	i32 1178241025, ; 68: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 75
	i32 1204270330, ; 69: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 42
	i32 1221286664, ; 70: Square.OkHttp3 => 0x48cb5b08 => 24
	i32 1267360935, ; 71: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 86
	i32 1275534314, ; 72: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 126
	i32 1293217323, ; 73: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 57
	i32 1333047053, ; 74: Xamarin.Firebase.Common => 0x4f74af0d => 92
	i32 1365406463, ; 75: System.ServiceModel.Internals.dll => 0x516272ff => 128
	i32 1376866003, ; 76: Xamarin.AndroidX.SavedState => 0x52114ed3 => 80
	i32 1379897097, ; 77: Xamarin.JavaX.Inject => 0x523f8f09 => 120
	i32 1380977605, ; 78: Huawei.Hms.Stats.dll => 0x52500bc5 => 19
	i32 1395857551, ; 79: Xamarin.AndroidX.Media.dll => 0x5333188f => 72
	i32 1406073936, ; 80: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 51
	i32 1449961411, ; 81: Huawei.Hms.Base => 0x566ca7c3 => 13
	i32 1460219004, ; 82: Xamarin.Forms.Xaml => 0x57092c7c => 106
	i32 1462112819, ; 83: System.IO.Compression.dll => 0x57261233 => 134
	i32 1469204771, ; 84: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 40
	i32 1522103383, ; 85: Huawei.Hms.Device.dll => 0x5ab97457 => 14
	i32 1531040989, ; 86: Xamarin.Firebase.Iid.Interop.dll => 0x5b41d4dd => 98
	i32 1548351080, ; 87: DengageTest123.Android => 0x5c49f668 => 0
	i32 1582372066, ; 88: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 56
	i32 1582821230, ; 89: Huawei.Android.Hms.SecuritySsl.dll => 0x5e57ef6e => 10
	i32 1592978981, ; 90: System.Runtime.Serialization.dll => 0x5ef2ee25 => 1
	i32 1615464666, ; 91: Huawei.Hms.Log => 0x604a08da => 16
	i32 1622152042, ; 92: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 70
	i32 1624863272, ; 93: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 89
	i32 1636350590, ; 94: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 54
	i32 1639085333, ; 95: Huawei.Hms.Base.dll => 0x61b27515 => 13
	i32 1639515021, ; 96: System.Net.Http.dll => 0x61b9038d => 31
	i32 1657153582, ; 97: System.Runtime => 0x62c6282e => 34
	i32 1658241508, ; 98: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 83
	i32 1658251792, ; 99: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 110
	i32 1663500400, ; 100: Huawei.Hmf.Tasks => 0x63270070 => 11
	i32 1670060433, ; 101: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 50
	i32 1698840827, ; 102: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 122
	i32 1729485958, ; 103: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 46
	i32 1740319209, ; 104: Huawei.Hms.Hatool => 0x67bb29e9 => 15
	i32 1745546883, ; 105: Dengage.Android.Binding => 0x680aee83 => 2
	i32 1758825074, ; 106: DengageTest123 => 0x68d58a72 => 5
	i32 1766324549, ; 107: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 82
	i32 1776026572, ; 108: System.Core.dll => 0x69dc03cc => 29
	i32 1788241197, ; 109: Xamarin.AndroidX.Fragment => 0x6a96652d => 59
	i32 1808609942, ; 110: Xamarin.AndroidX.Loader => 0x6bcd3296 => 70
	i32 1813058853, ; 111: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 123
	i32 1813201214, ; 112: Xamarin.Google.Android.Material => 0x6c13413e => 110
	i32 1818569960, ; 113: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 76
	i32 1858322800, ; 114: DengageTest123.dll => 0x6ec3c170 => 5
	i32 1867746548, ; 115: Xamarin.Essentials.dll => 0x6f538cf4 => 90
	i32 1876173635, ; 116: Xamarin.Firebase.Encoders.Proto => 0x6fd42343 => 97
	i32 1878053835, ; 117: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 106
	i32 1885316902, ; 118: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 43
	i32 1908813208, ; 119: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 114
	i32 1919157823, ; 120: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 73
	i32 1933215285, ; 121: Xamarin.Firebase.Messaging.dll => 0x733a8635 => 102
	i32 1983156543, ; 122: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 122
	i32 2019465201, ; 123: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 68
	i32 2055257422, ; 124: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 65
	i32 2066297753, ; 125: Huawei.Hms.Availableupdate.dll => 0x7b293399 => 12
	i32 2077425357, ; 126: Huawei.Hms.Stats => 0x7bd2fecd => 19
	i32 2079903147, ; 127: System.Runtime.dll => 0x7bf8cdab => 34
	i32 2090596640, ; 128: System.Numerics.Vectors => 0x7c9bf920 => 33
	i32 2097448633, ; 129: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 61
	i32 2101093318, ; 130: Xamarin.GooglePlayServices.Ads.Identifier.dll => 0x7d3c23c6 => 112
	i32 2124230737, ; 131: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x7e9d3051 => 108
	i32 2126786730, ; 132: Xamarin.Forms.Platform.Android => 0x7ec430aa => 104
	i32 2129483829, ; 133: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 113
	i32 2174878672, ; 134: Xamarin.Firebase.Annotations => 0x81a203d0 => 91
	i32 2201107256, ; 135: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 127
	i32 2201231467, ; 136: System.Net.Http => 0x8334206b => 31
	i32 2217644978, ; 137: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 85
	i32 2223043141, ; 138: Huawei.Hmf.Tasks.dll => 0x8480f245 => 11
	i32 2244775296, ; 139: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 71
	i32 2256548716, ; 140: Xamarin.AndroidX.MultiDex => 0x8680336c => 73
	i32 2261435625, ; 141: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 63
	i32 2279755925, ; 142: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 79
	i32 2315684594, ; 143: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 38
	i32 2409053734, ; 144: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 77
	i32 2465532216, ; 145: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 49
	i32 2467049111, ; 146: Huawei.Agconnect.AgconnectCore => 0x930c2e97 => 8
	i32 2471841756, ; 147: netstandard.dll => 0x93554fdc => 129
	i32 2475788418, ; 148: Java.Interop.dll => 0x93918882 => 21
	i32 2482008701, ; 149: DengageTest123.Android.dll => 0x93f0727d => 0
	i32 2483661569, ; 150: Xamarin.Firebase.Measurement.Connector => 0x9409ab01 => 101
	i32 2483742551, ; 151: Xamarin.Firebase.Messaging => 0x940ae757 => 102
	i32 2486410006, ; 152: Xamarin.GooglePlayServices.CloudMessaging => 0x94339b16 => 115
	i32 2501346920, ; 153: System.Data.DataSetExtensions => 0x95178668 => 132
	i32 2505896520, ; 154: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 67
	i32 2552232793, ; 155: Square.Retrofit2.ConverterGson => 0x981ffb59 => 27
	i32 2581819634, ; 156: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 86
	i32 2605712449, ; 157: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 127
	i32 2620111890, ; 158: Xamarin.Firebase.Encoders.dll => 0x9c2bbc12 => 95
	i32 2620871830, ; 159: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 54
	i32 2623491480, ; 160: Xamarin.Firebase.Installations.InterOp => 0x9c5f4d98 => 100
	i32 2624644809, ; 161: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 58
	i32 2633051222, ; 162: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 66
	i32 2639764100, ; 163: Xamarin.Firebase.Encoders => 0x9d579a84 => 95
	i32 2644307787, ; 164: Huawei.Hms.Availableupdate => 0x9d9cef4b => 12
	i32 2701096212, ; 165: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 83
	i32 2727552820, ; 166: Huawei.Hms.Device => 0xa2932734 => 14
	i32 2732626843, ; 167: Xamarin.AndroidX.Activity => 0xa2e0939b => 37
	i32 2737747696, ; 168: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 40
	i32 2766581644, ; 169: Xamarin.Forms.Core => 0xa4e6af8c => 103
	i32 2770495804, ; 170: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 121
	i32 2778768386, ; 171: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 88
	i32 2804607052, ; 172: Xamarin.Firebase.Components.dll => 0xa72ae84c => 93
	i32 2810250172, ; 173: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 51
	i32 2819470561, ; 174: System.Xml.dll => 0xa80db4e1 => 35
	i32 2847418871, ; 175: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 113
	i32 2853208004, ; 176: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 88
	i32 2855708567, ; 177: Xamarin.AndroidX.Transition => 0xaa36a797 => 84
	i32 2857126705, ; 178: Square.Retrofit2 => 0xaa4c4b31 => 28
	i32 2866218599, ; 179: Square.Retrofit2.dll => 0xaad70667 => 28
	i32 2883826422, ; 180: Xamarin.Firebase.Installations => 0xabe3b2f6 => 99
	i32 2903344695, ; 181: System.ComponentModel.Composition => 0xad0d8637 => 136
	i32 2905242038, ; 182: mscorlib.dll => 0xad2a79b6 => 23
	i32 2914202368, ; 183: Xamarin.Firebase.Iid.Interop => 0xadb33300 => 98
	i32 2916838712, ; 184: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 89
	i32 2919462931, ; 185: System.Numerics.Vectors.dll => 0xae037813 => 33
	i32 2921128767, ; 186: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 39
	i32 2957587826, ; 187: Xamarin.GooglePlayServices.Places.PlaceReport.dll => 0xb0493572 => 117
	i32 2965194746, ; 188: Huawei.Hms.NetworkCommon => 0xb0bd47fa => 17
	i32 2978675010, ; 189: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 57
	i32 3024354802, ; 190: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 62
	i32 3044182254, ; 191: FormsViewGroup => 0xb57288ee => 6
	i32 3057625584, ; 192: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 74
	i32 3058099980, ; 193: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 119
	i32 3071899978, ; 194: Xamarin.Firebase.Common.dll => 0xb719794a => 92
	i32 3106737866, ; 195: Xamarin.Firebase.Datatransport.dll => 0xb92d0eca => 94
	i32 3111772706, ; 196: System.Runtime.Serialization => 0xb979e222 => 1
	i32 3148237826, ; 197: GoogleGson.dll => 0xbba64c02 => 7
	i32 3155362983, ; 198: Xamarin.Google.Android.DataTransport.TransportApi => 0xbc1304a7 => 107
	i32 3204380047, ; 199: System.Data.dll => 0xbefef58f => 130
	i32 3211777861, ; 200: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 56
	i32 3215169282, ; 201: Square.Retrofit2.ConverterGson.dll => 0xbfa39702 => 27
	i32 3217536604, ; 202: Square.OkHttp3.dll => 0xbfc7b65c => 24
	i32 3230271625, ; 203: Square.OkIO.JVM => 0xc08a0889 => 26
	i32 3230466174, ; 204: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 114
	i32 3247949154, ; 205: Mono.Security => 0xc197c562 => 138
	i32 3258312781, ; 206: Xamarin.AndroidX.CardView => 0xc235e84d => 46
	i32 3267021929, ; 207: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 44
	i32 3273112673, ; 208: Huawei.Hms.NetworkCommon.dll => 0xc317bc61 => 17
	i32 3288844784, ; 209: Huawei.Android.Hms.SecurityEncrypt => 0xc407c9f0 => 9
	i32 3317135071, ; 210: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 55
	i32 3317144872, ; 211: System.Data => 0xc5b79d28 => 130
	i32 3331531814, ; 212: Xamarin.GooglePlayServices.Stats.dll => 0xc6932426 => 118
	i32 3340431453, ; 213: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 43
	i32 3346324047, ; 214: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 75
	i32 3353348832, ; 215: Square.OkHttp3.LoggingInterceptor.dll => 0xc7e00ae0 => 25
	i32 3353484488, ; 216: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 61
	i32 3362522851, ; 217: Xamarin.AndroidX.Core => 0xc86c06e3 => 53
	i32 3366347497, ; 218: Java.Interop => 0xc8a662e9 => 21
	i32 3371992681, ; 219: Xamarin.Firebase.Encoders.Proto.dll => 0xc8fc8669 => 97
	i32 3374999561, ; 220: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 79
	i32 3383578424, ; 221: Xamarin.Firebase.Encoders.JSON => 0xc9ad4f38 => 96
	i32 3404865022, ; 222: System.ServiceModel.Internals => 0xcaf21dfe => 128
	i32 3429136800, ; 223: System.Xml => 0xcc6479a0 => 35
	i32 3430777524, ; 224: netstandard => 0xcc7d82b4 => 129
	i32 3441283291, ; 225: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 58
	i32 3476120550, ; 226: Mono.Android => 0xcf3163e6 => 22
	i32 3486566296, ; 227: System.Transactions => 0xcfd0c798 => 131
	i32 3493954962, ; 228: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 48
	i32 3494395880, ; 229: Xamarin.GooglePlayServices.Location.dll => 0xd0483fe8 => 116
	i32 3501239056, ; 230: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 44
	i32 3509114376, ; 231: System.Xml.Linq => 0xd128d608 => 36
	i32 3534510610, ; 232: Huawei.Android.Hms.SecurityEncrypt.dll => 0xd2ac5a12 => 9
	i32 3536029504, ; 233: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 104
	i32 3549863983, ; 234: Huawei.Hms.Ui.dll => 0xd396a02f => 20
	i32 3567349600, ; 235: System.ComponentModel.Composition.dll => 0xd4a16f60 => 136
	i32 3579529003, ; 236: Huawei.Hms.Ui => 0xd55b472b => 20
	i32 3618140916, ; 237: Xamarin.AndroidX.Preference => 0xd7a872f4 => 77
	i32 3627220390, ; 238: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 78
	i32 3632359727, ; 239: Xamarin.Forms.Platform => 0xd881692f => 105
	i32 3633644679, ; 240: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 39
	i32 3641597786, ; 241: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 65
	i32 3662507408, ; 242: DengageSDK.Xamarin.Core.dll => 0xda4d6d90 => 4
	i32 3672681054, ; 243: Mono.Android.dll => 0xdae8aa5e => 22
	i32 3676310014, ; 244: System.Web.Services.dll => 0xdb2009fe => 137
	i32 3682565725, ; 245: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 45
	i32 3684561358, ; 246: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 48
	i32 3689375977, ; 247: System.Drawing.Common => 0xdbe768e9 => 133
	i32 3706696989, ; 248: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 52
	i32 3718780102, ; 249: Xamarin.AndroidX.Annotation => 0xdda814c6 => 38
	i32 3724971120, ; 250: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 74
	i32 3758932259, ; 251: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 63
	i32 3786282454, ; 252: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 47
	i32 3822602673, ; 253: Xamarin.AndroidX.Media => 0xe3d849b1 => 72
	i32 3829621856, ; 254: System.Numerics.dll => 0xe4436460 => 32
	i32 3885922214, ; 255: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 84
	i32 3896760992, ; 256: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 53
	i32 3920810846, ; 257: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 135
	i32 3921031405, ; 258: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 87
	i32 3928370257, ; 259: DengageSDK.Xamarin.Core => 0xea262c51 => 4
	i32 3931092270, ; 260: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 76
	i32 3934056515, ; 261: Xamarin.JavaX.Inject.dll => 0xea7cf043 => 120
	i32 3945713374, ; 262: System.Data.DataSetExtensions.dll => 0xeb2ecede => 132
	i32 3955647286, ; 263: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 41
	i32 3967165417, ; 264: Xamarin.GooglePlayServices.Location => 0xec7623e9 => 116
	i32 3970018735, ; 265: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 119
	i32 3979229314, ; 266: Huawei.Hms.Hatool.dll => 0xed2e3882 => 15
	i32 4025670099, ; 267: Xamarin.GooglePlayServices.Places.PlaceReport => 0xeff2d9d3 => 117
	i32 4105002889, ; 268: Mono.Security.dll => 0xf4ad5f89 => 138
	i32 4151237749, ; 269: System.Core => 0xf76edc75 => 29
	i32 4182413190, ; 270: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 69
	i32 4192648326, ; 271: Xamarin.Firebase.Encoders.JSON.dll => 0xf9e6bc86 => 96
	i32 4243269593, ; 272: DengageSDK.Xamarin.Android => 0xfceb27d9 => 3
	i32 4256097574, ; 273: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 52
	i32 4269159614, ; 274: Xamarin.Firebase.Datatransport => 0xfe7634be => 94
	i32 4284549794, ; 275: Xamarin.Firebase.Components => 0xff610aa2 => 93
	i32 4292120959, ; 276: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 69
	i32 4293620108 ; 277: Huawei.Agconnect.AgconnectCore.dll => 0xffeb718c => 8
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [278 x i32] [
	i32 67, i32 111, i32 103, i32 112, i32 81, i32 91, i32 81, i32 124, ; 0..7
	i32 47, i32 82, i32 25, i32 45, i32 18, i32 62, i32 137, i32 3, ; 8..15
	i32 50, i32 66, i32 60, i32 37, i32 32, i32 64, i32 49, i32 90, ; 16..23
	i32 59, i32 23, i32 30, i32 60, i32 109, i32 71, i32 109, i32 107, ; 24..31
	i32 131, i32 124, i32 118, i32 135, i32 55, i32 87, i32 16, i32 42, ; 32..39
	i32 36, i32 126, i32 121, i32 18, i32 26, i32 125, i32 134, i32 133, ; 40..47
	i32 78, i32 99, i32 100, i32 2, i32 111, i32 125, i32 64, i32 6, ; 48..55
	i32 108, i32 80, i32 41, i32 115, i32 105, i32 68, i32 7, i32 123, ; 56..63
	i32 30, i32 101, i32 10, i32 85, i32 75, i32 42, i32 24, i32 86, ; 64..71
	i32 126, i32 57, i32 92, i32 128, i32 80, i32 120, i32 19, i32 72, ; 72..79
	i32 51, i32 13, i32 106, i32 134, i32 40, i32 14, i32 98, i32 0, ; 80..87
	i32 56, i32 10, i32 1, i32 16, i32 70, i32 89, i32 54, i32 13, ; 88..95
	i32 31, i32 34, i32 83, i32 110, i32 11, i32 50, i32 122, i32 46, ; 96..103
	i32 15, i32 2, i32 5, i32 82, i32 29, i32 59, i32 70, i32 123, ; 104..111
	i32 110, i32 76, i32 5, i32 90, i32 97, i32 106, i32 43, i32 114, ; 112..119
	i32 73, i32 102, i32 122, i32 68, i32 65, i32 12, i32 19, i32 34, ; 120..127
	i32 33, i32 61, i32 112, i32 108, i32 104, i32 113, i32 91, i32 127, ; 128..135
	i32 31, i32 85, i32 11, i32 71, i32 73, i32 63, i32 79, i32 38, ; 136..143
	i32 77, i32 49, i32 8, i32 129, i32 21, i32 0, i32 101, i32 102, ; 144..151
	i32 115, i32 132, i32 67, i32 27, i32 86, i32 127, i32 95, i32 54, ; 152..159
	i32 100, i32 58, i32 66, i32 95, i32 12, i32 83, i32 14, i32 37, ; 160..167
	i32 40, i32 103, i32 121, i32 88, i32 93, i32 51, i32 35, i32 113, ; 168..175
	i32 88, i32 84, i32 28, i32 28, i32 99, i32 136, i32 23, i32 98, ; 176..183
	i32 89, i32 33, i32 39, i32 117, i32 17, i32 57, i32 62, i32 6, ; 184..191
	i32 74, i32 119, i32 92, i32 94, i32 1, i32 7, i32 107, i32 130, ; 192..199
	i32 56, i32 27, i32 24, i32 26, i32 114, i32 138, i32 46, i32 44, ; 200..207
	i32 17, i32 9, i32 55, i32 130, i32 118, i32 43, i32 75, i32 25, ; 208..215
	i32 61, i32 53, i32 21, i32 97, i32 79, i32 96, i32 128, i32 35, ; 216..223
	i32 129, i32 58, i32 22, i32 131, i32 48, i32 116, i32 44, i32 36, ; 224..231
	i32 9, i32 104, i32 20, i32 136, i32 20, i32 77, i32 78, i32 105, ; 232..239
	i32 39, i32 65, i32 4, i32 22, i32 137, i32 45, i32 48, i32 133, ; 240..247
	i32 52, i32 38, i32 74, i32 63, i32 47, i32 72, i32 32, i32 84, ; 248..255
	i32 53, i32 135, i32 87, i32 4, i32 76, i32 120, i32 132, i32 41, ; 256..263
	i32 116, i32 119, i32 15, i32 117, i32 138, i32 29, i32 69, i32 96, ; 264..271
	i32 3, i32 52, i32 94, i32 93, i32 69, i32 8 ; 272..277
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
