using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies
{
	[Serializable]
	public class AssetManifest
	{
		[FieldOffset(Offset="0x10")]
		[SerializeField]
		private List<AssetManifest.AssetGroup> asset_groups;

		[Address(RVA="0x14FECA0", Offset="0x14FECA0", VA="0x14FECA0")]
		public AssetManifest()
		{
		}

		[Address(RVA="0x14FEBC0", Offset="0x14FEBC0", VA="0x14FEBC0")]
		public List<string> GetAssets(string groupKey)
		{
			return null;
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DD8", Offset="0x1050DD8")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public string groupKey;

			[Address(RVA="0x14FEC98", Offset="0x14FEC98", VA="0x14FEC98")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x14FED10", Offset="0x14FED10", VA="0x14FED10")]
			internal bool <GetAssets>b__0(AssetManifest.AssetGroup g)
			{
				return new bool();
			}
		}

		[Serializable]
		public struct AssetGroup
		{
			[FieldOffset(Offset="0x0")]
			public string Key;

			[FieldOffset(Offset="0x8")]
			public List<string> AssetIds;
		}

		public static class Factory
		{
			[Address(RVA="0x14FED24", Offset="0x14FED24", VA="0x14FED24")]
			public static AssetManifest Create(List<AssetManifest.AssetGroup> assetGroups)
			{
				return null;
			}
		}
	}
}