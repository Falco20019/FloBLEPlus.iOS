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
	[Register("FmBluetoothSessionManager", true)]
	public unsafe partial class FmBluetoothSessionManager : NSObject, global::CoreBluetooth.ICBCentralManagerDelegate, global::CoreBluetooth.ICBPeripheralDelegate, IAcsBtReaderDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("FmBluetoothSessionManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FmBluetoothSessionManager () : base (NSObjectFlag.Empty)
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
		protected FmBluetoothSessionManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FmBluetoothSessionManager (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("didChangeCardStatus:fromDevice:")]
		[CompilerGenerated]
		public virtual void DidChangeCardStatus (NSNumber status, string device)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			if (device == null)
				throw new ArgumentNullException ("device");
			var nsdevice = NSString.CreateNative (device);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didChangeCardStatus:fromDevice:"), status.Handle, nsdevice);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didChangeCardStatus:fromDevice:"), status.Handle, nsdevice);
			}
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[Export ("didFindADataBlockWithNdef:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidFindADataBlockWithNdef (NSDictionary ndef, string device, NSError error)
		{
			if (ndef == null)
				throw new ArgumentNullException ("ndef");
			if (device == null)
				throw new ArgumentNullException ("device");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsdevice = NSString.CreateNative (device);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didFindADataBlockWithNdef:fromDevice:withError:"), ndef.Handle, nsdevice, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didFindADataBlockWithNdef:fromDevice:withError:"), ndef.Handle, nsdevice, error.Handle);
			}
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[Export ("didFindATagUuid:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidFindATagUuid (string UUID, string serialNumber, NSError error)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (serialNumber == null)
				throw new ArgumentNullException ("serialNumber");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsUUID = NSString.CreateNative (UUID);
			var nsserialNumber = NSString.CreateNative (serialNumber);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsserialNumber, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsserialNumber, error.Handle);
			}
			NSString.ReleaseNative (nsUUID);
			NSString.ReleaseNative (nsserialNumber);
			
		}
		
		[Export ("didMasterKeyUpdate:withError:")]
		[CompilerGenerated]
		public virtual void DidMasterKeyUpdate (bool success, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (this.Handle, Selector.GetHandle ("didMasterKeyUpdate:withError:"), success, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool_IntPtr (this.SuperHandle, Selector.GetHandle ("didMasterKeyUpdate:withError:"), success, error.Handle);
			}
		}
		
		[Export ("didReceiveReaderError:")]
		[CompilerGenerated]
		public virtual void DidReceiveReaderError (NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("didReceiveReaderError:"), error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("didReceiveReaderError:"), error.Handle);
			}
		}
		
		[Export ("didReturnResponseApdu:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidReturnResponseApdu (string response, string device, NSError error)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (device == null)
				throw new ArgumentNullException ("device");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsresponse = NSString.CreateNative (response);
			var nsdevice = NSString.CreateNative (device);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didReturnResponseApdu:fromDevice:withError:"), nsresponse, nsdevice, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didReturnResponseApdu:fromDevice:withError:"), nsresponse, nsdevice, error.Handle);
			}
			NSString.ReleaseNative (nsresponse);
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[Export ("updateConnectedDevicesWithDevice:")]
		[CompilerGenerated]
		public virtual void UpdateConnectedDevicesWithDevice (FmBluetoothDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("updateConnectedDevicesWithDevice:"), device.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("updateConnectedDevicesWithDevice:"), device.Handle);
			}
		}
		
		[Export ("centralManagerDidUpdateState:")]
		[CompilerGenerated]
		public virtual void UpdatedState (global::CoreBluetooth.CBCentralManager central)
		{
			if (central == null)
				throw new ArgumentNullException ("central");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("centralManagerDidUpdateState:"), central.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("centralManagerDidUpdateState:"), central.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual NSMutableArray AcceptedSerialNumbers {
			[Export ("acceptedSerialNumbers", ArgumentSemantic.Retain)]
			get {
				NSMutableArray ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("acceptedSerialNumbers")));
				} else {
					ret =  Runtime.GetNSObject<NSMutableArray> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("acceptedSerialNumbers")));
				}
				return ret;
			}
			
			[Export ("setAcceptedSerialNumbers:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAcceptedSerialNumbers:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAcceptedSerialNumbers:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public FmBluetoothSessionManagerDelegate Delegate {
			get {
				return WeakDelegate as /**/FmBluetoothSessionManagerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")));
				}
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
	} /* class FmBluetoothSessionManager */
}
