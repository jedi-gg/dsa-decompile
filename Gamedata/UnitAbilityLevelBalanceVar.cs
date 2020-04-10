using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbilityLevelBalanceVar : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public bool Accuracy
		{
			[Address(RVA="0xF0B59C", Offset="0xF0B59C", VA="0xF0B59C")]
			get
			{
				return new bool();
			}
		}

		public bool AttackSpeed
		{
			[Address(RVA="0xF0B57C", Offset="0xF0B57C", VA="0xF0B57C")]
			get
			{
				return new bool();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B500", Offset="0xF0B500", VA="0xF0B500", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool CritChance
		{
			[Address(RVA="0xF0B56C", Offset="0xF0B56C", VA="0xF0B56C")]
			get
			{
				return new bool();
			}
		}

		public bool CritPower
		{
			[Address(RVA="0xF0B574", Offset="0xF0B574", VA="0xF0B574")]
			get
			{
				return new bool();
			}
		}

		public bool Defense
		{
			[Address(RVA="0xF0B554", Offset="0xF0B554", VA="0xF0B554")]
			get
			{
				return new bool();
			}
		}

		public bool Evasion
		{
			[Address(RVA="0xF0B5A4", Offset="0xF0B5A4", VA="0xF0B5A4")]
			get
			{
				return new bool();
			}
		}

		public bool Health
		{
			[Address(RVA="0xF0B55C", Offset="0xF0B55C", VA="0xF0B55C")]
			get
			{
				return new bool();
			}
		}

		public bool Offense
		{
			[Address(RVA="0xF0B54C", Offset="0xF0B54C", VA="0xF0B54C")]
			get
			{
				return new bool();
			}
		}

		public bool Potency
		{
			[Address(RVA="0xF0B58C", Offset="0xF0B58C", VA="0xF0B58C")]
			get
			{
				return new bool();
			}
		}

		public bool Recovery
		{
			[Address(RVA="0xF0B564", Offset="0xF0B564", VA="0xF0B564")]
			get
			{
				return new bool();
			}
		}

		public bool Speed
		{
			[Address(RVA="0xF0B584", Offset="0xF0B584", VA="0xF0B584")]
			get
			{
				return new bool();
			}
		}

		public bool Tenacity
		{
			[Address(RVA="0xF0B594", Offset="0xF0B594", VA="0xF0B594")]
			get
			{
				return new bool();
			}
		}

		public int ValuesLength
		{
			[Address(RVA="0xF0B534", Offset="0xF0B534", VA="0xF0B534")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0B514", Offset="0xF0B514", VA="0xF0B514")]
		public UnitAbilityLevelBalanceVar __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityLevelBalanceVar();
		}

		[Address(RVA="0xF0B508", Offset="0xF0B508", VA="0xF0B508", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1678A2C", Offset="0x1678A2C", VA="0x1678A2C")]
		public static void AddAccuracy(FlatBufferBuilder builder, bool accuracy)
		{
		}

		[Address(RVA="0x1678B1C", Offset="0x1678B1C", VA="0x1678B1C")]
		public static void AddAttackSpeed(FlatBufferBuilder builder, bool attackSpeed)
		{
		}

		[Address(RVA="0x1678B94", Offset="0x1678B94", VA="0x1678B94")]
		public static void AddCritChance(FlatBufferBuilder builder, bool critChance)
		{
		}

		[Address(RVA="0x1678B58", Offset="0x1678B58", VA="0x1678B58")]
		public static void AddCritPower(FlatBufferBuilder builder, bool critPower)
		{
		}

		[Address(RVA="0x1678C48", Offset="0x1678C48", VA="0x1678C48")]
		public static void AddDefense(FlatBufferBuilder builder, bool defense)
		{
		}

		[Address(RVA="0x16789F0", Offset="0x16789F0", VA="0x16789F0")]
		public static void AddEvasion(FlatBufferBuilder builder, bool evasion)
		{
		}

		[Address(RVA="0x1678C0C", Offset="0x1678C0C", VA="0x1678C0C")]
		public static void AddHealth(FlatBufferBuilder builder, bool health)
		{
		}

		[Address(RVA="0x1678C84", Offset="0x1678C84", VA="0x1678C84")]
		public static void AddOffense(FlatBufferBuilder builder, bool offense)
		{
		}

		[Address(RVA="0x1678AA4", Offset="0x1678AA4", VA="0x1678AA4")]
		public static void AddPotency(FlatBufferBuilder builder, bool potency)
		{
		}

		[Address(RVA="0x1678BD0", Offset="0x1678BD0", VA="0x1678BD0")]
		public static void AddRecovery(FlatBufferBuilder builder, bool recovery)
		{
		}

		[Address(RVA="0x1678AE0", Offset="0x1678AE0", VA="0x1678AE0")]
		public static void AddSpeed(FlatBufferBuilder builder, bool speed)
		{
		}

		[Address(RVA="0x1678A68", Offset="0x1678A68", VA="0x1678A68")]
		public static void AddTenacity(FlatBufferBuilder builder, bool tenacity)
		{
		}

		[Address(RVA="0x16789B4", Offset="0x16789B4", VA="0x16789B4")]
		public static void AddValues(FlatBufferBuilder builder, VectorOffset valuesOffset)
		{
		}

		[Address(RVA="0x1678874", Offset="0x1678874", VA="0x1678874")]
		public static Offset<UnitAbilityLevelBalanceVar> CreateUnitAbilityLevelBalanceVar(FlatBufferBuilder builder, VectorOffset valuesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitAbilityLevelBalanceVar> Gamedata.UnitAbilityLevelBalanceVar::CreateUnitAbilityLevelBalanceVar(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitAbilityLevelBalanceVar> CreateUnitAbilityLevelBalanceVar(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1678D70", Offset="0x1678D70", VA="0x1678D70")]
		public static VectorOffset CreateValuesVector(FlatBufferBuilder builder, float[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1678CC0", Offset="0x1678CC0", VA="0x1678CC0")]
		public static Offset<UnitAbilityLevelBalanceVar> EndUnitAbilityLevelBalanceVar(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbilityLevelBalanceVar>();
		}

		[Address(RVA="0x1678234", Offset="0x1678234", VA="0x1678234")]
		public static UnitAbilityLevelBalanceVar GetRootAsUnitAbilityLevelBalanceVar(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityLevelBalanceVar();
		}

		[Address(RVA="0x1678240", Offset="0x1678240", VA="0x1678240")]
		public static UnitAbilityLevelBalanceVar GetRootAsUnitAbilityLevelBalanceVar(FlatBuffers.ByteBuffer _bb, UnitAbilityLevelBalanceVar obj)
		{
			return new UnitAbilityLevelBalanceVar();
		}

		[Address(RVA="0xF0B53C", Offset="0xF0B53C", VA="0xF0B53C")]
		public ArraySegment<byte>? GetValuesBytes()
		{
			return null;
		}

		[Address(RVA="0x1678D40", Offset="0x1678D40", VA="0x1678D40")]
		public static void StartUnitAbilityLevelBalanceVar(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x1678E68", Offset="0x1678E68", VA="0x1678E68")]
		public static void StartValuesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF0B52C", Offset="0xF0B52C", VA="0xF0B52C")]
		public float Values(int j)
		{
			return new float();
		}
	}
}