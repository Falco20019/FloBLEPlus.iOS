using System;
using CoreBluetooth;
using Foundation;
using ObjCRuntime;

namespace FloBLEPlus.iOS
{
	public partial class ABTBluetoothReader
	{
		private static unsafe bool BufferOperation (byte [] buffer, Func<IntPtr, nuint, bool> handler)
		{   
			if (buffer == null)
				throw new ArgumentNullException (nameof (buffer));

			if (buffer.Length == 0)
				return false;

			fixed (byte *ptr = &buffer [0])
			return handler (new IntPtr (ptr), (nuint)buffer.Length);
		}

		public bool AuthenticateWithMasterKey (byte[] masterKey)
		{
			return BufferOperation (masterKey, AuthenticateWithMasterKey);
		}

		public bool TransmitApdu (byte[] apdu)
		{
			return BufferOperation (apdu, TransmitApdu);
		}

		public bool TransmitEscapeCommand (byte[] command)
		{
			return BufferOperation (command, TransmitEscapeCommand);
		}
	}
}

