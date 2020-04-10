using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP
{
	public class Subscription : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string ProductID;

		[FieldOffset(Offset="0x18")]
		public readonly long PurchaseDate;

		[FieldOffset(Offset="0x20")]
		public readonly long ExpiresDate;

		[FieldOffset(Offset="0x28")]
		public readonly bool IsFreeTrial;

		[Address(RVA="0x21EAA70", Offset="0x21EAA70", VA="0x21EAA70")]
		public Subscription(string productID, long purchaseDate, long expiresDate, bool isFreeTrial)
		{
		}

		[Address(RVA="0x21EB218", Offset="0x21EB218", VA="0x21EB218", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EB28C", Offset="0x21EB28C", VA="0x21EB28C", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}