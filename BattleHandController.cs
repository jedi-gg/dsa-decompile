using BattleLib;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BattleHandController : ILoggable<LogCategory>, IDispatchHandler<DBattleEncounterAction>, IDispatchHandler, IDispatchHandler<DCastAttemptAction>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted>>, IDispatchHandler<DBattleBusyAction>, IDispatchHandler<DBattleAutoBattleStateChangedAction>, IDispatchHandler<DBattleCinematicAction>
{
	[FieldOffset(Offset="0x0")]
	private const float SHOW_HAND_DELAY_S = 0.25f;

	[FieldOffset(Offset="0x0")]
	private const int INITIAL_CARD_MODEL_POOL_SIZE = 8;

	[Attribute(Name="InjectAttribute", RVA="0x1053564", Offset="0x1053564")]
	[FieldOffset(Offset="0x10")]
	private ABattle _battle;

	[Attribute(Name="InjectAttribute", RVA="0x1053574", Offset="0x1053574")]
	[FieldOffset(Offset="0x18")]
	private BattleUnitsController _battleUnitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053584", Offset="0x1053584")]
	[FieldOffset(Offset="0x20")]
	private DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053594", Offset="0x1053594")]
	[FieldOffset(Offset="0x28")]
	private AssetRegistry _abilityAssetRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x10535A4", Offset="0x10535A4")]
	[FieldOffset(Offset="0x30")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10535B4", Offset="0x10535B4")]
	[FieldOffset(Offset="0x38")]
	private BattleViewController _battleViewController;

	[Attribute(Name="InjectAttribute", RVA="0x10535C4", Offset="0x10535C4")]
	[FieldOffset(Offset="0x40")]
	private BattleAutoBattleController _autoBattleController;

	[FieldOffset(Offset="0x48")]
	private List<BattleAbilityCardData> _unitCards;

	[FieldOffset(Offset="0x50")]
	private List<BattleAbilityCardData> _spellCards;

	[FieldOffset(Offset="0x58")]
	private BattleLib_Bootstrap.Types.Player _player;

	[FieldOffset(Offset="0x60")]
	private List<BattleAbilityCardData> _cardModelPool;

	[FieldOffset(Offset="0x68")]
	private Dictionary<string, AssetHandle> _abilityAssets;

	[FieldOffset(Offset="0x70")]
	private bool _isLocalPlayerTurn;

	public LogCategory LogCategory
	{
		[Address(RVA="0x11488FC", Offset="0x11488FC", VA="0x11488FC", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x114A35C", Offset="0x114A35C", VA="0x114A35C")]
	public BattleHandController()
	{
	}

	[Address(RVA="0x1149348", Offset="0x1149348", VA="0x1149348")]
	private BattleAbilityCardData GetCardModel(BattleLib_UpdateResult.Types.AbilityCard abilityCard)
	{
		return null;
	}

	[Address(RVA="0x1149F04", Offset="0x1149F04", VA="0x1149F04", Slot="5")]
	public void HandleDispatchAction(DBattleEncounterAction action)
	{
	}

	[Address(RVA="0x1149F5C", Offset="0x1149F5C", VA="0x1149F5C", Slot="8")]
	public void HandleDispatchAction(DBattleBusyAction action)
	{
	}

	[Address(RVA="0x114A058", Offset="0x114A058", VA="0x114A058", Slot="6")]
	public void HandleDispatchAction(DCastAttemptAction action)
	{
	}

	[Address(RVA="0x114A0A8", Offset="0x114A0A8", VA="0x114A0A8", Slot="7")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.UnitTurnStarted> action)
	{
	}

	[Address(RVA="0x114A160", Offset="0x114A160", VA="0x114A160", Slot="9")]
	public void HandleDispatchAction(DBattleAutoBattleStateChangedAction action)
	{
	}

	[Address(RVA="0x114A174", Offset="0x114A174", VA="0x114A174", Slot="10")]
	public void HandleDispatchAction(DBattleCinematicAction action)
	{
	}

	[Address(RVA="0x1148904", Offset="0x1148904", VA="0x1148904")]
	public void Initialize(BattleLib_Bootstrap.Types.Player localPlayer)
	{
	}

	[Address(RVA="0x1148AD4", Offset="0x1148AD4", VA="0x1148AD4")]
	public void LoadAssets(IEnumerable<BattleLib_Bootstrap.Types.Ability> abilities, Action finished)
	{
	}

	[Address(RVA="0x113ABF0", Offset="0x113ABF0", VA="0x113ABF0")]
	public void SelectCard(BattleAbilityCardWidget card)
	{
	}

	[Address(RVA="0x114A1C8", Offset="0x114A1C8", VA="0x114A1C8")]
	private void SetSpellsBusy(bool busy)
	{
	}

	[Address(RVA="0x1148A20", Offset="0x1148A20", VA="0x1148A20")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1148F00", Offset="0x1148F00", VA="0x1148F00")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1148F48", Offset="0x1148F48", VA="0x1148F48")]
	public void UpdateHand(BattleLib_UpdateResult.Types.PlayerHand hand)
	{
	}

	[Address(RVA="0x1149F64", Offset="0x1149F64", VA="0x1149F64")]
	private void UpdateShowHand(float showDelayS)
	{
	}

	[Address(RVA="0x1149B04", Offset="0x1149B04", VA="0x1149B04")]
	public void UpdateSpellHand(BattleLib_UpdateResult.Types.SpellHand hand)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFBC", Offset="0x104AFBC")]
	private sealed class <>c__DisplayClass15_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleHandController <>4__this;

		[FieldOffset(Offset="0x18")]
		public string iconName;

		[FieldOffset(Offset="0x20")]
		public BattleAbilityCardData model;

		[FieldOffset(Offset="0x28")]
		public BattleLib_Bootstrap.Types.Ability ability;

		[Address(RVA="0x114A1C0", Offset="0x114A1C0", VA="0x114A1C0")]
		public <>c__DisplayClass15_0()
		{
		}

		[Address(RVA="0x114A3EC", Offset="0x114A3EC", VA="0x114A3EC")]
		internal void <GetCardModel>b__0(AssetHandle handle)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFAC", Offset="0x104AFAC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public List<string> abilityIcons;

		[FieldOffset(Offset="0x18")]
		public BattleHandController <>4__this;

		[FieldOffset(Offset="0x20")]
		public Action finished;

		[Address(RVA="0x1148EF8", Offset="0x1148EF8", VA="0x1148EF8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x114A530", Offset="0x114A530", VA="0x114A530")]
		internal void <LoadAssets>b__0(AssetCollection assetCollection)
		{
		}
	}
}