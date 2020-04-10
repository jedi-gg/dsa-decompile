using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class MatchmakingPopupView : APopupView
{
	private MatchmakingPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11DAB0C", Offset="0x11DAB0C", VA="0x11DAB0C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11DAD04", Offset="0x11DAD04", VA="0x11DAD04")]
	public MatchmakingPopupView()
	{
	}

	[Address(RVA="0x11DABEC", Offset="0x11DABEC", VA="0x11DABEC", Slot="21")]
	protected override void ClosePopupView()
	{
	}

	[Address(RVA="0x11DAD00", Offset="0x11DAD00", VA="0x11DAD00", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x11DABF0", Offset="0x11DABF0", VA="0x11DABF0")]
	private void RequestCancel()
	{
	}

	[Address(RVA="0x11DAA94", Offset="0x11DAA94", VA="0x11DAA94")]
	public void SetLabel(string text)
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiLabel Label;

		[FieldOffset(Offset="0x38")]
		public Button CancelButton;

		[Address(RVA="0x11DAD0C", Offset="0x11DAD0C", VA="0x11DAD0C")]
		public SerializedFields()
		{
		}
	}
}