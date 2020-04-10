using DG.Tweening;
using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PackOpeningView : AStandardView, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler, IDispatchHandler<DViewSequencerEndAction>, IDispatchHandler<DPackOpeningCardAction>, IDispatchHandler<DPackOpeningPromoMaterialFlyupAction>, IDispatchHandler<DPackOpeningHudItemFlyupAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105AB08", Offset="0x105AB08")]
	[FieldOffset(Offset="0x68")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105AB18", Offset="0x105AB18")]
	[FieldOffset(Offset="0x70")]
	private ItemFindTracker _itemFindTracker;

	[Attribute(Name="InjectAttribute", RVA="0x105AB28", Offset="0x105AB28")]
	[FieldOffset(Offset="0x78")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105AB38", Offset="0x105AB38")]
	[FieldOffset(Offset="0x80")]
	private ViewSequencerController _sequencerController;

	[Attribute(Name="InjectAttribute", RVA="0x105AB48", Offset="0x105AB48")]
	[FieldOffset(Offset="0x88")]
	private IHapticController _hapticController;

	[FieldOffset(Offset="0x90")]
	private PackOpeningGameState.Context.InitialState _initialState;

	[FieldOffset(Offset="0x98")]
	private List<InventoryItem> _itemListForCards;

	[FieldOffset(Offset="0xA0")]
	private List<InventoryItem> _itemListForSummary;

	[FieldOffset(Offset="0xA8")]
	private List<InventoryItemConversion> _itemConversions;

	[FieldOffset(Offset="0xB0")]
	private int _nextCardPackItemIndex;

	[FieldOffset(Offset="0xB4")]
	private int _cardsRevealed;

	[FieldOffset(Offset="0xB8")]
	private List<PackOpeningCardWidget> _cards;

	[FieldOffset(Offset="0xC0")]
	private List<UiParticleFlyup> _particleFlyups;

	[FieldOffset(Offset="0xC8")]
	private float _helpingHandCooldownS;

	[FieldOffset(Offset="0xD0")]
	private Dictionary<ulong, long> _currentOwnedItemCounts;

	[Attribute(Name="TupleElementNamesAttribute", RVA="0x105AB58", Offset="0x105AB58")]
	[FieldOffset(Offset="0xD8")]
	private List<ValueTuple<HudItemComponent, DG.Tweening.Sequence>> _hudTweens;

	[FieldOffset(Offset="0xE0")]
	private float _hudDefaultYPos;

	[FieldOffset(Offset="0xE8")]
	private StoreItemData _buyAgainItem;

	private bool AllPackItemsShown
	{
		[Address(RVA="0x1304C34", Offset="0x1304C34", VA="0x1304C34")]
		get
		{
			return new bool();
		}
	}

	private PackOpeningView.SerializedFields Fields
	{
		[Address(RVA="0x1304B54", Offset="0x1304B54", VA="0x1304B54")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1308344", Offset="0x1308344", VA="0x1308344")]
	public PackOpeningView()
	{
	}

	[Address(RVA="0x1307FAC", Offset="0x1307FAC", VA="0x1307FAC")]
	private void BindPackItemListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x130828C", Offset="0x130828C", VA="0x130828C")]
	private void BuyAgainClicked()
	{
	}

	[Address(RVA="0x13076E0", Offset="0x13076E0", VA="0x13076E0")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x1307EA8", Offset="0x1307EA8", VA="0x1307EA8")]
	private void FastForwardClicked()
	{
	}

	[Address(RVA="0x1307604", Offset="0x1307604", VA="0x1307604")]
	private void HandleActionPreInitialize(ASequenceAction sequenceAction)
	{
	}

	[Address(RVA="0x1305658", Offset="0x1305658", VA="0x1305658", Slot="21")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x130580C", Offset="0x130580C", VA="0x130580C", Slot="22")]
	public void HandleDispatchAction(DViewSequencerEndAction action)
	{
	}

	[Address(RVA="0x13058E4", Offset="0x13058E4", VA="0x13058E4", Slot="23")]
	public void HandleDispatchAction(DPackOpeningCardAction action)
	{
	}

	[Address(RVA="0x1305F6C", Offset="0x1305F6C", VA="0x1305F6C", Slot="24")]
	public void HandleDispatchAction(DPackOpeningPromoMaterialFlyupAction action)
	{
	}

	[Address(RVA="0x1306154", Offset="0x1306154", VA="0x1306154", Slot="25")]
	public void HandleDispatchAction(DPackOpeningHudItemFlyupAction action)
	{
	}

	[Address(RVA="0x1307EB0", Offset="0x1307EB0", VA="0x1307EB0")]
	private void InitializePackItemListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x13042F4", Offset="0x13042F4", VA="0x13042F4")]
	public void OpenPack(InventoryDelta inventoryDelta, PackOpeningGameState.Context.InitialState initialState, StoreItemData buyAgainItem)
	{
	}

	[Address(RVA="0x1303E0C", Offset="0x1303E0C", VA="0x1303E0C")]
	public void PlayExit()
	{
	}

	[Address(RVA="0x130558C", Offset="0x130558C", VA="0x130558C")]
	private void PlayPackIntro()
	{
	}

	[Address(RVA="0x13075CC", Offset="0x13075CC", VA="0x13075CC", Slot="18")]
	protected override void ProcessBackButton()
	{
	}

	[Address(RVA="0x1305E14", Offset="0x1305E14", VA="0x1305E14")]
	private void SetCardsRevealedCount()
	{
	}

	[Address(RVA="0x130797C", Offset="0x130797C", VA="0x130797C")]
	private void ShowNextCards()
	{
	}

	[Address(RVA="0x1304C98", Offset="0x1304C98", VA="0x1304C98")]
	private void ShowSummary(bool skipReveal)
	{
	}

	[Address(RVA="0x1305394", Offset="0x1305394", VA="0x1305394")]
	private void SpawnCards()
	{
	}

	[Address(RVA="0x1303708", Offset="0x1303708", VA="0x1303708")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1306798", Offset="0x1306798", VA="0x1306798", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x13071D0", Offset="0x13071D0", VA="0x13071D0", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C46C", Offset="0x104C46C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public InventoryItem item;

		[Address(RVA="0x1304C90", Offset="0x1304C90", VA="0x1304C90")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x130849C", Offset="0x130849C", VA="0x130849C")]
		internal bool <OpenPack>b__0(InventoryItemConversion iic)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C47C", Offset="0x104C47C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public HudItemComponent hudComponent;

		[Address(RVA="0x13071C8", Offset="0x13071C8", VA="0x13071C8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x13084F0", Offset="0x13084F0", VA="0x13084F0")]
		internal void <ViewAssetLoaded>b__0()
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106AF84", Offset="0x106AF84")]
		[FieldOffset(Offset="0x28")]
		public Button FastFowardButton;

		[FieldOffset(Offset="0x30")]
		public PackOpeningCardWidget Card;

		[FieldOffset(Offset="0x38")]
		public float HelpingHandDelayS;

		[FieldOffset(Offset="0x40")]
		public UiLabel PackGroupLabel;

		[Attribute(Name="HeaderAttribute", RVA="0x106AFBC", Offset="0x106AFBC")]
		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject CardsRoot;

		[Attribute(Name="RangeAttribute", RVA="0x106AFF4", Offset="0x106AFF4")]
		[FieldOffset(Offset="0x50")]
		public int MaxCards;

		[FieldOffset(Offset="0x54")]
		public float MaxCardRotation;

		[FieldOffset(Offset="0x58")]
		public Vector3 CardArcOriginOffset;

		[Attribute(Name="HeaderAttribute", RVA="0x106B00C", Offset="0x106B00C")]
		[FieldOffset(Offset="0x68")]
		public List<HudItemComponent> HudItems;

		[FieldOffset(Offset="0x70")]
		public float HudItemAppearDuration;

		[FieldOffset(Offset="0x74")]
		public float HudItemAppearYOffset;

		[FieldOffset(Offset="0x78")]
		public float HudItemStayDuration;

		[FieldOffset(Offset="0x7C")]
		public float HudItemTallyStartDelay;

		[FieldOffset(Offset="0x80")]
		public float HudItemTallyDuration;

		[Attribute(Name="HeaderAttribute", RVA="0x106B044", Offset="0x106B044")]
		[FieldOffset(Offset="0x88")]
		public UiParticleFlyup ParticleFlyup;

		[Attribute(Name="HeaderAttribute", RVA="0x106B07C", Offset="0x106B07C")]
		[FieldOffset(Offset="0x90")]
		public UnityEngine.GameObject AllPackItemsRoot;

		[FieldOffset(Offset="0x98")]
		public WrappedScrollRect AllPackItemsScrollRect;

		[FieldOffset(Offset="0xA0")]
		public Button ContinueButton;

		[FieldOffset(Offset="0xA8")]
		public UnityEngine.GameObject BuyAgainContainer;

		[FieldOffset(Offset="0xB0")]
		public StoreItemBuyButtons BuyAgainButtons;

		[FieldOffset(Offset="0xB8")]
		public float AllItemsSequencerDelay;

		[Attribute(Name="HeaderAttribute", RVA="0x106B0B4", Offset="0x106B0B4")]
		[FieldOffset(Offset="0xC0")]
		public Camera WorldCamera;

		[FieldOffset(Offset="0xC8")]
		public UnityEngine.GameObject SorcererHands;

		[Attribute(Name="HeaderAttribute", RVA="0x106B0EC", Offset="0x106B0EC")]
		[FieldOffset(Offset="0xD0")]
		public ViewSequencer HandsIntroSequencer;

		[FieldOffset(Offset="0xD8")]
		public ViewSequencer NextCardGroupSequencer;

		[FieldOffset(Offset="0xE0")]
		public ViewSequencer ShowAllItemsSequencer;

		[FieldOffset(Offset="0xE8")]
		public ViewSequencer ExitSequencer;

		[Address(RVA="0x1308520", Offset="0x1308520", VA="0x1308520")]
		public SerializedFields()
		{
		}
	}
}