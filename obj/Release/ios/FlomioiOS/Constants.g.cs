//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace FloBLEPlus.iOS {
	public unsafe static partial class Constants  {
		
		[CompilerGenerated]
		static NSString _ABTErrorDomain;
		[Field ("ABTErrorDomain",  "__Internal")]
		public static unsafe NSString ABTErrorDomain {
			get {
				if (_ABTErrorDomain == null)
					_ABTErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "ABTErrorDomain");
				return _ABTErrorDomain;
			}
		}
		[Field ("g_rgSCardRawPci",  "__Internal")]
		public static unsafe global::System.IntPtr g_rgSCardRawPci {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "g_rgSCardRawPci");
			}
		}
		[Field ("g_rgSCardT0Pci",  "__Internal")]
		public static unsafe global::System.IntPtr g_rgSCardT0Pci {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "g_rgSCardT0Pci");
			}
		}
		[Field ("g_rgSCardT1Pci",  "__Internal")]
		public static unsafe global::System.IntPtr g_rgSCardT1Pci {
			get {
				return Dlfcn.GetIntPtr (Libraries.__Internal.Handle, "g_rgSCardT1Pci");
			}
		}
	} /* class Constants */
}
