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
	[Register("AcsBtReader", true)]
	public unsafe partial class AcsBtReader : NSObject, IABTBluetoothReaderDelegate, IABTBluetoothReaderManagerDelegate {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AcsBtReader");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AcsBtReader () : base (NSObjectFlag.Empty)
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
		protected AcsBtReader (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AcsBtReader (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("bluetoothReader:didAttachPeripheral:error:")]
		[CompilerGenerated]
		public virtual void DidAttachPeripheral (ABTBluetoothReader bluetoothReader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didAttachPeripheral:error:"), bluetoothReader.Handle, peripheral.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didAttachPeripheral:error:"), bluetoothReader.Handle, peripheral.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didAuthenticateWithError:")]
		[CompilerGenerated]
		public virtual void DidAuthenticateWithError (ABTBluetoothReader bluetoothReader, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didAuthenticateWithError:"), bluetoothReader.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didAuthenticateWithError:"), bluetoothReader.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didChangeBatteryLevel:error:")]
		[CompilerGenerated]
		public virtual void DidChangeBatteryLevel (ABTBluetoothReader bluetoothReader, global::System.nuint batteryLevel, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didChangeBatteryLevel:error:"), bluetoothReader.Handle, batteryLevel, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didChangeBatteryLevel:error:"), bluetoothReader.Handle, batteryLevel, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didChangeBatteryStatus:error:")]
		[CompilerGenerated]
		public virtual void DidChangeBatteryStatus (ABTBluetoothReader bluetoothReader, global::System.nuint batteryStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didChangeBatteryStatus:error:"), bluetoothReader.Handle, batteryStatus, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didChangeBatteryStatus:error:"), bluetoothReader.Handle, batteryStatus, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didChangeCardStatus:error:")]
		[CompilerGenerated]
		public virtual void DidChangeCardStatus (ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didChangeCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didChangeCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
			}
		}
		
		[Export ("bluetoothReaderManager:didDetectReader:peripheral:error:")]
		[CompilerGenerated]
		public virtual void DidDetectReader (ABTBluetoothReaderManager bluetoothReaderManager, ABTBluetoothReader reader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			if (bluetoothReaderManager == null)
				throw new ArgumentNullException ("bluetoothReaderManager");
			if (reader == null)
				throw new ArgumentNullException ("reader");
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReaderManager:didDetectReader:peripheral:error:"), bluetoothReaderManager.Handle, reader.Handle, peripheral.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReaderManager:didDetectReader:peripheral:error:"), bluetoothReaderManager.Handle, reader.Handle, peripheral.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didPowerOffCardWithError:")]
		[CompilerGenerated]
		public virtual void DidPowerOffCardWithError (ABTBluetoothReader bluetoothReader, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didPowerOffCardWithError:"), bluetoothReader.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didPowerOffCardWithError:"), bluetoothReader.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didReturnAtr:error:")]
		[CompilerGenerated]
		public virtual void DidReturnAtr (ABTBluetoothReader bluetoothReader, NSData atr, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (atr == null)
				throw new ArgumentNullException ("atr");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didReturnAtr:error:"), bluetoothReader.Handle, atr.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didReturnAtr:error:"), bluetoothReader.Handle, atr.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didReturnCardStatus:error:")]
		[CompilerGenerated]
		public virtual void DidReturnCardStatus (ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didReturnCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didReturnCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didReturnDeviceInfo:type:error:")]
		[CompilerGenerated]
		public virtual void DidReturnDeviceInfo (ABTBluetoothReader bluetoothReader, NSObject deviceInfo, global::System.nuint type, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (deviceInfo == null)
				throw new ArgumentNullException ("deviceInfo");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didReturnDeviceInfo:type:error:"), bluetoothReader.Handle, deviceInfo.Handle, type, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didReturnDeviceInfo:type:error:"), bluetoothReader.Handle, deviceInfo.Handle, type, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didReturnEscapeResponse:error:")]
		[CompilerGenerated]
		public virtual void DidReturnEscapeResponse (ABTBluetoothReader bluetoothReader, NSData response, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (response == null)
				throw new ArgumentNullException ("response");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didReturnEscapeResponse:error:"), bluetoothReader.Handle, response.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didReturnEscapeResponse:error:"), bluetoothReader.Handle, response.Handle, error.Handle);
			}
		}
		
		[Export ("bluetoothReader:didReturnResponseApdu:error:")]
		[CompilerGenerated]
		public virtual void DidReturnResponseApdu (ABTBluetoothReader bluetoothReader, NSData apdu, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (apdu == null)
				throw new ArgumentNullException ("apdu");
			if (error == null)
				throw new ArgumentNullException ("error");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("bluetoothReader:didReturnResponseApdu:error:"), bluetoothReader.Handle, apdu.Handle, error.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("bluetoothReader:didReturnResponseApdu:error:"), bluetoothReader.Handle, apdu.Handle, error.Handle);
			}
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
		
		[Export ("requestUuid")]
		[CompilerGenerated]
		public virtual void RequestUuid ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("requestUuid"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("requestUuid"));
			}
		}
		
		[Export ("startReaderWithPeripheral:")]
		[CompilerGenerated]
		public virtual void StartReaderWithPeripheral (global::CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startReaderWithPeripheral:"), peripheral.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startReaderWithPeripheral:"), peripheral.Handle);
			}
		}
		
		[Export ("stopReader")]
		[CompilerGenerated]
		public virtual void StopReader ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopReader"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopReader"));
			}
		}
		
		[Export ("transmitApdu:")]
		[CompilerGenerated]
		public virtual void TransmitApdu (NSData apdu)
		{
			if (apdu == null)
				throw new ArgumentNullException ("apdu");
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("transmitApdu:"), apdu.Handle);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("transmitApdu:"), apdu.Handle);
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
		public AcsBtReaderDelegate Delegate {
			get {
				return WeakDelegate as /**/AcsBtReaderDelegate;
			}
			set {
				WeakDelegate = value;
			}
		}
		
		[CompilerGenerated]
		public virtual FmBluetoothDevice Device {
			[Export ("device", ArgumentSemantic.Retain)]
			get {
				FmBluetoothDevice ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<FmBluetoothDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("device")));
				} else {
					ret =  Runtime.GetNSObject<FmBluetoothDevice> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("device")));
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
		
	} /* class AcsBtReader */
}
