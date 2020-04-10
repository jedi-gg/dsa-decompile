using Il2CppDummyDll;
using System;

namespace Polybrush
{
	public static class z_MeshChannelUtility
	{
		[Address(RVA="0x12717C0", Offset="0x12717C0", VA="0x12717C0")]
		public static z_MeshChannel StringToEnum(string str)
		{
			return new z_MeshChannel();
		}

		[Address(RVA="0x127184C", Offset="0x127184C", VA="0x127184C")]
		public static int UVChannelToIndex(z_MeshChannel channel)
		{
			return new int();
		}
	}
}