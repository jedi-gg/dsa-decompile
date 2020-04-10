using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Glunies
{
	public class AssetIdCache
	{
		[FieldOffset(Offset="0x10")]
		private Dictionary<string, AssetId> _cachedAssetIds;

		[Address(RVA="0x14FD218", Offset="0x14FD218", VA="0x14FD218")]
		public AssetIdCache()
		{
		}

		[Address(RVA="0x14F3FC8", Offset="0x14F3FC8", VA="0x14F3FC8")]
		public AssetId GetAssetId(string id)
		{
			return null;
		}

		[Address(RVA="0x14FD0C0", Offset="0x14FD0C0", VA="0x14FD0C0")]
		private static bool ParseAssetId(string id, out string bundleName, out string assetName)
		{
			bundleName = null;
			assetName = null;
			return new bool();
		}
	}
}