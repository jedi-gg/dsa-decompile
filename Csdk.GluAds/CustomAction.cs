using Csdk.GluAds.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluAds
{
	public class CustomAction : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string Action;

		[FieldOffset(Offset="0x18")]
		public readonly IDictionary<string, object> Extra;

		[Address(RVA="0x154E8A0", Offset="0x154E8A0", VA="0x154E8A0")]
		public CustomAction(string action, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x154E948", Offset="0x154E948", VA="0x154E948", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x154EA3C", Offset="0x154EA3C", VA="0x154EA3C", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}