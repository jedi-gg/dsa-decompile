using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP
{
	public class QuerySubscriptionAwardsEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly IList<SubscriptionAward> Awards;

		[FieldOffset(Offset="0x18")]
		public readonly Exception Error;

		[Address(RVA="0x21EAB7C", Offset="0x21EAB7C", VA="0x21EAB7C")]
		public QuerySubscriptionAwardsEvent(IList<SubscriptionAward> awards, Exception error)
		{
		}

		[Address(RVA="0x21EB008", Offset="0x21EB008", VA="0x21EB008", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EB07C", Offset="0x21EB07C", VA="0x21EB07C", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}