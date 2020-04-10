using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StoreItemBuyButtons : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	private CostController _costController;

	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private SingleAssetRegistry _singleAssetRegistry;

	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x48")]
	private RevSdkController _revSdkController;

	[FieldOffset(Offset="0x50")]
	private InteractableOverrideButton _activeButton;

	[FieldOffset(Offset="0x58")]
	private ButtonRequireCooldown _activeButtonCooldown;

	[FieldOffset(Offset="0x60")]
	private bool _forceSuppressConfirmComponent;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private CostButton _buyWithIngameCurrencyButton;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private ButtonRequireConfirmation _buyWithIngameCurrencyConfirmation;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private ButtonRequireCooldown _buyWithIngameCurrencyCooldown;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private LabelButton _buyWithRealCurrencyButton;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private ButtonRequireCooldown _buyWithRealCurrencyCooldown;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private LabelButton _getButton;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private ButtonRequireCooldown _getButtonCooldown;

	[FieldOffset(Offset="0xA0")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private LabelButton _videoAdButton;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private Image _videoAdImage;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private ButtonRequireCooldown _videoAdButtonCooldown;

	public LogCategory LogCategory
	{
		[Address(RVA="0x122F744", Offset="0x122F744", VA="0x122F744", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1231300", Offset="0x1231300", VA="0x1231300")]
	public StoreItemBuyButtons()
	{
	}

	[Address(RVA="0x122FB80", Offset="0x122FB80", VA="0x122FB80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070AEC", Offset="0x1070AEC")]
	private void <Initialize>g__InitializeCooldownComponent|2_0(ButtonRequireCooldown cooldownComponent, ref StoreItemBuyButtons.<>c__DisplayClass2_0 _)
	{
	}

	[Address(RVA="0x122FEA0", Offset="0x122FEA0", VA="0x122FEA0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070AFC", Offset="0x1070AFC")]
	private void <Shutdown>g__ShutdownCooldownComponent|3_0(ButtonRequireCooldown cooldownComponent)
	{
	}

	[Address(RVA="0x12311B8", Offset="0x12311B8", VA="0x12311B8")]
	private void ClickedOnCooldown()
	{
	}

	[Address(RVA="0x1230A6C", Offset="0x1230A6C", VA="0x1230A6C")]
	public void ConfigureForItem(StoreItemData itemData)
	{
	}

	[Address(RVA="0x1231000", Offset="0x1231000", VA="0x1231000")]
	public void ConfigureForOfferWall()
	{
	}

	[Address(RVA="0x12308E4", Offset="0x12308E4", VA="0x12308E4")]
	public RectTransform GetActiveButtonForContextualMessagePointAt()
	{
		return null;
	}

	[Address(RVA="0x1231108", Offset="0x1231108", VA="0x1231108")]
	public ulong GetIngameCurrencyCostItemId()
	{
		return new ulong();
	}

	[Address(RVA="0x1230428", Offset="0x1230428", VA="0x1230428")]
	public void Hide()
	{
	}

	[Address(RVA="0x122F74C", Offset="0x122F74C", VA="0x122F74C")]
	public void Initialize(WidgetDependencyContainer dependencies, UnityAction buyClicked)
	{
	}

	[Address(RVA="0x12305EC", Offset="0x12305EC", VA="0x12305EC")]
	public void SetCost(ulong cost, InventoryItem? costItem)
	{
	}

	[Address(RVA="0x1230834", Offset="0x1230834", VA="0x1230834")]
	public void SetPurchaseLimitElapsedTime(DateTime expiryUtc)
	{
	}

	[Address(RVA="0x1230430", Offset="0x1230430", VA="0x1230430")]
	private void ShowActiveButton()
	{
	}

	[Address(RVA="0x1230828", Offset="0x1230828", VA="0x1230828")]
	private void ShowFreeButton()
	{
	}

	[Address(RVA="0x12306DC", Offset="0x12306DC", VA="0x12306DC")]
	private void ShowIngameCurrencyCost(ulong cost, InventoryItem? costItem)
	{
	}

	[Address(RVA="0x1230F80", Offset="0x1230F80", VA="0x1230F80")]
	private void ShowRealCurrencyButton(string costText)
	{
	}

	[Address(RVA="0x1230FF0", Offset="0x1230FF0", VA="0x1230FF0")]
	private void ShowVideoAdButton()
	{
	}

	[Address(RVA="0x122FD00", Offset="0x122FD00", VA="0x122FD00")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1230004", Offset="0x1230004", VA="0x1230004")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CCFC", Offset="0x104CCFC")]
	private struct <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x0")]
		public WidgetDependencyContainer dependencies;

		[FieldOffset(Offset="0x8")]
		public StoreItemBuyButtons <>4__this;
	}
}