using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class GamedataDomainController : ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x0")]
	public const ulong INVALID_CONTENT_ID = 0L;

	[FieldOffset(Offset="0x0")]
	public const int MAX_BATTLE_NODE_STARS = 3;

	[Attribute(Name="InjectAttribute", RVA="0x1058690", Offset="0x1058690")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x18")]
	private Constants? _constants;

	[FieldOffset(Offset="0x30")]
	private ClubSupport? _clubSupport;

	[FieldOffset(Offset="0x48")]
	private VipPerks? _vipPerks;

	[FieldOffset(Offset="0x60")]
	private GamedataDomainController.GamedataIdMapping<Gamedata.Unit?> _unitMapping;

	[FieldOffset(Offset="0x68")]
	private GamedataDomainController.GamedataIdMapping<UnitCategory?> _unitCategoryMapping;

	[FieldOffset(Offset="0x70")]
	private GamedataDomainController.GamedataIdMapping<Gamedata.Spell?> _spellMapping;

	[FieldOffset(Offset="0x78")]
	private GamedataDomainController.GamedataIdMapping<SpellCategory?> _spellCategoryMapping;

	[FieldOffset(Offset="0x80")]
	private GamedataDomainController.GamedataIdMapping<Gamedata.InventoryItem?> _inventoryItemMapping;

	[FieldOffset(Offset="0x88")]
	private GamedataDomainController.GamedataIdMapping<Campaign?> _campaignMapping;

	[FieldOffset(Offset="0x90")]
	private GamedataDomainController.GamedataIdMapping<GearSlotTable?> _gearSlotTableMapping;

	[FieldOffset(Offset="0x98")]
	private GamedataDomainController.GamedataIdMapping<StatProgressionTable?> _statProgressionTableMapping;

	[FieldOffset(Offset="0xA0")]
	private GamedataDomainController.GamedataIdMapping<AbilityEffect?> _abilityEffectMapping;

	[FieldOffset(Offset="0xA8")]
	private GamedataDomainController.GamedataIdMapping<EnergyConstants?> _energyConstants;

	[FieldOffset(Offset="0xB0")]
	private GamedataDomainController.GamedataIdMapping<BattleRestriction?> _battleRestrictionMapping;

	[FieldOffset(Offset="0xB8")]
	private GamedataDomainController.GamedataIdMapping<ContextualMessageGroup?> _contextualMessageGroupMapping;

	[FieldOffset(Offset="0xC0")]
	private GamedataDomainController.GamedataIdMapping<PvpRank?> _pvpRankMapping;

	[FieldOffset(Offset="0xC8")]
	private GamedataDomainController.GamedataIdMapping<PinPageCollection?> _pinPageCollectionMapping;

	[FieldOffset(Offset="0xD0")]
	private GamedataDomainController.GamedataIdMapping<PassportSeason?> _passportSeasonMapping;

	[FieldOffset(Offset="0xD8")]
	private GamedataDomainController.GamedataIdMapping<UnitPromotionTable?> _unitPromotionTableMapping;

	[FieldOffset(Offset="0xE0")]
	private GamedataDomainController.GamedataIdMapping<UnitTrainingTable?> _unitTrainingTableMapping;

	[FieldOffset(Offset="0xE8")]
	private GamedataDomainController.GamedataIdMapping<LockableFeatures?> _lockableFeatureMapping;

	[FieldOffset(Offset="0xF0")]
	private GamedataDomainController.GamedataIdMapping<ShipmentNameMap?> _shipmentNameMapMapping;

	[FieldOffset(Offset="0xF8")]
	private GamedataDomainController.GamedataIdMapping<KothRank?> _kothRankMapping;

	[FieldOffset(Offset="0x100")]
	private GamedataDomainController.GamedataIdMapping<BattleAbilityCodes?> _battleAbilityCodesMapping;

	[FieldOffset(Offset="0x108")]
	private GamedataDomainController.GamedataIdMapping<CardProgressTracker?> _cardProgressTrackerMapping;

	[FieldOffset(Offset="0x110")]
	private GamedataDomainController.GamedataIdMapping<SorcererStoneCollection?> _sorcererStoneCollectionMapping;

	[FieldOffset(Offset="0x118")]
	private GamedataDomainController.GamedataIdMapping<Gamedata.ClubWar?> _clubWarMapping;

	[FieldOffset(Offset="0x120")]
	private GamedataDomainController.GamedataIdMapping<Gamedata.DailyReward?> _dailyRewardMapping;

	[FieldOffset(Offset="0x128")]
	private GamedataDomainController.GamedataIdMapping<BattleMessage?> _battleMessageMapping;

	[FieldOffset(Offset="0x130")]
	private GamedataDomainController.GamedataIdMapping<Aura?> _auraMapping;

	[FieldOffset(Offset="0x138")]
	private List<Gamedata.Unit?> _obtainableUnitDefinitions;

	[FieldOffset(Offset="0x140")]
	private List<Gamedata.Spell?> _obtainableSpellDefinitions;

	[FieldOffset(Offset="0x148")]
	private List<Gamedata.InventoryItem?> _limitedPinDefinitions;

	[FieldOffset(Offset="0x150")]
	private List<Gamedata.InventoryItem?> _seasonalPassportPinDefinitions;

	[FieldOffset(Offset="0x158")]
	private List<Gamedata.InventoryItem?> _emotes;

	[FieldOffset(Offset="0x160")]
	private List<LockableFeatureEntry?> _lockableFeatures;

	[FieldOffset(Offset="0x168")]
	private List<PvpRank?> _sortedPvpRanks;

	[FieldOffset(Offset="0x170")]
	private List<KothRank?> _sortedKothRanks;

	[FieldOffset(Offset="0x178")]
	private Dictionary<ulong, ulong> _unitDefIdByPromotionMaterialId;

	[FieldOffset(Offset="0x180")]
	private Dictionary<ulong, ulong> _spellDefIdByPromotionMaterialId;

	[FieldOffset(Offset="0x188")]
	private List<PassportSeason?> _sortedPassportSeasons;

	[FieldOffset(Offset="0x190")]
	private Dictionary<ulong, Gamedata.Color?> _colorIds;

	public LogCategory LogCategory
	{
		[Address(RVA="0x1681E48", Offset="0x1681E48", VA="0x1681E48", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x168A390", Offset="0x168A390", VA="0x168A390")]
	public GamedataDomainController()
	{
	}

	[Address(RVA="0x1687218", Offset="0x1687218", VA="0x1687218")]
	private void AddGamedata(StaticGamedata gamedata, bool clearExisting)
	{
	}

	[Address(RVA="0x1684D60", Offset="0x1684D60", VA="0x1684D60")]
	public AbilityEffect? GetAbilityEffect(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1685760", Offset="0x1685760", VA="0x1685760")]
	public IEnumerable<ContextualMessageGroup?> GetAllContextualMessageGroups()
	{
		return null;
	}

	[Address(RVA="0x1689EC4", Offset="0x1689EC4", VA="0x1689EC4")]
	public Aura? GetAura(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1689864", Offset="0x1689864", VA="0x1689864")]
	public string GetBattleAbilityFailureCodeLocKey(uint failureCode)
	{
		return null;
	}

	[Address(RVA="0x1689E48", Offset="0x1689E48", VA="0x1689E48")]
	public BattleMessage? GetBattleMessage(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1685314", Offset="0x1685314", VA="0x1685314")]
	public BattleRestriction? GetBattleRestriction(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1683CA4", Offset="0x1683CA4", VA="0x1683CA4")]
	public Campaign? GetCampaign(ulong campaignId)
	{
		return null;
	}

	[Address(RVA="0x1683F38", Offset="0x1683F38", VA="0x1683F38")]
	public Gamedata.BattleNode? GetCampaignBattleNode(ulong campaignId, int mapIndex, int nodeIndex, int battleIndex)
	{
		return null;
	}

	[Address(RVA="0x1684058", Offset="0x1684058", VA="0x1684058")]
	public Gamedata.BattleNode? GetCampaignBattleNode(CampaignIdentifier campaignIdentifier)
	{
		return null;
	}

	[Address(RVA="0x1684138", Offset="0x1684138", VA="0x1684138")]
	public Gamedata.BattleNode? GetCampaignBattleNode(DCampaignAddress campaignAddress)
	{
		return null;
	}

	[Address(RVA="0x1683D20", Offset="0x1683D20", VA="0x1683D20")]
	public Gamedata.CampaignMap? GetCampaignMap(ulong campaignId, int mapIndex)
	{
		return null;
	}

	[Address(RVA="0x1683E28", Offset="0x1683E28", VA="0x1683E28")]
	public Gamedata.CampaignNode? GetCampaignNode(ulong campaignId, int mapIndex, int nodeIndex)
	{
		return null;
	}

	[Address(RVA="0x16843C0", Offset="0x16843C0", VA="0x16843C0")]
	public ulong GetCampaignNodeRewardPlayerActivityId(DCampaignAddress nodeAddress)
	{
		return new ulong();
	}

	[Address(RVA="0x1689A64", Offset="0x1689A64", VA="0x1689A64")]
	public IEnumerable<CardProgressTracker?> GetCardProgressTrackers()
	{
		return null;
	}

	[Address(RVA="0x1682B98", Offset="0x1682B98", VA="0x1682B98")]
	private UnitCategory? GetCategoryOfType(Gamedata.Unit unitDef, UnitCategoryType categoryType)
	{
		return null;
	}

	[Address(RVA="0x1682DE0", Offset="0x1682DE0", VA="0x1682DE0")]
	private UnitCategory? GetCategoryOfType(IList<ulong> categories, UnitCategoryType categoryType)
	{
		return null;
	}

	[Address(RVA="0x1689BBC", Offset="0x1689BBC", VA="0x1689BBC")]
	public Gamedata.ClubSupportRequest? GetClubSupportRequest(Gamedata.ClubSupportRequestType requestType)
	{
		return null;
	}

	[Address(RVA="0x1689D38", Offset="0x1689D38", VA="0x1689D38")]
	public uint GetClubSupportRequestFulfillCooldownS()
	{
		return new uint();
	}

	[Address(RVA="0x1689B40", Offset="0x1689B40", VA="0x1689B40")]
	public Gamedata.ClubWar? GetClubWarDefinition(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1689F40", Offset="0x1689F40", VA="0x1689F40")]
	public Gamedata.Color? GetColorId(ulong id)
	{
		return null;
	}

	[Address(RVA="0x1681E58", Offset="0x1681E58", VA="0x1681E58")]
	public Constants? GetConstants()
	{
		return null;
	}

	[Address(RVA="0x16857C0", Offset="0x16857C0", VA="0x16857C0")]
	public ContextualMessageGroup? GetContextualMessageGroup(ulong groupId)
	{
		return null;
	}

	[Address(RVA="0x1689DCC", Offset="0x1689DCC", VA="0x1689DCC")]
	public Gamedata.DailyReward? GetDailyReward(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1683AE4", Offset="0x1683AE4", VA="0x1683AE4")]
	public Gamedata.InventoryItem? GetEmote(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1683ADC", Offset="0x1683ADC", VA="0x1683ADC")]
	public IEnumerable<Gamedata.InventoryItem?> GetEmotes()
	{
		return null;
	}

	[Address(RVA="0x16822F8", Offset="0x16822F8", VA="0x16822F8")]
	public EnergyConstants? GetEnergyConstants(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1684EE8", Offset="0x1684EE8", VA="0x1684EE8")]
	public EnergyConstants? GetEnergyConstantsFromEnergyId(ulong energyItemId)
	{
		return null;
	}

	[Address(RVA="0x168414C", Offset="0x168414C", VA="0x168414C")]
	public Gamedata.GameMode GetGameMode(DCampaignAddress campaignAddress)
	{
		return new Gamedata.GameMode();
	}

	[Address(RVA="0x1684C68", Offset="0x1684C68", VA="0x1684C68")]
	public GearSlotTable? GetGearSlotTable(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1684DDC", Offset="0x1684DDC", VA="0x1684DDC")]
	public UnityEngine.Color GetGearTierColor(int gearTier)
	{
		return new UnityEngine.Color();
	}

	[Address(RVA="0x1682374", Offset="0x1682374", VA="0x1682374")]
	public EnergyConstants? GetGrandCampaignEnergyConstants()
	{
		return null;
	}

	[Address(RVA="0x1684B5C", Offset="0x1684B5C", VA="0x1684B5C")]
	public uint GetHardCampaignRefreshCost(int numRefreshesAlreadyPurchased)
	{
		return new uint();
	}

	[Address(RVA="0x1683514", Offset="0x1683514", VA="0x1683514")]
	public Gamedata.InventoryItem? GetInventoryItem(ulong contentId, bool logError = true)
	{
		return null;
	}

	[Address(RVA="0x16838CC", Offset="0x16838CC", VA="0x16838CC")]
	public int GetInventoryItemSortOrder(ulong itemId)
	{
		return new int();
	}

	[Address(RVA="0x16858D8", Offset="0x16858D8", VA="0x16858D8")]
	public KothRank? GetKothReward(ulong score)
	{
		return null;
	}

	[Address(RVA="0x1683ACC", Offset="0x1683ACC", VA="0x1683ACC")]
	public IEnumerable<Gamedata.InventoryItem?> GetLimitedPins()
	{
		return null;
	}

	[Address(RVA="0x168513C", Offset="0x168513C", VA="0x168513C")]
	public LockableFeatureEntry? GetLockableFeatureEntry(LockableFeature feature)
	{
		return null;
	}

	[Address(RVA="0x1685134", Offset="0x1685134", VA="0x1685134")]
	public List<LockableFeatureEntry?> GetLockableFeatures()
	{
		return null;
	}

	[Address(RVA="0x1689688", Offset="0x1689688", VA="0x1689688")]
	public string GetLockableFeatureShortDescriptionKey(LockableFeature feature)
	{
		return null;
	}

	[Address(RVA="0x168A21C", Offset="0x168A21C", VA="0x168A21C")]
	public string GetNewsletterUrl(GameLanguage language)
	{
		return null;
	}

	[Address(RVA="0x1684238", Offset="0x1684238", VA="0x1684238")]
	public DCampaignAddress GetNextNode(DCampaignAddress nodeAddress)
	{
		return new DCampaignAddress();
	}

	[Address(RVA="0x16826C8", Offset="0x16826C8", VA="0x16826C8")]
	public int GetObtainableSpellCount()
	{
		return new int();
	}

	[Address(RVA="0x1683198", Offset="0x1683198", VA="0x1683198")]
	public IEnumerable<Gamedata.Spell?> GetObtainableSpellDefinitions()
	{
		return null;
	}

	[Address(RVA="0x16831A0", Offset="0x16831A0", VA="0x16831A0")]
	public IEnumerable<Gamedata.Spell?> GetObtainableSpellDefinitionsRandomly()
	{
		return null;
	}

	[Address(RVA="0x1682668", Offset="0x1682668", VA="0x1682668")]
	public int GetObtainableUnitCount()
	{
		return new int();
	}

	[Address(RVA="0x16825EC", Offset="0x16825EC", VA="0x16825EC")]
	public IEnumerable<Gamedata.Unit?> GetObtainableUnitDefinitions()
	{
		return null;
	}

	[Address(RVA="0x16825F4", Offset="0x16825F4", VA="0x16825F4")]
	public IEnumerable<Gamedata.Unit?> GetObtainableUnitDefinitionsRandomly()
	{
		return null;
	}

	[Address(RVA="0x1689FDC", Offset="0x1689FDC", VA="0x1689FDC")]
	public OfferWallSpecial? GetOfferWallSpecial()
	{
		return null;
	}

	[Address(RVA="0x1684998", Offset="0x1684998", VA="0x1684998")]
	public ulong GetOtherDifficultyCampaignId(ulong campaignId)
	{
		return new ulong();
	}

	[Address(RVA="0x168512C", Offset="0x168512C", VA="0x168512C")]
	public IEnumerable<PassportSeason?> GetPassportSeasons()
	{
		return null;
	}

	[Address(RVA="0x16850CC", Offset="0x16850CC", VA="0x16850CC")]
	public IEnumerable<PinPageCollection?> GetPinPageCollections()
	{
		return null;
	}

	[Address(RVA="0x16821E0", Offset="0x16821E0", VA="0x16821E0")]
	public EnergyConstants? GetPveEnergyConstants()
	{
		return null;
	}

	[Address(RVA="0x168542C", Offset="0x168542C", VA="0x168542C")]
	public PvpRank? GetPvpRankFromScore(ulong score)
	{
		return null;
	}

	[Address(RVA="0x1681E6C", Offset="0x1681E6C", VA="0x1681E6C")]
	public uint GetSavedSquadsFreeCount()
	{
		return new uint();
	}

	[Address(RVA="0x1681F00", Offset="0x1681F00", VA="0x1681F00")]
	public uint GetSavedSquadsVipCount()
	{
		return new uint();
	}

	[Address(RVA="0x1683AD4", Offset="0x1683AD4", VA="0x1683AD4")]
	public IEnumerable<Gamedata.InventoryItem?> GetSeasonalPassportPins()
	{
		return null;
	}

	[Address(RVA="0x16894FC", Offset="0x16894FC", VA="0x16894FC")]
	public string GetShipmentNameKey(ulong shipmentDefId)
	{
		return null;
	}

	[Address(RVA="0x1689440", Offset="0x1689440", VA="0x1689440")]
	public ShipmentNameMap? GetShipmentNameMap()
	{
		return null;
	}

	[Address(RVA="0x1689AC4", Offset="0x1689AC4", VA="0x1689AC4")]
	public SorcererStoneCollection? GetSorcererStoneCollection(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x168583C", Offset="0x168583C", VA="0x168583C")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106FB90", Offset="0x106FB90")]
	public IEnumerable<KothRank?> GetSortedKothRanks(bool lowestRankFirst)
	{
		return null;
	}

	[Address(RVA="0x1685390", Offset="0x1685390", VA="0x1685390")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106FB2C", Offset="0x106FB2C")]
	public IEnumerable<PvpRank?> GetSortedPvpRanks(bool lowestRankFirst)
	{
		return null;
	}

	[Address(RVA="0x1682B14", Offset="0x1682B14", VA="0x1682B14")]
	public SpellCategory? GetSpellCategory(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x168311C", Offset="0x168311C", VA="0x168311C")]
	public Gamedata.Spell? GetSpellDefinition(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1683214", Offset="0x1683214", VA="0x1683214")]
	public ulong GetSpellMaterialId(ulong spellId)
	{
		return new ulong();
	}

	[Address(RVA="0x168359C", Offset="0x168359C", VA="0x168359C")]
	public ulong GetSpellPromotionMaterialItemIdForSpell(ulong spellDefId)
	{
		return new ulong();
	}

	[Address(RVA="0x1683664", Offset="0x1683664", VA="0x1683664")]
	public ulong GetSpellPromotionMaterialItemIdForSpell(Gamedata.Spell spellDef)
	{
		return new ulong();
	}

	[Address(RVA="0x1684CE4", Offset="0x1684CE4", VA="0x1684CE4")]
	public StatProgressionTable? GetStatProgressionTable(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x168451C", Offset="0x168451C", VA="0x168451C")]
	public int GetTotalCampaignStars(ulong campaignId)
	{
		return new int();
	}

	[Address(RVA="0x1682CA4", Offset="0x1682CA4", VA="0x1682CA4")]
	public UnitCategory? GetUnitAffinity(Gamedata.Unit unitDef)
	{
		return null;
	}

	[Address(RVA="0x1682FE0", Offset="0x1682FE0", VA="0x1682FE0")]
	public UnitCategory? GetUnitAffinity(IList<ulong> categories)
	{
		return null;
	}

	[Address(RVA="0x1682CAC", Offset="0x1682CAC", VA="0x1682CAC")]
	public ulong GetUnitAffinityCategoryId(ulong unitDefId)
	{
		return new ulong();
	}

	[Address(RVA="0x1682A20", Offset="0x1682A20", VA="0x1682A20")]
	public UnitCategory? GetUnitCategory(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x168248C", Offset="0x168248C", VA="0x168248C")]
	public Gamedata.Unit? GetUnitDefinition(ulong contentId)
	{
		return null;
	}

	[Address(RVA="0x1682FE8", Offset="0x1682FE8", VA="0x1682FE8")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106FA64", Offset="0x106FA64")]
	public IEnumerable<UnitCategory?> GetUnitPrimaryCategories(Gamedata.Unit unitDef)
	{
		return null;
	}

	[Address(RVA="0x1683084", Offset="0x1683084", VA="0x1683084")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106FAC8", Offset="0x106FAC8")]
	public IEnumerable<UnitCategory?> GetUnitPrimaryCategories(IList<ulong> categories)
	{
		return null;
	}

	[Address(RVA="0x1681FA8", Offset="0x1681FA8", VA="0x1681FA8")]
	public UnitPromotionTable? GetUnitPromotionTable()
	{
		return null;
	}

	[Address(RVA="0x1682B90", Offset="0x1682B90", VA="0x1682B90")]
	public UnitCategory? GetUnitRole(Gamedata.Unit unitDef)
	{
		return null;
	}

	[Address(RVA="0x1682DD8", Offset="0x1682DD8", VA="0x1682DD8")]
	public UnitCategory? GetUnitRole(IList<ulong> categories)
	{
		return null;
	}

	[Address(RVA="0x16820C4", Offset="0x16820C4", VA="0x16820C4")]
	public UnitTrainingTable? GetUnitTrainingTable()
	{
		return null;
	}

	[Address(RVA="0x1681F94", Offset="0x1681F94", VA="0x1681F94")]
	public VipPerks? GetVipPerks()
	{
		return null;
	}

	[Address(RVA="0x1681E50", Offset="0x1681E50", VA="0x1681E50")]
	public void Initialize()
	{
	}

	[Address(RVA="0x16848C8", Offset="0x16848C8", VA="0x16848C8")]
	public bool IsGrandCampaign(ulong campaignId)
	{
		return new bool();
	}

	[Address(RVA="0x1684728", Offset="0x1684728", VA="0x1684728")]
	public bool IsHeroCampaign(ulong campaignId)
	{
		return new bool();
	}

	[Address(RVA="0x1682508", Offset="0x1682508", VA="0x1682508")]
	public bool IsUnitObtainable(ulong contentId)
	{
		return new bool();
	}

	[Address(RVA="0x16847F8", Offset="0x16847F8", VA="0x16847F8")]
	public bool IsVillainCampaign(ulong campaignId)
	{
		return new bool();
	}

	[Address(RVA="0x1685C10", Offset="0x1685C10", VA="0x1685C10")]
	public void SetGamedata(StaticGamedata? gamedata, List<ulong> variantIds)
	{
	}

	[Address(RVA="0x1681E54", Offset="0x1681E54", VA="0x1681E54")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x1683BD0", Offset="0x1683BD0", VA="0x1683BD0")]
	public bool TryGetEmote(ulong contentId, out Gamedata.InventoryItem? emote)
	{
		emote = new Nullable();
		return new bool();
	}

	[Address(RVA="0x1682A9C", Offset="0x1682A9C", VA="0x1682A9C")]
	public bool TryGetSpellDefIdFromPromotionMaterial(ulong promotionMaterialId, out ulong spellDefId)
	{
		spellDefId = 0L;
		return new bool();
	}

	[Address(RVA="0x1682728", Offset="0x1682728", VA="0x1682728")]
	public bool TryGetUnitDefIdFromPromotionMaterial(ulong promotionMaterialId, out ulong unitDefId)
	{
		unitDefId = 0L;
		return new bool();
	}

	[Address(RVA="0x16827A0", Offset="0x16827A0", VA="0x16827A0")]
	public bool TryGetUnitSkinFromItemId(ulong unitSkinItemId, out Gamedata.Unit? unitDef, out UnitSkin? unitSkin)
	{
		unitDef = new Nullable();
		unitSkin = new Nullable();
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFBC", Offset="0x104BFBC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static GamedataDomainController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Comparison<PvpRank?> <>9__77_0;

		[FieldOffset(Offset="0x10")]
		public static Comparison<PassportSeason?> <>9__77_1;

		[FieldOffset(Offset="0x18")]
		public static Comparison<KothRank?> <>9__77_2;

		[FieldOffset(Offset="0x20")]
		public static Func<Gamedata.Unit?, ulong> <>9__93_0;

		[FieldOffset(Offset="0x28")]
		public static Func<UnitCategory?, ulong> <>9__93_1;

		[FieldOffset(Offset="0x30")]
		public static Func<Gamedata.Spell?, ulong> <>9__93_2;

		[FieldOffset(Offset="0x38")]
		public static Func<SpellCategory?, ulong> <>9__93_3;

		[FieldOffset(Offset="0x40")]
		public static Func<Gamedata.InventoryItem?, ulong> <>9__93_4;

		[FieldOffset(Offset="0x48")]
		public static Func<Campaign?, ulong> <>9__93_5;

		[FieldOffset(Offset="0x50")]
		public static Func<GearSlotTable?, ulong> <>9__93_6;

		[FieldOffset(Offset="0x58")]
		public static Func<StatProgressionTable?, ulong> <>9__93_7;

		[FieldOffset(Offset="0x60")]
		public static Func<AbilityEffect?, ulong> <>9__93_8;

		[FieldOffset(Offset="0x68")]
		public static Func<EnergyConstants?, ulong> <>9__93_9;

		[FieldOffset(Offset="0x70")]
		public static Func<BattleRestriction?, ulong> <>9__93_10;

		[FieldOffset(Offset="0x78")]
		public static Func<ContextualMessageGroup?, ulong> <>9__93_11;

		[FieldOffset(Offset="0x80")]
		public static Func<PvpRank?, ulong> <>9__93_12;

		[FieldOffset(Offset="0x88")]
		public static Func<PinPageCollection?, ulong> <>9__93_13;

		[FieldOffset(Offset="0x90")]
		public static Func<PassportSeason?, ulong> <>9__93_14;

		[FieldOffset(Offset="0x98")]
		public static Func<UnitPromotionTable?, ulong> <>9__93_15;

		[FieldOffset(Offset="0xA0")]
		public static Func<UnitTrainingTable?, ulong> <>9__93_16;

		[FieldOffset(Offset="0xA8")]
		public static Func<LockableFeatures?, ulong> <>9__93_17;

		[FieldOffset(Offset="0xB0")]
		public static Func<ShipmentNameMap?, ulong> <>9__93_18;

		[FieldOffset(Offset="0xB8")]
		public static Func<KothRank?, ulong> <>9__93_19;

		[FieldOffset(Offset="0xC0")]
		public static Func<BattleAbilityCodes?, ulong> <>9__93_20;

		[FieldOffset(Offset="0xC8")]
		public static Func<CardProgressTracker?, ulong> <>9__93_21;

		[FieldOffset(Offset="0xD0")]
		public static Func<SorcererStoneCollection?, ulong> <>9__93_22;

		[FieldOffset(Offset="0xD8")]
		public static Func<Gamedata.ClubWar?, ulong> <>9__93_23;

		[FieldOffset(Offset="0xE0")]
		public static Func<Gamedata.DailyReward?, ulong> <>9__93_24;

		[FieldOffset(Offset="0xE8")]
		public static Func<BattleMessage?, ulong> <>9__93_25;

		[FieldOffset(Offset="0xF0")]
		public static Func<Aura?, ulong> <>9__93_26;

		[Address(RVA="0x14E5AC0", Offset="0x14E5AC0", VA="0x14E5AC0")]
		static <>c()
		{
		}

		[Address(RVA="0x14E5B24", Offset="0x14E5B24", VA="0x14E5B24")]
		public <>c()
		{
		}

		[Address(RVA="0x14E5D24", Offset="0x14E5D24", VA="0x14E5D24")]
		internal ulong <AddGamedata>b__93_0(Gamedata.Unit? unit)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5D90", Offset="0x14E5D90", VA="0x14E5D90")]
		internal ulong <AddGamedata>b__93_1(UnitCategory? unitCategory)
		{
			return new ulong();
		}

		[Address(RVA="0x14E615C", Offset="0x14E615C", VA="0x14E615C")]
		internal ulong <AddGamedata>b__93_10(BattleRestriction? battleRestriction)
		{
			return new ulong();
		}

		[Address(RVA="0x14E61C8", Offset="0x14E61C8", VA="0x14E61C8")]
		internal ulong <AddGamedata>b__93_11(ContextualMessageGroup? messageGroup)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6234", Offset="0x14E6234", VA="0x14E6234")]
		internal ulong <AddGamedata>b__93_12(PvpRank? pvpRank)
		{
			return new ulong();
		}

		[Address(RVA="0x14E62A0", Offset="0x14E62A0", VA="0x14E62A0")]
		internal ulong <AddGamedata>b__93_13(PinPageCollection? ppc)
		{
			return new ulong();
		}

		[Address(RVA="0x14E630C", Offset="0x14E630C", VA="0x14E630C")]
		internal ulong <AddGamedata>b__93_14(PassportSeason? ps)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6378", Offset="0x14E6378", VA="0x14E6378")]
		internal ulong <AddGamedata>b__93_15(UnitPromotionTable? upt)
		{
			return new ulong();
		}

		[Address(RVA="0x14E63E4", Offset="0x14E63E4", VA="0x14E63E4")]
		internal ulong <AddGamedata>b__93_16(UnitTrainingTable? utt)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6450", Offset="0x14E6450", VA="0x14E6450")]
		internal ulong <AddGamedata>b__93_17(LockableFeatures? lf)
		{
			return new ulong();
		}

		[Address(RVA="0x14E64BC", Offset="0x14E64BC", VA="0x14E64BC")]
		internal ulong <AddGamedata>b__93_18(ShipmentNameMap? snm)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6528", Offset="0x14E6528", VA="0x14E6528")]
		internal ulong <AddGamedata>b__93_19(KothRank? kothRank)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5DFC", Offset="0x14E5DFC", VA="0x14E5DFC")]
		internal ulong <AddGamedata>b__93_2(Gamedata.Spell? spell)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6594", Offset="0x14E6594", VA="0x14E6594")]
		internal ulong <AddGamedata>b__93_20(BattleAbilityCodes? codes)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6600", Offset="0x14E6600", VA="0x14E6600")]
		internal ulong <AddGamedata>b__93_21(CardProgressTracker? cpt)
		{
			return new ulong();
		}

		[Address(RVA="0x14E666C", Offset="0x14E666C", VA="0x14E666C")]
		internal ulong <AddGamedata>b__93_22(SorcererStoneCollection? ssc)
		{
			return new ulong();
		}

		[Address(RVA="0x14E66D8", Offset="0x14E66D8", VA="0x14E66D8")]
		internal ulong <AddGamedata>b__93_23(Gamedata.ClubWar? cw)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6744", Offset="0x14E6744", VA="0x14E6744")]
		internal ulong <AddGamedata>b__93_24(Gamedata.DailyReward? dr)
		{
			return new ulong();
		}

		[Address(RVA="0x14E67B0", Offset="0x14E67B0", VA="0x14E67B0")]
		internal ulong <AddGamedata>b__93_25(BattleMessage? dr)
		{
			return new ulong();
		}

		[Address(RVA="0x14E681C", Offset="0x14E681C", VA="0x14E681C")]
		internal ulong <AddGamedata>b__93_26(Aura? au)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5E68", Offset="0x14E5E68", VA="0x14E5E68")]
		internal ulong <AddGamedata>b__93_3(SpellCategory? spellCategory)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5ED4", Offset="0x14E5ED4", VA="0x14E5ED4")]
		internal ulong <AddGamedata>b__93_4(Gamedata.InventoryItem? item)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5F40", Offset="0x14E5F40", VA="0x14E5F40")]
		internal ulong <AddGamedata>b__93_5(Campaign? campaign)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5FAC", Offset="0x14E5FAC", VA="0x14E5FAC")]
		internal ulong <AddGamedata>b__93_6(GearSlotTable? gearSlotTable)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6018", Offset="0x14E6018", VA="0x14E6018")]
		internal ulong <AddGamedata>b__93_7(StatProgressionTable? statProgressionTable)
		{
			return new ulong();
		}

		[Address(RVA="0x14E6084", Offset="0x14E6084", VA="0x14E6084")]
		internal ulong <AddGamedata>b__93_8(AbilityEffect? effect)
		{
			return new ulong();
		}

		[Address(RVA="0x14E60F0", Offset="0x14E60F0", VA="0x14E60F0")]
		internal ulong <AddGamedata>b__93_9(EnergyConstants? energy)
		{
			return new ulong();
		}

		[Address(RVA="0x14E5B2C", Offset="0x14E5B2C", VA="0x14E5B2C")]
		internal int <SetGamedata>b__77_0(PvpRank? a, PvpRank? b)
		{
			return new int();
		}

		[Address(RVA="0x14E5BD4", Offset="0x14E5BD4", VA="0x14E5BD4")]
		internal int <SetGamedata>b__77_1(PassportSeason? a, PassportSeason? b)
		{
			return new int();
		}

		[Address(RVA="0x14E5C7C", Offset="0x14E5C7C", VA="0x14E5C7C")]
		internal int <SetGamedata>b__77_2(KothRank? a, KothRank? b)
		{
			return new int();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BFAC", Offset="0x104BFAC")]
	private sealed class <GetSortedKothRanks>d__75 : IEnumerable<KothRank?>, IEnumerable, IEnumerator<KothRank?>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private KothRank? <>2__current;

		[FieldOffset(Offset="0x30")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x34")]
		private bool lowestRankFirst;

		[FieldOffset(Offset="0x35")]
		public bool <>3__lowestRankFirst;

		[FieldOffset(Offset="0x38")]
		public GamedataDomainController <>4__this;

		[FieldOffset(Offset="0x40")]
		private int <i>5__2;

		private KothRank? System.Collections.Generic.IEnumerator<Gamedata.KothRank?>.Current
		{
			[Address(RVA="0x14E6AB4", Offset="0x14E6AB4", VA="0x14E6AB4", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x14E6B30", Offset="0x14E6B30", VA="0x14E6B30", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14E6888", Offset="0x14E6888", VA="0x14E6888")]
		[DebuggerHidden]
		public <GetSortedKothRanks>d__75(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x14E68C4", Offset="0x14E68C4", VA="0x14E68C4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x14E6B9C", Offset="0x14E6B9C", VA="0x14E6B9C", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<KothRank?> System.Collections.Generic.IEnumerable<Gamedata.KothRank?>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E6C5C", Offset="0x14E6C5C", VA="0x14E6C5C", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E6AC8", Offset="0x14E6AC8", VA="0x14E6AC8", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x14E68C0", Offset="0x14E68C0", VA="0x14E68C0", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF9C", Offset="0x104BF9C")]
	private sealed class <GetSortedPvpRanks>d__71 : IEnumerable<PvpRank?>, IEnumerable, IEnumerator<PvpRank?>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private PvpRank? <>2__current;

		[FieldOffset(Offset="0x30")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x34")]
		private bool lowestRankFirst;

		[FieldOffset(Offset="0x35")]
		public bool <>3__lowestRankFirst;

		[FieldOffset(Offset="0x38")]
		public GamedataDomainController <>4__this;

		[FieldOffset(Offset="0x40")]
		private int <i>5__2;

		private PvpRank? System.Collections.Generic.IEnumerator<Gamedata.PvpRank?>.Current
		{
			[Address(RVA="0x14E6E8C", Offset="0x14E6E8C", VA="0x14E6E8C", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x14E6F08", Offset="0x14E6F08", VA="0x14E6F08", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14E6C60", Offset="0x14E6C60", VA="0x14E6C60")]
		[DebuggerHidden]
		public <GetSortedPvpRanks>d__71(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x14E6C9C", Offset="0x14E6C9C", VA="0x14E6C9C", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x14E6F74", Offset="0x14E6F74", VA="0x14E6F74", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<PvpRank?> System.Collections.Generic.IEnumerable<Gamedata.PvpRank?>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E7034", Offset="0x14E7034", VA="0x14E7034", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E6EA0", Offset="0x14E6EA0", VA="0x14E6EA0", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x14E6C98", Offset="0x14E6C98", VA="0x14E6C98", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF7C", Offset="0x104BF7C")]
	private sealed class <GetUnitPrimaryCategories>d__30 : IEnumerable<UnitCategory?>, IEnumerable, IEnumerator<UnitCategory?>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private UnitCategory? <>2__current;

		[FieldOffset(Offset="0x30")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x38")]
		public GamedataDomainController <>4__this;

		[FieldOffset(Offset="0x40")]
		private Gamedata.Unit unitDef;

		[FieldOffset(Offset="0x50")]
		public Gamedata.Unit <>3__unitDef;

		[FieldOffset(Offset="0x60")]
		private int <i>5__2;

		private UnitCategory? System.Collections.Generic.IEnumerator<Gamedata.UnitCategory?>.Current
		{
			[Address(RVA="0x14E71CC", Offset="0x14E71CC", VA="0x14E71CC", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x14E7248", Offset="0x14E7248", VA="0x14E7248", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14E7038", Offset="0x14E7038", VA="0x14E7038")]
		[DebuggerHidden]
		public <GetUnitPrimaryCategories>d__30(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x14E7074", Offset="0x14E7074", VA="0x14E7074", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x14E72B4", Offset="0x14E72B4", VA="0x14E72B4", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<UnitCategory?> System.Collections.Generic.IEnumerable<Gamedata.UnitCategory?>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E7374", Offset="0x14E7374", VA="0x14E7374", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E71E0", Offset="0x14E71E0", VA="0x14E71E0", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x14E7070", Offset="0x14E7070", VA="0x14E7070", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BF8C", Offset="0x104BF8C")]
	private sealed class <GetUnitPrimaryCategories>d__31 : IEnumerable<UnitCategory?>, IEnumerable, IEnumerator<UnitCategory?>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private UnitCategory? <>2__current;

		[FieldOffset(Offset="0x30")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x38")]
		public GamedataDomainController <>4__this;

		[FieldOffset(Offset="0x40")]
		private IList<ulong> categories;

		[FieldOffset(Offset="0x48")]
		public IList<ulong> <>3__categories;

		[FieldOffset(Offset="0x50")]
		private int <i>5__2;

		private UnitCategory? System.Collections.Generic.IEnumerator<Gamedata.UnitCategory?>.Current
		{
			[Address(RVA="0x14E75FC", Offset="0x14E75FC", VA="0x14E75FC", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x14E7678", Offset="0x14E7678", VA="0x14E7678", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x14E7378", Offset="0x14E7378", VA="0x14E7378")]
		[DebuggerHidden]
		public <GetUnitPrimaryCategories>d__31(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x14E73B4", Offset="0x14E73B4", VA="0x14E73B4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x14E76E4", Offset="0x14E76E4", VA="0x14E76E4", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<UnitCategory?> System.Collections.Generic.IEnumerable<Gamedata.UnitCategory?>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E77A4", Offset="0x14E77A4", VA="0x14E77A4", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x14E7610", Offset="0x14E7610", VA="0x14E7610", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x14E73B0", Offset="0x14E73B0", VA="0x14E73B0", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	private class GamedataIdMapping<T> : ILoggable<LogCategory>
	{
		[FieldOffset(Offset="0x0")]
		private Dictionary<ulong, T> _contentDataIdMap;

		[FieldOffset(Offset="0x0")]
		private string _typeName;

		public int Count
		{
			[Address(RVA="0x16CA95C", Offset="0x16CA95C", VA="0x16CA95C")]
			get
			{
				return new int();
			}
		}

		public LogCategory LogCategory
		{
			[Address(RVA="0x16CA954", Offset="0x16CA954", VA="0x16CA954", Slot="4")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x16CA97C", Offset="0x16CA97C", VA="0x16CA97C")]
		public GamedataIdMapping()
		{
		}

		[Address(RVA="0x16CADC0", Offset="0x16CADC0", VA="0x16CADC0")]
		[Attribute(Name="IteratorStateMachineAttribute", RVA="0x108B2D8", Offset="0x108B2D8")]
		public IEnumerable<T> All()
		{
			return null;
		}

		[Address(RVA="0x16CAE3C", Offset="0x16CAE3C", VA="0x16CAE3C")]
		public bool Exists(ulong contentId)
		{
			return new bool();
		}

		[Address(RVA="0x16CAC8C", Offset="0x16CAC8C", VA="0x16CAC8C")]
		public T GetData(ulong contentId, bool logError = true)
		{
			return null;
		}

		[Address(RVA="0x16CAA84", Offset="0x16CAA84", VA="0x16CAA84")]
		public void Initialize(bool clearExisting, Func<int, T> dataAccessor, int dataArrayLength, Func<T, ulong> dataIdAccessor)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051578", Offset="0x1051578")]
		private sealed class <All>d__7 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset="0x0")]
			private int <>1__state;

			[FieldOffset(Offset="0x0")]
			private T <>2__current;

			[FieldOffset(Offset="0x0")]
			private int <>l__initialThreadId;

			[FieldOffset(Offset="0x0")]
			public GamedataDomainController.GamedataIdMapping<T> <>4__this;

			[FieldOffset(Offset="0x0")]
			private Dictionary<ulong, T>.Enumerator <>7__wrap1;

			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Address(RVA="0x16C1E40", Offset="0x16C1E40", VA="0x16C1E40", Slot="6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System.Collections.IEnumerator.Current
			{
				[Address(RVA="0x16C1EBC", Offset="0x16C1EBC", VA="0x16C1EBC", Slot="9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Address(RVA="0x16C1AE0", Offset="0x16C1AE0", VA="0x16C1AE0")]
			[DebuggerHidden]
			public <All>d__7(int u003cu003e1__state)
			{
			}

			[Address(RVA="0x16C1D10", Offset="0x16C1D10", VA="0x16C1D10")]
			private void <>m__Finally1()
			{
			}

			[Address(RVA="0x16C1B50", Offset="0x16C1B50", VA="0x16C1B50", Slot="8")]
			private bool MoveNext()
			{
				return new bool();
			}

			[Address(RVA="0x16C1F14", Offset="0x16C1F14", VA="0x16C1F14", Slot="4")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x16C1FC0", Offset="0x16C1FC0", VA="0x16C1FC0", Slot="5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Address(RVA="0x16C1E54", Offset="0x16C1E54", VA="0x16C1E54", Slot="10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Address(RVA="0x16C1B24", Offset="0x16C1B24", VA="0x16C1B24", Slot="7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}
		}
	}
}