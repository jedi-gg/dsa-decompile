using Il2CppDummyDll;
using Serverproto;
using System;

public struct DRevSdkPurchaseResponseAction
{
	[FieldOffset(Offset="0x0")]
	public readonly string ProductId;

	[FieldOffset(Offset="0x8")]
	public readonly BuyStoreItemResponse BuyResponse;

	[FieldOffset(Offset="0x10")]
	public readonly DRevSdkPurchaseResponseAction.State TransactionState;

	[Address(RVA="0xEFED5C", Offset="0xEFED5C", VA="0xEFED5C")]
	public DRevSdkPurchaseResponseAction(string productId, BuyStoreItemResponse buyResponse, DRevSdkPurchaseResponseAction.State transactionState)
	{
	}

	public enum State
	{
		[FieldOffset(Offset="0x0")]
		Success,
		[FieldOffset(Offset="0x0")]
		Failure,
		[FieldOffset(Offset="0x0")]
		Deferred
	}
}