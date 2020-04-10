using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class ApiReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x16083B0", Offset="0x16083B0", VA="0x16083B0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1608418", Offset="0x1608418", VA="0x1608418")]
		static ApiReflection()
		{
		}
	}
}