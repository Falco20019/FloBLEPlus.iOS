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
	[Register("NdefRecord", true)]
	public unsafe partial class NdefRecord : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NdefRecord");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NdefRecord () : base (NSObjectFlag.Empty)
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
		protected NdefRecord (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NdefRecord (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithTnf:andType:andId:andPayload:")]
		[CompilerGenerated]
		public NdefRecord (short tnf, NSData type, NSData theId, NSData payload)
			: base (NSObjectFlag.Empty)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (theId == null)
				throw new ArgumentNullException ("theId");
			if (payload == null)
				throw new ArgumentNullException ("payload");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_short_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTnf:andType:andId:andPayload:"), tnf, type.Handle, theId.Handle, payload.Handle), "initWithTnf:andType:andId:andPayload:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_short_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTnf:andType:andId:andPayload:"), tnf, type.Handle, theId.Handle, payload.Handle), "initWithTnf:andType:andId:andPayload:");
			}
		}
		
		[Export ("initWithTnf:andType:andId:andPayload:andFlags:")]
		[CompilerGenerated]
		public NdefRecord (short tnf, NSData type, NSData theId, NSData payload, NSData flags)
			: base (NSObjectFlag.Empty)
		{
			if (type == null)
				throw new ArgumentNullException ("type");
			if (theId == null)
				throw new ArgumentNullException ("theId");
			if (payload == null)
				throw new ArgumentNullException ("payload");
			if (flags == null)
				throw new ArgumentNullException ("flags");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_short_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTnf:andType:andId:andPayload:andFlags:"), tnf, type.Handle, theId.Handle, payload.Handle, flags.Handle), "initWithTnf:andType:andId:andPayload:andFlags:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_short_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTnf:andType:andId:andPayload:andFlags:"), tnf, type.Handle, theId.Handle, payload.Handle, flags.Handle), "initWithTnf:andType:andId:andPayload:andFlags:");
			}
		}
		
		[Export ("asByteBuffer")]
		[CompilerGenerated]
		public virtual NSData AsByteBuffer ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("asByteBuffer")));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("asByteBuffer")));
			}
		}
		
		[Export ("createURIWithString:")]
		[CompilerGenerated]
		public static NdefRecord CreateURIWithString (string uriString)
		{
			if (uriString == null)
				throw new ArgumentNullException ("uriString");
			var nsuriString = NSString.CreateNative (uriString);
			
			NdefRecord ret;
			ret =  Runtime.GetNSObject<NdefRecord> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createURIWithString:"), nsuriString));
			NSString.ReleaseNative (nsuriString);
			
			return ret;
		}
		
		[Export ("createURIWithURL:")]
		[CompilerGenerated]
		public static NdefRecord CreateURIWithURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return  Runtime.GetNSObject<NdefRecord> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createURIWithURL:"), url.Handle));
		}
		
		[Export ("parseData:andIgnoreMbMe:")]
		[CompilerGenerated]
		public static NdefRecord[] ParseData (NSData data, bool ignoreMbMe)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return NSArray.ArrayFromHandle<NdefRecord>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_bool (class_ptr, Selector.GetHandle ("parseData:andIgnoreMbMe:"), data.Handle, ignoreMbMe));
		}
		
		[CompilerGenerated]
		public virtual NSData Payload {
			[Export ("payload")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("payload")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("payload")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData TheId {
			[Export ("theId")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("theId")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("theId")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual short Tnf {
			[Export ("tnf")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.short_objc_msgSend (this.Handle, Selector.GetHandle ("tnf"));
				} else {
					return global::ApiDefinitions.Messaging.short_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tnf"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSData Type {
			[Export ("type")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("type")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSUrl UriFromPayload {
			[Export ("getUriFromPayload")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getUriFromPayload")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getUriFromPayload")));
				}
				return ret;
			}
			
		}
		
	} /* class NdefRecord */
}
