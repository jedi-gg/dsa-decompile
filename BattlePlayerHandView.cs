using DG.Tweening;
using Gamedata;
using Glunies;
using Glunies.Audio;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayerHandView : AStandardView, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.PlayerSpellCharge>>, IDispatchHandler, IDispatchHandler<DBattleCastStatusAction>, IDispatchHandler<DAbilityCardIconLoadedAction>, IDispatchHandler<DBattleCinematicAction>
{
	[FieldOffset(Offset="0x0")]
	private const int INITIAL_UNIT_CARD_POOL_SIZE = 5;

	[FieldOffset(Offset="0x0")]
	private const int INITIAL_UNIT_PASSIVE_CARD_POOL_SIZE = 3;

	[FieldOffset(Offset="0x0")]
	private const int INITIAL_SPELL_CARD_POOL_SIZE = 2;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DELAY = 0.25f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_DURATION = 0.75f;

	[FieldOffset(Offset="0x0")]
	private const float INITIAL_TWEEN_HEIGHT_OFFSET = 600f;

	[FieldOffset(Offset="0x0")]
	private const Ease INITIAL_TWEEN_EASE = Ease.OutCubic;

	[FieldOffset(Offset="0x0")]
	private const float SPELL_TRAY_HIDE_OFFSET = 300f;

	[FieldOffset(Offset="0x0")]
	private const float SPELL_TRAY_HIDE_DELAY_S = 1.4f;

	[FieldOffset(Offset="0x0")]
	private const float SPELL_TRAY_TWEEN_DURATION = 0.12f;

	[FieldOffset(Offset="0x0")]
	private const Ease SPELL_TRAY_TWEEN_EASE = Ease.OutSine;

	[Attribute(Name="InjectAttribute", RVA="0x1053AA0", Offset="0x1053AA0")]
	[FieldOffset(Offset="0x68")]
	private BattleCastController _castController;

	[FieldOffset(Offset="0x70")]
	private Dictionary<DBattleAbilityId, uint> _lastAbilityCharges;

	[FieldOffset(Offset="0x78")]
	private MonoArchetypePool<BattleAbilityCardWidget> _unitCardWidgets;

	[FieldOffset(Offset="0x80")]
	private MonoArchetypePool<BattleAbilityCardWidget> _unitPassiveCardWidgets;

	[FieldOffset(Offset="0x88")]
	private MonoArchetypePool<BattleAbilityCardWidget> _spellCardWidgets;

	[FieldOffset(Offset="0x90")]
	private Sequence _openingTweenSequence;

	[FieldOffset(Offset="0x98")]
	private Sequence _showSpellTraySequence;

	[FieldOffset(Offset="0xA0")]
	private bool _isSpellTrayShown;

	[FieldOffset(Offset="0xA1")]
	private bool _showSpellTrayPermanently;

	[FieldOffset(Offset="0xA4")]
	private float _spellTrayHideDelayS;

	[FieldOffset(Offset="0xA8")]
	private float _showHandDelayS;

	private BattlePlayerHandView.SerializedFields Fields
	{
		[Address(RVA="0x1115D5C", Offset="0x1115D5C", VA="0x1115D5C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x111A5D0", Offset="0x111A5D0", VA="0x111A5D0")]
	public BattlePlayerHandView()
	{
	}

	[Address(RVA="0x1118CC8", Offset="0x1118CC8", VA="0x1118CC8")]
	public void AddAura(Aura aura, bool isPlayer, BattleLib_Bootstrap.Types.Unit unit, int abilityId)
	{
	}

	[Address(RVA="0x11161B4", Offset="0x11161B4", VA="0x11161B4")]
	public void EnableCanvas(bool enabled)
	{
	}

	[Address(RVA="0x111A000", Offset="0x111A000", VA="0x111A000", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1115E3C", Offset="0x1115E3C", VA="0x1115E3C")]
	public BattleAbilityCardWidget GetFirstValidCard()
	{
		return null;
	}

	[Address(RVA="0x1115CA4", Offset="0x1115CA4", VA="0x1115CA4")]
	public BattleFullscreenInputHandler GetFullScreenInputHandler()
	{
		return null;
	}

	[Address(RVA="0x1118D4C", Offset="0x1118D4C", VA="0x1118D4C", Slot="21")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.PlayerSpellCharge> action)
	{
	}

	[Address(RVA="0x1119140", Offset="0x1119140", VA="0x1119140", Slot="22")]
	public void HandleDispatchAction(DBattleCastStatusAction action)
	{
	}

	[Address(RVA="0x11194EC", Offset="0x11194EC", VA="0x11194EC", Slot="23")]
	public void HandleDispatchAction(DAbilityCardIconLoadedAction action)
	{
	}

	[Address(RVA="0x1119810", Offset="0x1119810", VA="0x1119810", Slot="24")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x11165C0", Offset="0x11165C0", VA="0x11165C0")]
	public void HideHand()
	{
	}

	[Address(RVA="0x1115C08", Offset="0x1115C08", VA="0x1115C08")]
	public void HideSpellTray()
	{
	}

	[Address(RVA="0x1118C04", Offset="0x1118C04", VA="0x1118C04")]
	public void PlayVictoryAudio()
	{
	}

	[Address(RVA="0x11184E8", Offset="0x11184E8", VA="0x11184E8")]
	public void SelectCard(BattleAbilityCardWidget selectedCard)
	{
	}

	[Address(RVA="0x111791C", Offset="0x111791C", VA="0x111791C")]
	public void SetSpellCards(IReadOnlyList<BattleAbilityCardData> cards)
	{
	}

	[Address(RVA="0x1116630", Offset="0x1116630", VA="0x1116630")]
	public void SetUnitCards(IReadOnlyList<BattleAbilityCardData> cards)
	{
	}

	[Address(RVA="0x1115B20", Offset="0x1115B20", VA="0x1115B20")]
	public void ShowHand(float delayS)
	{
	}

	[Address(RVA="0x11161FC", Offset="0x11161FC", VA="0x11161FC")]
	public void ShowSpellTray(bool permanent)
	{
	}

	[Address(RVA="0x11159C0", Offset="0x11159C0", VA="0x11159C0")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1117DC4", Offset="0x1117DC4", VA="0x1117DC4")]
	public void UpdateSpellCardData(IReadOnlyList<BattleAbilityCardData> cards)
	{
	}

	[Address(RVA="0x1116DC8", Offset="0x1116DC8", VA="0x1116DC8")]
	public void UpdateUnitCardData(IReadOnlyList<BattleAbilityCardData> cards)
	{
	}

	[Address(RVA="0x1119820", Offset="0x1119820", VA="0x1119820", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1119FE8", Offset="0x1119FE8", VA="0x1119FE8", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x1119F88", Offset="0x1119F88", VA="0x1119F88", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1119E00", Offset="0x1119E00", VA="0x1119E00", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x10699E4", Offset="0x10699E4")]
		[FieldOffset(Offset="0x28")]
		public SpriteSheetNameLookup AffinitySpriteLookup;

		[FieldOffset(Offset="0x30")]
		public BattleAbilityCardWidget UnitCardArchetype;

		[FieldOffset(Offset="0x38")]
		public BattleAbilityCardWidget UnitPassiveCardArchetype;

		[FieldOffset(Offset="0x40")]
		public BattleAbilityCardWidget SpellCardArchetype;

		[FieldOffset(Offset="0x48")]
		public BattleFullscreenInputHandler FullscreenInputHandler;

		[FieldOffset(Offset="0x50")]
		public RectTransform CardTray;

		[FieldOffset(Offset="0x58")]
		public RectTransform SpellTrayRoot;

		[FieldOffset(Offset="0x60")]
		public RectTransform PassiveAbilitiesRoot;

		[Attribute(Name="HeaderAttribute", RVA="0x1069A1C", Offset="0x1069A1C")]
		[FieldOffset(Offset="0x68")]
		public AuraListView PlayerAuras;

		[FieldOffset(Offset="0x70")]
		public AuraListView OpponentAuras;

		[Attribute(Name="HeaderAttribute", RVA="0x1069A54", Offset="0x1069A54")]
		[FieldOffset(Offset="0x78")]
		public AudioClipGroup VictoryAudio;

		[FieldOffset(Offset="0x80")]
		public AudioClipGroup ActivatedAbilityReadyAudio;

		[Address(RVA="0x128AD5C", Offset="0x128AD5C", VA="0x128AD5C")]
		public SerializedFields()
		{
		}
	}
}