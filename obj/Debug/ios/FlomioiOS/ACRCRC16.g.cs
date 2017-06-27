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
	[Register("ACRCRC16", true)]
	public unsafe partial class ACRCRC16 : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ACRCRC16");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ACRCRC16 () : base (NSObjectFlag.Empty)
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
		protected ACRCRC16 (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ACRCRC16 (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("reset")]
		[CompilerGenerated]
		public virtual void Reset ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("reset"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reset"));
			}
		}
		
		[Export ("updateWithBytes:length:")]
		[CompilerGenerated]
		public virtual void UpdateWithBytes (global::System.IntPtr bytes, global::System.nuint length)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("updateWithBytes:length:"), bytes, length);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("updateWithBytes:length:"), bytes, length);
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.UInt16 Value {
			[Export ("value")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.UInt16_objc_msgSend (this.Handle, Selector.GetHandle ("value"));
				} else {
					return global::ApiDefinitions.Messaging.UInt16_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("value"));
				}
			}
			
		}
		
	} /* class ACRCRC16 */
}
