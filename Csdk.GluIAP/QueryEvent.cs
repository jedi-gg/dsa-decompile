using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP
{
	public class QueryEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly IList<InAppPurchaseProduct> Products;

		[FieldOffset(Offset="0x18")]
		public readonly Exception Error;

		[Address(RVA="0x21EAA38", Offset="0x21EAA38", VA="0x21EAA38")]
		public QueryEvent(IList<InAppPurchaseProduct> products, Exception error)
		{
		}

		[Address(RVA="0x21EAF00", Offset="0x21EAF00", VA="0x21EAF00", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EAF74", Offset="0x21EAF74", VA="0x21EAF74", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}