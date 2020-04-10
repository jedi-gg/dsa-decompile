using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct Spell : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public int BalanceVarsLength
		{
			[Address(RVA="0xF592A4", Offset="0xF592A4", VA="0xF592A4")]
			get
			{
				return new int();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF591A8", Offset="0xF591A8", VA="0xF591A8", Slot="5")]
			get
			{
				return null;
			}
		}

		public AbilityCastArea CastArea
		{
			[Address(RVA="0xF59244", Offset="0xF59244", VA="0xF59244")]
			get
			{
				return new AbilityCastArea();
			}
		}

		public int CategoriesLength
		{
			[Address(RVA="0xF59284", Offset="0xF59284", VA="0xF59284")]
			get
			{
				return new int();
			}
		}

		public string DetailsPrefab
		{
			[Address(RVA="0xF592AC", Offset="0xF592AC", VA="0xF592AC")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF5920C", Offset="0xF5920C", VA="0xF5920C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF591D4", Offset="0xF591D4", VA="0xF591D4")]
			get
			{
				return new ulong();
			}
		}

		public string InventoryIcon
		{
			[Address(RVA="0xF59224", Offset="0xF59224", VA="0xF59224")]
			get
			{
				return null;
			}
		}

		public bool IsHidden
		{
			[Address(RVA="0xF592C4", Offset="0xF592C4", VA="0xF592C4")]
			get
			{
				return new bool();
			}
		}

		public int LevelsLength
		{
			[Address(RVA="0xF59254", Offset="0xF59254", VA="0xF59254")]
			get
			{
				return new int();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF591DC", Offset="0xF591DC", VA="0xF591DC")]
			get
			{
				return null;
			}
		}

		public bool Obtainable
		{
			[Address(RVA="0xF5923C", Offset="0xF5923C", VA="0xF5923C")]
			get
			{
				return new bool();
			}
		}

		public string Prefab
		{
			[Address(RVA="0xF591F4", Offset="0xF591F4", VA="0xF591F4")]
			get
			{
				return null;
			}
		}

		public int VisualEffectsLength
		{
			[Address(RVA="0xF59264", Offset="0xF59264", VA="0xF59264")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF591BC", Offset="0xF591BC", VA="0xF591BC")]
		public Spell __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new Spell();
		}

		[Address(RVA="0xF591B0", Offset="0xF591B0", VA="0xF591B0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24ED558", Offset="0x24ED558", VA="0x24ED558")]
		public static void AddBalanceVars(FlatBufferBuilder builder, VectorOffset balanceVarsOffset)
		{
		}

		[Address(RVA="0x24ED774", Offset="0x24ED774", VA="0x24ED774")]
		public static void AddCastArea(FlatBufferBuilder builder, AbilityCastArea castArea)
		{
		}

		[Address(RVA="0x24ED594", Offset="0x24ED594", VA="0x24ED594")]
		public static void AddCategories(FlatBufferBuilder builder, VectorOffset categoriesOffset)
		{
		}

		[Address(RVA="0x24ED51C", Offset="0x24ED51C", VA="0x24ED51C")]
		public static void AddDetailsPrefab(FlatBufferBuilder builder, StringOffset detailsPrefabOffset)
		{
		}

		[Address(RVA="0x24ED684", Offset="0x24ED684", VA="0x24ED684")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x24ED4E0", Offset="0x24ED4E0", VA="0x24ED4E0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24ED648", Offset="0x24ED648", VA="0x24ED648")]
		public static void AddInventoryIcon(FlatBufferBuilder builder, StringOffset inventoryIconOffset)
		{
		}

		[Address(RVA="0x24ED738", Offset="0x24ED738", VA="0x24ED738")]
		public static void AddIsHidden(FlatBufferBuilder builder, bool isHidden)
		{
		}

		[Address(RVA="0x24ED60C", Offset="0x24ED60C", VA="0x24ED60C")]
		public static void AddLevels(FlatBufferBuilder builder, VectorOffset levelsOffset)
		{
		}

		[Address(RVA="0x24ED6FC", Offset="0x24ED6FC", VA="0x24ED6FC")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24ED7B0", Offset="0x24ED7B0", VA="0x24ED7B0")]
		public static void AddObtainable(FlatBufferBuilder builder, bool obtainable)
		{
		}

		[Address(RVA="0x24ED6C0", Offset="0x24ED6C0", VA="0x24ED6C0")]
		public static void AddPrefab(FlatBufferBuilder builder, StringOffset prefabOffset)
		{
		}

		[Address(RVA="0x24ED5D0", Offset="0x24ED5D0", VA="0x24ED5D0")]
		public static void AddVisualEffects(FlatBufferBuilder builder, VectorOffset visualEffectsOffset)
		{
		}

		[Address(RVA="0xF5929C", Offset="0xF5929C", VA="0xF5929C")]
		public SpellLevelBalanceVar? BalanceVars(int j)
		{
			return null;
		}

		[Address(RVA="0xF5927C", Offset="0xF5927C", VA="0xF5927C")]
		public ulong Categories(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x24EDC38", Offset="0x24EDC38", VA="0x24EDC38")]
		public static VectorOffset CreateBalanceVarsVector(FlatBufferBuilder builder, Offset<SpellLevelBalanceVar>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EDB04", Offset="0x24EDB04", VA="0x24EDB04")]
		public static VectorOffset CreateCategoriesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24ED89C", Offset="0x24ED89C", VA="0x24ED89C")]
		public static VectorOffset CreateLevelsVector(FlatBufferBuilder builder, Offset<SpellLevel>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24ED3A4", Offset="0x24ED3A4", VA="0x24ED3A4")]
		public static Offset<Spell> CreateSpell(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.Spell> Gamedata.Spell::CreateSpell(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.AbilityCastArea,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.Spell> CreateSpell(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Boolean,Gamedata.AbilityCastArea,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24ED9D0", Offset="0x24ED9D0", VA="0x24ED9D0")]
		public static VectorOffset CreateVisualEffectsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24ED7EC", Offset="0x24ED7EC", VA="0x24ED7EC")]
		public static Offset<Spell> EndSpell(FlatBufferBuilder builder)
		{
			return new Offset<Spell>();
		}

		[Address(RVA="0x24EDD6C", Offset="0x24EDD6C", VA="0x24EDD6C")]
		public static void FinishSpellBuffer(FlatBufferBuilder builder, Offset<Spell> offset)
		{
		}

		[Address(RVA="0xF5928C", Offset="0xF5928C", VA="0xF5928C")]
		public ArraySegment<byte>? GetCategoriesBytes()
		{
			return null;
		}

		[Address(RVA="0xF592B4", Offset="0xF592B4", VA="0xF592B4")]
		public ArraySegment<byte>? GetDetailsPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0xF59214", Offset="0xF59214", VA="0xF59214")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF5922C", Offset="0xF5922C", VA="0xF5922C")]
		public ArraySegment<byte>? GetInventoryIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF591E4", Offset="0xF591E4", VA="0xF591E4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF591FC", Offset="0xF591FC", VA="0xF591FC")]
		public ArraySegment<byte>? GetPrefabBytes()
		{
			return null;
		}

		[Address(RVA="0x24ECB88", Offset="0x24ECB88", VA="0x24ECB88")]
		public static Spell GetRootAsSpell(FlatBuffers.ByteBuffer _bb)
		{
			return new Spell();
		}

		[Address(RVA="0x24ECB94", Offset="0x24ECB94", VA="0x24ECB94")]
		public static Spell GetRootAsSpell(FlatBuffers.ByteBuffer _bb, Spell obj)
		{
			return new Spell();
		}

		[Address(RVA="0xF5926C", Offset="0xF5926C", VA="0xF5926C")]
		public ArraySegment<byte>? GetVisualEffectsBytes()
		{
			return null;
		}

		[Address(RVA="0xF5924C", Offset="0xF5924C", VA="0xF5924C")]
		public SpellLevel? Levels(int j)
		{
			return null;
		}

		[Address(RVA="0x24EDD30", Offset="0x24EDD30", VA="0x24EDD30")]
		public static void StartBalanceVarsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24EDBFC", Offset="0x24EDBFC", VA="0x24EDBFC")]
		public static void StartCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24ED994", Offset="0x24ED994", VA="0x24ED994")]
		public static void StartLevelsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24ED86C", Offset="0x24ED86C", VA="0x24ED86C")]
		public static void StartSpell(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24EDAC8", Offset="0x24EDAC8", VA="0x24EDAC8")]
		public static void StartVisualEffectsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF5925C", Offset="0xF5925C", VA="0xF5925C")]
		public ulong VisualEffects(int j)
		{
			return new ulong();
		}
	}
}