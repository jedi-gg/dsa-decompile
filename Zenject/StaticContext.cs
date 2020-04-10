using Il2CppDummyDll;
using System;

namespace Zenject
{
	public static class StaticContext
	{
		[FieldOffset(Offset="0x0")]
		private static DiContainer _container;

		public static DiContainer Container
		{
			[Address(RVA="0x2334BFC", Offset="0x2334BFC", VA="0x2334BFC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2334B90", Offset="0x2334B90", VA="0x2334B90")]
		static StaticContext()
		{
		}
	}
}