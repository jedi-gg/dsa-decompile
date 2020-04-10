using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class CommonReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x1EE9094", Offset="0x1EE9094", VA="0x1EE9094")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EE9BBC", Offset="0x1EE9BBC", VA="0x1EE9BBC")]
		static CommonReflection()
		{
		}
	}
}