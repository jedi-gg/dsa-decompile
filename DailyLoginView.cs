using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DailyLoginView : APopupView, IDispatchHandler<DDailyLoginListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057934", Offset="0x1057934")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057944", Offset="0x1057944")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x1057954", Offset="0x1057954")]
	[FieldOffset(Offset="0x78")]
	private SingleAssetRegistry _descriptionIconAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1057964", Offset="0x1057964")]
	[FieldOffset(Offset="0x80")]
	private CostController _costController;

	[Attribute(Name="InjectAttribute", RVA="0x1057974", Offset="0x1057974")]
	[FieldOffset(Offset="0x88")]
	private FeatureLockController _featureLockController;

	[Attribute(Name="InjectAttribute", RVA="0x1057984", Offset="0x1057984")]
	[FieldOffset(Offset="0x90")]
	private BadgingController _badgingController;

	[Attribute(Name="InjectAttribute", RVA="0x1057994", Offset="0x1057994")]
	[FieldOffset(Offset="0x98")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0xA0")]
	private DailyLogin _dailyLogin;

	[FieldOffset(Offset="0xA8")]
	private List<DailyLoginListItem> _dailyLoginListItems;

	[FieldOffset(Offset="0xB0")]
	private DailyLoginListItem _selectedListItem;

	private DailyLoginView.SerializedFields Fields
	{
		[Address(RVA="0x12B07E4", Offset="0x12B07E4", VA="0x12B07E4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12B2388", Offset="0x12B2388", VA="0x12B2388")]
	public DailyLoginView()
	{
	}

	[Address(RVA="0x12B2390", Offset="0x12B2390", VA="0x12B2390")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F484", Offset="0x106F484")]
	private void <ViewAssetLoaded>b__5_0()
	{
	}

	[Address(RVA="0x12B2414", Offset="0x12B2414", VA="0x12B2414")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F494", Offset="0x106F494")]
	private void <ViewAssetLoaded>b__5_1()
	{
	}

	[Address(RVA="0x12B21B0", Offset="0x12B21B0", VA="0x12B21B0")]
	private void BuyExpiredClicked()
	{
	}

	[Address(RVA="0x12AF890", Offset="0x12AF890", VA="0x12AF890")]
	public void CelebrateRewards(InventoryDelta delta)
	{
	}

	[Address(RVA="0x12B1F88", Offset="0x12B1F88", VA="0x12B1F88")]
	private void ClaimClicked()
	{
	}

	[Address(RVA="0x12B1D38", Offset="0x12B1D38", VA="0x12B1D38")]
	private DailyLoginView.DayState GetCalendarDayState(ulong calendarDay)
	{
		return new DailyLoginView.DayState();
	}

	[Address(RVA="0x12B12E8", Offset="0x12B12E8", VA="0x12B12E8", Slot="22")]
	public void HandleDispatchAction(DDailyLoginListItemAction action)
	{
	}

	[Address(RVA="0x12AEB5C", Offset="0x12AEB5C", VA="0x12AEB5C")]
	public void Initialize(DailyLogin dailyLogin)
	{
	}

	[Address(RVA="0x12B08C4", Offset="0x12B08C4", VA="0x12B08C4")]
	private void InitializeDailyLoginListItem(DailyLoginListItem listItem, int index)
	{
	}

	[Address(RVA="0x12AF1E0", Offset="0x12AF1E0", VA="0x12AF1E0")]
	public void SelectIndex(int index)
	{
	}

	[Address(RVA="0x12B0BA0", Offset="0x12B0BA0", VA="0x12B0BA0")]
	private void SelectListItem(DailyLoginListItem listItem)
	{
	}

	[Address(RVA="0x12B0A3C", Offset="0x12B0A3C", VA="0x12B0A3C")]
	private void SetListItemState(DailyLoginListItem listItem)
	{
	}

	[Address(RVA="0x12B1CB8", Offset="0x12B1CB8", VA="0x12B1CB8")]
	private void ToggleInfoContainer()
	{
	}

	[Address(RVA="0x12AFD60", Offset="0x12AFD60", VA="0x12AFD60")]
	public void UpdateData()
	{
	}

	[Address(RVA="0x12B12EC", Offset="0x12B12EC", VA="0x12B12EC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x12B197C", Offset="0x12B197C", VA="0x12B197C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	public enum DayState
	{
		[FieldOffset(Offset="0x0")]
		CanClaim,
		[FieldOffset(Offset="0x0")]
		CanClaimBonus,
		[FieldOffset(Offset="0x0")]
		Claimed,
		[FieldOffset(Offset="0x0")]
		ExpiredCanBuy,
		[FieldOffset(Offset="0x0")]
		ExpiredCannotBuyYet,
		[FieldOffset(Offset="0x0")]
		FutureDay
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A38C", Offset="0x106A38C")]
		[FieldOffset(Offset="0x30")]
		public DailyLoginListItem DailyLoginListItemArchetype;

		[FieldOffset(Offset="0x38")]
		public Button InfoButton;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject InfoContainer;

		[FieldOffset(Offset="0x48")]
		public Button InfoContainerCloseButton;

		[FieldOffset(Offset="0x50")]
		public Button ClaimDailyLoginButton;

		[FieldOffset(Offset="0x58")]
		public Button ClaimDailyLoginBonusButton;

		[FieldOffset(Offset="0x60")]
		public Button VipButton;

		[FieldOffset(Offset="0x68")]
		public CostButton BuyExpiredDailyLoginButton;

		[FieldOffset(Offset="0x70")]
		public RawImage DetailsRewardImage;

		[FieldOffset(Offset="0x78")]
		public UiLabel MonthLabel;

		[FieldOffset(Offset="0x80")]
		public UiLabel DetailsRewardCount;

		[FieldOffset(Offset="0x88")]
		public UiLabel DetailsRewardName;

		[FieldOffset(Offset="0x90")]
		public UiLabel DetailsRewardDescription;

		[FieldOffset(Offset="0x98")]
		public UiLabel AvailableInLabel;

		[FieldOffset(Offset="0xA0")]
		public UiLabel BuybackBlockedByPreviousDayLabel;

		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject BonusEligibilityContainer;

		[FieldOffset(Offset="0xB0")]
		public RectTransform SelectedBorder;

		[Address(RVA="0x12B2498", Offset="0x12B2498", VA="0x12B2498")]
		public SerializedFields()
		{
		}
	}
}