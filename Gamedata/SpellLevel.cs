using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellLevel : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public SpellSpawnableAdd? AddUnit
		{
			[Address(RVA="0xF594A4", Offset="0xF594A4", VA="0xF594A4")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59458", Offset="0xF59458", VA="0xF59458", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0xF594B4", Offset="0xF594B4", VA="0xF594B4")]
			get
			{
				return null;
			}
		}

		public ulong Geometry
		{
			[Address(RVA="0xF5948C", Offset="0xF5948C", VA="0xF5948C")]
			get
			{
				return new ulong();
			}
		}

		public bool IgnoreBuildings
		{
			[Address(RVA="0xF594FC", Offset="0xF594FC", VA="0xF594FC")]
			get
			{
				return new bool();
			}
		}

		public byte InitialMana
		{
			[Address(RVA="0xF59504", Offset="0xF59504", VA="0xF59504")]
			get
			{
				return new byte();
			}
		}

		public byte ManaCost
		{
			[Address(RVA="0xF59484", Offset="0xF59484", VA="0xF59484")]
			get
			{
				return new byte();
			}
		}

		public string PreviewUpgradeDescription
		{
			[Address(RVA="0xF594CC", Offset="0xF594CC", VA="0xF594CC")]
			get
			{
				return null;
			}
		}

		public int PreviewUpgradeVarsLength
		{
			[Address(RVA="0xF59514", Offset="0xF59514", VA="0xF59514")]
			get
			{
				return new int();
			}
		}

		public SpellLevelRecipe? Recipe
		{
			[Address(RVA="0xF594AC", Offset="0xF594AC", VA="0xF594AC")]
			get
			{
				return null;
			}
		}

		public bool TargetAlly
		{
			[Address(RVA="0xF59494", Offset="0xF59494", VA="0xF59494")]
			get
			{
				return new bool();
			}
		}

		public bool TargetEnemy
		{
			[Address(RVA="0xF5949C", Offset="0xF5949C", VA="0xF5949C")]
			get
			{
				return new bool();
			}
		}

		public string UpgradeIcon
		{
			[Address(RVA="0xF594E4", Offset="0xF594E4", VA="0xF594E4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5946C", Offset="0xF5946C", VA="0xF5946C")]
		public SpellLevel __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevel();
		}

		[Address(RVA="0xF59460", Offset="0xF59460", VA="0xF59460", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EEFCC", Offset="0x24EEFCC", VA="0x24EEFCC")]
		public static void AddAddUnit(FlatBufferBuilder builder, Offset<SpellSpawnableAdd> addUnitOffset)
		{
		}

		[Address(RVA="0x24EEF54", Offset="0x24EEF54", VA="0x24EEF54")]
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
		}

		[Address(RVA="0x24EEE64", Offset="0x24EEE64", VA="0x24EEE64")]
		public static void AddGeometry(FlatBufferBuilder builder, ulong geometry)
		{
		}

		[Address(RVA="0x24EF044", Offset="0x24EF044", VA="0x24EF044")]
		public static void AddIgnoreBuildings(FlatBufferBuilder builder, bool ignoreBuildings)
		{
		}

		[Address(RVA="0x24EF008", Offset="0x24EF008", VA="0x24EF008")]
		public static void AddInitialMana(FlatBufferBuilder builder, byte initialMana)
		{
		}

		[Address(RVA="0x24EF0F8", Offset="0x24EF0F8", VA="0x24EF0F8")]
		public static void AddManaCost(FlatBufferBuilder builder, byte manaCost)
		{
		}

		[Address(RVA="0x24EEF18", Offset="0x24EEF18", VA="0x24EEF18")]
		public static void AddPreviewUpgradeDescription(FlatBufferBuilder builder, StringOffset previewUpgradeDescriptionOffset)
		{
		}

		[Address(RVA="0x24EEEA0", Offset="0x24EEEA0", VA="0x24EEEA0")]
		public static void AddPreviewUpgradeVars(FlatBufferBuilder builder, VectorOffset previewUpgradeVarsOffset)
		{
		}

		[Address(RVA="0x24EEF90", Offset="0x24EEF90", VA="0x24EEF90")]
		public static void AddRecipe(FlatBufferBuilder builder, Offset<SpellLevelRecipe> recipeOffset)
		{
		}

		[Address(RVA="0x24EF0BC", Offset="0x24EF0BC", VA="0x24EF0BC")]
		public static void AddTargetAlly(FlatBufferBuilder builder, bool targetAlly)
		{
		}

		[Address(RVA="0x24EF080", Offset="0x24EF080", VA="0x24EF080")]
		public static void AddTargetEnemy(FlatBufferBuilder builder, bool targetEnemy)
		{
		}

		[Address(RVA="0x24EEEDC", Offset="0x24EEEDC", VA="0x24EEEDC")]
		public static void AddUpgradeIcon(FlatBufferBuilder builder, StringOffset upgradeIconOffset)
		{
		}

		[Address(RVA="0x24EF1E4", Offset="0x24EF1E4", VA="0x24EF1E4")]
		public static VectorOffset CreatePreviewUpgradeVarsVector(FlatBufferBuilder builder, float[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EED3C", Offset="0x24EED3C", VA="0x24EED3C")]
		public static Offset<SpellLevel> CreateSpellLevel(FlatBufferBuilder builder, byte mana_cost = 0, ulong geometry = 0L, bool target_ally = false, bool target_enemy = false, Offset<SpellSpawnableAdd> add_unitOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellLevel> Gamedata.SpellLevel::CreateSpellLevel(FlatBuffers.FlatBufferBuilder,System.Byte,System.UInt64,System.Boolean,System.Boolean,FlatBuffers.Offset`1<Gamedata.SpellSpawnableAdd>,FlatBuffers.Offset`1<Gamedata.SpellLevelRecipe>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,System.Byte,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellLevel> CreateSpellLevel(FlatBuffers.FlatBufferBuilder,System.Byte,System.UInt64,System.Boolean,System.Boolean,FlatBuffers.Offset<Gamedata.SpellSpawnableAdd>,FlatBuffers.Offset<Gamedata.SpellLevelRecipe>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,System.Byte,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EF134", Offset="0x24EF134", VA="0x24EF134")]
		public static Offset<SpellLevel> EndSpellLevel(FlatBufferBuilder builder)
		{
			return new Offset<SpellLevel>();
		}

		[Address(RVA="0xF594BC", Offset="0xF594BC", VA="0xF594BC")]
		public ArraySegment<byte>? GetDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF594D4", Offset="0xF594D4", VA="0xF594D4")]
		public ArraySegment<byte>? GetPreviewUpgradeDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF5951C", Offset="0xF5951C", VA="0xF5951C")]
		public ArraySegment<byte>? GetPreviewUpgradeVarsBytes()
		{
			return null;
		}

		[Address(RVA="0x24EE69C", Offset="0x24EE69C", VA="0x24EE69C")]
		public static SpellLevel GetRootAsSpellLevel(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellLevel();
		}

		[Address(RVA="0x24EE6A8", Offset="0x24EE6A8", VA="0x24EE6A8")]
		public static SpellLevel GetRootAsSpellLevel(FlatBuffers.ByteBuffer _bb, SpellLevel obj)
		{
			return new SpellLevel();
		}

		[Address(RVA="0xF594EC", Offset="0xF594EC", VA="0xF594EC")]
		public ArraySegment<byte>? GetUpgradeIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF5950C", Offset="0xF5950C", VA="0xF5950C")]
		public float PreviewUpgradeVars(int j)
		{
			return new float();
		}

		[Address(RVA="0x24EF2DC", Offset="0x24EF2DC", VA="0x24EF2DC")]
		public static void StartPreviewUpgradeVarsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24EF1B4", Offset="0x24EF1B4", VA="0x24EF1B4")]
		public static void StartSpellLevel(FlatBufferBuilder builder)
		{
		}
	}
}