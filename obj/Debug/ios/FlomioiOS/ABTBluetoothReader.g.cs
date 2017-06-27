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
	[Register("ABTBluetoothReader", true)]
	public unsafe partial class ABTBluetoothReader : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("ABTBluetoothReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABTBluetoothReader () : base (NSObjectFlag.Empty)
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
		protected ABTBluetoothReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ABTBluetoothReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("attachPeripheral:")]
		[CompilerGenerated]
		public virtual void AttachPeripheral (global::CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("attachPeripheral:"), peripheral.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("attachPeripheral:"), peripheral.Handle);
			}
		}
		
		[Export ("authenticateWithMasterKey:")]
		[CompilerGenerated]
		public virtual bool AuthenticateWithMasterKey (NSData masterKey)
		{
			if (masterKey == null)
				throw new ArgumentNullException ("masterKey");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("authenticateWithMasterKey:"), masterKey.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("authenticateWithMasterKey:"), masterKey.Handle);
			}
		}
		
		[Export ("authenticateWithMasterKey:length:")]
		[CompilerGenerated]
		public virtual bool AuthenticateWithMasterKey (global::System.IntPtr masterKey, global::System.nuint length)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("authenticateWithMasterKey:length:"), masterKey, length);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("authenticateWithMasterKey:length:"), masterKey, length);
			}
		}
		
		[Export ("detach")]
		[CompilerGenerated]
		public virtual void Detach ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("detach"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("detach"));
			}
		}
		
		[Export ("getDeviceInfoWithType:")]
		[CompilerGenerated]
		public virtual bool GetDeviceInfoWithType (global::System.nuint type)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("getDeviceInfoWithType:"), type);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("getDeviceInfoWithType:"), type);
			}
		}
		
		[Export ("powerOffCard")]
		[CompilerGenerated]
		public virtual bool PowerOffCard ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("powerOffCard"));
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerOffCard"));
			}
		}
		
		[Export ("powerOnCard")]
		[CompilerGenerated]
		public virtual bool PowerOnCard ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("powerOnCard"));
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("powerOnCard"));
			}
		}
		
		[Export ("transmitApdu:")]
		[CompilerGenerated]
		public virtual bool TransmitApdu (NSData apdu)
		{
			if (apdu == null)
				throw new ArgumentNullException ("apdu");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("transmitApdu:"), apdu.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("transmitApdu:"), apdu.Handle);
			}
		}
		
		[Export ("transmitApdu:length:")]
		[CompilerGenerated]
		public virtual bool TransmitApdu (global::System.IntPtr apdu, global::System.nuint length)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("transmitApdu:length:"), apdu, length);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("transmitApdu:length:"), apdu, length);
			}
		}
		
		[Export ("transmitEscapeCommand:")]
		[CompilerGenerated]
		public virtual bool TransmitEscapeCommand (NSData command)
		{
			if (command == null)
				throw new ArgumentNullException ("command");
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("transmitEscapeCommand:"), command.Handle);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("transmitEscapeCommand:"), command.Handle);
			}
		}
		
		[Export ("transmitEscapeCommand:length:")]
		[CompilerGenerated]
		public virtual bool TransmitEscapeCommand (global::System.IntPtr command, global::System.nuint length)
		{
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_nuint (this.Handle, Selector.GetHandle ("transmitEscapeCommand:length:"), command, length);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_nuint (this.SuperHandle, Selector.GetHandle ("transmitEscapeCommand:length:"), command, length);
			}
		}
		
		[CompilerGenerated]
		public virtual bool CardStatus {
			[Export ("getCardStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("getCardStatus"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCardStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public ABTBluetoothReaderDelegate Delegate {
			get {
				return WeakDelegate as /**/ABTBluetoothReaderDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Weak)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class ABTBluetoothReader */
}
