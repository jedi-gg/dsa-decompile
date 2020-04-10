using Il2CppDummyDll;
using System;

namespace ModestTree.Util
{
	public static class ValuePair
	{
		[Address(RVA="0x1E4B9F4", Offset="0x1E4B9F4", VA="0x1E4B9F4")]
		public static ValuePair<T1, T2> New<T1, T2>(T1 first, T2 second)
		{
			return null;
		}

		[Address(RVA="0x1E4BACC", Offset="0x1E4BACC", VA="0x1E4BACC")]
		public static ValuePair<T1, T2, T3> New<T1, T2, T3>(T1 first, T2 second, T3 third)
		{
			return null;
		}

		[Address(RVA="0x1E4BB48", Offset="0x1E4BB48", VA="0x1E4BB48")]
		public static ValuePair<T1, T2, T3, T4> New<T1, T2, T3, T4>(T1 first, T2 second, T3 third, T4 fourth)
		{
			return null;
		}
	}
}