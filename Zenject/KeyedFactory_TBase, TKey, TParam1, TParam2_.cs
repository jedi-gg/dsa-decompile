using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class KeyedFactory<TBase, TKey, TParam1, TParam2> : KeyedFactoryBase<TBase, TKey>
	{
		protected override IEnumerable<Type> ProvidedTypes
		{
			[Address(RVA="0x2352B2C", Offset="0x2352B2C", VA="0x2352B2C", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2352E88", Offset="0x2352E88", VA="0x2352E88")]
		public KeyedFactory()
		{
		}

		[Address(RVA="0x2352C88", Offset="0x2352C88", VA="0x2352C88", Slot="7")]
		public virtual TBase Create(TKey key, TParam1 param1, TParam2 param2)
		{
			return null;
		}
	}
}