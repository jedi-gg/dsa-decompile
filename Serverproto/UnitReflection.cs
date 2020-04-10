using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class UnitReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x14B1990", Offset="0x14B1990", VA="0x14B1990")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14B5530", Offset="0x14B5530", VA="0x14B5530")]
		static UnitReflection()
		{
		}
	}
}