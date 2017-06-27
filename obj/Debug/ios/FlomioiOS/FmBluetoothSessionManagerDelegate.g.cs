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
	[Protocol (Name = "FmBluetoothSessionManagerDelegate", WrapperType = typeof (FmBluetoothSessionManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveReaderError", Selector = "didReceiveReaderError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindATagUuid", Selector = "didFindATagUuid:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindADataBlockWithNdef", Selector = "didFindADataBlockWithNdef:fromDevice:withError:", ParameterType = new Type [] { typeof (NSDictionary), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnResponseApdu", Selector = "didReturnResponseApdu:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateConnectedDevicesWithDevice", Selector = "updateConnectedDevicesWithDevice:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.FmBluetoothDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveDevicewithPeripheral", Selector = "removeDevicewithPeripheral:", ParameterType = new Type [] { typeof (CoreBluetooth.CBPeripheral) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCardStatus", Selector = "didChangeCardStatus:fromDevice:", ParameterType = new Type [] { typeof (NSNumber), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMasterKeyUpdate", Selector = "didMasterKeyUpdate:withError:", ParameterType = new Type [] { typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IFmBluetoothSessionManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class FmBluetoothSessionManagerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveReaderError (this IFmBluetoothSessionManagerDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didReceiveReaderError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFindATagUuid (this IFmBluetoothSessionManagerDelegate This, string UUID, string deviceId, NSError error)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (deviceId == null)
				throw new ArgumentNullException ("deviceId");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsUUID = NSString.CreateNative (UUID);
			var nsdeviceId = NSString.CreateNative (deviceId);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsdeviceId, error.Handle);
			NSString.ReleaseNative (nsUUID);
			NSString.ReleaseNative (nsdeviceId);
			
		}
		
		[CompilerGenerated]
		public static void DidFindADataBlockWithNdef (this IFmBluetoothSessionManagerDelegate This, NSDictionary ndef, string device, NSError error)
		{
			if (ndef == null)
				throw new ArgumentNullException ("ndef");
			if (device == null)
				throw new ArgumentNullException ("device");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsdevice = NSString.CreateNative (device);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFindADataBlockWithNdef:fromDevice:withError:"), ndef.Handle, nsdevice, error.Handle);
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[CompilerGenerated]
		public static void DidReturnResponseApdu (this IFmBluetoothSessionManagerDelegate This, string response, string device, NSError error)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (device == null)
				throw new ArgumentNullException ("device");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsresponse = NSString.CreateNative (response);
			var nsdevice = NSString.CreateNative (device);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didReturnResponseApdu:fromDevice:withError:"), nsresponse, nsdevice, error.Handle);
			NSString.ReleaseNative (nsresponse);
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[CompilerGenerated]
		public static void UpdateConnectedDevicesWithDevice (this IFmBluetoothSessionManagerDelegate This, FmBluetoothDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("updateConnectedDevicesWithDevice:"), device.Handle);
		}
		
		[CompilerGenerated]
		public static void RemoveDevicewithPeripheral (this IFmBluetoothSessionManagerDelegate This, global::CoreBluetooth.CBPeripheral peripheral)
		{
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("removeDevicewithPeripheral:"), peripheral.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeCardStatus (this IFmBluetoothSessionManagerDelegate This, NSNumber status, string device)
		{
			if (status == null)
				throw new ArgumentNullException ("status");
			if (device == null)
				throw new ArgumentNullException ("device");
			var nsdevice = NSString.CreateNative (device);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didChangeCardStatus:fromDevice:"), status.Handle, nsdevice);
			NSString.ReleaseNative (nsdevice);
			
		}
		
		[CompilerGenerated]
		public static void DidMasterKeyUpdate (this IFmBluetoothSessionManagerDelegate This, bool success, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("didMasterKeyUpdate:withError:"), success, error.Handle);
		}
		
	}
	
	internal sealed class FmBluetoothSessionManagerDelegateWrapper : BaseWrapper, IFmBluetoothSessionManagerDelegate {
		public FmBluetoothSessionManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public FmBluetoothSessionManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FloBLEPlus.iOS {
	[Protocol]
	[Register("FmBluetoothSessionManagerDelegate", false)]
	[Model]
	public unsafe partial class FmBluetoothSessionManagerDelegate : NSObject, IFmBluetoothSessionManagerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FmBluetoothSessionManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected FmBluetoothSessionManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FmBluetoothSessionManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("didChangeCardStatus:fromDevice:")]
		[CompilerGenerated]
		public virtual void DidChangeCardStatus (NSNumber status, string device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFindADataBlockWithNdef:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidFindADataBlockWithNdef (NSDictionary ndef, string device, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didFindATagUuid:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidFindATagUuid (string UUID, string deviceId, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didMasterKeyUpdate:withError:")]
		[CompilerGenerated]
		public virtual void DidMasterKeyUpdate (bool success, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didReceiveReaderError:")]
		[CompilerGenerated]
		public virtual void DidReceiveReaderError (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didReturnResponseApdu:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidReturnResponseApdu (string response, string device, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("removeDevicewithPeripheral:")]
		[CompilerGenerated]
		public virtual void RemoveDevicewithPeripheral (global::CoreBluetooth.CBPeripheral peripheral)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("updateConnectedDevicesWithDevice:")]
		[CompilerGenerated]
		public virtual void UpdateConnectedDevicesWithDevice (FmBluetoothDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class FmBluetoothSessionManagerDelegate */
}
