using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class EnergyRefreshView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x1057D74", Offset="0x1057D74")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057D84", Offset="0x1057D84")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057D94", Offset="0x1057D94")]
	[FieldOffset(Offset="0x78")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x1057DA4", Offset="0x1057DA4")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x88")]
	private UiTimerLabel _nextEnergyGenerateTimerLabel;

	[FieldOffset(Offset="0x90")]
	private ulong _energyItemId;

	private EnergyRefreshView.SerializedFields Fields
	{
		[Address(RVA="0x12114C8", Offset="0x12114C8", VA="0x12114C8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x121232C", Offset="0x121232C", VA="0x121232C")]
	public EnergyRefreshView()
	{
	}

	[Address(RVA="0x1212334", Offset="0x1212334", VA="0x1212334")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F634", Offset="0x106F634")]
	private void <ViewAssetLoaded>b__5_0()
	{
	}

	[Address(RVA="0x120F938", Offset="0x120F938", VA="0x120F938")]
	public void CelebrateEnergyRefresh(InventoryDelta delta)
	{
	}

	[Address(RVA="0x1211DFC", Offset="0x1211DFC", VA="0x1211DFC")]
	private void DispatchBonusAction()
	{
	}

	[Address(RVA="0x1211F2C", Offset="0x1211F2C", VA="0x1211F2C")]
	private void DispatchBonusGenerateAction()
	{
	}

	[Address(RVA="0x1211008", Offset="0x1211008", VA="0x1211008")]
	public void SetClubSuppotRequestType(Serverproto.ClubSupportRequestType requestType)
	{
	}

	[Address(RVA="0x120FF0C", Offset="0x120FF0C", VA="0x120FF0C")]
	public void SetData(EnergyConstants? energyConstants, Gamedata.InventoryItem? energyItem)
	{
	}

	[Address(RVA="0x120F730", Offset="0x120F730", VA="0x120F730")]
	public void SetNextEnergyGenerateTimeUtc(DateTime nextGenerateTime, EnergyConstants? energyConstants, Gamedata.InventoryItem? energyItem)
	{
	}

	[Address(RVA="0x120ECB4", Offset="0x120ECB4", VA="0x120ECB4")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x12115A8", Offset="0x12115A8", VA="0x12115A8")]
	private void UpdateBonusGenerateElements(EnergyConstants? energyConstants, Gamedata.InventoryItem? energyItem)
	{
	}

	[Address(RVA="0x12119B4", Offset="0x12119B4", VA="0x12119B4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1211C88", Offset="0x1211C88", VA="0x1211C88", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x121205C", Offset="0x121205C", VA="0x121205C")]
	private void VipUpgradeClicked()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A484", Offset="0x106A484")]
		[FieldOffset(Offset="0x30")]
		public CostButton PurchaseButton;

		[FieldOffset(Offset="0x38")]
		public Button MaxedButton;

		[FieldOffset(Offset="0x40")]
		public RawImage EnergyImage;

		[FieldOffset(Offset="0x48")]
		public UiLabel PurchasePromptLabel;

		[FieldOffset(Offset="0x50")]
		public UiLabel PurchasesMaxedLabel;

		[FieldOffset(Offset="0x58")]
		public UiLabel NextEnergyGenerateLabel;

		[FieldOffset(Offset="0x60")]
		public UiLabel EnergyMaxedLabel;

		[FieldOffset(Offset="0x68")]
		public UnityEngine.GameObject EnergyGenerateParent;

		[FieldOffset(Offset="0x70")]
		public Button BonusButton;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject ActionButtonContainer;

		[FieldOffset(Offset="0x80")]
		public Button BonusGenerateButton;

		[FieldOffset(Offset="0x88")]
		public UiLabel EnergyGenerateLabel;

		[FieldOffset(Offset="0x90")]
		public UiLabel NameLabel;

		[FieldOffset(Offset="0x98")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0xA0")]
		public Button VIPBonusRefreshButton;

		[FieldOffset(Offset="0xA8")]
		public UiLabel VIPBonusRefreshPrompt;

		[Address(RVA="0x12123B8", Offset="0x12123B8", VA="0x12123B8")]
		public SerializedFields()
		{
		}
	}
}