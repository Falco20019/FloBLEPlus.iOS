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
	[Register("FmSessionManager", true)]
	public unsafe partial class FmSessionManager : NSObject, global::AVFoundation.IAVAudioPlayerDelegate, IFmBluetoothSessionManagerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("FmSessionManager");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FmSessionManager () : base (NSObjectFlag.Empty)
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
		protected FmSessionManager (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FmSessionManager (IntPtr handle) : base (handle)
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
		public virtual void DidFindATagUuid (string UUID, string deviceId, NSError error)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (deviceId == null)
				throw new ArgumentNullException ("deviceId");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsUUID = NSString.CreateNative (UUID);
			var nsdeviceId = NSString.CreateNative (deviceId);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsdeviceId, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsdeviceId, error.Handle);
			}
			NSString.ReleaseNative (nsUUID);
			NSString.ReleaseNative (nsdeviceId);
			
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
		
		[Export ("removeDevicewithPeripheral:")]
		[CompilerGenerated]
		public virtual void RemoveDevicewithPeripheral (global::CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeDevicewithPeripheral:"), peripheral.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeDevicewithPeripheral:"), peripheral.Handle);
			}
		}
		
		[Export ("sendAPDUtoDevice:")]
		[CompilerGenerated]
		public virtual void SendAPDUtoDevice (string apdu)
		{
			if (apdu == null)
				throw new ArgumentNullException ("apdu");
			var nsapdu = NSString.CreateNative (apdu);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendAPDUtoDevice:"), nsapdu);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendAPDUtoDevice:"), nsapdu);
			}
			NSString.ReleaseNative (nsapdu);
			
		}
		
		[Export ("startReaders")]
		[CompilerGenerated]
		public virtual void StartReaders ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("startReaders"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startReaders"));
			}
		}
		
		[Export ("stopReaders")]
		[CompilerGenerated]
		public virtual void StopReaders ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopReaders"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopReaders"));
			}
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
		public virtual FmBluetoothSessionManager BtManager {
			[Export ("btManager", ArgumentSemantic.Retain)]
			get {
				FmBluetoothSessionManager ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FmBluetoothSessionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("btManager")));
				} else {
					ret =  Runtime.GetNSObject<FmBluetoothSessionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("btManager")));
				}
				return ret;
			}
			
			[Export ("setBtManager:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBtManager:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBtManager:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public FmSessionManagerDelegate Delegate {
			get {
				return WeakDelegate as /**/FmSessionManagerDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint PollPeriod {
			[Export ("pollPeriod")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("pollPeriod"));
				} else {
					return global::ApiDefinitions.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pollPeriod"));
				}
			}
			
			[Export ("setPollPeriod:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setPollPeriod:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setPollPeriod:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSNumber ScanPeriod {
			[Export ("scanPeriod", ArgumentSemantic.Retain)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scanPeriod")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scanPeriod")));
				}
				return ret;
			}
			
			[Export ("setScanPeriod:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScanPeriod:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScanPeriod:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ScanSound_var;
		[CompilerGenerated]
		public virtual NSNumber ScanSound {
			[Export ("scanSound", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSNumber ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("scanSound")));
				} else {
					ret =  Runtime.GetNSObject<NSNumber> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("scanSound")));
				}
				MarkDirty ();
				__mt_ScanSound_var = ret;
				return ret;
			}
			
			[Export ("setScanSound:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScanSound:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScanSound:"), value.Handle);
				}
				MarkDirty ();
				__mt_ScanSound_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual DeviceType SelectedDeviceType {
			[Export ("selectedDeviceType", ArgumentSemantic.UnsafeUnretained)]
			get {
				DeviceType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (DeviceType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("selectedDeviceType"));
					} else {
						ret = (DeviceType) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("selectedDeviceType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (DeviceType) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedDeviceType"));
					} else {
						ret = (DeviceType) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("selectedDeviceType"));
					}
				}
				return ret;
			}
			
			[Export ("setSelectedDeviceType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setSelectedDeviceType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setSelectedDeviceType:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setSelectedDeviceType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setSelectedDeviceType:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public static FmSessionManager SharedManager {
			[Export ("sharedManager")]
			get {
				FmSessionManager ret;
				ret =  Runtime.GetNSObject<FmSessionManager> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedManager")));
				return ret;
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
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ScanSound_var = null;
			}
		}
	} /* class FmSessionManager */
}
