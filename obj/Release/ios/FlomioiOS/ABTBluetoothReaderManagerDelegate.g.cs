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
	[Protocol (Name = "ABTBluetoothReaderManagerDelegate", WrapperType = typeof (ABTBluetoothReaderManagerDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDetectReader", Selector = "bluetoothReaderManager:didDetectReader:peripheral:error:", ParameterType = new Type [] { typeof (FloBLEPlus.iOS.ABTBluetoothReaderManager), typeof (FloBLEPlus.iOS.ABTBluetoothReader), typeof (CoreBluetooth.CBPeripheral), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, false })]
	public interface IABTBluetoothReaderManagerDelegate : INativeObject, IDisposable
	{
	}
	
	public static partial class ABTBluetoothReaderManagerDelegate_Extensions {
		[CompilerGenerated]
		public static void DidDetectReader (this IABTBluetoothReaderManagerDelegate This, ABTBluetoothReaderManager bluetoothReaderManager, ABTBluetoothReader reader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			if (bluetoothReaderManager == null)
				throw new ArgumentNullException ("bluetoothReaderManager");
			if (reader == null)
				throw new ArgumentNullException ("reader");
			if (peripheral == null)
				throw new ArgumentNullException ("peripheral");
			if (error == null)
				throw new ArgumentNullException ("error");
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("bluetoothReaderManager:didDetectReader:peripheral:error:"), bluetoothReaderManager.Handle, reader.Handle, peripheral.Handle, error.Handle);
		}
		
	}
	
	internal sealed class ABTBluetoothReaderManagerDelegateWrapper : BaseWrapper, IABTBluetoothReaderManagerDelegate {
		public ABTBluetoothReaderManagerDelegateWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public ABTBluetoothReaderManagerDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace FloBLEPlus.iOS {
	[Protocol]
	[Register("ABTBluetoothReaderManagerDelegate", false)]
	[Model]
	public unsafe partial class ABTBluetoothReaderManagerDelegate : NSObject, IABTBluetoothReaderManagerDelegate {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public ABTBluetoothReaderManagerDelegate () : base (NSObjectFlag.Empty)
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
		protected ABTBluetoothReaderManagerDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal ABTBluetoothReaderManagerDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("bluetoothReaderManager:didDetectReader:peripheral:error:")]
		[CompilerGenerated]
		public virtual void DidDetectReader (ABTBluetoothReaderManager bluetoothReaderManager, ABTBluetoothReader reader, global::CoreBluetooth.CBPeripheral peripheral, NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class ABTBluetoothReaderManagerDelegate */
}
