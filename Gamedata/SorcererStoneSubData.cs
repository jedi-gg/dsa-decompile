using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SorcererStoneSubData : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public float Accuracy
		{
			[Address(RVA="0xF590C4", Offset="0xF590C4", VA="0xF590C4")]
			get
			{
				return new float();
			}
		}

		public float AttackSpeed
		{
			[Address(RVA="0xF5907C", Offset="0xF5907C", VA="0xF5907C")]
			get
			{
				return new float();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59020", Offset="0xF59020", VA="0xF59020", Slot="5")]
			get
			{
				return null;
			}
		}

		public float CritChance
		{
			[Address(RVA="0xF5906C", Offset="0xF5906C", VA="0xF5906C")]
			get
			{
				return new float();
			}
		}

		public float CritPower
		{
			[Address(RVA="0xF59074", Offset="0xF59074", VA="0xF59074")]
			get
			{
				return new float();
			}
		}

		public float Defense
		{
			[Address(RVA="0xF59054", Offset="0xF59054", VA="0xF59054")]
			get
			{
				return new float();
			}
		}

		public float Evasion
		{
			[Address(RVA="0xF590CC", Offset="0xF590CC", VA="0xF590CC")]
			get
			{
				return new float();
			}
		}

		public float Health
		{
			[Address(RVA="0xF5905C", Offset="0xF5905C", VA="0xF5905C")]
			get
			{
				return new float();
			}
		}

		public float Offense
		{
			[Address(RVA="0xF5904C", Offset="0xF5904C", VA="0xF5904C")]
			get
			{
				return new float();
			}
		}

		public float Potency
		{
			[Address(RVA="0xF590B4", Offset="0xF590B4", VA="0xF590B4")]
			get
			{
				return new float();
			}
		}

		public float Recovery
		{
			[Address(RVA="0xF59064", Offset="0xF59064", VA="0xF59064")]
			get
			{
				return new float();
			}
		}

		public uint RequiredUnitGearTier
		{
			[Address(RVA="0xF590A4", Offset="0xF590A4", VA="0xF590A4")]
			get
			{
				return new uint();
			}
		}

		public uint RequiredUnitLevel
		{
			[Address(RVA="0xF59094", Offset="0xF59094", VA="0xF59094")]
			get
			{
				return new uint();
			}
		}

		public uint RequiredUnitRarity
		{
			[Address(RVA="0xF5909C", Offset="0xF5909C", VA="0xF5909C")]
			get
			{
				return new uint();
			}
		}

		public float Speed
		{
			[Address(RVA="0xF590AC", Offset="0xF590AC", VA="0xF590AC")]
			get
			{
				return new float();
			}
		}

		public float Tenacity
		{
			[Address(RVA="0xF590BC", Offset="0xF590BC", VA="0xF590BC")]
			get
			{
				return new float();
			}
		}

		public ItemCount? UnequipCost
		{
			[Address(RVA="0xF5908C", Offset="0xF5908C", VA="0xF5908C")]
			get
			{
				return null;
			}
		}

		public uint UnitPowerValue
		{
			[Address(RVA="0xF59084", Offset="0xF59084", VA="0xF59084")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF59034", Offset="0xF59034", VA="0xF59034")]
		public SorcererStoneSubData __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SorcererStoneSubData();
		}

		[Address(RVA="0xF59028", Offset="0xF59028", VA="0xF59028", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EC378", Offset="0x24EC378", VA="0x24EC378")]
		public static void AddAccuracy(FlatBufferBuilder builder, float accuracy)
		{
		}

		[Address(RVA="0x24EC5B4", Offset="0x24EC5B4", VA="0x24EC5B4")]
		public static void AddAttackSpeed(FlatBufferBuilder builder, float attackSpeed)
		{
		}

		[Address(RVA="0x24EC63C", Offset="0x24EC63C", VA="0x24EC63C")]
		public static void AddCritChance(FlatBufferBuilder builder, float critChance)
		{
		}

		[Address(RVA="0x24EC5F8", Offset="0x24EC5F8", VA="0x24EC5F8")]
		public static void AddCritPower(FlatBufferBuilder builder, float critPower)
		{
		}

		[Address(RVA="0x24EC708", Offset="0x24EC708", VA="0x24EC708")]
		public static void AddDefense(FlatBufferBuilder builder, float defense)
		{
		}

		[Address(RVA="0x24EC334", Offset="0x24EC334", VA="0x24EC334")]
		public static void AddEvasion(FlatBufferBuilder builder, float evasion)
		{
		}

		[Address(RVA="0x24EC6C4", Offset="0x24EC6C4", VA="0x24EC6C4")]
		public static void AddHealth(FlatBufferBuilder builder, float health)
		{
		}

		[Address(RVA="0x24EC74C", Offset="0x24EC74C", VA="0x24EC74C")]
		public static void AddOffense(FlatBufferBuilder builder, float offense)
		{
		}

		[Address(RVA="0x24EC400", Offset="0x24EC400", VA="0x24EC400")]
		public static void AddPotency(FlatBufferBuilder builder, float potency)
		{
		}

		[Address(RVA="0x24EC680", Offset="0x24EC680", VA="0x24EC680")]
		public static void AddRecovery(FlatBufferBuilder builder, float recovery)
		{
		}

		[Address(RVA="0x24EC488", Offset="0x24EC488", VA="0x24EC488")]
		public static void AddRequiredUnitGearTier(FlatBufferBuilder builder, uint requiredUnitGearTier)
		{
		}

		[Address(RVA="0x24EC500", Offset="0x24EC500", VA="0x24EC500")]
		public static void AddRequiredUnitLevel(FlatBufferBuilder builder, uint requiredUnitLevel)
		{
		}

		[Address(RVA="0x24EC4C4", Offset="0x24EC4C4", VA="0x24EC4C4")]
		public static void AddRequiredUnitRarity(FlatBufferBuilder builder, uint requiredUnitRarity)
		{
		}

		[Address(RVA="0x24EC444", Offset="0x24EC444", VA="0x24EC444")]
		public static void AddSpeed(FlatBufferBuilder builder, float speed)
		{
		}

		[Address(RVA="0x24EC3BC", Offset="0x24EC3BC", VA="0x24EC3BC")]
		public static void AddTenacity(FlatBufferBuilder builder, float tenacity)
		{
		}

		[Address(RVA="0x24EC53C", Offset="0x24EC53C", VA="0x24EC53C")]
		public static void AddUnequipCost(FlatBufferBuilder builder, Offset<ItemCount> unequipCostOffset)
		{
		}

		[Address(RVA="0x24EC578", Offset="0x24EC578", VA="0x24EC578")]
		public static void AddUnitPowerValue(FlatBufferBuilder builder, uint unitPowerValue)
		{
		}

		[Address(RVA="0x24EC1B4", Offset="0x24EC1B4", VA="0x24EC1B4")]
		public static Offset<SorcererStoneSubData> CreateSorcererStoneSubData(FlatBufferBuilder builder, float offense = 0f, float defense = 0f, float health = 0f, float recovery = 0f, float crit_chance = 0f, float crit_power = 0f, float attack_speed = 0f, uint unit_power_value = 0, Offset<ItemCount> unequip_costOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SorcererStoneSubData> Gamedata.SorcererStoneSubData::CreateSorcererStoneSubData(FlatBuffers.FlatBufferBuilder,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.UInt32,FlatBuffers.Offset`1<Gamedata.ItemCount>,System.UInt32,System.UInt32,System.UInt32,System.Single,System.Single,System.Single,System.Single,System.Single)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SorcererStoneSubData> CreateSorcererStoneSubData(FlatBuffers.FlatBufferBuilder,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.Single,System.UInt32,FlatBuffers.Offset<Gamedata.ItemCount>,System.UInt32,System.UInt32,System.UInt32,System.Single,System.Single,System.Single,System.Single,System.Single)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EC790", Offset="0x24EC790", VA="0x24EC790")]
		public static Offset<SorcererStoneSubData> EndSorcererStoneSubData(FlatBufferBuilder builder)
		{
			return new Offset<SorcererStoneSubData>();
		}

		[Address(RVA="0x24EB960", Offset="0x24EB960", VA="0x24EB960")]
		public static SorcererStoneSubData GetRootAsSorcererStoneSubData(FlatBuffers.ByteBuffer _bb)
		{
			return new SorcererStoneSubData();
		}

		[Address(RVA="0x24EB96C", Offset="0x24EB96C", VA="0x24EB96C")]
		public static SorcererStoneSubData GetRootAsSorcererStoneSubData(FlatBuffers.ByteBuffer _bb, SorcererStoneSubData obj)
		{
			return new SorcererStoneSubData();
		}

		[Address(RVA="0x24EC810", Offset="0x24EC810", VA="0x24EC810")]
		public static void StartSorcererStoneSubData(FlatBufferBuilder builder)
		{
		}
	}
}