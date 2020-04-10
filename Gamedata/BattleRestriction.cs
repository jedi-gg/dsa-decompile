using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleRestriction : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0AAB8", Offset="0xF0AAB8", VA="0xF0AAB8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF0AB14", Offset="0xF0AB14", VA="0xF0AB14")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0AAE4", Offset="0xF0AAE4", VA="0xF0AAE4")]
			get
			{
				return new ulong();
			}
		}

		public bool OnlyRequiredSpellsAllowed
		{
			[Address(RVA="0xF0AB0C", Offset="0xF0AB0C", VA="0xF0AB0C")]
			get
			{
				return new bool();
			}
		}

		public bool OnlyRequiredUnitsAllowed
		{
			[Address(RVA="0xF0AB04", Offset="0xF0AB04", VA="0xF0AB04")]
			get
			{
				return new bool();
			}
		}

		public bool RequiresFullSquad
		{
			[Address(RVA="0xF0AB2C", Offset="0xF0AB2C", VA="0xF0AB2C")]
			get
			{
				return new bool();
			}
		}

		public Gamedata.SpellFilter? SpellFilter
		{
			[Address(RVA="0xF0AAFC", Offset="0xF0AAFC", VA="0xF0AAFC")]
			get
			{
				return null;
			}
		}

		public Gamedata.SquadRequirement? SquadRequirement
		{
			[Address(RVA="0xF0AAEC", Offset="0xF0AAEC", VA="0xF0AAEC")]
			get
			{
				return null;
			}
		}

		public Gamedata.UnitFilter? UnitFilter
		{
			[Address(RVA="0xF0AAF4", Offset="0xF0AAF4", VA="0xF0AAF4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0AACC", Offset="0xF0AACC", VA="0xF0AACC")]
		public BattleRestriction __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleRestriction();
		}

		[Address(RVA="0xF0AAC0", Offset="0xF0AAC0", VA="0xF0AAC0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F5BC8", Offset="0x15F5BC8", VA="0x15F5BC8")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x15F5B8C", Offset="0x15F5B8C", VA="0x15F5B8C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F5CF4", Offset="0x15F5CF4", VA="0x15F5CF4")]
		public static void AddOnlyRequiredSpellsAllowed(FlatBufferBuilder builder, bool onlyRequiredSpellsAllowed)
		{
		}

		[Address(RVA="0x15F5D30", Offset="0x15F5D30", VA="0x15F5D30")]
		public static void AddOnlyRequiredUnitsAllowed(FlatBufferBuilder builder, bool onlyRequiredUnitsAllowed)
		{
		}

		[Address(RVA="0x15F5CB8", Offset="0x15F5CB8", VA="0x15F5CB8")]
		public static void AddRequiresFullSquad(FlatBufferBuilder builder, bool requiresFullSquad)
		{
		}

		[Address(RVA="0x15F5C04", Offset="0x15F5C04", VA="0x15F5C04")]
		public static void AddSpellFilter(FlatBufferBuilder builder, Offset<Gamedata.SpellFilter> spellFilterOffset)
		{
		}

		[Address(RVA="0x15F5C7C", Offset="0x15F5C7C", VA="0x15F5C7C")]
		public static void AddSquadRequirement(FlatBufferBuilder builder, Offset<Gamedata.SquadRequirement> squadRequirementOffset)
		{
		}

		[Address(RVA="0x15F5C40", Offset="0x15F5C40", VA="0x15F5C40")]
		public static void AddUnitFilter(FlatBufferBuilder builder, Offset<Gamedata.UnitFilter> unitFilterOffset)
		{
		}

		[Address(RVA="0x15F5AAC", Offset="0x15F5AAC", VA="0x15F5AAC")]
		public static Offset<BattleRestriction> CreateBattleRestriction(FlatBufferBuilder builder, ulong id = 0L, Offset<Gamedata.SquadRequirement> squad_requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleRestriction> Gamedata.BattleRestriction::CreateBattleRestriction(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.SquadRequirement>,FlatBuffers.Offset`1<Gamedata.UnitFilter>,FlatBuffers.Offset`1<Gamedata.SpellFilter>,System.Boolean,System.Boolean,FlatBuffers.StringOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleRestriction> CreateBattleRestriction(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.SquadRequirement>,FlatBuffers.Offset<Gamedata.UnitFilter>,FlatBuffers.Offset<Gamedata.SpellFilter>,System.Boolean,System.Boolean,FlatBuffers.StringOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F5D6C", Offset="0x15F5D6C", VA="0x15F5D6C")]
		public static Offset<BattleRestriction> EndBattleRestriction(FlatBufferBuilder builder)
		{
			return new Offset<BattleRestriction>();
		}

		[Address(RVA="0x15F5E1C", Offset="0x15F5E1C", VA="0x15F5E1C")]
		public static void FinishBattleRestrictionBuffer(FlatBufferBuilder builder, Offset<BattleRestriction> offset)
		{
		}

		[Address(RVA="0xF0AB1C", Offset="0xF0AB1C", VA="0xF0AB1C")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x15F5578", Offset="0x15F5578", VA="0x15F5578")]
		public static BattleRestriction GetRootAsBattleRestriction(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleRestriction();
		}

		[Address(RVA="0x15F5584", Offset="0x15F5584", VA="0x15F5584")]
		public static BattleRestriction GetRootAsBattleRestriction(FlatBuffers.ByteBuffer _bb, BattleRestriction obj)
		{
			return new BattleRestriction();
		}

		[Address(RVA="0x15F5DEC", Offset="0x15F5DEC", VA="0x15F5DEC")]
		public static void StartBattleRestriction(FlatBufferBuilder builder)
		{
		}
	}
}