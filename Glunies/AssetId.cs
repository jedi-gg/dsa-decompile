using Il2CppDummyDll;
using System;

namespace Glunies
{
	public class AssetId
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Id;

		[FieldOffset(Offset="0x18")]
		public readonly string BundleName;

		[FieldOffset(Offset="0x20")]
		public readonly string AssetName;

		[Address(RVA="0x14FD078", Offset="0x14FD078", VA="0x14FD078")]
		public AssetId(string id, string bundleName, string assetName)
		{
		}

		[Address(RVA="0x14FD0B8", Offset="0x14FD0B8", VA="0x14FD0B8", Slot="3")]
		public override string ToString()
		{
			return null;
		}
	}
}