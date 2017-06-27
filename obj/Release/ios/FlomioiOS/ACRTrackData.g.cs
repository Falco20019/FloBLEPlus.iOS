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
	[Register("ACRTrackData", true)]
	public unsafe partial class ACRTrackData : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ACRTrackData");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ACRTrackData () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected ACRTrackData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ACRTrackData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual global::System.nuint BatteryStatus {
			[Export ("batteryStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("batteryStatus"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("batteryStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Track1ErrorCode {
			[Export ("track1ErrorCode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("track1ErrorCode"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("track1ErrorCode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Track1Length {
			[Export ("track1Length")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("track1Length"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("track1Length"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Track2ErrorCode {
			[Export ("track2ErrorCode")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("track2ErrorCode"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("track2ErrorCode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint Track2Length {
			[Export ("track2Length")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("track2Length"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("track2Length"));
				}
			}
			
		}
		
	} /* class ACRTrackData */
}
