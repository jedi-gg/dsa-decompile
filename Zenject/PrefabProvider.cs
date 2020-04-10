using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabProvider : IPrefabProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly UnityEngine.Object _prefab;

		[Address(RVA="0x183F184", Offset="0x183F184", VA="0x183F184")]
		public PrefabProvider(UnityEngine.Object prefab)
		{
		}

		[Address(RVA="0x1840BE0", Offset="0x1840BE0", VA="0x1840BE0", Slot="4")]
		public UnityEngine.Object GetPrefab()
		{
			return null;
		}
	}
}