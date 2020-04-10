using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class KeyedFactory<TBase, TKey, TParam1, TParam2, TParam3, TParam4> : KeyedFactoryBase<TBase, TKey>
	{
		protected override IEnumerable<Type> ProvidedTypes
		{
			[Address(RVA="0x2353300", Offset="0x2353300", VA="0x2353300", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x235379C", Offset="0x235379C", VA="0x235379C")]
		public KeyedFactory()
		{
		}

		[Address(RVA="0x235351C", Offset="0x235351C", VA="0x235351C", Slot="7")]
		public virtual TBase Create(TKey key, TParam1 param1, TParam2 param2, TParam3 param3, TParam4 param4)
		{
			return null;
		}
	}
}