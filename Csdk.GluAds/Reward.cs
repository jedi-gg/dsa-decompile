using Csdk.GluAds.Implementation;
using Il2CppDummyDll;
using System;

namespace Csdk.GluAds
{
	public class Reward : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Identifier;

		[FieldOffset(Offset="0x18")]
		public readonly string Placement;

		[FieldOffset(Offset="0x20")]
		public readonly string AdvertisementType;

		[FieldOffset(Offset="0x28")]
		public readonly string Item;

		[FieldOffset(Offset="0x30")]
		public readonly int Amount;

		[Address(RVA="0x1558BDC", Offset="0x1558BDC", VA="0x1558BDC")]
		public Reward(string identifier, string placement, string advertisementType, string item, int amount)
		{
		}

		[Address(RVA="0x1558EA4", Offset="0x1558EA4", VA="0x1558EA4", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1558F18", Offset="0x1558F18", VA="0x1558F18", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}