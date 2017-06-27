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
	[Protocol (Name = "FmSessionManagerDelegate", WrapperType = typeof (FmSessionManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindATagUuid", Selector = "didFindATagUuid:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFindADataBlockWithNdef", Selector = "didFindADataBlockWithNdef:fromDevice:withError:", ParameterType = new Type [] { typeof (NSDictionary), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRespondToApduCommand", Selector = "didRespondToApduCommand:fromDevice:withError:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateConnectedDevices", Selector = "didUpdateConnectedDevices:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.FmDevice[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveReaderError", Selector = "didReceiveReaderError:", ParameterType = new Type [] { typeof (NSError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidMasterKeyUpdate", Selector = "didMasterKeyUpdate:withError:", ParameterType = new Type [] { typeof (bool), typeof (NSError) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidChangeCardStatus", Selector = "didChangeCardStatus:fromDevice:", ParameterType = new Type [] { typeof (NSNumber), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateConnectedBR500", Selector = "didUpdateConnectedBR500:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	public interface IFmSessionManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class FmSessionManagerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidFindATagUuid (this IFmSessionManagerDelegate This, string UUID, string deviceId, NSError error)
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
		public static void DidFindADataBlockWithNdef (this IFmSessionManagerDelegate This, NSDictionary ndef, string device, NSError error)
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
		public static void DidRespondToApduCommand (this IFmSessionManagerDelegate This, string response, string deviceId, NSError error)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			if (deviceId == null)
				throw new ArgumentNullException ("deviceId");
			if (error == null)
				throw new ArgumentNullException ("error");
			var nsresponse = NSString.CreateNative (response);
			var nsdeviceId = NSString.CreateNative (deviceId);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("didRespondToApduCommand:fromDevice:withError:"), nsresponse, nsdeviceId, error.Handle);
			NSString.ReleaseNative (nsresponse);
			NSString.ReleaseNative (nsdeviceId);
			
		}
		
		[CompilerGenerated]
		public static void DidUpdateConnectedDevices (this IFmSessionManagerDelegate This, FmDevice[] devices)
		{
			if (devices == null)
				throw new ArgumentNullException ("devices");
			var nsa_devices = NSArray.FromNSObjects (devices);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didUpdateConnectedDevices:"), nsa_devices.Handle);
			nsa_devices.Dispose ();
			
		}
		
		[CompilerGenerated]
		public static void DidReceiveReaderError (this IFmSessionManagerDelegate This, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didReceiveReaderError:"), error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidMasterKeyUpdate (this IFmSessionManagerDelegate This, bool success, NSError error)
		{
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_bool_IntPtr (This.Handle, Selector.GetHandle ("didMasterKeyUpdate:withError:"), success, error.Handle);
		}
		
		[CompilerGenerated]
		public static void DidChangeCardStatus (this IFmSessionManagerDelegate This, NSNumber status, string device)
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
		public static void DidUpdateConnectedBR500 (this IFmSessionManagerDelegate This, NSObject[] peripherals)
		{
			if (peripherals == null)
				throw new ArgumentNullException ("peripherals");
			var nsa_peripherals = NSArray.FromNSObjects (peripherals);
			
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("didUpdateConnectedBR500:"), nsa_peripherals.Handle);
			nsa_peripherals.Dispose ();
			
		}
		
	}
	
	internal sealed class FmSessionManagerDelegateWrapper : BaseWrapper, IFmSessionManagerDelegate {
		public FmSessionManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public FmSessionManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FloBLEPlus.iOS {
	[Protocol]
	[Register("FmSessionManagerDelegate", false)]
	[Model]
	public unsafe partial class FmSessionManagerDelegate : NSObject, IFmSessionManagerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public FmSessionManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected FmSessionManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal FmSessionManagerDelegate (IntPtr handle) : base (handle)
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
		
		[Export ("didRespondToApduCommand:fromDevice:withError:")]
		[CompilerGenerated]
		public virtual void DidRespondToApduCommand (string response, string deviceId, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateConnectedBR500:")]
		[CompilerGenerated]
		public virtual void DidUpdateConnectedBR500 (NSObject[] peripherals)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("didUpdateConnectedDevices:")]
		[CompilerGenerated]
		public virtual void DidUpdateConnectedDevices (FmDevice[] devices)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class FmSessionManagerDelegate */
}
