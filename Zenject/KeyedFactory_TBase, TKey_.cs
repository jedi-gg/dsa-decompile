using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Zenject
{
	public class KeyedFactory<TBase, TKey> : KeyedFactoryBase<TBase, TKey>
	{
		protected override IEnumerable<Type> ProvidedTypes
		{
			[Address(RVA="0x23526A0", Offset="0x23526A0", VA="0x23526A0", Slot="5")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x2352804", Offset="0x2352804", VA="0x2352804")]
		public KeyedFactory()
		{
		}

		[Address(RVA="0x23526EC", Offset="0x23526EC", VA="0x23526EC", Slot="7")]
		public virtual TBase Create(TKey key)
		{
			return null;
		}
	}
}