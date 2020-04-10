using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class AboutGameView : APopupView
{
	private AboutGameView.SerializedFields Fields
	{
		[Address(RVA="0x1154E94", Offset="0x1154E94", VA="0x1154E94")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115513C", Offset="0x115513C", VA="0x115513C")]
	public AboutGameView()
	{
	}

	[Address(RVA="0x11550B8", Offset="0x11550B8", VA="0x11550B8")]
	private void AttributionClicked()
	{
	}

	[Address(RVA="0x1154E48", Offset="0x1154E48", VA="0x1154E48")]
	public void SetAttributionUrl(string url)
	{
	}

	[Address(RVA="0x1154F74", Offset="0x1154F74", VA="0x1154F74", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1155044", Offset="0x1155044", VA="0x1155044", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiLabel AttributionLabel;

		[FieldOffset(Offset="0x38")]
		public Button AttributionButton;

		[Address(RVA="0x1155144", Offset="0x1155144", VA="0x1155144")]
		public SerializedFields()
		{
		}
	}
}