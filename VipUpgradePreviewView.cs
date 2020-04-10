using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class VipUpgradePreviewView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105FB60", Offset="0x105FB60")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105FB70", Offset="0x105FB70")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	private VipUpgradePreviewView.SerializedFields Fields
	{
		[Address(RVA="0x15A4AA0", Offset="0x15A4AA0", VA="0x15A4AA0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15A4BF4", Offset="0x15A4BF4", VA="0x15A4BF4")]
	public VipUpgradePreviewView()
	{
	}

	[Address(RVA="0x15A4BFC", Offset="0x15A4BFC", VA="0x15A4BFC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071270", Offset="0x1071270")]
	private void <ViewAssetLoaded>b__0_0()
	{
	}

	[Address(RVA="0x15A4594", Offset="0x15A4594", VA="0x15A4594", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x15A4B80", Offset="0x15A4B80", VA="0x15A4B80", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button BuyButton;

		[FieldOffset(Offset="0x38")]
		public UiLabel EliteNodeCountVip;

		[FieldOffset(Offset="0x40")]
		public UiLabel EnergyRefreshGrandCountVip;

		[FieldOffset(Offset="0x48")]
		public UiLabel EnergyRefreshPvECountVip;

		[FieldOffset(Offset="0x50")]
		public UiLabel DungeonRetriesCountVip;

		[Address(RVA="0x15A4C80", Offset="0x15A4C80", VA="0x15A4C80")]
		public SerializedFields()
		{
		}
	}
}