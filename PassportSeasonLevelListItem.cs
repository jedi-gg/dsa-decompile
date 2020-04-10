using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonLevelListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x40")]
	private CostController _costController;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _costButtonAssetRegistry;

	[FieldOffset(Offset="0x50")]
	private ButtonRequireConfirmation _purchaseLevelConfirmation;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Image _xpProgressFill;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private Image _xpProgressPreviewFill;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UnityEngine.Color _freeProgressColor;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UnityEngine.Color _premiumProgressColor;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UnityEngine.Color _lockedRewardColor;

	[Attribute(Name="RangeAttribute", RVA="0x105ADBC", Offset="0x105ADBC")]
	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private float _previewFillColorVMultiplier;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private UiLabel _levelLabel;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private UiLabel _xpProgressLabel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _buyLevelContainer;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private CostButton _buyLevelButton;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private PassportSeasonLevelListItem.RewardContainer _premiumReward;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private PassportSeasonLevelListItem.RewardContainer _freeReward;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private Vector3 _singleRewardScale;

	private int PassportLevelDataIndex
	{
		[Address(RVA="0x13FDF04", Offset="0x13FDF04", VA="0x13FDF04")]
		get
		{
			return new int();
		}
	}

	[Address(RVA="0x13FE42C", Offset="0x13FE42C", VA="0x13FE42C")]
	public PassportSeasonLevelListItem()
	{
	}

	[Address(RVA="0x13FE090", Offset="0x13FE090", VA="0x13FE090")]
	public void AnimateXpFill(float endVal, float duration, float delay, bool preview)
	{
	}

	[Address(RVA="0x13FE270", Offset="0x13FE270", VA="0x13FE270")]
	private void BuyLevelClicked()
	{
	}

	[Address(RVA="0x13FE398", Offset="0x13FE398", VA="0x13FE398")]
	private void BuyLevelConfirmationExpired()
	{
	}

	[Address(RVA="0x13FE304", Offset="0x13FE304", VA="0x13FE304")]
	private void BuyLevelConfirmationInitiated()
	{
	}

	[Address(RVA="0x13FE1DC", Offset="0x13FE1DC", VA="0x13FE1DC")]
	private void FreeClicked()
	{
	}

	[Address(RVA="0x13FD128", Offset="0x13FD128", VA="0x13FD128")]
	public RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x13FC4D8", Offset="0x13FC4D8", VA="0x13FC4D8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x13FE148", Offset="0x13FE148", VA="0x13FE148")]
	private void PremiumClicked()
	{
	}

	[Address(RVA="0x13FD208", Offset="0x13FD208", VA="0x13FD208")]
	public void SetData(PassportSeasonLevelRewards? rewards, long playerXpAmount, uint levelMinXp, uint levelMaxXp, bool playerIsPremium)
	{
	}

	[Address(RVA="0x13FDF20", Offset="0x13FDF20", VA="0x13FDF20")]
	public void SetLevelPurchaseCost(uint levelPurchaseCost, ulong currencyItem, string currencyIcon)
	{
	}

	[Address(RVA="0x13FCA10", Offset="0x13FCA10", VA="0x13FCA10")]
	public void ShowVfx(bool show)
	{
	}

	[Address(RVA="0x13FCB80", Offset="0x13FCB80", VA="0x13FCB80", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x13FCEFC", Offset="0x13FCEFC", VA="0x13FCEFC", Slot="5")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4FC", Offset="0x104C4FC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static PassportSeasonLevelListItem.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<InventoryItemListItem> <>9__1_0;

		[FieldOffset(Offset="0x10")]
		public static Action<InventoryItemListItem> <>9__1_1;

		[Address(RVA="0x13FE4AC", Offset="0x13FE4AC", VA="0x13FE4AC")]
		static <>c()
		{
		}

		[Address(RVA="0x13FE510", Offset="0x13FE510", VA="0x13FE510")]
		public <>c()
		{
		}

		[Address(RVA="0x13FE518", Offset="0x13FE518", VA="0x13FE518")]
		internal void <Shutdown>b__1_0(InventoryItemListItem i)
		{
		}

		[Address(RVA="0x13FE54C", Offset="0x13FE54C", VA="0x13FE54C")]
		internal void <Shutdown>b__1_1(InventoryItemListItem i)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C4EC", Offset="0x104C4EC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x18")]
		public PassportSeasonLevelListItem <>4__this;

		[Address(RVA="0x13FCA08", Offset="0x13FCA08", VA="0x13FCA08")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x13FE580", Offset="0x13FE580", VA="0x13FE580")]
		internal void <Initialize>b__0(InventoryItemListItem i)
		{
		}

		[Address(RVA="0x13FE5C4", Offset="0x13FE5C4", VA="0x13FE5C4")]
		internal void <Initialize>b__1(InventoryItemListItem i)
		{
		}
	}

	[Serializable]
	public class RewardContainer
	{
		[FieldOffset(Offset="0x10")]
		public GameObject Container;

		[FieldOffset(Offset="0x18")]
		public Button Button;

		[FieldOffset(Offset="0x20")]
		public List<InventoryItemListItem> RewardItems;

		[FieldOffset(Offset="0x28")]
		public GameObject MultiRewardIcon;

		[FieldOffset(Offset="0x30")]
		public GameObject ClaimedIndicator;

		[FieldOffset(Offset="0x38")]
		public GameObject LockedIndicator;

		[FieldOffset(Offset="0x40")]
		public GameObject VfxRoot;

		[Address(RVA="0x13FE608", Offset="0x13FE608", VA="0x13FE608")]
		public RewardContainer()
		{
		}
	}
}