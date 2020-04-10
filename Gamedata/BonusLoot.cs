using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BonusLoot : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong AddLootTable
		{
			[Address(RVA="0xF0AD6C", Offset="0xF0AD6C", VA="0xF0AD6C")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0ACA8", Offset="0xF0ACA8", VA="0xF0ACA8", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DescriptionLocKey
		{
			[Address(RVA="0xF0AD94", Offset="0xF0AD94", VA="0xF0AD94")]
			get
			{
				return null;
			}
		}

		public int ExcludedItemsLength
		{
			[Address(RVA="0xF0AD54", Offset="0xF0AD54", VA="0xF0AD54")]
			get
			{
				return new int();
			}
		}

		public BonusLootGameMode GameMode
		{
			[Address(RVA="0xF0ACE4", Offset="0xF0ACE4", VA="0xF0ACE4")]
			get
			{
				return new BonusLootGameMode();
			}
		}

		public string GameModeId
		{
			[Address(RVA="0xF0ACEC", Offset="0xF0ACEC", VA="0xF0ACEC")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0ACD4", Offset="0xF0ACD4", VA="0xF0ACD4")]
			get
			{
				return new ulong();
			}
		}

		public int ItemIdsLength
		{
			[Address(RVA="0xF0AD14", Offset="0xF0AD14", VA="0xF0AD14")]
			get
			{
				return new int();
			}
		}

		public int ItemTypesLength
		{
			[Address(RVA="0xF0AD34", Offset="0xF0AD34", VA="0xF0AD34")]
			get
			{
				return new int();
			}
		}

		public float Multiplier
		{
			[Address(RVA="0xF0AD04", Offset="0xF0AD04", VA="0xF0AD04")]
			get
			{
				return new float();
			}
		}

		public OccasionRef? Occasion
		{
			[Address(RVA="0xF0ACDC", Offset="0xF0ACDC", VA="0xF0ACDC")]
			get
			{
				return null;
			}
		}

		public bool ShowCampaignNodeBonusLabel
		{
			[Address(RVA="0xF0AD74", Offset="0xF0AD74", VA="0xF0AD74")]
			get
			{
				return new bool();
			}
		}

		public string TitleLocKey
		{
			[Address(RVA="0xF0AD7C", Offset="0xF0AD7C", VA="0xF0AD7C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF0ACBC", Offset="0xF0ACBC", VA="0xF0ACBC")]
		public BonusLoot __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BonusLoot();
		}

		[Address(RVA="0xF0ACB0", Offset="0xF0ACB0", VA="0xF0ACB0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F6E0C", Offset="0x15F6E0C", VA="0x15F6E0C")]
		public static void AddAddLootTable(FlatBufferBuilder builder, ulong addLootTable)
		{
		}

		[Address(RVA="0x15F6E84", Offset="0x15F6E84", VA="0x15F6E84")]
		public static void AddDescriptionLocKey(FlatBufferBuilder builder, StringOffset descriptionLocKeyOffset)
		{
		}

		[Address(RVA="0x15F6EFC", Offset="0x15F6EFC", VA="0x15F6EFC")]
		public static void AddExcludedItems(FlatBufferBuilder builder, VectorOffset excludedItemsOffset)
		{
		}

		[Address(RVA="0x15F70A8", Offset="0x15F70A8", VA="0x15F70A8")]
		public static void AddGameMode(FlatBufferBuilder builder, BonusLootGameMode gameMode)
		{
		}

		[Address(RVA="0x15F6FF4", Offset="0x15F6FF4", VA="0x15F6FF4")]
		public static void AddGameModeId(FlatBufferBuilder builder, StringOffset gameModeIdOffset)
		{
		}

		[Address(RVA="0x15F6E48", Offset="0x15F6E48", VA="0x15F6E48")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F6F74", Offset="0x15F6F74", VA="0x15F6F74")]
		public static void AddItemIds(FlatBufferBuilder builder, VectorOffset itemIdsOffset)
		{
		}

		[Address(RVA="0x15F6F38", Offset="0x15F6F38", VA="0x15F6F38")]
		public static void AddItemTypes(FlatBufferBuilder builder, VectorOffset itemTypesOffset)
		{
		}

		[Address(RVA="0x15F6FB0", Offset="0x15F6FB0", VA="0x15F6FB0")]
		public static void AddMultiplier(FlatBufferBuilder builder, float multiplier)
		{
		}

		[Address(RVA="0x15F7030", Offset="0x15F7030", VA="0x15F7030")]
		public static void AddOccasion(FlatBufferBuilder builder, Offset<OccasionRef> occasionOffset)
		{
		}

		[Address(RVA="0x15F706C", Offset="0x15F706C", VA="0x15F706C")]
		public static void AddShowCampaignNodeBonusLabel(FlatBufferBuilder builder, bool showCampaignNodeBonusLabel)
		{
		}

		[Address(RVA="0x15F6EC0", Offset="0x15F6EC0", VA="0x15F6EC0")]
		public static void AddTitleLocKey(FlatBufferBuilder builder, StringOffset titleLocKeyOffset)
		{
		}

		[Address(RVA="0x15F6CE0", Offset="0x15F6CE0", VA="0x15F6CE0")]
		public static Offset<BonusLoot> CreateBonusLoot(FlatBufferBuilder builder, ulong id = 0L, Offset<OccasionRef> occasionOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BonusLoot> Gamedata.BonusLoot::CreateBonusLoot(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset`1<Gamedata.OccasionRef>,Gamedata.BonusLootGameMode,FlatBuffers.StringOffset,System.Single,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt64,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BonusLoot> CreateBonusLoot(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.Offset<Gamedata.OccasionRef>,Gamedata.BonusLootGameMode,FlatBuffers.StringOffset,System.Single,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset,System.UInt64,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F7400", Offset="0x15F7400", VA="0x15F7400")]
		public static VectorOffset CreateExcludedItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F7194", Offset="0x15F7194", VA="0x15F7194")]
		public static VectorOffset CreateItemIdsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F72C8", Offset="0x15F72C8", VA="0x15F72C8")]
		public static VectorOffset CreateItemTypesVector(FlatBufferBuilder builder, InventoryItemType[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F70E4", Offset="0x15F70E4", VA="0x15F70E4")]
		public static Offset<BonusLoot> EndBonusLoot(FlatBufferBuilder builder)
		{
			return new Offset<BonusLoot>();
		}

		[Address(RVA="0xF0AD4C", Offset="0xF0AD4C", VA="0xF0AD4C")]
		public ulong ExcludedItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x15F7534", Offset="0x15F7534", VA="0x15F7534")]
		public static void FinishBonusLootBuffer(FlatBufferBuilder builder, Offset<BonusLoot> offset)
		{
		}

		[Address(RVA="0xF0AD9C", Offset="0xF0AD9C", VA="0xF0AD9C")]
		public ArraySegment<byte>? GetDescriptionLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AD5C", Offset="0xF0AD5C", VA="0xF0AD5C")]
		public ArraySegment<byte>? GetExcludedItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF0ACF4", Offset="0xF0ACF4", VA="0xF0ACF4")]
		public ArraySegment<byte>? GetGameModeIdBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AD1C", Offset="0xF0AD1C", VA="0xF0AD1C")]
		public ArraySegment<byte>? GetItemIdsBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AD3C", Offset="0xF0AD3C", VA="0xF0AD3C")]
		public ArraySegment<byte>? GetItemTypesBytes()
		{
			return null;
		}

		[Address(RVA="0x15F65AC", Offset="0x15F65AC", VA="0x15F65AC")]
		public static BonusLoot GetRootAsBonusLoot(FlatBuffers.ByteBuffer _bb)
		{
			return new BonusLoot();
		}

		[Address(RVA="0x15F65B8", Offset="0x15F65B8", VA="0x15F65B8")]
		public static BonusLoot GetRootAsBonusLoot(FlatBuffers.ByteBuffer _bb, BonusLoot obj)
		{
			return new BonusLoot();
		}

		[Address(RVA="0xF0AD84", Offset="0xF0AD84", VA="0xF0AD84")]
		public ArraySegment<byte>? GetTitleLocKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF0AD0C", Offset="0xF0AD0C", VA="0xF0AD0C")]
		public ulong ItemIds(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF0AD2C", Offset="0xF0AD2C", VA="0xF0AD2C")]
		public InventoryItemType ItemTypes(int j)
		{
			return new InventoryItemType();
		}

		[Address(RVA="0x15F7164", Offset="0x15F7164", VA="0x15F7164")]
		public static void StartBonusLoot(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F74F8", Offset="0x15F74F8", VA="0x15F74F8")]
		public static void StartExcludedItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x15F728C", Offset="0x15F728C", VA="0x15F728C")]
		public static void StartItemIdsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x15F73C4", Offset="0x15F73C4", VA="0x15F73C4")]
		public static void StartItemTypesVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}