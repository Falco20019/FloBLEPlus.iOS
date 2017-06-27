using System;
using System.Text;
using Foundation;

namespace FloBLEPlus.iOS
{
	public static class Extensions
	{
		public static byte[] ToByteArray (this NSData data) {
			var dataBytes = new byte[data.Length];
			System.Runtime.InteropServices.Marshal.Copy(data.Bytes, dataBytes, 0, Convert.ToInt32(data.Length));
			return dataBytes;
        }
		public static byte[] ToByteArray(this string data)
		{
			string[] parts = data.Split(' ');
			byte[] result = new byte[parts.Length];
			for (int i = 0; i < parts.Length; i++)
				result[i] = Convert.ToByte(parts[i], 16);
			
			return result;
		}
		public static string ToHexString(this byte[] data)
		{
			StringBuilder sb = new StringBuilder();
			foreach (var b in data)
			{
				if (sb.Length != 0)
					sb.Append(' ');

				sb.Append(b.ToString("X2"));
			}
			return sb.ToString();
		}
    }
}

