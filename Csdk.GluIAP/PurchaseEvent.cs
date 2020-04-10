using Csdk.GluIAP.Implementation;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace Csdk.GluIAP
{
	public class PurchaseEvent : ISerializableJsonObject
	{
		[FieldOffset(Offset="0x10")]
		public readonly string ProductId;

		[FieldOffset(Offset="0x18")]
		public readonly decimal Price;

		[FieldOffset(Offset="0x28")]
		public readonly string TransactionState;

		[FieldOffset(Offset="0x30")]
		public readonly string TransactionId;

		[FieldOffset(Offset="0x38")]
		public readonly string Receipt;

		[FieldOffset(Offset="0x40")]
		public readonly string ValidationRequestBody;

		[FieldOffset(Offset="0x48")]
		public readonly Exception Error;

		[FieldOffset(Offset="0x50")]
		public readonly IDictionary<string, object> Extra;

		[Address(RVA="0x21EA968", Offset="0x21EA968", VA="0x21EA968")]
		public PurchaseEvent(string productId, string transactionState, string transactionId, string receipt, string validationRequestBody, Exception error, IDictionary<string, object> extra)
		{
		}

		[Address(RVA="0x21EAD58", Offset="0x21EAD58", VA="0x21EAD58", Slot="3")]
		public override string ToString()
		{
			return null;
		}

		[Address(RVA="0x21EADCC", Offset="0x21EADCC", VA="0x21EADCC", Slot="4")]
		public void WriteObject(JsonStringer json)
		{
		}
	}
}