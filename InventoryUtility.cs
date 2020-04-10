using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class InventoryUtility
{
	[Attribute(Name="InjectAttribute", RVA="0x105B494", Offset="0x105B494")]
	[FieldOffset(Offset="0x10")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B4A4", Offset="0x105B4A4")]
	[FieldOffset(Offset="0x18")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105B4B4", Offset="0x105B4B4")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x0")]
	private static Dictionary<ulong, long> s_ingredientCountTrackerForCraftItemQuery;

	[FieldOffset(Offset="0x8")]
	private static HashSet<ulong> s_useableGearIds;

	[Address(RVA="0x137BC10", Offset="0x137BC10", VA="0x137BC10")]
	static InventoryUtility()
	{
	}

	[Address(RVA="0x137BC08", Offset="0x137BC08", VA="0x137BC08")]
	public InventoryUtility()
	{
	}

	[Address(RVA="0x1375614", Offset="0x1375614", VA="0x1375614")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10703D8", Offset="0x10703D8")]
	private void <UpdateUseableGearIds>g__AddAllRecipeItems|24_0(ulong gearId)
	{
	}

	[Address(RVA="0x1371FF4", Offset="0x1371FF4", VA="0x1371FF4")]
	public bool AnyHeroCanBeTrained()
	{
		return new bool();
	}

	[Address(RVA="0x1376038", Offset="0x1376038", VA="0x1376038")]
	public bool AnyHeroCanEquipGear()
	{
		return new bool();
	}

	[Address(RVA="0x13793BC", Offset="0x13793BC", VA="0x13793BC")]
	public bool AnySpellCanBeUnlocked()
	{
		return new bool();
	}

	[Address(RVA="0x1378AE8", Offset="0x1378AE8", VA="0x1378AE8")]
	public bool AnyUnitAbilityCanBeUpgraded()
	{
		return new bool();
	}

	[Address(RVA="0x1372F3C", Offset="0x1372F3C", VA="0x1372F3C")]
	public bool AnyUnitCanBePromoted()
	{
		return new bool();
	}

	[Address(RVA="0x1371AC0", Offset="0x1371AC0", VA="0x1371AC0")]
	public bool AnyUnitCanBeTrained()
	{
		return new bool();
	}

	[Address(RVA="0x1372B98", Offset="0x1372B98", VA="0x1372B98")]
	public bool AnyUnitCanBeUnlocked()
	{
		return new bool();
	}

	[Address(RVA="0x137722C", Offset="0x137722C", VA="0x137722C")]
	public bool AnyUnitCanCraftAnyUnownedGearAtGearTier(ulong gearTier)
	{
		return new bool();
	}

	[Address(RVA="0x1375D3C", Offset="0x1375D3C", VA="0x1375D3C")]
	public bool AnyUnitCanEquipGear()
	{
		return new bool();
	}

	[Address(RVA="0x137B4F4", Offset="0x137B4F4", VA="0x137B4F4")]
	public bool AnyUnitCanEquipSorcererStone()
	{
		return new bool();
	}

	[Address(RVA="0x1371288", Offset="0x1371288", VA="0x1371288")]
	public bool AnyUnitCanUseGear(ulong gearId)
	{
		return new bool();
	}

	[Address(RVA="0x13723B8", Offset="0x13723B8", VA="0x13723B8")]
	public bool AnyVillainCanBeTrained()
	{
		return new bool();
	}

	[Address(RVA="0x13763F8", Offset="0x13763F8", VA="0x13763F8")]
	public bool AnyVillainCanEquipGear()
	{
		return new bool();
	}

	[Address(RVA="0x1376E8C", Offset="0x1376E8C", VA="0x1376E8C")]
	public bool CanCraftGear(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1376EDC", Offset="0x1376EDC", VA="0x1376EDC")]
	public bool CanCraftGear(Serverproto.Unit unit)
	{
		return new bool();
	}

	[Address(RVA="0x13770AC", Offset="0x13770AC", VA="0x13770AC")]
	public bool CanCraftGear(ulong unitId, int index)
	{
		return new bool();
	}

	[Address(RVA="0x1376FA0", Offset="0x1376FA0", VA="0x1376FA0")]
	public bool CanCraftGear(Serverproto.Unit unit, int index)
	{
		return new bool();
	}

	[Address(RVA="0x1373E34", Offset="0x1373E34", VA="0x1373E34")]
	public bool CanCraftItem(ulong itemId, long amountToCraft = 1L)
	{
		return new bool();
	}

	[Address(RVA="0x1373EB4", Offset="0x1373EB4", VA="0x1373EB4")]
	public bool CanCraftItem(Gamedata.InventoryItem? item, long amountToCraft = 1L)
	{
		return new bool();
	}

	[Address(RVA="0x1373F60", Offset="0x1373F60", VA="0x1373F60")]
	public bool CanCraftItem(Gamedata.InventoryItem item, long amountToCraft = 1L, bool checkIngredientRecipes = true)
	{
		return new bool();
	}

	[Address(RVA="0x1373AE4", Offset="0x1373AE4", VA="0x1373AE4")]
	private bool CanCraftPromotionRecipe(ulong requiredPromotionMaterialCount, uint promotionCost, ulong promotionMaterialId)
	{
		return new bool();
	}

	[Address(RVA="0x1374050", Offset="0x1374050", VA="0x1374050")]
	private bool CanCraftRecipe(InventoryItemRecipe? recipe, ref Dictionary<ulong, long> ingredientsToBeConsumed, long amountToCraft = 1L, bool checkIngredientRecipes = true)
	{
		return new bool();
	}

	[Address(RVA="0x1379D98", Offset="0x1379D98", VA="0x1379D98")]
	private bool CanCraftRecipe(SpellLevelRecipe? recipe, ref Dictionary<ulong, long> ingredientsToBeConsumed)
	{
		return new bool();
	}

	[Address(RVA="0x13767B8", Offset="0x13767B8", VA="0x13767B8")]
	public bool CanEquipGear(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1375C78", Offset="0x1375C78", VA="0x1375C78")]
	public bool CanEquipGear(Serverproto.Unit unit)
	{
		return new bool();
	}

	[Address(RVA="0x1376948", Offset="0x1376948", VA="0x1376948")]
	public bool CanEquipGear(ulong unitId, int index)
	{
		return new bool();
	}

	[Address(RVA="0x1376808", Offset="0x1376808", VA="0x1376808")]
	public bool CanEquipGear(Serverproto.Unit unit, int index)
	{
		return new bool();
	}

	[Address(RVA="0x1372AE0", Offset="0x1372AE0", VA="0x1372AE0")]
	public bool CanPromoteUnit(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1373238", Offset="0x1373238", VA="0x1373238")]
	public bool CanPromoteUnit(Serverproto.Unit unit)
	{
		return new bool();
	}

	[Address(RVA="0x1373688", Offset="0x1373688", VA="0x1373688")]
	public bool CanPromoteUnit(Gamedata.Unit? unitDef)
	{
		return new bool();
	}

	[Address(RVA="0x1379298", Offset="0x1379298", VA="0x1379298")]
	public bool CanUnlockSpell(ulong spellId)
	{
		return new bool();
	}

	[Address(RVA="0x1372A78", Offset="0x1372A78", VA="0x1372A78")]
	public bool CanUnlockUnit(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1378DE4", Offset="0x1378DE4", VA="0x1378DE4")]
	public bool CanUpgradeAbility(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1378E4C", Offset="0x1378E4C", VA="0x1378E4C")]
	public bool CanUpgradeAbility(ulong unitId, int abilityId)
	{
		return new bool();
	}

	[Address(RVA="0x13789B8", Offset="0x13789B8", VA="0x13789B8")]
	public bool CanUpgradeAbility(Serverproto.Unit unit)
	{
		return new bool();
	}

	[Address(RVA="0x1378EBC", Offset="0x1378EBC", VA="0x1378EBC")]
	public bool CanUpgradeAbility(Serverproto.Unit unit, int abilityId)
	{
		return new bool();
	}

	[Address(RVA="0x1379300", Offset="0x1379300", VA="0x1379300")]
	public bool CanUpgradeSpell(ulong spellId)
	{
		return new bool();
	}

	[Address(RVA="0x1379A98", Offset="0x1379A98", VA="0x1379A98")]
	public bool CanUpgradeSpell(Serverproto.Spell spell)
	{
		return new bool();
	}

	[Address(RVA="0x1379A60", Offset="0x1379A60", VA="0x1379A60")]
	public bool CanUpgradeSpell(Gamedata.Spell? spellDef)
	{
		return new bool();
	}

	[Address(RVA="0x1379C0C", Offset="0x1379C0C", VA="0x1379C0C")]
	public bool CanUpgradeSpell(Gamedata.Spell? spellDef, int levelIndexToCraft)
	{
		return new bool();
	}

	[Address(RVA="0x1373388", Offset="0x1373388", VA="0x1373388")]
	public int GetCountOfPromotableUnits()
	{
		return new int();
	}

	[Address(RVA="0x137277C", Offset="0x137277C", VA="0x137277C")]
	public int GetCountOfTrainableUnits()
	{
		return new int();
	}

	[Address(RVA="0x13759CC", Offset="0x13759CC", VA="0x13759CC")]
	public int GetCountOfUnitsThatCanEquipGear()
	{
		return new int();
	}

	[Address(RVA="0x137870C", Offset="0x137870C", VA="0x137870C")]
	public int GetCountOfUnitsThatCanUpgradeAbilities()
	{
		return new int();
	}

	[Address(RVA="0x1374994", Offset="0x1374994", VA="0x1374994")]
	public int GetCountOfUnitsThatCanUseGear(ulong gearId, ulong ignoredUnitId = 0L)
	{
		return new int();
	}

	[Address(RVA="0x1379760", Offset="0x1379760", VA="0x1379760")]
	public int GetCountOfUpgradeableSpells()
	{
		return new int();
	}

	[Address(RVA="0x137B1B8", Offset="0x137B1B8", VA="0x137B1B8")]
	public IReadOnlyList<Gamedata.InventoryItem?> GetEmoteDeck()
	{
		return null;
	}

	[Address(RVA="0x13743CC", Offset="0x13743CC", VA="0x13743CC")]
	public void GetFirstMissingRecipeIngredientTrace(Gamedata.InventoryItem item, ref List<ulong> missingRecipeIngredientTrace)
	{
	}

	[Address(RVA="0x13744AC", Offset="0x13744AC", VA="0x13744AC")]
	private bool GetFirstMissingRecipeIngredientTrace(InventoryItemRecipe? recipe, ref Dictionary<ulong, long> ingredientsToBeConsumed, ref List<ulong> missingRecipeIngredientTrace, long amountToCraft = 1L)
	{
		return new bool();
	}

	[Address(RVA="0x13777D8", Offset="0x13777D8", VA="0x13777D8")]
	public int GetGearSlotIndexThatIsUnownedAndCanCraft(ulong unitId)
	{
		return new int();
	}

	[Address(RVA="0x13769A0", Offset="0x13769A0", VA="0x13769A0")]
	public UnitGearSlotState GetGearSlotState(Serverproto.Unit unit, UnitGearTier? unitGearTier, int slotIndex)
	{
		return new UnitGearSlotState();
	}

	[Address(RVA="0x1374EC4", Offset="0x1374EC4", VA="0x1374EC4")]
	public uint GetItemCountInRecipe(ulong mainItemId, ulong queryRecipeItem)
	{
		return new uint();
	}

	[Address(RVA="0x1375910", Offset="0x1375910", VA="0x1375910")]
	private uint GetItemCountInRecipe(InventoryItemRecipeIngredient? ingredient, ulong queryRecipeItem)
	{
		return new uint();
	}

	[Address(RVA="0x137A878", Offset="0x137A878", VA="0x137A878")]
	public uint GetMaxCount(ulong itemId)
	{
		return new uint();
	}

	[Address(RVA="0x1370DE0", Offset="0x1370DE0", VA="0x1370DE0")]
	public uint GetNextGoalCount(ulong itemId)
	{
		return new uint();
	}

	[Address(RVA="0x1370EE4", Offset="0x1370EE4", VA="0x1370EE4")]
	public long GetOwnedCount(ulong itemId)
	{
		return new long();
	}

	[Address(RVA="0x137AE28", Offset="0x137AE28", VA="0x137AE28")]
	public IReadOnlyList<Gamedata.InventoryItem?> GetOwnedEmotes()
	{
		return null;
	}

	[Address(RVA="0x137A97C", Offset="0x137A97C", VA="0x137A97C")]
	public IReadOnlyList<Gamedata.InventoryItem?> GetOwnedPins()
	{
		return null;
	}

	[Address(RVA="0x137382C", Offset="0x137382C", VA="0x137382C")]
	public uint GetPromotionCurrencyCost(ulong unitId)
	{
		return new uint();
	}

	[Address(RVA="0x1373770", Offset="0x1373770", VA="0x1373770")]
	public uint GetPromotionMaterialRequiredCount(ulong unitId)
	{
		return new uint();
	}

	[Address(RVA="0x1373C10", Offset="0x1373C10", VA="0x1373C10")]
	public uint GetPromotionMaterialRequiredCount(Gamedata.Unit unitDef)
	{
		return new uint();
	}

	[Address(RVA="0x1373CBC", Offset="0x1373CBC", VA="0x1373CBC")]
	public uint GetPromotionMaterialRequiredCount(int currentRarity, int targetRarity)
	{
		return new uint();
	}

	[Address(RVA="0x136CCDC", Offset="0x136CCDC", VA="0x136CCDC")]
	public uint GetPromotionMaterialRequiredForMaxCount(ulong unitId)
	{
		return new uint();
	}

	[Address(RVA="0x137A5E4", Offset="0x137A5E4", VA="0x137A5E4")]
	private uint GetSkinRequiredCount(UnitSkin? unitSkin)
	{
		return new uint();
	}

	[Address(RVA="0x137A0E4", Offset="0x137A0E4", VA="0x137A0E4")]
	public uint GetSpellPromotionMaterialRequiredCount(ulong spellId)
	{
		return new uint();
	}

	[Address(RVA="0x137A1A0", Offset="0x137A1A0", VA="0x137A1A0")]
	public uint GetSpellPromotionMaterialRequiredCount(Gamedata.Spell spellDef)
	{
		return new uint();
	}

	[Address(RVA="0x137A244", Offset="0x137A244", VA="0x137A244")]
	public uint GetSpellPromotionMaterialRequiredCount(Gamedata.Spell spellDef, int currentLevel, int targetLevel)
	{
		return new uint();
	}

	[Address(RVA="0x137A4D0", Offset="0x137A4D0", VA="0x137A4D0")]
	public uint GetSpellPromotionMaterialRequiredForMaxCount(ulong spellId)
	{
		return new uint();
	}

	[Address(RVA="0x1377248", Offset="0x1377248", VA="0x1377248")]
	public ulong GetUnitIdThatCanCraftAnyUnownedGearAtGearTier(ulong gearTier)
	{
		return new ulong();
	}

	[Address(RVA="0x137489C", Offset="0x137489C", VA="0x137489C")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x1070374", Offset="0x1070374")]
	public IEnumerable<Serverproto.Unit> GetUnitsThatCanUseGear(ulong gearId, ulong ignoredUnitId = 0L)
	{
		return null;
	}

	[Address(RVA="0x1372A28", Offset="0x1372A28", VA="0x1372A28")]
	public InventoryUtility.UnitTrainingStatus GetUnitTrainingStatus(ulong unitId)
	{
		return new InventoryUtility.UnitTrainingStatus();
	}

	[Address(RVA="0x1371DC0", Offset="0x1371DC0", VA="0x1371DC0")]
	public InventoryUtility.UnitTrainingStatus GetUnitTrainingStatus(Serverproto.Unit unit)
	{
		return new InventoryUtility.UnitTrainingStatus();
	}

	[Address(RVA="0x137B80C", Offset="0x137B80C", VA="0x137B80C")]
	public bool HasAnySorcererStone()
	{
		return new bool();
	}

	[Address(RVA="0x137A6CC", Offset="0x137A6CC", VA="0x137A6CC")]
	public bool HasMaxItemCount(ulong itemId)
	{
		return new bool();
	}

	[Address(RVA="0x1376BD4", Offset="0x1376BD4", VA="0x1376BD4")]
	public bool HeroCanEquipGear(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x137AD34", Offset="0x137AD34", VA="0x137AD34")]
	public bool InventoryItemIsValidAvatar(Gamedata.InventoryItem? item)
	{
		return new bool();
	}

	[Address(RVA="0x13713F0", Offset="0x13713F0", VA="0x13713F0")]
	public bool ItemIdIsShardShopCurrency(ulong itemId)
	{
		return new bool();
	}

	[Address(RVA="0x1377104", Offset="0x1377104", VA="0x1377104")]
	public bool MeetsGearRequirement(Serverproto.Unit unit, UnitGearTier? unitGearTier, int slotIndex)
	{
		return new bool();
	}

	[Address(RVA="0x1377A24", Offset="0x1377A24", VA="0x1377A24")]
	public void SetGearEquipStatChangeLabel(UiLabel label, Serverproto.Unit oldUnit, Serverproto.Unit newUnit)
	{
	}

	[Address(RVA="0x137BBA4", Offset="0x137BBA4", VA="0x137BBA4")]
	public bool UnitCanEquipSorcererStone(ulong unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1375074", Offset="0x1375074", VA="0x1375074")]
	public void UpdateUseableGearIds()
	{
	}

	[Address(RVA="0x1376D30", Offset="0x1376D30", VA="0x1376D30")]
	public bool VillainCanEquipGear(ulong unitId)
	{
		return new bool();
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C62C", Offset="0x104C62C")]
	private sealed class <GetUnitsThatCanUseGear>d__22 : IEnumerable<Serverproto.Unit>, IEnumerable, IEnumerator<Serverproto.Unit>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private Serverproto.Unit <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		public InventoryUtility <>4__this;

		[FieldOffset(Offset="0x30")]
		private ulong gearId;

		[FieldOffset(Offset="0x38")]
		public ulong <>3__gearId;

		[FieldOffset(Offset="0x40")]
		private ulong ignoredUnitId;

		[FieldOffset(Offset="0x48")]
		public ulong <>3__ignoredUnitId;

		[FieldOffset(Offset="0x50")]
		private IEnumerator<Serverproto.Unit> <>7__wrap1;

		private Serverproto.Unit System.Collections.Generic.IEnumerator<Serverproto.Unit>.Current
		{
			[Address(RVA="0x137C340", Offset="0x137C340", VA="0x137C340", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x137C3B0", Offset="0x137C3B0", VA="0x137C3B0", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x137495C", Offset="0x137495C", VA="0x137495C")]
		[DebuggerHidden]
		public <GetUnitsThatCanUseGear>d__22(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x137BCE4", Offset="0x137BCE4", VA="0x137BCE4")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x137BDA4", Offset="0x137BDA4", VA="0x137BDA4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x137C3B8", Offset="0x137C3B8", VA="0x137C3B8", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<Serverproto.Unit> System.Collections.Generic.IEnumerable<Serverproto.Unit>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x137C480", Offset="0x137C480", VA="0x137C480", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x137C348", Offset="0x137C348", VA="0x137C348", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x137BCB8", Offset="0x137BCB8", VA="0x137BCB8", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	public enum UnitTrainingStatus
	{
		[FieldOffset(Offset="0x0")]
		InvalidUnit,
		[FieldOffset(Offset="0x0")]
		CanTrain,
		[FieldOffset(Offset="0x0")]
		UnitMaxLevel,
		[FieldOffset(Offset="0x0")]
		CappedAtPlayerLevel,
		[FieldOffset(Offset="0x0")]
		InsufficientTrainingMats,
		[FieldOffset(Offset="0x0")]
		InsufficientCurrency
	}
}