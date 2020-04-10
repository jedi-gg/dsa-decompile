using Glunies;
using Il2CppDummyDll;
using System;

public class PassportSeasonInfoView : APopupView
{
	private PassportSeasonInfoView.SerializedFields Fields
	{
		[Address(RVA="0x13FC3D8", Offset="0x13FC3D8", VA="0x13FC3D8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13FC4B8", Offset="0x13FC4B8", VA="0x13FC4B8")]
	public PassportSeasonInfoView()
	{
	}

	[Address(RVA="0x13FC3A8", Offset="0x13FC3A8", VA="0x13FC3A8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x13FC3B0", Offset="0x13FC3B0", VA="0x13FC3B0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Address(RVA="0x13FC4C0", Offset="0x13FC4C0", VA="0x13FC4C0")]
		public SerializedFields()
		{
		}
	}
}