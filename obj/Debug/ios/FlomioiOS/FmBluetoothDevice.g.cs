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
	[Register("FmBluetoothDevice", true)]
	public unsafe partial class FmBluetoothDevice : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("FmBluetoothDevice");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FmBluetoothDevice () : base (NSObjectFlag.Empty)
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
		protected FmBluetoothDevice (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FmBluetoothDevice (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("getDataBlocks")]
		[CompilerGenerated]
		public virtual void GetDataBlocks ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("getDataBlocks"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDataBlocks"));
			}
		}
		
		[Export ("sendApduCommand:")]
		[CompilerGenerated]
		public virtual void SendApduCommand (string command)
		{
			if (command == null)
				throw new ArgumentNullException ("command");
			var nscommand = NSString.CreateNative (command);
			
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendApduCommand:"), nscommand);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendApduCommand:"), nscommand);
			}
			NSString.ReleaseNative (nscommand);
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nuint BatteryLevel {
			[Export ("batteryLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSend (this.Handle, Selector.GetHandle ("batteryLevel"));
				} else {
					return global::ApiDefinitions.Messaging.nuint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("batteryLevel"));
				}
			}
			
			[Export ("setBatteryLevel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_nuint (this.Handle, Selector.GetHandle ("setBatteryLevel:"), value);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_nuint (this.SuperHandle, Selector.GetHandle ("setBatteryLevel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string CardStatus {
			[Export ("cardStatus", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("cardStatus")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cardStatus")));
				}
			}
			
			[Export ("setCardStatus:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCardStatus:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCardStatus:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual NSObject Device {
			[Export ("device", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("device")));
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("device")));
				}
				return ret;
			}
			
			[Export ("setDevice:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDevice:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDevice:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual DeviceType DeviceType {
			[Export ("deviceType", ArgumentSemantic.UnsafeUnretained)]
			get {
				DeviceType ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (DeviceType) global::ApiDefinitions.Messaging.Int64_objc_msgSend (this.Handle, Selector.GetHandle ("deviceType"));
					} else {
						ret = (DeviceType) global::ApiDefinitions.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("deviceType"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (DeviceType) global::ApiDefinitions.Messaging.Int64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceType"));
					} else {
						ret = (DeviceType) global::ApiDefinitions.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("deviceType"));
					}
				}
				return ret;
			}
			
			[Export ("setDeviceType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSend_Int64 (this.Handle, Selector.GetHandle ("setDeviceType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDeviceType:"), (int)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_Int64 (this.SuperHandle, Selector.GetHandle ("setDeviceType:"), (Int64)value);
					} else {
						global::ApiDefinitions.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDeviceType:"), (int)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::CoreBluetooth.CBPeripheral Peripheral {
			[Export ("peripheral", ArgumentSemantic.Retain)]
			get {
				global::CoreBluetooth.CBPeripheral ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("peripheral")));
				} else {
					ret =  Runtime.GetNSObject<global::CoreBluetooth.CBPeripheral> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("peripheral")));
				}
				return ret;
			}
			
			[Export ("setPeripheral:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPeripheral:"), value.Handle);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPeripheral:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string SerialNumber {
			[Export ("serialNumber", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("serialNumber")));
				} else {
					return NSString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("serialNumber")));
				}
			}
			
			[Export ("setSerialNumber:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSerialNumber:"), nsvalue);
				} else {
					global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSerialNumber:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class FmBluetoothDevice */
}
