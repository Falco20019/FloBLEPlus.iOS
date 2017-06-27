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
	[Register("NdefMessage", true)]
	public unsafe partial class NdefMessage : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("NdefMessage");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public NdefMessage () : base (NSObjectFlag.Empty)
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
		protected NdefMessage (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal NdefMessage (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithByteBuffer:")]
		[CompilerGenerated]
		public NdefMessage (NSData byteBuffer)
			: base (NSObjectFlag.Empty)
		{
			if (byteBuffer == null)
				throw new ArgumentNullException ("byteBuffer");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithByteBuffer:"), byteBuffer.Handle), "initWithByteBuffer:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithByteBuffer:"), byteBuffer.Handle), "initWithByteBuffer:");
			}
		}
		
		[Export ("initWithNdefRecords:")]
		[CompilerGenerated]
		public NdefMessage (NdefRecord[] ndefRecords)
			: base (NSObjectFlag.Empty)
		{
			if (ndefRecords == null)
				throw new ArgumentNullException ("ndefRecords");
			var nsa_ndefRecords = NSArray.FromNSObjects (ndefRecords);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithNdefRecords:"), nsa_ndefRecords.Handle), "initWithNdefRecords:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithNdefRecords:"), nsa_ndefRecords.Handle), "initWithNdefRecords:");
			}
			nsa_ndefRecords.Dispose ();
			
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
		public static NdefMessage CreateURIWithString (string uriString)
		{
			if (uriString == null)
				throw new ArgumentNullException ("uriString");
			var nsuriString = NSString.CreateNative (uriString);
			
			NdefMessage ret;
			ret =  Runtime.GetNSObject<NdefMessage> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("createURIWithString:"), nsuriString));
			NSString.ReleaseNative (nsuriString);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual NdefRecord[] NdefRecords {
			[Export ("ndefRecords")]
			get {
				NdefRecord[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<NdefRecord>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("ndefRecords")));
				} else {
					ret = NSArray.ArrayFromHandle<NdefRecord>(global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("ndefRecords")));
				}
				return ret;
			}
			
		}
		
	} /* class NdefMessage */
}
