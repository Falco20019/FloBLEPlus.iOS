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
	[Register("Tag", true)]
	public unsafe partial class Tag : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Tag");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Tag () : base (NSObjectFlag.Empty)
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
		protected Tag (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Tag (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("init:")]
		[CompilerGenerated]
		public Tag (NSData data)
			: base (NSObjectFlag.Empty)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("init:"), data.Handle), "init:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("init:"), data.Handle), "init:");
			}
		}
		
		[Export ("byteArrayFromHexString:")]
		[CompilerGenerated]
		public static NSData ByteArrayFromHexString (string hexString)
		{
			if (hexString == null)
				throw new ArgumentNullException ("hexString");
			var nshexString = NSString.CreateNative (hexString);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("byteArrayFromHexString:"), nshexString));
			NSString.ReleaseNative (nshexString);
			
			return ret;
		}
		
		[Export ("toByteArray:buffer:bufferSize:")]
		[CompilerGenerated]
		public static global::System.nuint ToByteArray (string hexString, global::System.IntPtr buffer, global::System.nuint bufferSize)
		{
			if (hexString == null)
				throw new ArgumentNullException ("hexString");
			var nshexString = NSString.CreateNative (hexString);
			
			global::System.nuint ret;
			ret = global::ApiDefinitions.Messaging.nuint_objc_msgSend_IntPtr_IntPtr_nuint (class_ptr, Selector.GetHandle ("toByteArray:buffer:bufferSize:"), nshexString, buffer, bufferSize);
			NSString.ReleaseNative (nshexString);
			
			return ret;
		}
		
		[Export ("toHexString:length:")]
		[CompilerGenerated]
		public static string ToHexString (global::System.IntPtr buffer, global::System.nuint length)
		{
			return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("toHexString:length:"), buffer, length));
		}
		
		[CompilerGenerated]
		public virtual NSData Data {
			[Export ("data", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("data")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("data")));
				}
				return ret;
			}
			
			[Export ("setData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setData:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setData:"), value.Handle);
				}
			}
		}
		
	} /* class Tag */
}
