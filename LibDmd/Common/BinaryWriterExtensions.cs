using System;
using System.IO;

namespace LibDmd.Common
{
	/// <summary>
	/// Reader functions for Big Endian integers.
	/// </summary>
	/// 
	/// <remarks>
	/// Note this MODIFIES THE GIVEN ARRAY then returns a reference to the modified array.
	/// </remarks>
	public static class BinaryWriterExtensions
	{
		/// <summary>
		/// Reads a 16-bit unsigned integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>unsigned 16-bit integer</returns>
		public static void WriteUInt16BE(this BinaryWriter binWtr, ushort value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		/// <summary>
		/// Reads a 16-bit signed integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>signed 16-bit integer</returns>
		public static void WriteInt16BE(this BinaryWriter binWtr, short value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		/// <summary>
		/// Reads a 32-bit unsigned integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>unsigned 32-bit integer</returns>
		public static void WriteUInt32BE(this BinaryWriter binWtr, uint value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		/// <summary>
		/// Reads a 32-bit signed integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>signed 32-bit integer</returns>
		public static void WriteInt32BE(this BinaryWriter binWtr, int value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		/// <summary>
		/// Reads a 64-bit unsigned integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>unsigned 64-bit integer</returns>
		public static void WriteUInt64BE(this BinaryWriter binWtr, ulong value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		/// <summary>
		/// Reads a 64-bit signed integer as Big Endian from the binary reader.
		/// </summary>
		/// <returns>signed 64-bit integer</returns>
		public static void WriteInt64BE(this BinaryWriter binWtr, long value)
		{
			binWtr.WriteBytesRequired(BitConverter.GetBytes(value).Reverse());
		}

		public static void WriteBytesRequired(this BinaryWriter binWtr, byte[] value)
		{
			binWtr.Write(value);

			//if (result.Length != byteCount)
			//	throw new EndOfStreamException(string.Format("{0} bytes required from stream, but only {1} returned.", byteCount, result.Length));
		}
	}
}
