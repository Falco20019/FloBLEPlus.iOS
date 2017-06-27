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
	[Protocol (Name = "AcsBtReaderDelegate", WrapperType = typeof (AcsBtReaderDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveReaderError", Selector = "didReceiveReaderError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindATagUuid", Selector = "didFindATagUuid:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindADataBlockWithNdef", Selector = "didFindADataBlockWithNdef:fromDevice:withError:", ParameterType = new Type [] { typeof (NSDictionary), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReturnResponseApdu", Selector = "didReturnResponseApdu:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateConnectedDevicesWithDevice", Selector = "updateConnectedDevicesWithDevice:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.FmBluetoothDevice) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCardStatus", Selector = "didChangeCardStatus:fromDevice:", ParameterType = new Type [] { typeof (NSNumber), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMasterKeyUpdate", Selector = "didMasterKeyUpdate:withError:", ParameterType = new Type [] { typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	public interface IAcsBtReaderDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class AcsBtReaderDelegate_Extensions {
		[CompilerGenerated]
		public static void DidReceiveReaderError (this IAcsBtReaderDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didReceiveReaderError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidFindATagUuid (this IAcsBtReaderDelegate This, string UUID, string serialNumber, NSError error)
		{
			if (UUID == null)
				throw new ArgumentNullException ("UUID");
			if (serialNumber == null)
				throw new ArgumentNullException ("serialNumber");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsUUID = NSString.CreateNative (UUID);
			var nsserialNumber = NSString.CreateNative (serialNumber);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didFindATagUuid:fromDevice:withError:"), nsUUID, nsserialNumber, error.Handle);
			NSString.ReleaseNative (nsUUID);
			NSString.ReleaseNative (nsserialNumber);
			
		}
		
		[CompilerGenerated]
		public static void DidFindADataBlockWithNdef (this IAcsBtReaderDelegate This, NSDictionary ndef, string device, NSError error)
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
		public static void DidReturnResponseApdu (this IAcsBtReaderDelegate This, string response, string device, NSError error)
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
		public static void UpdateConnectedDevicesWithDevice (this IAcsBtReaderDelegate This, FmBluetoothDevice device)
		{
			if (device == null)
				throw new ArgumentNullException ("device");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("updateConnectedDevicesWithDevice:"), device.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeCardStatus (this IAcsBtReaderDelegate This, NSNumber status, string device)
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
		public static void DidMasterKeyUpdate (this IAcsBtReaderDelegate This, bool success, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("didMasterKeyUpdate:withError:"), success, error.Handle);
		}
		
	}
	
	internal sealed class AcsBtReaderDelegateWrapper : BaseWrapper, IAcsBtReaderDelegate {
		public AcsBtReaderDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public AcsBtReaderDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FloBLEPlus.iOS {
	[Protocol]
	[Register("AcsBtReaderDelegate", false)]
	[Model]
	public unsafe partial class AcsBtReaderDelegate : NSObject, IAcsBtReaderDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AcsBtReaderDelegate () : base (NSObjectFlag.Empty)
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
		protected AcsBtReaderDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AcsBtReaderDelegate (IntPtr handle) : base (handle)
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
		public virtual void DidFindATagUuid (string UUID, string serialNumber, NSError error)
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
		
		[Export ("updateConnectedDevicesWithDevice:")]
		[CompilerGenerated]
		public virtual void UpdateConnectedDevicesWithDevice (FmBluetoothDevice device)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class AcsBtReaderDelegate */
}
