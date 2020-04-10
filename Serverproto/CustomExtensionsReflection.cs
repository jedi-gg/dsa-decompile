using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class CustomExtensionsReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x1EF5514", Offset="0x1EF5514", VA="0x1EF5514")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1EF557C", Offset="0x1EF557C", VA="0x1EF557C")]
		static CustomExtensionsReflection()
		{
		}
	}
}