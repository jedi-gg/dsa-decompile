using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Zenject
{
	public class PrefabProviderResource : IPrefabProvider
	{
		[FieldOffset(Offset="0x10")]
		private readonly string _resourcePath;

		[Address(RVA="0x1840BE8", Offset="0x1840BE8", VA="0x1840BE8")]
		public PrefabProviderResource(string resourcePath)
		{
		}

		[Address(RVA="0x1840C14", Offset="0x1840C14", VA="0x1840C14", Slot="4")]
		public UnityEngine.Object GetPrefab()
		{
			return null;
		}
	}
}