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
	[Protocol (Name = "ABTBluetoothReaderDelegate", WrapperType = typeof (ABTBluetoothReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAttachPeripheral", Selector = "bluetoothReader:didAttachPeripheral:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnDeviceInfo", Selector = "bluetoothReader:didReturnDeviceInfo:type:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSObject), typeof (nuint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCardStatus", Selector = "bluetoothReader:didChangeCardStatus:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (nuint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeBatteryStatus", Selector = "bluetoothReader:didChangeBatteryStatus:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (nuint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeBatteryLevel", Selector = "bluetoothReader:didChangeBatteryLevel:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (nuint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAuthenticateWithError", Selector = "bluetoothReader:didAuthenticateWithError:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnAtr", Selector = "bluetoothReader:didReturnAtr:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidPowerOffCardWithError", Selector = "bluetoothReader:didPowerOffCardWithError:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnCardStatus", Selector = "bluetoothReader:didReturnCardStatus:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (nuint), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnResponseApdu", Selector = "bluetoothReader:didReturnResponseApdu:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnEscapeResponse", Selector = "bluetoothReader:didReturnEscapeResponse:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (NSData), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	public interface IABTBluetoothReaderDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class ABTBluetoothReaderDelegate_Extensions {
		[CompilerGenerated]
		public static void DidAttachPeripheral (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didAttachPeripheral:error:"), bluetoothReader.Handle, peripheral.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReturnDeviceInfo (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSObject deviceInfo, global::System.nuint type, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (deviceInfo == null)
				throw new ArgumentNullException ("deviceInfo");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didReturnDeviceInfo:type:error:"), bluetoothReader.Handle, deviceInfo.Handle, type, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeCardStatus (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didChangeCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeBatteryStatus (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, global::System.nuint batteryStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didChangeBatteryStatus:error:"), bluetoothReader.Handle, batteryStatus, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeBatteryLevel (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, global::System.nuint batteryLevel, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didChangeBatteryLevel:error:"), bluetoothReader.Handle, batteryLevel, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidAuthenticateWithError (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didAuthenticateWithError:"), bluetoothReader.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReturnAtr (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSData atr, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (atr == null)
				throw new ArgumentNullException ("atr");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didReturnAtr:error:"), bluetoothReader.Handle, atr.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidPowerOffCardWithError (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didPowerOffCardWithError:"), bluetoothReader.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReturnCardStatus (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_nuint_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didReturnCardStatus:error:"), bluetoothReader.Handle, cardStatus, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReturnResponseApdu (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSData apdu, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (apdu == null)
				throw new ArgumentNullException ("apdu");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didReturnResponseApdu:error:"), bluetoothReader.Handle, apdu.Handle, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidReturnEscapeResponse (this IABTBluetoothReaderDelegate This, ABTBluetoothReader bluetoothReader, NSData response, NSError error)
		{
			if (bluetoothReader == null)
				throw new ArgumentNullException ("bluetoothReader");
			if (response == null)
				throw new ArgumentNullException ("response");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReader:didReturnEscapeResponse:error:"), bluetoothReader.Handle, response.Handle, error.Handle);
		}
		
	}
	
	internal sealed class ABTBluetoothReaderDelegateWrapper : BaseWrapper, IABTBluetoothReaderDelegate {
		public ABTBluetoothReaderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ABTBluetoothReaderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FloBLEPlus.iOS {
	[Protocol]
	[Register("ABTBluetoothReaderDelegate", false)]
	[Model]
	public unsafe partial class ABTBluetoothReaderDelegate : NSObject, IABTBluetoothReaderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABTBluetoothReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected ABTBluetoothReaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ABTBluetoothReaderDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("bluetoothReader:didAttachPeripheral:error:")]
		[CompilerGenerated]
		public virtual void DidAttachPeripheral (ABTBluetoothReader bluetoothReader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didAuthenticateWithError:")]
		[CompilerGenerated]
		public virtual void DidAuthenticateWithError (ABTBluetoothReader bluetoothReader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didChangeBatteryLevel:error:")]
		[CompilerGenerated]
		public virtual void DidChangeBatteryLevel (ABTBluetoothReader bluetoothReader, global::System.nuint batteryLevel, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didChangeBatteryStatus:error:")]
		[CompilerGenerated]
		public virtual void DidChangeBatteryStatus (ABTBluetoothReader bluetoothReader, global::System.nuint batteryStatus, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didChangeCardStatus:error:")]
		[CompilerGenerated]
		public virtual void DidChangeCardStatus (ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didPowerOffCardWithError:")]
		[CompilerGenerated]
		public virtual void DidPowerOffCardWithError (ABTBluetoothReader bluetoothReader, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didReturnAtr:error:")]
		[CompilerGenerated]
		public virtual void DidReturnAtr (ABTBluetoothReader bluetoothReader, NSData atr, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didReturnCardStatus:error:")]
		[CompilerGenerated]
		public virtual void DidReturnCardStatus (ABTBluetoothReader bluetoothReader, global::System.nuint cardStatus, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didReturnDeviceInfo:type:error:")]
		[CompilerGenerated]
		public virtual void DidReturnDeviceInfo (ABTBluetoothReader bluetoothReader, NSObject deviceInfo, global::System.nuint type, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didReturnEscapeResponse:error:")]
		[CompilerGenerated]
		public virtual void DidReturnEscapeResponse (ABTBluetoothReader bluetoothReader, NSData response, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("bluetoothReader:didReturnResponseApdu:error:")]
		[CompilerGenerated]
		public virtual void DidReturnResponseApdu (ABTBluetoothReader bluetoothReader, NSData apdu, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class ABTBluetoothReaderDelegate */
}
