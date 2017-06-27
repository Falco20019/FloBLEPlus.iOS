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
	[Register("ACRAesTrackData", true)]
	public unsafe partial class ACRAesTrackData : ACRTrackData {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ACRAesTrackData");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ACRAesTrackData () : base (NSObjectFlag.Empty)
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
		protected ACRAesTrackData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ACRAesTrackData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithBytes:length:")]
		[CompilerGenerated]
		public ACRAesTrackData (global::System.IntPtr bytes, global::System.nuint length)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("initWithBytes:length:"), bytes, length), "initWithBytes:length:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("initWithBytes:length:"), bytes, length), "initWithBytes:length:");
			}
		}
		
		[CompilerGenerated]
		public virtual NSData TrackData {
			[Export ("trackData")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("trackData")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("trackData")));
				}
				return ret;
			}
			
		}
		
	} /* class ACRAesTrackData */
}
