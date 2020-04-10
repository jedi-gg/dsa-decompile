using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampaignView : AStandardView, IDispatchHandler<DCampaignWorldMapScroll>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1055608", Offset="0x1055608")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1055618", Offset="0x1055618")]
	[FieldOffset(Offset="0x70")]
	private CampaignUtility _campaignUtility;

	[Attribute(Name="InjectAttribute", RVA="0x1055628", Offset="0x1055628")]
	[FieldOffset(Offset="0x78")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1055638", Offset="0x1055638")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x88")]
	private Campaign? _normalCampaign;

	[FieldOffset(Offset="0xA0")]
	private Campaign? _hardCampaign;

	[FieldOffset(Offset="0xB8")]
	private CampaignBattleTileTutorialPointAtLookup _pointAtLookup;

	[FieldOffset(Offset="0xC0")]
	private Func<int, RectTransform> _rewardTilePointAt;

	[FieldOffset(Offset="0xC8")]
	private Camera _pointAtWorldCamera;

	[FieldOffset(Offset="0xD0")]
	private IList<BonusLootData> _bonusLootData;

	private CampaignView.SerializedFields Fields
	{
		[Address(RVA="0x1189538", Offset="0x1189538", VA="0x1189538")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x118AD8C", Offset="0x118AD8C", VA="0x118AD8C")]
	public CampaignView()
	{
	}

	[Address(RVA="0x118AD94", Offset="0x118AD94", VA="0x118AD94")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E9A8", Offset="0x106E9A8")]
	private void <ViewAssetLoaded>b__9_0(Button b)
	{
	}

	[Address(RVA="0x118AC78", Offset="0x118AC78", VA="0x118AC78")]
	private void BonusInfoClicked()
	{
	}

	[Address(RVA="0x118AB70", Offset="0x118AB70", VA="0x118AB70")]
	private void EventDetailsClicked()
	{
	}

	[Address(RVA="0x118A6EC", Offset="0x118A6EC", VA="0x118A6EC", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x118AB68", Offset="0x118AB68", VA="0x118AB68", Slot="16")]
	protected override Camera GetDynamicPointAtObjectWorldCamera(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1189E70", Offset="0x1189E70", VA="0x1189E70", Slot="21")]
	public void HandleDispatchAction(DCampaignWorldMapScroll action)
	{
	}

	[Address(RVA="0x118ABF4", Offset="0x118ABF4", VA="0x118ABF4")]
	private void InventoryClicked()
	{
	}

	[Address(RVA="0x118A554", Offset="0x118A554", VA="0x118A554", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x1189924", Offset="0x1189924", VA="0x1189924")]
	public void SelectMap(DCampaignAddress campaignAddress)
	{
	}

	[Address(RVA="0x1189A30", Offset="0x1189A30", VA="0x1189A30")]
	public void SetBattleSelected(bool selected)
	{
	}

	[Address(RVA="0x1189AD0", Offset="0x1189AD0", VA="0x1189AD0")]
	public void SetBonusLootInfoButton(IList<BonusLootData> bonusLootData)
	{
	}

	[Address(RVA="0x1189618", Offset="0x1189618", VA="0x1189618")]
	public void SetCampaigns(Campaign? normalCampaign, Campaign? hardCampaign)
	{
	}

	[Address(RVA="0x1189A7C", Offset="0x1189A7C", VA="0x1189A7C")]
	public void SetTutorialPointAtLookup(CampaignBattleTileTutorialPointAtLookup pointAtLookup, Func<int, RectTransform> rewardTilePointAt, Camera worldCamera)
	{
	}

	[Address(RVA="0x1189A88", Offset="0x1189A88", VA="0x1189A88")]
	public void ShowActiveBonusIndicator(bool hasActiveBonus)
	{
	}

	[Address(RVA="0x11894DC", Offset="0x11894DC", VA="0x11894DC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x118A5C4", Offset="0x118A5C4", VA="0x118A5C4")]
	private void ToggleInfo()
	{
	}

	[Address(RVA="0x1189998", Offset="0x1189998", VA="0x1189998")]
	public void UpdateMapComponents()
	{
	}

	[Address(RVA="0x1189EB8", Offset="0x1189EB8", VA="0x1189EB8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x118A244", Offset="0x118A244", VA="0x118A244", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B4CC", Offset="0x104B4CC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static CampaignView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<Button> <>9__10_0;

		[Address(RVA="0x118AE44", Offset="0x118AE44", VA="0x118AE44")]
		static <>c()
		{
		}

		[Address(RVA="0x118AEA8", Offset="0x118AEA8", VA="0x118AEA8")]
		public <>c()
		{
		}

		[Address(RVA="0x118AEB0", Offset="0x118AEB0", VA="0x118AEB0")]
		internal void <ViewShuttingDown>b__10_0(Button b)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069DEC", Offset="0x1069DEC")]
		[FieldOffset(Offset="0x28")]
		public CampaignMapSelectorComponent MapSelector;

		[FieldOffset(Offset="0x30")]
		public UiLabel CampaignLabel;

		[FieldOffset(Offset="0x38")]
		public Button InfoButton;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject InfoContainer;

		[FieldOffset(Offset="0x48")]
		public List<Button> InfoCloseButtons;

		[FieldOffset(Offset="0x50")]
		public UiLabel CampaignDetailsLabel;

		[FieldOffset(Offset="0x58")]
		public Button InventoryButton;

		[FieldOffset(Offset="0x60")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x68")]
		public ClubSupportRequestButton ClubSupportRequestButton;

		[FieldOffset(Offset="0x70")]
		public Button BonusInfoButton;

		[Attribute(Name="HeaderAttribute", RVA="0x1069E24", Offset="0x1069E24")]
		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject EventDetailsContainer;

		[FieldOffset(Offset="0x80")]
		public Button EventDetailsButton;

		[Address(RVA="0x118AEF8", Offset="0x118AEF8", VA="0x118AEF8")]
		public SerializedFields()
		{
		}
	}
}