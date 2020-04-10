using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP
{
	public class QuerySubscriptionsEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly IList<Subscription> Subs;

		[FieldOffset(Offset="0x18")]
		public readonly Exception Error;

		[Address(RVA="0x21EAAC4", Offset="0x21EAAC4", VA="0x21EAAC4")]
		public QuerySubscriptionsEvent(IList<Subscription> subs, Exception error)
		{
		}

		[Address(RVA="0x21EB110", Offset="0x21EB110", VA="0x21EB110", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EB184", Offset="0x21EB184", VA="0x21EB184", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}