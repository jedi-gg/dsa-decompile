using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;

namespace Csdk.GluIAP
{
	public class InAppPurchaseProduct : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string ProductId;

		[FieldOffset(Offset="0x18")]
		public readonly string Title;

		[FieldOffset(Offset="0x20")]
		public readonly string Description;

		[FieldOffset(Offset="0x28")]
		public readonly decimal Price;

		[FieldOffset(Offset="0x38")]
		public readonly string PriceString;

		[FieldOffset(Offset="0x40")]
		public readonly string CurrencyCode;

		[Address(RVA="0x21EA9D0", Offset="0x21EA9D0", VA="0x21EA9D0")]
		public InAppPurchaseProduct(string productId, string title, string description, decimal price, string priceString, string currencyCode)
		{
		}

		[Address(RVA="0x21EABB4", Offset="0x21EABB4", VA="0x21EABB4", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EAC28", Offset="0x21EAC28", VA="0x21EAC28", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}