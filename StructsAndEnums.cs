namespace FloBLEPlus.iOS
{
	public enum ABTBluetoothReaderCardStatus : uint
	{
		Unknown = 0,
		Absent = 1,
		Present = 2,
		Powered = 3,
		PowerSavingMode = 255
	}

	public enum ABTBluetoothReaderBatteryStatus : uint
	{
		None = 0,
		Full = 254,
		UsbPlugged = 255
	}

	public enum ABTBluetoothReaderDeviceInfo : uint
	{
		SystemId = 10787,
		ModelNumberString = 10788,
		SerialNumberString = 10789,
		FirmwareRevisionString = 10790,
		HardwareRevisionString = 10791,
		ManufacturerNameString = 10793
	}
}
