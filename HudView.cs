using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudView : AView, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerLevelUpAction>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler<DPlayerEnergyUpdateProcessedAction>, IDispatchHandler<DBonusEnergyGenerateBeginAction>, IDispatchHandler<DApplicationFocusAction>, IDispatchHandler<DHudFlyupAction>, IDispatchHandler<DHudFlyupPosAction>, IDispatchHandler<DHudFlyupCustomAction>, IDispatchHandler<DHudFlyupStopAction>
{
	[FieldOffset(Offset="0x0")]
	private const int MAX_HUD_ITEMS = 4;

	[Attribute(Name="InjectAttribute", RVA="0x1059088", Offset="0x1059088")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1059098", Offset="0x1059098")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10590A8", Offset="0x10590A8")]
	[FieldOffset(Offset="0x78")]
	private EnergyGenerateController _energyGenerateController;

	[Attribute(Name="InjectAttribute", RVA="0x10590B8", Offset="0x10590B8")]
	[FieldOffset(Offset="0x80")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x10590C8", Offset="0x10590C8")]
	[FieldOffset(Offset="0x88")]
	private BadgingController _badgingController;

	[FieldOffset(Offset="0x90")]
	private List<HudItemComponent> _hudItemComponents;

	[FieldOffset(Offset="0x98")]
	private List<UiParticleFlyup> _particleFlyups;

	[FieldOffset(Offset="0xA0")]
	private HudItemComponent.Data _pveEnergyData;

	[FieldOffset(Offset="0xA8")]
	private HudItemComponent.Data _grandCampaignEnergyData;

	[FieldOffset(Offset="0xB0")]
	private HudItemComponent.Data _grindCurrencyData;

	[FieldOffset(Offset="0xB8")]
	private HudItemComponent.Data _premiumCurrencyData;

	[FieldOffset(Offset="0xC0")]
	private HudItemComponent.Data _socialCurrencyData;

	[FieldOffset(Offset="0xC8")]
	private HudItemComponent.Data _shardCurrencyData;

	[FieldOffset(Offset="0xD0")]
	private HudItemComponent.Data _pvpCurrencyData;

	[FieldOffset(Offset="0xD8")]
	private HudItemComponent.Data _towerCurrencyData;

	[FieldOffset(Offset="0xE0")]
	private HudItemComponent.Data _clubCurrencyData;

	[FieldOffset(Offset="0xE8")]
	private HudItemComponent.Data _clubDungeonCurrencyData;

	[FieldOffset(Offset="0xF0")]
	private HudItemComponent.Data _grandCampaignCurrencyData;

	[FieldOffset(Offset="0xF8")]
	private HudItemComponent.Data _unitTrainingMaterialData;

	[FieldOffset(Offset="0x100")]
	private List<HudItemComponent.Data> _allHudData;

	public override ViewDepth Depth
	{
		[Address(RVA="0x11794F4", Offset="0x11794F4", VA="0x11794F4", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private HudView.SerializedFields Fields
	{
		[Address(RVA="0x11799D4", Offset="0x11799D4", VA="0x11799D4")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x117C5C0", Offset="0x117C5C0", VA="0x117C5C0", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x117C5C8", Offset="0x117C5C8", VA="0x117C5C8")]
	public HudView()
	{
	}

	[Address(RVA="0x117C668", Offset="0x117C668", VA="0x117C668")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE14", Offset="0x106FE14")]
	private void <ViewAssetLoaded>b__17_0()
	{
	}

	[Address(RVA="0x117C670", Offset="0x117C670", VA="0x117C670")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE24", Offset="0x106FE24")]
	private void <ViewAssetLoaded>b__17_1()
	{
	}

	[Address(RVA="0x117C678", Offset="0x117C678", VA="0x117C678")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE34", Offset="0x106FE34")]
	private void <ViewAssetLoaded>b__17_2()
	{
	}

	[Address(RVA="0x1179AB4", Offset="0x1179AB4", VA="0x1179AB4")]
	public bool CanBePurchased(ulong inventoryItemId)
	{
		return new bool();
	}

	[Address(RVA="0x1176D84", Offset="0x1176D84", VA="0x1176D84")]
	public void Configure(DHudConfig config)
	{
	}

	[Address(RVA="0x11794FC", Offset="0x11794FC", VA="0x11794FC")]
	private void ConfigureLeftButton(HudView.LeftButton leftButton, bool enabled)
	{
	}

	[Address(RVA="0x11795A4", Offset="0x11795A4", VA="0x11795A4")]
	private void ConfigureRightButton(HudView.RightButton rightButton, bool enabled)
	{
	}

	[Address(RVA="0x117C538", Offset="0x117C538", VA="0x117C538")]
	private void DispatchViewAction(DHudViewAction.Type type)
	{
	}

	[Address(RVA="0x117A96C", Offset="0x117A96C", VA="0x117A96C")]
	private void FlyTo(ulong itemId, int count, Vector3 sourceScreenPos)
	{
	}

	[Address(RVA="0x117AD04", Offset="0x117AD04", VA="0x117AD04")]
	private void FlyTo(Texture itemTexture, int count, Vector3 sourceScreenPos, Vector3 targetScreenPos)
	{
	}

	[Address(RVA="0x117C198", Offset="0x117C198", VA="0x117C198", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x117A480", Offset="0x117A480", VA="0x117A480", Slot="21")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x117A484", Offset="0x117A484", VA="0x117A484", Slot="22")]
	public void HandleDispatchAction(DPlayerLevelUpAction action)
	{
	}

	[Address(RVA="0x117A488", Offset="0x117A488", VA="0x117A488", Slot="23")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x117A88C", Offset="0x117A88C", VA="0x117A88C", Slot="24")]
	public void HandleDispatchAction(DPlayerEnergyUpdateProcessedAction action)
	{
	}

	[Address(RVA="0x117A8B0", Offset="0x117A8B0", VA="0x117A8B0", Slot="25")]
	public void HandleDispatchAction(DBonusEnergyGenerateBeginAction action)
	{
	}

	[Address(RVA="0x117A8B4", Offset="0x117A8B4", VA="0x117A8B4", Slot="26")]
	public void HandleDispatchAction(DApplicationFocusAction action)
	{
	}

	[Address(RVA="0x117A8C8", Offset="0x117A8C8", VA="0x117A8C8", Slot="27")]
	public void HandleDispatchAction(DHudFlyupAction action)
	{
	}

	[Address(RVA="0x117ABF0", Offset="0x117ABF0", VA="0x117ABF0", Slot="28")]
	public void HandleDispatchAction(DHudFlyupPosAction action)
	{
	}

	[Address(RVA="0x117AC10", Offset="0x117AC10", VA="0x117AC10", Slot="29")]
	public void HandleDispatchAction(DHudFlyupCustomAction action)
	{
	}

	[Address(RVA="0x117AEFC", Offset="0x117AEFC", VA="0x117AEFC", Slot="30")]
	public void HandleDispatchAction(DHudFlyupStopAction action)
	{
	}

	[Address(RVA="0x11772AC", Offset="0x11772AC", VA="0x11772AC")]
	public void PlayTitleAnimations()
	{
	}

	[Address(RVA="0x11796D0", Offset="0x11796D0", VA="0x11796D0")]
	private void SetHudComponent(HudItemComponent.Data data, ref int componentsSet)
	{
	}

	[Address(RVA="0x1177174", Offset="0x1177174", VA="0x1177174")]
	public void StopAllFlyups()
	{
	}

	[Address(RVA="0x1179850", Offset="0x1179850", VA="0x1179850")]
	private void UpdateAllLabels(bool allowTally = true)
	{
	}

	[Address(RVA="0x1179E40", Offset="0x1179E40", VA="0x1179E40")]
	private void UpdateBonusEnergyIndicators()
	{
	}

	[Address(RVA="0x117C330", Offset="0x117C330", VA="0x117C330")]
	private void UpdateBonusIndicatorVisbility()
	{
	}

	[Address(RVA="0x117C494", Offset="0x117C494", VA="0x117C494")]
	private void UpdateItemComponentLabel(HudItemComponent hudItemComponent)
	{
	}

	[Address(RVA="0x117A700", Offset="0x117A700", VA="0x117A700")]
	private void UpdateItemListenerCount(ulong itemId)
	{
	}

	[Address(RVA="0x1179BF4", Offset="0x1179BF4", VA="0x1179BF4")]
	private void UpdateMaxEnergy()
	{
	}

	[Address(RVA="0x1177E3C", Offset="0x1177E3C", VA="0x1177E3C")]
	public void UpdatePlayerData()
	{
	}

	[Address(RVA="0x117AF00", Offset="0x117AF00", VA="0x117AF00", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x117BF54", Offset="0x117BF54", VA="0x117BF54", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C0AC", Offset="0x104C0AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static HudView.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<HudItemComponent> <>9__18_0;

		[Address(RVA="0x117C680", Offset="0x117C680", VA="0x117C680")]
		static <>c()
		{
		}

		[Address(RVA="0x117C6E4", Offset="0x117C6E4", VA="0x117C6E4")]
		public <>c()
		{
		}

		[Address(RVA="0x117C6EC", Offset="0x117C6EC", VA="0x117C6EC")]
		internal void <ViewShuttingDown>b__18_0(HudItemComponent c)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C09C", Offset="0x104C09C")]
	private sealed class <>c__DisplayClass17_0
	{
		[FieldOffset(Offset="0x10")]
		public HudItemComponent.Data hudItemComponentData;

		[Address(RVA="0x117BF4C", Offset="0x117BF4C", VA="0x117BF4C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Address(RVA="0x117C718", Offset="0x117C718", VA="0x117C718")]
		internal void <ViewAssetLoaded>b__3(AssetHandle assetHandle)
		{
		}
	}

	public enum LeftButton
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Back
	}

	public enum RightButton
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		Home,
		[FieldOffset(Offset="0x0")]
		Settings
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AA34", Offset="0x106AA34")]
		[FieldOffset(Offset="0x28")]
		public List<Badge> Badges;

		[FieldOffset(Offset="0x30")]
		public Button BackButton;

		[FieldOffset(Offset="0x38")]
		public Button HomeButton;

		[FieldOffset(Offset="0x40")]
		public Button SettingsButton;

		[Attribute(Name="HeaderAttribute", RVA="0x106AA6C", Offset="0x106AA6C")]
		[FieldOffset(Offset="0x48")]
		public HudItemComponent HudItemComponentArchetype;

		[Attribute(Name="HeaderAttribute", RVA="0x106AAA4", Offset="0x106AAA4")]
		[FieldOffset(Offset="0x50")]
		public UiParticleFlyup ParticleFlyup;

		[Attribute(Name="HeaderAttribute", RVA="0x106AADC", Offset="0x106AADC")]
		[FieldOffset(Offset="0x58")]
		public List<HomeView.TitleTween> TitleTweens;

		[Address(RVA="0x117C79C", Offset="0x117C79C", VA="0x117C79C")]
		public SerializedFields()
		{
		}
	}
}