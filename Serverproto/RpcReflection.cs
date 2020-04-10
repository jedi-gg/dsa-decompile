using Google.Protobuf.Reflection;
using Il2CppDummyDll;
using System;

namespace Serverproto
{
	public static class RpcReflection
	{
		[FieldOffset(Offset="0x0")]
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor
		{
			[Address(RVA="0x1BC9438", Offset="0x1BC9438", VA="0x1BC9438")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1BCB9A8", Offset="0x1BCB9A8", VA="0x1BCB9A8")]
		static RpcReflection()
		{
		}
	}
}