using Il2CppDummyDll;
using System;

namespace GooglePlayGames.OurUtils
{
	public static class Misc
	{
		[Address(RVA="0x12D4A9C", Offset="0x12D4A9C", VA="0x12D4A9C")]
		public static bool BuffersAreIdentical(byte[] a, byte[] b)
		{
			return new bool();
		}

		[Address(RVA="0x16AB7F0", Offset="0x16AB7F0", VA="0x16AB7F0")]
		public static T CheckNotNull<T>(T value)
		{
			return null;
		}

		[Address(RVA="0x16AB870", Offset="0x16AB870", VA="0x16AB870")]
		public static T CheckNotNull<T>(T value, string paramName)
		{
			return null;
		}

		[Address(RVA="0x12D4B60", Offset="0x12D4B60", VA="0x12D4B60")]
		public static byte[] GetSubsetBytes(byte[] array, int offset, int length)
		{
			return null;
		}
	}
}