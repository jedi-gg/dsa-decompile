using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class KeyedFactory<TBase, TKey, TParam1, TParam2, TParam3> : KeyedFactoryBase<TBase, TKey>
	{
		protected override IEnumerable<Type> ProvidedTypes
		{
			[Address(RVA="0x2352EC4", Offset="0x2352EC4", VA="0x2352EC4", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x23532C4", Offset="0x23532C4", VA="0x23532C4")]
		public KeyedFactory()
		{
		}

		[Address(RVA="0x2353080", Offset="0x2353080", VA="0x2353080", Slot="7")]
		public virtual TBase Create(TKey key, TParam1 param1, TParam2 param2, TParam3 param3)
		{
			return null;
		}
	}
}