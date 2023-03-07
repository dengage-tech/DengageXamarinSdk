using System;
using System.Diagnostics;
using DengageSDK.Xamarin.Core;

namespace DengageSDK.Xamarin
{
	public class DengageCoordinator
	{
        static readonly Lazy<DengageSDKInternal> Implementation = new Lazy<DengageSDKInternal>(CreateDengage);

        public static DengageSDKInternal Default
        {
            get
            {
                if (Implementation.Value == null)
                    throw NotImplementedInReferenceAssembly();

                return Implementation.Value;
            }
        }

        static DengageSDKInternal CreateDengage()
        {
            return null;

#if PORTABL
            return null;
#else
          //  return new DengageImplementation();
#endif
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");
        }
    }
}

