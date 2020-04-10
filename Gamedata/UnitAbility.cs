using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbility : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public UnitAbilityType AbilityType
		{
			[Address(RVA="0xF0B28C", Offset="0xF0B28C", VA="0xF0B28C")]
			get
			{
				return new UnitAbilityType();
			}
		}

		public bool Activated
		{
			[Address(RVA="0xF0B27C", Offset="0xF0B27C", VA="0xF0B27C")]
			get
			{
				return new bool();
			}
		}

		public int BalanceVarsLength
		{
			[Address(RVA="0xF0B2AC", Offset="0xF0B2AC", VA="0xF0B2AC")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B220", Offset="0xF0B220", VA="0xF0B220", Slot="5")]
			get
			{
				return null;
			}
		}

		public AbilityCastArea CastArea
		{
			[Address(RVA="0xF0B284", Offset="0xF0B284", VA="0xF0B284")]
			get
			{
				return new AbilityCastArea();
			}
		}

		public int DetailsSortOrder
		{
			[Address(RVA="0xF0B2E4", Offset="0xF0B2E4", VA="0xF0B2E4")]
			get
			{
				return new int();
			}
		}

		public int ExclusionGameModeLength
		{
			[Address(RVA="0xF0B2C4", Offset="0xF0B2C4", VA="0xF0B2C4")]
			get
			{
				return new int();
			}
		}

		public string Icon
		{
			[Address(RVA="0xF0B264", Offset="0xF0B264", VA="0xF0B264")]
			get
			{
				return null;
			}
		}

		public int Id
		{
			[Address(RVA="0xF0B2DC", Offset="0xF0B2DC", VA="0xF0B2DC")]
			get
			{
				return new int();
			}
		}

		public int LevelsLength
		{
			[Address(RVA="0xF0B29C", Offset="0xF0B29C", VA="0xF0B29C")]
			get
			{
				return new int();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0B24C", Offset="0xF0B24C", VA="0xF0B24C")]
			get
			{
				return null;
			}
		}

		public bool PreviewStrength
		{
			[Address(RVA="0xF0B2B4", Offset="0xF0B2B4", VA="0xF0B2B4")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0xF0B234", Offset="0xF0B234", VA="0xF0B234")]
		public UnitAbility __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbility();
		}

		[Address(RVA="0xF0B228", Offset="0xF0B228", VA="0xF0B228", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1676A10", Offset="0x1676A10", VA="0x1676A10")]
		public static void AddAbilityType(FlatBufferBuilder builder, UnitAbilityType abilityType)
		{
		}

		[Address(RVA="0x1676A88", Offset="0x1676A88", VA="0x1676A88")]
		public static void AddActivated(FlatBufferBuilder builder, bool activated)
		{
		}

		[Address(RVA="0x16768E4", Offset="0x16768E4", VA="0x16768E4")]
		public static void AddBalanceVars(FlatBufferBuilder builder, VectorOffset balanceVarsOffset)
		{
		}

		[Address(RVA="0x1676A4C", Offset="0x1676A4C", VA="0x1676A4C")]
		public static void AddCastArea(FlatBufferBuilder builder, AbilityCastArea castArea)
		{
		}

		[Address(RVA="0x1676830", Offset="0x1676830", VA="0x1676830")]
		public static void AddDetailsSortOrder(FlatBufferBuilder builder, int detailsSortOrder)
		{
		}

		[Address(RVA="0x16768A8", Offset="0x16768A8", VA="0x16768A8")]
		public static void AddExclusionGameMode(FlatBufferBuilder builder, VectorOffset exclusionGameModeOffset)
		{
		}

		[Address(RVA="0x167695C", Offset="0x167695C", VA="0x167695C")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x167686C", Offset="0x167686C", VA="0x167686C")]
		public static void AddId(FlatBufferBuilder builder, int id)
		{
		}

		[Address(RVA="0x1676920", Offset="0x1676920", VA="0x1676920")]
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
		}

		[Address(RVA="0x1676998", Offset="0x1676998", VA="0x1676998")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x16769D4", Offset="0x16769D4", VA="0x16769D4")]
		public static void AddPreviewStrength(FlatBufferBuilder builder, bool previewStrength)
		{
		}

		[Address(RVA="0xF0B2A4", Offset="0xF0B2A4", VA="0xF0B2A4")]
		public UnitAbilityLevelBalanceVar? BalanceVars(int j)
		{
			return null;
		}

		[Address(RVA="0x1676CA8", Offset="0x1676CA8", VA="0x1676CA8")]
		public static VectorOffset CreateBalanceVarsVector(FlatBufferBuilder builder, Offset<UnitAbilityLevelBalanceVar>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1676DDC", Offset="0x1676DDC", VA="0x1676DDC")]
		public static VectorOffset CreateExclusionGameModeVector(FlatBufferBuilder builder, GameMode[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1676B74", Offset="0x1676B74", VA="0x1676B74")]
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<UnitAbilityLevel>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1676718", Offset="0x1676718", VA="0x1676718")]
		public static Offset<UnitAbility> CreateUnitAbility(FlatBufferBuilder builder, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitAbility> Gamedata.UnitAbility::CreateUnitAbility(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.AbilityCastArea,Gamedata.UnitAbilityType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean,FlatBuffers.VectorOffset,System.Int32,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitAbility> CreateUnitAbility(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.AbilityCastArea,Gamedata.UnitAbilityType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.Boolean,FlatBuffers.VectorOffset,System.Int32,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1676AC4", Offset="0x1676AC4", VA="0x1676AC4")]
		public static Offset<UnitAbility> EndUnitAbility(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbility>();
		}

		[Address(RVA="0xF0B2BC", Offset="0xF0B2BC", VA="0xF0B2BC")]
		public GameMode ExclusionGameMode(int j)
		{
			return new GameMode();
		}

		[Address(RVA="0xF0B2CC", Offset="0xF0B2CC", VA="0xF0B2CC")]
		public ArraySegment<byte>? GetExclusionGameModeBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B26C", Offset="0xF0B26C", VA="0xF0B26C")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B254", Offset="0xF0B254", VA="0xF0B254")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x1676034", Offset="0x1676034", VA="0x1676034")]
		public static UnitAbility GetRootAsUnitAbility(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbility();
		}

		[Address(RVA="0x1676040", Offset="0x1676040", VA="0x1676040")]
		public static UnitAbility GetRootAsUnitAbility(FlatBuffers.ByteBuffer _bb, UnitAbility obj)
		{
			return new UnitAbility();
		}

		[Address(RVA="0xF0B294", Offset="0xF0B294", VA="0xF0B294")]
		public UnitAbilityLevel? Levels(int j)
		{
			return null;
		}

		[Address(RVA="0x1676DA0", Offset="0x1676DA0", VA="0x1676DA0")]
		public static void StartBalanceVarsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1676ED8", Offset="0x1676ED8", VA="0x1676ED8")]
		public static void StartExclusionGameModeVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1676C6C", Offset="0x1676C6C", VA="0x1676C6C")]
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1676B44", Offset="0x1676B44", VA="0x1676B44")]
		public static void StartUnitAbility(FlatBufferBuilder builder)
		{
		}
	}
}