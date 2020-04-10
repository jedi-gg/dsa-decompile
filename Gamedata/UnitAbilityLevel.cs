using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitAbilityLevel : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public UnitAbilityAdd? AddUnit
		{
			[Address(RVA="0xF0B41C", Offset="0xF0B41C", VA="0xF0B41C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B3C8", Offset="0xF0B3C8", VA="0xF0B3C8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Description
		{
			[Address(RVA="0xF0B434", Offset="0xF0B434", VA="0xF0B434")]
			get
			{
				return null;
			}
		}

		public ulong Geometry
		{
			[Address(RVA="0xF0B3FC", Offset="0xF0B3FC", VA="0xF0B3FC")]
			get
			{
				return new ulong();
			}
		}

		public bool IgnoreBuildings
		{
			[Address(RVA="0xF0B484", Offset="0xF0B484", VA="0xF0B484")]
			get
			{
				return new bool();
			}
		}

		public byte InitialMana
		{
			[Address(RVA="0xF0B4AC", Offset="0xF0B4AC", VA="0xF0B4AC")]
			get
			{
				return new byte();
			}
		}

		public byte ManaCost
		{
			[Address(RVA="0xF0B3F4", Offset="0xF0B3F4", VA="0xF0B3F4")]
			get
			{
				return new byte();
			}
		}

		public string PreviewUpgradeDescription
		{
			[Address(RVA="0xF0B44C", Offset="0xF0B44C", VA="0xF0B44C")]
			get
			{
				return null;
			}
		}

		public int PreviewUpgradeVarsLength
		{
			[Address(RVA="0xF0B494", Offset="0xF0B494", VA="0xF0B494")]
			get
			{
				return new int();
			}
		}

		public float Range
		{
			[Address(RVA="0xF0B464", Offset="0xF0B464", VA="0xF0B464")]
			get
			{
				return new float();
			}
		}

		public UnitAbilityRecipe? Recipe
		{
			[Address(RVA="0xF0B424", Offset="0xF0B424", VA="0xF0B424")]
			get
			{
				return null;
			}
		}

		public UnitRequirements? Requirements
		{
			[Address(RVA="0xF0B42C", Offset="0xF0B42C", VA="0xF0B42C")]
			get
			{
				return null;
			}
		}

		public bool TargetAlly
		{
			[Address(RVA="0xF0B40C", Offset="0xF0B40C", VA="0xF0B40C")]
			get
			{
				return new bool();
			}
		}

		public bool TargetEnemy
		{
			[Address(RVA="0xF0B414", Offset="0xF0B414", VA="0xF0B414")]
			get
			{
				return new bool();
			}
		}

		public bool TargetSelf
		{
			[Address(RVA="0xF0B404", Offset="0xF0B404", VA="0xF0B404")]
			get
			{
				return new bool();
			}
		}

		public string UpgradeIcon
		{
			[Address(RVA="0xF0B46C", Offset="0xF0B46C", VA="0xF0B46C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0B3DC", Offset="0xF0B3DC", VA="0xF0B3DC")]
		public UnitAbilityLevel __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityLevel();
		}

		[Address(RVA="0xF0B3D0", Offset="0xF0B3D0", VA="0xF0B3D0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1677EA4", Offset="0x1677EA4", VA="0x1677EA4")]
		public static void AddAddUnit(FlatBufferBuilder builder, Offset<UnitAbilityAdd> addUnitOffset)
		{
		}

		[Address(RVA="0x1677DF0", Offset="0x1677DF0", VA="0x1677DF0")]
		public static void AddDescription(FlatBufferBuilder builder, StringOffset descriptionOffset)
		{
		}

		[Address(RVA="0x1677CBC", Offset="0x1677CBC", VA="0x1677CBC")]
		public static void AddGeometry(FlatBufferBuilder builder, ulong geometry)
		{
		}

		[Address(RVA="0x1677F1C", Offset="0x1677F1C", VA="0x1677F1C")]
		public static void AddIgnoreBuildings(FlatBufferBuilder builder, bool ignoreBuildings)
		{
		}

		[Address(RVA="0x1677EE0", Offset="0x1677EE0", VA="0x1677EE0")]
		public static void AddInitialMana(FlatBufferBuilder builder, byte initialMana)
		{
		}

		[Address(RVA="0x167800C", Offset="0x167800C", VA="0x167800C")]
		public static void AddManaCost(FlatBufferBuilder builder, byte manaCost)
		{
		}

		[Address(RVA="0x1677DB4", Offset="0x1677DB4", VA="0x1677DB4")]
		public static void AddPreviewUpgradeDescription(FlatBufferBuilder builder, StringOffset previewUpgradeDescriptionOffset)
		{
		}

		[Address(RVA="0x1677CF8", Offset="0x1677CF8", VA="0x1677CF8")]
		public static void AddPreviewUpgradeVars(FlatBufferBuilder builder, VectorOffset previewUpgradeVarsOffset)
		{
		}

		[Address(RVA="0x1677D70", Offset="0x1677D70", VA="0x1677D70")]
		public static void AddRange(FlatBufferBuilder builder, float range)
		{
		}

		[Address(RVA="0x1677E68", Offset="0x1677E68", VA="0x1677E68")]
		public static void AddRecipe(FlatBufferBuilder builder, Offset<UnitAbilityRecipe> recipeOffset)
		{
		}

		[Address(RVA="0x1677E2C", Offset="0x1677E2C", VA="0x1677E2C")]
		public static void AddRequirements(FlatBufferBuilder builder, Offset<UnitRequirements> requirementsOffset)
		{
		}

		[Address(RVA="0x1677F94", Offset="0x1677F94", VA="0x1677F94")]
		public static void AddTargetAlly(FlatBufferBuilder builder, bool targetAlly)
		{
		}

		[Address(RVA="0x1677F58", Offset="0x1677F58", VA="0x1677F58")]
		public static void AddTargetEnemy(FlatBufferBuilder builder, bool targetEnemy)
		{
		}

		[Address(RVA="0x1677FD0", Offset="0x1677FD0", VA="0x1677FD0")]
		public static void AddTargetSelf(FlatBufferBuilder builder, bool targetSelf)
		{
		}

		[Address(RVA="0x1677D34", Offset="0x1677D34", VA="0x1677D34")]
		public static void AddUpgradeIcon(FlatBufferBuilder builder, StringOffset upgradeIconOffset)
		{
		}

		[Address(RVA="0x16780F8", Offset="0x16780F8", VA="0x16780F8")]
		public static VectorOffset CreatePreviewUpgradeVarsVector(FlatBufferBuilder builder, float[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1677B58", Offset="0x1677B58", VA="0x1677B58")]
		public static Offset<UnitAbilityLevel> CreateUnitAbilityLevel(FlatBufferBuilder builder, byte mana_cost = 0, ulong geometry = 0L, bool target_self = false, bool target_ally = false, bool target_enemy = false, Offset<UnitAbilityAdd> add_unitOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitAbilityLevel> Gamedata.UnitAbilityLevel::CreateUnitAbilityLevel(FlatBuffers.FlatBufferBuilder,System.Byte,System.UInt64,System.Boolean,System.Boolean,System.Boolean,FlatBuffers.Offset`1<Gamedata.UnitAbilityAdd>,FlatBuffers.Offset`1<Gamedata.UnitAbilityRecipe>,FlatBuffers.Offset`1<Gamedata.UnitRequirements>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Single,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.Byte)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitAbilityLevel> CreateUnitAbilityLevel(FlatBuffers.FlatBufferBuilder,System.Byte,System.UInt64,System.Boolean,System.Boolean,System.Boolean,FlatBuffers.Offset<Gamedata.UnitAbilityAdd>,FlatBuffers.Offset<Gamedata.UnitAbilityRecipe>,FlatBuffers.Offset<Gamedata.UnitRequirements>,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Single,FlatBuffers.StringOffset,System.Boolean,FlatBuffers.VectorOffset,System.Byte)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1678048", Offset="0x1678048", VA="0x1678048")]
		public static Offset<UnitAbilityLevel> EndUnitAbilityLevel(FlatBufferBuilder builder)
		{
			return new Offset<UnitAbilityLevel>();
		}

		[Address(RVA="0xF0B43C", Offset="0xF0B43C", VA="0xF0B43C")]
		public ArraySegment<byte>? GetDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B454", Offset="0xF0B454", VA="0xF0B454")]
		public ArraySegment<byte>? GetPreviewUpgradeDescriptionBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B49C", Offset="0xF0B49C", VA="0xF0B49C")]
		public ArraySegment<byte>? GetPreviewUpgradeVarsBytes()
		{
			return null;
		}

		[Address(RVA="0x1677354", Offset="0x1677354", VA="0x1677354")]
		public static UnitAbilityLevel GetRootAsUnitAbilityLevel(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitAbilityLevel();
		}

		[Address(RVA="0x1677360", Offset="0x1677360", VA="0x1677360")]
		public static UnitAbilityLevel GetRootAsUnitAbilityLevel(FlatBuffers.ByteBuffer _bb, UnitAbilityLevel obj)
		{
			return new UnitAbilityLevel();
		}

		[Address(RVA="0xF0B474", Offset="0xF0B474", VA="0xF0B474")]
		public ArraySegment<byte>? GetUpgradeIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B48C", Offset="0xF0B48C", VA="0xF0B48C")]
		public float PreviewUpgradeVars(int j)
		{
			return new float();
		}

		[Address(RVA="0x16781F0", Offset="0x16781F0", VA="0x16781F0")]
		public static void StartPreviewUpgradeVarsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x16780C8", Offset="0x16780C8", VA="0x16780C8")]
		public static void StartUnitAbilityLevel(FlatBufferBuilder builder)
		{
		}
	}
}