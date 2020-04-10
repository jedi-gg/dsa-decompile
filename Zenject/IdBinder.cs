using Il2CppDummyDll;
using System;

namespace Zenject
{
	public class IdBinder
	{
		[FieldOffset(Offset="0x10")]
		private BindInfo _bindInfo;

		[Address(RVA="0x18391C0", Offset="0x18391C0", VA="0x18391C0")]
		public IdBinder(BindInfo bindInfo)
		{
		}

		[Address(RVA="0x18391EC", Offset="0x18391EC", VA="0x18391EC")]
		public void WithId(object identifier)
		{
		}
	}
}