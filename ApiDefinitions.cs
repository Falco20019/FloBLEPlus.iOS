using System;
using CoreBluetooth;
using Foundation;
using ObjCRuntime;

namespace FloBLEPlus.iOS
{
	// @interface ABTBluetoothReader : NSObject
	[BaseType (typeof(NSObject))]
	interface ABTBluetoothReader
	{
		[Wrap ("WeakDelegate")]
		ABTBluetoothReaderDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ABTBluetoothReaderDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)attachPeripheral:(CBPeripheral *)peripheral;
		[Export ("attachPeripheral:")]
		void AttachPeripheral (CBPeripheral peripheral);

		// -(void)detach;
		[Export ("detach")]
		void Detach ();

		// -(BOOL)getDeviceInfoWithType:(ABTBluetoothReaderDeviceInfo)type;
		[Export ("getDeviceInfoWithType:")]
		bool GetDeviceInfoWithType (nuint type);

		// -(BOOL)authenticateWithMasterKey:(NSData *)masterKey;
		[Export ("authenticateWithMasterKey:")]
		bool AuthenticateWithMasterKey (NSData masterKey);

		// -(BOOL)authenticateWithMasterKey:(const uint8_t *)masterKey length:(NSUInteger)length;
		[Export ("authenticateWithMasterKey:length:")]
		unsafe bool AuthenticateWithMasterKey (IntPtr masterKey, nuint length);

		// -(BOOL)powerOnCard;
		[Export("powerOnCard")]
		bool PowerOnCard();

		// -(BOOL)powerOffCard;
		[Export("powerOffCard")]
		bool PowerOffCard();

		// -(BOOL)getCardStatus;
		[Export ("getCardStatus")]
		bool CardStatus { get; }

		// -(BOOL)transmitApdu:(NSData *)apdu;
		[Export ("transmitApdu:")]
		bool TransmitApdu (NSData apdu);

		// -(BOOL)transmitApdu:(const uint8_t *)apdu length:(NSUInteger)length;
		[Export ("transmitApdu:length:")]
		unsafe bool TransmitApdu (IntPtr apdu, nuint length);

		// -(BOOL)transmitEscapeCommand:(NSData *)command;
		[Export ("transmitEscapeCommand:")]
		bool TransmitEscapeCommand (NSData command);

		// -(BOOL)transmitEscapeCommand:(const uint8_t *)command length:(NSUInteger)length;
		[Export ("transmitEscapeCommand:length:")]
		unsafe bool TransmitEscapeCommand (IntPtr command, nuint length);
	}

	// @protocol ABTBluetoothReaderDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface ABTBluetoothReaderDelegate
	{
		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didAttachPeripheral:(CBPeripheral *)peripheral error:(NSError *)error;
		[Export ("bluetoothReader:didAttachPeripheral:error:")]
		void DidAttachPeripheral (ABTBluetoothReader bluetoothReader, CBPeripheral peripheral, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didReturnDeviceInfo:(NSObject *)deviceInfo type:(ABTBluetoothReaderDeviceInfo)type error:(NSError *)error;
		[Export ("bluetoothReader:didReturnDeviceInfo:type:error:")]
		void DidReturnDeviceInfo (ABTBluetoothReader bluetoothReader, NSObject deviceInfo, ABTBluetoothReaderDeviceInfo type, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didChangeCardStatus:(ABTBluetoothReaderCardStatus)cardStatus error:(NSError *)error;
		[Export ("bluetoothReader:didChangeCardStatus:error:")]
		void DidChangeCardStatus (ABTBluetoothReader bluetoothReader, ABTBluetoothReaderCardStatus cardStatus, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didChangeBatteryStatus:(ABTBluetoothReaderBatteryStatus)batteryStatus error:(NSError *)error;
		[Export ("bluetoothReader:didChangeBatteryStatus:error:")]
		void DidChangeBatteryStatus (ABTBluetoothReader bluetoothReader, ABTBluetoothReaderBatteryStatus batteryStatus, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didChangeBatteryLevel:(NSUInteger)batteryLevel error:(NSError *)error;
		[Export ("bluetoothReader:didChangeBatteryLevel:error:")]
		void DidChangeBatteryLevel (ABTBluetoothReader bluetoothReader, nuint batteryLevel, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didAuthenticateWithError:(NSError *)error;
		[Export ("bluetoothReader:didAuthenticateWithError:")]
		void DidAuthenticateWithError (ABTBluetoothReader bluetoothReader, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didReturnAtr:(NSData *)atr error:(NSError *)error;
		[Export ("bluetoothReader:didReturnAtr:error:")]
		void DidReturnAtr (ABTBluetoothReader bluetoothReader, NSData atr, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didPowerOffCardWithError:(NSError *)error;
		[Export ("bluetoothReader:didPowerOffCardWithError:")]
		void DidPowerOffCardWithError (ABTBluetoothReader bluetoothReader, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didReturnCardStatus:(ABTBluetoothReaderCardStatus)cardStatus error:(NSError *)error;
		[Export ("bluetoothReader:didReturnCardStatus:error:")]
		void DidReturnCardStatus (ABTBluetoothReader bluetoothReader, ABTBluetoothReaderCardStatus cardStatus, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didReturnResponseApdu:(NSData *)apdu error:(NSError *)error;
		[Export ("bluetoothReader:didReturnResponseApdu:error:")]
		void DidReturnResponseApdu (ABTBluetoothReader bluetoothReader, NSData apdu, NSError error);

		// @optional -(void)bluetoothReader:(ABTBluetoothReader *)bluetoothReader didReturnEscapeResponse:(NSData *)response error:(NSError *)error;
		[Export ("bluetoothReader:didReturnEscapeResponse:error:")]
		void DidReturnEscapeResponse (ABTBluetoothReader bluetoothReader, NSData response, NSError error);
	}

	// @interface ABTAcr1255uj1Reader : ABTBluetoothReader
	[BaseType (typeof(ABTBluetoothReader))]
	interface ABTAcr1255uj1Reader
	{
		// -(BOOL)getBatteryLevel;
		[Export ("getBatteryLevel")]
		bool BatteryLevel { get; }
	}

	// @interface ABTBluetoothReaderManager : NSObject
	[BaseType (typeof(NSObject))]
	interface ABTBluetoothReaderManager
	{
		[Wrap ("WeakDelegate")]
		ABTBluetoothReaderManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<ABTBluetoothReaderManagerDelegate> delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// -(void)detectReaderWithPeripheral:(CBPeripheral *)peripheral;
		[Export ("detectReaderWithPeripheral:")]
		void DetectReaderWithPeripheral (CBPeripheral peripheral);
	}

	// @protocol ABTBluetoothReaderManagerDelegate <NSObject>
	[BaseType(typeof(NSObject))]
	[Model]
	interface ABTBluetoothReaderManagerDelegate
	{
		// @optional -(void)bluetoothReaderManager:(ABTBluetoothReaderManager *)bluetoothReaderManager didDetectReader:(ABTBluetoothReader *)reader peripheral:(CBPeripheral *)peripheral error:(NSError *)error;
		[Export ("bluetoothReaderManager:didDetectReader:peripheral:error:")]
		void DidDetectReader (ABTBluetoothReaderManager bluetoothReaderManager, ABTBluetoothReader reader, CBPeripheral peripheral, NSError error);
	}
}
