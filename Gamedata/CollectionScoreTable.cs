using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct CollectionScoreTable : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int AbilityLevelLength
		{
			[Address(RVA="0xF442F0", Offset="0xF442F0", VA="0xF442F0")]
			get
			{
				return new int();
			}
		}

		public int AchievementsLength
		{
			[Address(RVA="0xF44370", Offset="0xF44370", VA="0xF44370")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4424C", Offset="0xF4424C", VA="0xF4424C", Slot="5")]
			get
			{
				return null;
			}
		}

		public int CompletionStarsLength
		{
			[Address(RVA="0xF44380", Offset="0xF44380", VA="0xF44380")]
			get
			{
				return new int();
			}
		}

		public int GearTierLength
		{
			[Address(RVA="0xF44310", Offset="0xF44310", VA="0xF44310")]
			get
			{
				return new int();
			}
		}

		public int PinsLength
		{
			[Address(RVA="0xF44360", Offset="0xF44360", VA="0xF44360")]
			get
			{
				return new int();
			}
		}

		public int PlayerLevelLength
		{
			[Address(RVA="0xF44280", Offset="0xF44280", VA="0xF44280")]
			get
			{
				return new int();
			}
		}

		public int SpellLevelLength
		{
			[Address(RVA="0xF44340", Offset="0xF44340", VA="0xF44340")]
			get
			{
				return new int();
			}
		}

		public int SpellUnlockLength
		{
			[Address(RVA="0xF44330", Offset="0xF44330", VA="0xF44330")]
			get
			{
				return new int();
			}
		}

		public int UnitLevelLength
		{
			[Address(RVA="0xF442D0", Offset="0xF442D0", VA="0xF442D0")]
			get
			{
				return new int();
			}
		}

		public int UnitRarityLength
		{
			[Address(RVA="0xF442A0", Offset="0xF442A0", VA="0xF442A0")]
			get
			{
				return new int();
			}
		}

		public int UnitRarityModifierLength
		{
			[Address(RVA="0xF442C0", Offset="0xF442C0", VA="0xF442C0")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF44260", Offset="0xF44260", VA="0xF44260")]
		public CollectionScoreTable __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new CollectionScoreTable();
		}

		[Address(RVA="0xF44254", Offset="0xF44254", VA="0xF44254", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0xF442E8", Offset="0xF442E8", VA="0xF442E8")]
		public uint AbilityLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF44368", Offset="0xF44368", VA="0xF44368")]
		public AchievementCollectionScore? Achievements(int j)
		{
			return null;
		}

		[Address(RVA="0x23289F8", Offset="0x23289F8", VA="0x23289F8")]
		public static void AddAbilityLevel(FlatBufferBuilder builder, VectorOffset abilityLevelOffset)
		{
		}

		[Address(RVA="0x23288CC", Offset="0x23288CC", VA="0x23288CC")]
		public static void AddAchievements(FlatBufferBuilder builder, VectorOffset achievementsOffset)
		{
		}

		[Address(RVA="0x2328890", Offset="0x2328890", VA="0x2328890")]
		public static void AddCompletionStars(FlatBufferBuilder builder, VectorOffset completionStarsOffset)
		{
		}

		[Address(RVA="0x23289BC", Offset="0x23289BC", VA="0x23289BC")]
		public static void AddGearTier(FlatBufferBuilder builder, VectorOffset gearTierOffset)
		{
		}

		[Address(RVA="0x2328908", Offset="0x2328908", VA="0x2328908")]
		public static void AddPins(FlatBufferBuilder builder, VectorOffset pinsOffset)
		{
		}

		[Address(RVA="0x2328AE8", Offset="0x2328AE8", VA="0x2328AE8")]
		public static void AddPlayerLevel(FlatBufferBuilder builder, VectorOffset playerLevelOffset)
		{
		}

		[Address(RVA="0x2328944", Offset="0x2328944", VA="0x2328944")]
		public static void AddSpellLevel(FlatBufferBuilder builder, VectorOffset spellLevelOffset)
		{
		}

		[Address(RVA="0x2328980", Offset="0x2328980", VA="0x2328980")]
		public static void AddSpellUnlock(FlatBufferBuilder builder, VectorOffset spellUnlockOffset)
		{
		}

		[Address(RVA="0x2328A34", Offset="0x2328A34", VA="0x2328A34")]
		public static void AddUnitLevel(FlatBufferBuilder builder, VectorOffset unitLevelOffset)
		{
		}

		[Address(RVA="0x2328AAC", Offset="0x2328AAC", VA="0x2328AAC")]
		public static void AddUnitRarity(FlatBufferBuilder builder, VectorOffset unitRarityOffset)
		{
		}

		[Address(RVA="0x2328A70", Offset="0x2328A70", VA="0x2328A70")]
		public static void AddUnitRarityModifier(FlatBufferBuilder builder, VectorOffset unitRarityModifierOffset)
		{
		}

		[Address(RVA="0xF44378", Offset="0xF44378", VA="0xF44378")]
		public uint CompletionStars(int j)
		{
			return new uint();
		}

		[Address(RVA="0x23290A4", Offset="0x23290A4", VA="0x23290A4")]
		public static VectorOffset CreateAbilityLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23296A8", Offset="0x23296A8", VA="0x23296A8")]
		public static VectorOffset CreateAchievementsVector(FlatBufferBuilder builder, Offset<AchievementCollectionScore>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232877C", Offset="0x232877C", VA="0x232877C")]
		public static Offset<CollectionScoreTable> CreateCollectionScoreTable(FlatBufferBuilder builder, VectorOffset player_levelOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.CollectionScoreTable> Gamedata.CollectionScoreTable::CreateCollectionScoreTable(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.CollectionScoreTable> CreateCollectionScoreTable(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23297DC", Offset="0x23297DC", VA="0x23297DC")]
		public static VectorOffset CreateCompletionStarsVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23291D8", Offset="0x23291D8", VA="0x23291D8")]
		public static VectorOffset CreateGearTierVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2329574", Offset="0x2329574", VA="0x2329574")]
		public static VectorOffset CreatePinsVector(FlatBufferBuilder builder, Offset<PinCollectionScore>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2328BD4", Offset="0x2328BD4", VA="0x2328BD4")]
		public static VectorOffset CreatePlayerLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2329440", Offset="0x2329440", VA="0x2329440")]
		public static VectorOffset CreateSpellLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x232930C", Offset="0x232930C", VA="0x232930C")]
		public static VectorOffset CreateSpellUnlockVector(FlatBufferBuilder builder, Offset<SpellUnlockCollectionScore>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2328F70", Offset="0x2328F70", VA="0x2328F70")]
		public static VectorOffset CreateUnitLevelVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2328E3C", Offset="0x2328E3C", VA="0x2328E3C")]
		public static VectorOffset CreateUnitRarityModifierVector(FlatBufferBuilder builder, Offset<UnitCollectionScoreRarityModifier>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2328D08", Offset="0x2328D08", VA="0x2328D08")]
		public static VectorOffset CreateUnitRarityVector(FlatBufferBuilder builder, uint[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2328B24", Offset="0x2328B24", VA="0x2328B24")]
		public static Offset<CollectionScoreTable> EndCollectionScoreTable(FlatBufferBuilder builder)
		{
			return new Offset<CollectionScoreTable>();
		}

		[Address(RVA="0xF44308", Offset="0xF44308", VA="0xF44308")]
		public uint GearTier(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF442F8", Offset="0xF442F8", VA="0xF442F8")]
		public ArraySegment<byte>? GetAbilityLevelBytes()
		{
			return null;
		}

		[Address(RVA="0xF44388", Offset="0xF44388", VA="0xF44388")]
		public ArraySegment<byte>? GetCompletionStarsBytes()
		{
			return null;
		}

		[Address(RVA="0xF44318", Offset="0xF44318", VA="0xF44318")]
		public ArraySegment<byte>? GetGearTierBytes()
		{
			return null;
		}

		[Address(RVA="0xF44288", Offset="0xF44288", VA="0xF44288")]
		public ArraySegment<byte>? GetPlayerLevelBytes()
		{
			return null;
		}

		[Address(RVA="0x2327C48", Offset="0x2327C48", VA="0x2327C48")]
		public static CollectionScoreTable GetRootAsCollectionScoreTable(FlatBuffers.ByteBuffer _bb)
		{
			return new CollectionScoreTable();
		}

		[Address(RVA="0x2327C54", Offset="0x2327C54", VA="0x2327C54")]
		public static CollectionScoreTable GetRootAsCollectionScoreTable(FlatBuffers.ByteBuffer _bb, CollectionScoreTable obj)
		{
			return new CollectionScoreTable();
		}

		[Address(RVA="0xF44348", Offset="0xF44348", VA="0xF44348")]
		public ArraySegment<byte>? GetSpellLevelBytes()
		{
			return null;
		}

		[Address(RVA="0xF442D8", Offset="0xF442D8", VA="0xF442D8")]
		public ArraySegment<byte>? GetUnitLevelBytes()
		{
			return null;
		}

		[Address(RVA="0xF442A8", Offset="0xF442A8", VA="0xF442A8")]
		public ArraySegment<byte>? GetUnitRarityBytes()
		{
			return null;
		}

		[Address(RVA="0xF44358", Offset="0xF44358", VA="0xF44358")]
		public PinCollectionScore? Pins(int j)
		{
			return null;
		}

		[Address(RVA="0xF44278", Offset="0xF44278", VA="0xF44278")]
		public uint PlayerLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF44338", Offset="0xF44338", VA="0xF44338")]
		public uint SpellLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF44328", Offset="0xF44328", VA="0xF44328")]
		public SpellUnlockCollectionScore? SpellUnlock(int j)
		{
			return null;
		}

		[Address(RVA="0x232919C", Offset="0x232919C", VA="0x232919C")]
		public static void StartAbilityLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23297A0", Offset="0x23297A0", VA="0x23297A0")]
		public static void StartAchievementsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2328BA4", Offset="0x2328BA4", VA="0x2328BA4")]
		public static void StartCollectionScoreTable(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x23298D4", Offset="0x23298D4", VA="0x23298D4")]
		public static void StartCompletionStarsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x23292D0", Offset="0x23292D0", VA="0x23292D0")]
		public static void StartGearTierVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x232966C", Offset="0x232966C", VA="0x232966C")]
		public static void StartPinsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2328CCC", Offset="0x2328CCC", VA="0x2328CCC")]
		public static void StartPlayerLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2329538", Offset="0x2329538", VA="0x2329538")]
		public static void StartSpellLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2329404", Offset="0x2329404", VA="0x2329404")]
		public static void StartSpellUnlockVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2329068", Offset="0x2329068", VA="0x2329068")]
		public static void StartUnitLevelVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2328F34", Offset="0x2328F34", VA="0x2328F34")]
		public static void StartUnitRarityModifierVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2328E00", Offset="0x2328E00", VA="0x2328E00")]
		public static void StartUnitRarityVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF442C8", Offset="0xF442C8", VA="0xF442C8")]
		public uint UnitLevel(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF44298", Offset="0xF44298", VA="0xF44298")]
		public uint UnitRarity(int j)
		{
			return new uint();
		}

		[Address(RVA="0xF442B8", Offset="0xF442B8", VA="0xF442B8")]
		public UnitCollectionScoreRarityModifier? UnitRarityModifier(int j)
		{
			return null;
		}
	}
}