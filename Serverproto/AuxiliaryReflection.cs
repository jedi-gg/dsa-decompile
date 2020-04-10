using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class AuxiliaryReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x1E6E308", Offset="0x1E6E308", VA="0x1E6E308")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1E6E370", Offset="0x1E6E370", VA="0x1E6E370")]
		static AuxiliaryReflection()
		{
		}
	}
}