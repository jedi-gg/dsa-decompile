using Csdk.GluAds.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAds
{
	public class PlacementEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string AdvertisementType;

		[FieldOffset(Offset="0x18")]
		public readonly string Placement;

		[FieldOffset(Offset="0x20")]
		public readonly string Status;

		[FieldOffset(Offset="0x28")]
		public readonly Exception Error;

		[FieldOffset(Offset="0x30")]
		public readonly IDictionary<string, object> Extra;

		[Address(RVA="0x1551264", Offset="0x1551264", VA="0x1551264")]
		public PlacementEvent(string advertisementType, string placement, string status, Exception error, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x1558D3C", Offset="0x1558D3C", VA="0x1558D3C", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x1558DB0", Offset="0x1558DB0", VA="0x1558DB0", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}