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
	[Register("ACRDukptReceiver", true)]
	public unsafe partial class ACRDukptReceiver : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ACRDukptReceiver");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ACRDukptReceiver () : base (NSObjectFlag.Empty)
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
		protected ACRDukptReceiver (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ACRDukptReceiver (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("compareKeySerialNumber:ksn2:")]
		[CompilerGenerated]
		public static bool CompareKeySerialNumber (NSData ksn1, NSData ksn2)
		{
			if (ksn1 == null)
				throw new ArgumentNullException ("ksn1");
			if (ksn2 == null)
				throw new ArgumentNullException ("ksn2");
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("compareKeySerialNumber:ksn2:"), ksn1.Handle, ksn2.Handle);
		}
		
		[Export ("compareKeySerialNumber:ksn1Length:ksn2:ksn2Length:")]
		[CompilerGenerated]
		public static bool CompareKeySerialNumber (global::System.IntPtr ksn1, global::System.nuint ksn1Length, global::System.IntPtr ksn2, global::System.nuint ksn2Length)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_nuint_IntPtr_nuint (class_ptr, Selector.GetHandle ("compareKeySerialNumber:ksn1Length:ksn2:ksn2Length:"), ksn1, ksn1Length, ksn2, ksn2Length);
		}
		
		[Export ("dataEncryptionRequestKeyFromKey:")]
		[CompilerGenerated]
		public static NSData DataEncryptionRequestKeyFromKey (NSData key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dataEncryptionRequestKeyFromKey:"), key.Handle));
		}
		
		[Export ("dataEncryptionRequestKeyFromKey:length:")]
		[CompilerGenerated]
		public static NSData DataEncryptionRequestKeyFromKey (global::System.IntPtr key, global::System.nuint length)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("dataEncryptionRequestKeyFromKey:length:"), key, length));
		}
		
		[Export ("dataEncryptionResponseKeyFromKey:")]
		[CompilerGenerated]
		public static NSData DataEncryptionResponseKeyFromKey (NSData key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("dataEncryptionResponseKeyFromKey:"), key.Handle));
		}
		
		[Export ("dataEncryptionResponseKeyFromKey:length:")]
		[CompilerGenerated]
		public static NSData DataEncryptionResponseKeyFromKey (global::System.IntPtr key, global::System.nuint length)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("dataEncryptionResponseKeyFromKey:length:"), key, length));
		}
		
		[Export ("encryptionCounter")]
		[CompilerGenerated]
		public virtual global::System.nuint EncryptionCounter ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("encryptionCounter"));
			} else {
				return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("encryptionCounter"));
			}
		}
		
		[Export ("encryptionCounterFromKeySerialNumber:")]
		[CompilerGenerated]
		public static global::System.nuint EncryptionCounterFromKeySerialNumber (NSData ksn)
		{
			if (ksn == null)
				throw new ArgumentNullException ("ksn");
			return global::ApiDefinitions.Messaging.nuint_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("encryptionCounterFromKeySerialNumber:"), ksn.Handle);
		}
		
		[Export ("encryptionCounterFromKeySerialNumber:length:")]
		[CompilerGenerated]
		public static global::System.nuint EncryptionCounterFromKeySerialNumber (global::System.IntPtr ksn, global::System.nuint length)
		{
			return global::ApiDefinitions.Messaging.nuint_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("encryptionCounterFromKeySerialNumber:length:"), ksn, length);
		}
		
		[Export ("key")]
		[CompilerGenerated]
		public virtual NSData Key ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("key")));
			} else {
				return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("key")));
			}
		}
		
		[Export ("loadInitialKey:")]
		[CompilerGenerated]
		public virtual void LoadInitialKey (NSData initialKey)
		{
			if (initialKey == null)
				throw new ArgumentNullException ("initialKey");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("loadInitialKey:"), initialKey.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("loadInitialKey:"), initialKey.Handle);
			}
		}
		
		[Export ("loadInitialKey:length:")]
		[CompilerGenerated]
		public virtual void LoadInitialKey (global::System.IntPtr initialKey, global::System.nuint length)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("loadInitialKey:length:"), initialKey, length);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("loadInitialKey:length:"), initialKey, length);
			}
		}
		
		[Export ("macFromData:key:")]
		[CompilerGenerated]
		public static NSData MacFromData (NSData data, NSData key)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("macFromData:key:"), data.Handle, key.Handle));
		}
		
		[Export ("macFromData:dataLength:key:keyLength:")]
		[CompilerGenerated]
		public static NSData MacFromData (global::System.IntPtr data, global::System.nuint dataLength, global::System.IntPtr key, global::System.nuint keyLength)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_nuint (class_ptr, Selector.GetHandle ("macFromData:dataLength:key:keyLength:"), data, dataLength, key, keyLength));
		}
		
		[Export ("macRequestKeyFromKey:")]
		[CompilerGenerated]
		public static NSData MacRequestKeyFromKey (NSData key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("macRequestKeyFromKey:"), key.Handle));
		}
		
		[Export ("macRequestKeyFromKey:length:")]
		[CompilerGenerated]
		public static NSData MacRequestKeyFromKey (global::System.IntPtr key, global::System.nuint length)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("macRequestKeyFromKey:length:"), key, length));
		}
		
		[Export ("macResponseKeyFromKey:")]
		[CompilerGenerated]
		public static NSData MacResponseKeyFromKey (NSData key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("macResponseKeyFromKey:"), key.Handle));
		}
		
		[Export ("macResponseKeyFromKey:length:")]
		[CompilerGenerated]
		public static NSData MacResponseKeyFromKey (global::System.IntPtr key, global::System.nuint length)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("macResponseKeyFromKey:length:"), key, length));
		}
		
		[Export ("pinEncryptionKeyFromKey:")]
		[CompilerGenerated]
		public static NSData PinEncryptionKeyFromKey (NSData key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("pinEncryptionKeyFromKey:"), key.Handle));
		}
		
		[Export ("pinEncryptionKeyFromKey:length:")]
		[CompilerGenerated]
		public static NSData PinEncryptionKeyFromKey (global::System.IntPtr key, global::System.nuint length)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr_nuint (class_ptr, Selector.GetHandle ("pinEncryptionKeyFromKey:length:"), key, length));
		}
		
		[Export ("setKeySerialNumber:length:")]
		[CompilerGenerated]
		public virtual void SetKeySerialNumber (global::System.IntPtr keySerialNumber, global::System.nuint length)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("setKeySerialNumber:length:"), keySerialNumber, length);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("setKeySerialNumber:length:"), keySerialNumber, length);
			}
		}
		
		[CompilerGenerated]
		public virtual NSData KeySerialNumber {
			[Export ("keySerialNumber")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("keySerialNumber")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("keySerialNumber")));
				}
				return ret;
			}
			
			[Export ("setKeySerialNumber:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeySerialNumber:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setKeySerialNumber:"), value.Handle);
				}
			}
		}
		
	} /* class ACRDukptReceiver */
}
