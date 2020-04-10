using Glunies;
using Il2CppDummyDll;
using System;

public class SorcererStoneInfoView : APopupView
{
	private SorcererStoneInfoView.SerializedFields Fields
	{
		[Address(RVA="0x123C958", Offset="0x123C958", VA="0x123C958")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x123CA38", Offset="0x123CA38", VA="0x123CA38")]
	public SorcererStoneInfoView()
	{
	}

	[Address(RVA="0x123C928", Offset="0x123C928", VA="0x123C928", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x123C930", Offset="0x123C930", VA="0x123C930", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Address(RVA="0x123CA40", Offset="0x123CA40", VA="0x123CA40")]
		public SerializedFields()
		{
		}
	}
}