using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Unit : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AbilitiesLength
		{
			[Address(RVA="0xF0B0EC", Offset="0xF0B0EC", VA="0xF0B0EC")]
			get
			{
				return new int();
			}
		}

		public int AbilityEffectsLength
		{
			[Address(RVA="0xF0B124", Offset="0xF0B124", VA="0xF0B124")]
			get
			{
				return new int();
			}
		}

		public float AttackRange
		{
			[Address(RVA="0xF0B10C", Offset="0xF0B10C", VA="0xF0B10C")]
			get
			{
				return new float();
			}
		}

		public UnitStats? BaseStats
		{
			[Address(RVA="0xF0B06C", Offset="0xF0B06C", VA="0xF0B06C")]
			get
			{
				return null;
			}
		}

		public int BattleAltPrefabsLength
		{
			[Address(RVA="0xF0B1BC", Offset="0xF0B1BC", VA="0xF0B1BC")]
			get
			{
				return new int();
			}
		}

		public string BattlePrefab
		{
			[Address(RVA="0xF0B0AC", Offset="0xF0B0AC", VA="0xF0B0AC")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B020", Offset="0xF0B020", VA="0xF0B020", Slot="5")]
			get
			{
				return null;
			}
		}

		public int CategoriesLength
		{
			[Address(RVA="0xF0B14C", Offset="0xF0B14C", VA="0xF0B14C")]
			get
			{
				return new int();
			}
		}

		public ulong GearSlotTable
		{
			[Address(RVA="0xF0B07C", Offset="0xF0B07C", VA="0xF0B07C")]
			get
			{
				return new ulong();
			}
		}

		public int GearTierMeritItemsLength
		{
			[Address(RVA="0xF0B16C", Offset="0xF0B16C", VA="0xF0B16C")]
			get
			{
				return new int();
			}
		}

		public int GearTiersLength
		{
			[Address(RVA="0xF0B08C", Offset="0xF0B08C", VA="0xF0B08C")]
			get
			{
				return new int();
			}
		}

		public string Icon
		{
			[Address(RVA="0xF0B0C4", Offset="0xF0B0C4", VA="0xF0B0C4")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0B04C", Offset="0xF0B04C", VA="0xF0B04C")]
			get
			{
				return new ulong();
			}
		}

		public bool IsHidden
		{
			[Address(RVA="0xF0B1A4", Offset="0xF0B1A4", VA="0xF0B1A4")]
			get
			{
				return new bool();
			}
		}

		public bool MysteryDetails
		{
			[Address(RVA="0xF0B18C", Offset="0xF0B18C", VA="0xF0B18C")]
			get
			{
				return new bool();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0B054", Offset="0xF0B054", VA="0xF0B054")]
			get
			{
				return null;
			}
		}

		public bool Obtainable
		{
			[Address(RVA="0xF0B0DC", Offset="0xF0B0DC", VA="0xF0B0DC")]
			get
			{
				return new bool();
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF0B094", Offset="0xF0B094", VA="0xF0B094")]
			get
			{
				return null;
			}
		}

		public ulong PromotionMaterial
		{
			[Address(RVA="0xF0B0F4", Offset="0xF0B0F4", VA="0xF0B0F4")]
			get
			{
				return new ulong();
			}
		}

		public float Radius
		{
			[Address(RVA="0xF0B114", Offset="0xF0B114", VA="0xF0B114")]
			get
			{
				return new float();
			}
		}

		public int RarityProgressionLength
		{
			[Address(RVA="0xF0B1CC", Offset="0xF0B1CC", VA="0xF0B1CC")]
			get
			{
				return new int();
			}
		}

		public int SkinsLength
		{
			[Address(RVA="0xF0B19C", Offset="0xF0B19C", VA="0xF0B19C")]
			get
			{
				return new int();
			}
		}

		public ulong StatProgressionTable
		{
			[Address(RVA="0xF0B074", Offset="0xF0B074", VA="0xF0B074")]
			get
			{
				return new ulong();
			}
		}

		public string SubtitleKey
		{
			[Address(RVA="0xF0B174", Offset="0xF0B174", VA="0xF0B174")]
			get
			{
				return null;
			}
		}

		public Gamedata.UnitType UnitType
		{
			[Address(RVA="0xF0B13C", Offset="0xF0B13C", VA="0xF0B13C")]
			get
			{
				return new Gamedata.UnitType();
			}
		}

		public int UnlockRarity
		{
			[Address(RVA="0xF0B0FC", Offset="0xF0B0FC", VA="0xF0B0FC")]
			get
			{
				return new int();
			}
		}

		public bool UseAbilityIds
		{
			[Address(RVA="0xF0B1AC", Offset="0xF0B1AC", VA="0xF0B1AC")]
			get
			{
				return new bool();
			}
		}

		public float WalkSpeed
		{
			[Address(RVA="0xF0B104", Offset="0xF0B104", VA="0xF0B104")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0B034", Offset="0xF0B034", VA="0xF0B034")]
		public Unit __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Unit();
		}

		[Address(RVA="0xF0B028", Offset="0xF0B028", VA="0xF0B028", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0xF0B0E4", Offset="0xF0B0E4", VA="0xF0B0E4")]
		public UnitAbility? Abilities(int j)
		{
			return null;
		}

		[Address(RVA="0xF0B11C", Offset="0xF0B11C", VA="0xF0B11C")]
		public ulong AbilityEffects(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x16752D8", Offset="0x16752D8", VA="0x16752D8")]
		public static void AddAbilities(FlatBufferBuilder builder, VectorOffset abilitiesOffset)
		{
		}

		[Address(RVA="0x1675194", Offset="0x1675194", VA="0x1675194")]
		public static void AddAbilityEffects(FlatBufferBuilder builder, VectorOffset abilityEffectsOffset)
		{
		}

		[Address(RVA="0x1675214", Offset="0x1675214", VA="0x1675214")]
		public static void AddAttackRange(FlatBufferBuilder builder, float attackRange)
		{
		}

		[Address(RVA="0x1675404", Offset="0x1675404", VA="0x1675404")]
		public static void AddBaseStats(FlatBufferBuilder builder, Offset<UnitStats> baseStatsOffset)
		{
		}

		[Address(RVA="0x1675068", Offset="0x1675068", VA="0x1675068")]
		public static void AddBattleAltPrefabs(FlatBufferBuilder builder, VectorOffset battleAltPrefabsOffset)
		{
		}

		[Address(RVA="0x1675350", Offset="0x1675350", VA="0x1675350")]
		public static void AddBattlePrefab(FlatBufferBuilder builder, StringOffset battlePrefabOffset)
		{
		}

		[Address(RVA="0x1675158", Offset="0x1675158", VA="0x1675158")]
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
		}

		[Address(RVA="0x1674F78", Offset="0x1674F78", VA="0x1674F78")]
		public static void AddGearSlotTable(FlatBufferBuilder builder, ulong gearSlotTable)
		{
		}

		[Address(RVA="0x167511C", Offset="0x167511C", VA="0x167511C")]
		public static void AddGearTierMeritItems(FlatBufferBuilder builder, VectorOffset gearTierMeritItemsOffset)
		{
		}

		[Address(RVA="0x16753C8", Offset="0x16753C8", VA="0x16753C8")]
		public static void AddGearTiers(FlatBufferBuilder builder, VectorOffset gearTiersOffset)
		{
		}

		[Address(RVA="0x1675314", Offset="0x1675314", VA="0x1675314")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x1674FF0", Offset="0x1674FF0", VA="0x1674FF0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x16754B8", Offset="0x16754B8", VA="0x16754B8")]
		public static void AddIsHidden(FlatBufferBuilder builder, bool isHidden)
		{
		}

		[Address(RVA="0x16754F4", Offset="0x16754F4", VA="0x16754F4")]
		public static void AddMysteryDetails(FlatBufferBuilder builder, bool mysteryDetails)
		{
		}

		[Address(RVA="0x1675440", Offset="0x1675440", VA="0x1675440")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x167556C", Offset="0x167556C", VA="0x167556C")]
		public static void AddObtainable(FlatBufferBuilder builder, bool obtainable)
		{
		}

		[Address(RVA="0x167538C", Offset="0x167538C", VA="0x167538C")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x1674F3C", Offset="0x1674F3C", VA="0x1674F3C")]
		public static void AddPromotionMaterial(FlatBufferBuilder builder, ulong promotionMaterial)
		{
		}

		[Address(RVA="0x16751D0", Offset="0x16751D0", VA="0x16751D0")]
		public static void AddRadius(FlatBufferBuilder builder, float radius)
		{
		}

		[Address(RVA="0x167502C", Offset="0x167502C", VA="0x167502C")]
		public static void AddRarityProgression(FlatBufferBuilder builder, VectorOffset rarityProgressionOffset)
		{
		}

		[Address(RVA="0x16750A4", Offset="0x16750A4", VA="0x16750A4")]
		public static void AddSkins(FlatBufferBuilder builder, VectorOffset skinsOffset)
		{
		}

		[Address(RVA="0x1674FB4", Offset="0x1674FB4", VA="0x1674FB4")]
		public static void AddStatProgressionTable(FlatBufferBuilder builder, ulong statProgressionTable)
		{
		}

		[Address(RVA="0x16750E0", Offset="0x16750E0", VA="0x16750E0")]
		public static void AddSubtitleKey(FlatBufferBuilder builder, StringOffset subtitleKeyOffset)
		{
		}

		[Address(RVA="0x1675530", Offset="0x1675530", VA="0x1675530")]
		public static void AddUnitType(FlatBufferBuilder builder, Gamedata.UnitType unitType)
		{
		}

		[Address(RVA="0x167529C", Offset="0x167529C", VA="0x167529C")]
		public static void AddUnlockRarity(FlatBufferBuilder builder, int unlockRarity)
		{
		}

		[Address(RVA="0x167547C", Offset="0x167547C", VA="0x167547C")]
		public static void AddUseAbilityIds(FlatBufferBuilder builder, bool useAbilityIds)
		{
		}

		[Address(RVA="0x1675258", Offset="0x1675258", VA="0x1675258")]
		public static void AddWalkSpeed(FlatBufferBuilder builder, float walkSpeed)
		{
		}

		[Address(RVA="0xF0B1B4", Offset="0xF0B1B4", VA="0xF0B1B4")]
		public BattleAltPrefab? BattleAltPrefabs(int j)
		{
			return null;
		}

		[Address(RVA="0xF0B144", Offset="0xF0B144", VA="0xF0B144")]
		public ulong Categories(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x167578C", Offset="0x167578C", VA="0x167578C")]
		public static VectorOffset CreateAbilitiesVector(FlatBufferBuilder builder, Offset<UnitAbility>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x16758C0", Offset="0x16758C0", VA="0x16758C0")]
		public static VectorOffset CreateAbilityEffectsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1675D90", Offset="0x1675D90", VA="0x1675D90")]
		public static VectorOffset CreateBattleAltPrefabsVector(FlatBufferBuilder builder, Offset<BattleAltPrefab>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x16759F4", Offset="0x16759F4", VA="0x16759F4")]
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1675B28", Offset="0x1675B28", VA="0x1675B28")]
		public static VectorOffset CreateGearTierMeritItemsVector(FlatBufferBuilder builder, Offset<UnitGearTierMeritItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1675658", Offset="0x1675658", VA="0x1675658")]
		public static VectorOffset CreateGearTiersVector(FlatBufferBuilder builder, Offset<UnitGearTier>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1675EC4", Offset="0x1675EC4", VA="0x1675EC4")]
		public static VectorOffset CreateRarityProgressionVector(FlatBufferBuilder builder, Offset<UnitStats>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1675C5C", Offset="0x1675C5C", VA="0x1675C5C")]
		public static VectorOffset CreateSkinsVector(FlatBufferBuilder builder, Offset<UnitSkin>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1674CC8", Offset="0x1674CC8", VA="0x1674CC8")]
		public static Offset<Unit> CreateUnit(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Unit> Gamedata.Unit::CreateUnit(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.UnitStats>,System.UInt64,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.UInt64,System.Int32,System.Single,System.Single,System.Single,FlatBuffers.VectorOffset,Gamedata.UnitType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.Boolean,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Unit> CreateUnit(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.UnitStats>,System.UInt64,System.UInt64,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.UInt64,System.Int32,System.Single,System.Single,System.Single,FlatBuffers.VectorOffset,Gamedata.UnitType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.Boolean,System.Boolean,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x16755A8", Offset="0x16755A8", VA="0x16755A8")]
		public static Offset<Unit> EndUnit(FlatBufferBuilder builder)
		{
			return new Offset<Unit>();
		}

		[Address(RVA="0x1675FF8", Offset="0x1675FF8", VA="0x1675FF8")]
		public static void FinishUnitBuffer(FlatBufferBuilder builder, Offset<Unit> offset)
		{
		}

		[Address(RVA="0xF0B164", Offset="0xF0B164", VA="0xF0B164")]
		public UnitGearTierMeritItem? GearTierMeritItems(int j)
		{
			return null;
		}

		[Address(RVA="0xF0B084", Offset="0xF0B084", VA="0xF0B084")]
		public UnitGearTier? GearTiers(int j)
		{
			return null;
		}

		[Address(RVA="0xF0B12C", Offset="0xF0B12C", VA="0xF0B12C")]
		public ArraySegment<byte>? GetAbilityEffectsBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B0B4", Offset="0xF0B0B4", VA="0xF0B0B4")]
		public ArraySegment<byte>? GetBattlePrefabBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B154", Offset="0xF0B154", VA="0xF0B154")]
		public ArraySegment<byte>? GetCategoriesBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B0CC", Offset="0xF0B0CC", VA="0xF0B0CC")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B05C", Offset="0xF0B05C", VA="0xF0B05C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B09C", Offset="0xF0B09C", VA="0xF0B09C")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x1673BC8", Offset="0x1673BC8", VA="0x1673BC8")]
		public static Unit GetRootAsUnit(FlatBuffers.ByteBuffer _bb)
		{
			return new Unit();
		}

		[Address(RVA="0x1673BD4", Offset="0x1673BD4", VA="0x1673BD4")]
		public static Unit GetRootAsUnit(FlatBuffers.ByteBuffer _bb, Unit obj)
		{
			return new Unit();
		}

		[Address(RVA="0xF0B17C", Offset="0xF0B17C", VA="0xF0B17C")]
		public ArraySegment<byte>? GetSubtitleKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B1C4", Offset="0xF0B1C4", VA="0xF0B1C4")]
		public UnitStats? RarityProgression(int j)
		{
			return null;
		}

		[Address(RVA="0xF0B194", Offset="0xF0B194", VA="0xF0B194")]
		public UnitSkin? Skins(int j)
		{
			return null;
		}

		[Address(RVA="0x1675884", Offset="0x1675884", VA="0x1675884")]
		public static void StartAbilitiesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x16759B8", Offset="0x16759B8", VA="0x16759B8")]
		public static void StartAbilityEffectsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675E88", Offset="0x1675E88", VA="0x1675E88")]
		public static void StartBattleAltPrefabsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675AEC", Offset="0x1675AEC", VA="0x1675AEC")]
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675C20", Offset="0x1675C20", VA="0x1675C20")]
		public static void StartGearTierMeritItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675750", Offset="0x1675750", VA="0x1675750")]
		public static void StartGearTiersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675FBC", Offset="0x1675FBC", VA="0x1675FBC")]
		public static void StartRarityProgressionVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675D54", Offset="0x1675D54", VA="0x1675D54")]
		public static void StartSkinsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1675628", Offset="0x1675628", VA="0x1675628")]
		public static void StartUnit(FlatBufferBuilder builder)
		{
		}
	}
}