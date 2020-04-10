using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class KeyedFactory<TBase, TKey, TParam1> : KeyedFactoryBase<TBase, TKey>
	{
		protected override IEnumerable<Type> ProvidedTypes
		{
			[Address(RVA="0x2352840", Offset="0x2352840", VA="0x2352840", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2352AF0", Offset="0x2352AF0", VA="0x2352AF0")]
		public KeyedFactory()
		{
		}

		[Address(RVA="0x2352934", Offset="0x2352934", VA="0x2352934", Slot="7")]
		public virtual TBase Create(TKey key, TParam1 param1)
		{
			return null;
		}
	}
}