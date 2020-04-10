using Il2CppDummyDll;
using System;

public class DialogManager : ADialogManager<DialogView>
{
	[Address(RVA="0x1203F0C", Offset="0x1203F0C", VA="0x1203F0C")]
	public DialogManager()
	{
	}

	[Address(RVA="0x1203D98", Offset="0x1203D98", VA="0x1203D98")]
	public void ConfirmBuy(string confirmBuyText, ulong costItemId, ulong costAmount, Action confirmed)
	{
	}

	[Address(RVA="0x1203DB8", Offset="0x1203DB8", VA="0x1203DB8")]
	public void ConfirmBuy(string confirmBuyText, string buyButtonText, ulong costItemId, ulong costAmount, Action confirmed)
	{
	}
}