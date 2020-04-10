using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP
{
	public class SubscriptionAward : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string AwardID;

		[FieldOffset(Offset="0x18")]
		public readonly long AwardedTime;

		[FieldOffset(Offset="0x20")]
		public readonly long ExpiresTime;

		[FieldOffset(Offset="0x28")]
		public readonly string ProductID;

		[FieldOffset(Offset="0x30")]
		public readonly string Store;

		[FieldOffset(Offset="0x38")]
		public readonly string ApplicationID;

		[FieldOffset(Offset="0x40")]
		public readonly string UserID;

		[FieldOffset(Offset="0x48")]
		public readonly string AwardStatus;

		[FieldOffset(Offset="0x50")]
		public readonly bool IsFreeTrial;

		[Address(RVA="0x21EAAFC", Offset="0x21EAAFC", VA="0x21EAAFC")]
		public SubscriptionAward(string awardID, long awardedTime, long expiresTime, string productID, string store, string applicationID, string userID, string awardStatus, bool isFreeTrial)
		{
		}

		[Address(RVA="0x21EB3B4", Offset="0x21EB3B4", VA="0x21EB3B4", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EB428", Offset="0x21EB428", VA="0x21EB428", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}