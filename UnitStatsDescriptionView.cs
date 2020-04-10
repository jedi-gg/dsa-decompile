using Il2CppDummyDll;
using System;

public class UnitStatsDescriptionView : APressedPopupView
{
	private UnitStatsDescriptionView.SerializedFields Fields
	{
		[Address(RVA="0x1513BF8", Offset="0x1513BF8", VA="0x1513BF8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1513D08", Offset="0x1513D08", VA="0x1513D08")]
	public UnitStatsDescriptionView()
	{
	}

	[Address(RVA="0x1513B14", Offset="0x1513B14", VA="0x1513B14")]
	public void SetData(string stat, string statDesc)
	{
	}

	[Address(RVA="0x1513CD8", Offset="0x1513CD8", VA="0x1513CD8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1513CE0", Offset="0x1513CE0", VA="0x1513CE0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PressedPopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiLabel StatTitle;

		[FieldOffset(Offset="0x38")]
		public UiLabel StatDescription;

		[Address(RVA="0x1513D10", Offset="0x1513D10", VA="0x1513D10")]
		public SerializedFields()
		{
		}
	}
}