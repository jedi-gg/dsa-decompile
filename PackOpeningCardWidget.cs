using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class PackOpeningCardWidget : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	private DiContainer _diContainer;

	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x28")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x38")]
	private InventoryUtility _inventoryUtility;

	[FieldOffset(Offset="0x40")]
	private InventoryItemUtil _inventoryItemUtil;

	[FieldOffset(Offset="0x48")]
	private SingleAssetRegistry _iconAssetRegistry;

	[FieldOffset(Offset="0x50")]
	private SingleAssetRegistry _3dAssetRegistry;

	[FieldOffset(Offset="0x58")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x60")]
	private Camera _camera;

	[FieldOffset(Offset="0x68")]
	private GameObject _sorcererHands;

	[FieldOffset(Offset="0x70")]
	private Vector3 _moveToPos;

	[FieldOffset(Offset="0x7C")]
	private Vector3 _initialRotation;

	[FieldOffset(Offset="0x88")]
	private Serverproto.InventoryItem _item;

	[FieldOffset(Offset="0x90")]
	private bool _shouldTallyShardCount;

	[FieldOffset(Offset="0x98")]
	private Tweener _shardProgressBarTween;

	[FieldOffset(Offset="0xA0")]
	private bool _revealAutomatically;

	[FieldOffset(Offset="0xA1")]
	private bool _inIntroDelayState;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private Canvas _canvas;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private GameObject _uiFrontRoot;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private GameObject _worldFrontRoot;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private GameObject _uiBackRoot;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private GameObject _worldBackRoot;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private GameObject _helpingHand;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private PackOpeningCardSequencer _introSequencer;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private PackOpeningCardSequencer _revealSequencer;

	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private Button _cardButton;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiInputSquish _inputSquish;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private float _revealDurationS;

	[FieldOffset(Offset="0xFC")]
	[SerializeField]
	private float _introDelayS;

	[Attribute(Name="HeaderAttribute", RVA="0x105A914", Offset="0x105A914")]
	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private List<PackOpeningCardWidget.DropRarityEffect> _dropRarityEffects;

	[Attribute(Name="HeaderAttribute", RVA="0x105A960", Offset="0x105A960")]
	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private GameObject _itemRoot;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private RawImage _itemIcon;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private EmoteWidget _emoteWidget;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private UiLabel _nameLabel;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private UiLabel _countLabel;

	[Attribute(Name="HeaderAttribute", RVA="0x105A9EC", Offset="0x105A9EC")]
	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private GameObject _3dRoot;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private GameObject _shardRoot;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private GameObject _ownedShardRoot;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private RawImage[] _shardIcons;

	[FieldOffset(Offset="0x150")]
	[SerializeField]
	private UiLabel _shardCount;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private Transform _particleFlyToDestination;

	[FieldOffset(Offset="0x160")]
	[SerializeField]
	private SlicedFilledImage _shardProgressBar;

	[FieldOffset(Offset="0x168")]
	[SerializeField]
	private TallyLabelSigned _shardProgressCountLabel;

	[FieldOffset(Offset="0x170")]
	[SerializeField]
	private float _tallyDurationS;

	[FieldOffset(Offset="0x174")]
	[SerializeField]
	private float _tallyDelayS;

	[FieldOffset(Offset="0x178")]
	[SerializeField]
	private GameObject _upgradeIndicator;

	public bool IsPlayingReveal
	{
		[Address(RVA="0x12FFF88", Offset="0x12FFF88", VA="0x12FFF88")]
		get
		{
			return new bool();
		}
	}

	public bool IsRevealed
	{
		[Address(RVA="0x12FFF58", Offset="0x12FFF58", VA="0x12FFF58")]
		get
		{
			return new bool();
		}
	}

	public long ItemCount
	{
		[Address(RVA="0x12FFFCC", Offset="0x12FFFCC", VA="0x12FFFCC")]
		get
		{
			return new long();
		}
	}

	public ulong ItemId
	{
		[Address(RVA="0x12FFFB8", Offset="0x12FFFB8", VA="0x12FFFB8")]
		get
		{
			return new ulong();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x12FFF50", Offset="0x12FFF50", VA="0x12FFF50", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x13028F0", Offset="0x13028F0", VA="0x13028F0")]
	public PackOpeningCardWidget()
	{
	}

	[Address(RVA="0x1302908", Offset="0x1302908", VA="0x1302908")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070214", Offset="0x1070214")]
	private void <ShowCard>b__13_0()
	{
	}

	[Address(RVA="0x12FFE1C", Offset="0x12FFE1C", VA="0x12FFE1C")]
	public void ApplySequencerOverrides(PackOpeningCardSequencer.RuntimeBindingType type, Binding binding)
	{
	}

	[Address(RVA="0x1302528", Offset="0x1302528", VA="0x1302528")]
	private void HandleActionPreInitialize(ASequenceAction sequenceAction)
	{
	}

	[Address(RVA="0x1300930", Offset="0x1300930", VA="0x1300930")]
	private void HandleRevealFinished()
	{
	}

	[Address(RVA="0x1301408", Offset="0x1301408", VA="0x1301408")]
	private void HideAllRarityEffects()
	{
	}

	[Address(RVA="0x1301FE0", Offset="0x1301FE0", VA="0x1301FE0")]
	public void HideCard()
	{
	}

	[Address(RVA="0x12FFFE0", Offset="0x12FFFE0", VA="0x12FFFE0")]
	public void Initialize(WidgetDependencyContainer dependencies, GameObject sorcererHands, Camera worldCamera)
	{
	}

	[Address(RVA="0x13023C0", Offset="0x13023C0", VA="0x13023C0")]
	public bool ItemWillFlyToHud()
	{
		return new bool();
	}

	[Address(RVA="0x1301D44", Offset="0x1301D44", VA="0x1301D44")]
	private void LoadItem(Gamedata.InventoryItem item, long count)
	{
	}

	[Address(RVA="0x130260C", Offset="0x130260C", VA="0x130260C")]
	private void LoadShardInfo(Gamedata.InventoryItem shardItem, long grantedAmount)
	{
	}

	[Address(RVA="0x1301AC4", Offset="0x1301AC4", VA="0x1301AC4")]
	private void LoadSkin(Gamedata.InventoryItem skinItem, long count)
	{
	}

	[Address(RVA="0x1301828", Offset="0x1301828", VA="0x1301828")]
	private void LoadSpell(Gamedata.InventoryItem promotionItem, long count)
	{
	}

	[Address(RVA="0x130158C", Offset="0x130158C", VA="0x130158C")]
	private void LoadUnit(Gamedata.InventoryItem promotionItem, long count)
	{
	}

	[Address(RVA="0x1300828", Offset="0x1300828", VA="0x1300828")]
	private void PlayReveal()
	{
	}

	[Address(RVA="0x13020A4", Offset="0x13020A4", VA="0x13020A4")]
	public void SetCurrentOwnedShardItemCount(long startingCount)
	{
	}

	[Address(RVA="0x1302098", Offset="0x1302098", VA="0x1302098")]
	public void SetRevealAutomatically(bool revealAutomatically)
	{
	}

	[Address(RVA="0x1300E20", Offset="0x1300E20", VA="0x1300E20")]
	public void ShowCard(Serverproto.InventoryItem item, Vector3 rotationPivot, float rotationAmount, float delayOffset)
	{
	}

	[Address(RVA="0x13013B8", Offset="0x13013B8", VA="0x13013B8")]
	public void ShowHelpingHand(bool show)
	{
	}

	[Address(RVA="0x1302734", Offset="0x1302734", VA="0x1302734")]
	private void ShowRarityEffect(long itemCount)
	{
	}

	[Address(RVA="0x1301380", Offset="0x1301380", VA="0x1301380")]
	public void ShowShardInfo(bool show)
	{
	}

	[Address(RVA="0x13003CC", Offset="0x13003CC", VA="0x13003CC")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x130057C", Offset="0x130057C", VA="0x130057C")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x130076C", Offset="0x130076C", VA="0x130076C")]
	private void UpdateInputSquish()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C40C", Offset="0x104C40C")]
	private sealed class <>c__DisplayClass24_0
	{
		[FieldOffset(Offset="0x10")]
		public PackOpeningCardWidget <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong unitDefId;

		[Address(RVA="0x1302604", Offset="0x1302604", VA="0x1302604")]
		public <>c__DisplayClass24_0()
		{
		}

		[Address(RVA="0x1302910", Offset="0x1302910", VA="0x1302910")]
		internal void <LoadUnit>b__0(AssetHandle handle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C41C", Offset="0x104C41C")]
	private sealed class <>c__DisplayClass25_0
	{
		[FieldOffset(Offset="0x10")]
		public PackOpeningCardWidget <>4__this;

		[FieldOffset(Offset="0x18")]
		public Gamedata.Unit? unitDef;

		[FieldOffset(Offset="0x30")]
		public Gamedata.InventoryItem skinItem;

		[Address(RVA="0x13028E0", Offset="0x13028E0", VA="0x13028E0")]
		public <>c__DisplayClass25_0()
		{
		}

		[Address(RVA="0x1302C60", Offset="0x1302C60", VA="0x1302C60")]
		internal void <LoadSkin>b__0(AssetHandle handle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C42C", Offset="0x104C42C")]
	private sealed class <>c__DisplayClass26_0
	{
		[FieldOffset(Offset="0x10")]
		public PackOpeningCardWidget <>4__this;

		[FieldOffset(Offset="0x18")]
		public ulong spellId;

		[Address(RVA="0x13028E8", Offset="0x13028E8", VA="0x13028E8")]
		public <>c__DisplayClass26_0()
		{
		}

		[Address(RVA="0x1302FF0", Offset="0x1302FF0", VA="0x1302FF0")]
		internal void <LoadSpell>b__0(AssetHandle handle)
		{
		}
	}

	[Serializable]
	public class DropRarityEffect
	{
		[FieldOffset(Offset="0x10")]
		public int MinItemCount;

		[FieldOffset(Offset="0x18")]
		public GameObject EffectInstance;

		[Address(RVA="0x1303340", Offset="0x1303340", VA="0x1303340")]
		public DropRarityEffect()
		{
		}
	}
}