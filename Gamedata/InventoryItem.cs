using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct InventoryItem : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ItemCount? BuyAndEquipCost
		{
			[Address(RVA="0xF5AA9C", Offset="0xF5AA9C", VA="0xF5AA9C")]
			get
			{
				return null;
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A9A0", Offset="0xF5A9A0", VA="0xF5A9A0", Slot="5")]
			get
			{
				return null;
			}
		}

		public bool CanBeDonated
		{
			[Address(RVA="0xF5AA54", Offset="0xF5AA54", VA="0xF5AA54")]
			get
			{
				return new bool();
			}
		}

		public uint ColorId
		{
			[Address(RVA="0xF5AABC", Offset="0xF5AABC", VA="0xF5AABC")]
			get
			{
				return new uint();
			}
		}

		public int CostsLength
		{
			[Address(RVA="0xF5AA4C", Offset="0xF5AA4C", VA="0xF5AA4C")]
			get
			{
				return new int();
			}
		}

		public Gamedata.DeepLinkLocation DeepLinkLocation
		{
			[Address(RVA="0xF5AACC", Offset="0xF5AACC", VA="0xF5AACC")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string DeepLinkSublocation
		{
			[Address(RVA="0xF5AAD4", Offset="0xF5AAD4", VA="0xF5AAD4")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF5A9F4", Offset="0xF5A9F4", VA="0xF5A9F4")]
			get
			{
				return null;
			}
		}

		public Gamedata.DeepLinkLocation GetMoreDeepLinkLocation
		{
			[Address(RVA="0xF5AAEC", Offset="0xF5AAEC", VA="0xF5AAEC")]
			get
			{
				return new Gamedata.DeepLinkLocation();
			}
		}

		public string GetMoreDeepLinkSublocation
		{
			[Address(RVA="0xF5AAF4", Offset="0xF5AAF4", VA="0xF5AAF4")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF5AA0C", Offset="0xF5AA0C", VA="0xF5AA0C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5A9CC", Offset="0xF5A9CC", VA="0xF5A9CC")]
			get
			{
				return new ulong();
			}
		}

		public string InsufficientCountKey
		{
			[Address(RVA="0xF5AA84", Offset="0xF5AA84", VA="0xF5AA84")]
			get
			{
				return null;
			}
		}

		public bool IsExclusive
		{
			[Address(RVA="0xF5AA64", Offset="0xF5AA64", VA="0xF5AA64")]
			get
			{
				return new bool();
			}
		}

		public string LargeIcon
		{
			[Address(RVA="0xF5AA24", Offset="0xF5AA24", VA="0xF5AA24")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF5A9DC", Offset="0xF5A9DC", VA="0xF5A9DC")]
			get
			{
				return null;
			}
		}

		public InventoryItemRecipe? Recipe
		{
			[Address(RVA="0xF5AA3C", Offset="0xF5AA3C", VA="0xF5AA3C")]
			get
			{
				return null;
			}
		}

		public int ShipmentSort
		{
			[Address(RVA="0xF5AAC4", Offset="0xF5AAC4", VA="0xF5AAC4")]
			get
			{
				return new int();
			}
		}

		public InventoryItemSubData SubDataType
		{
			[Address(RVA="0xF5AA5C", Offset="0xF5AA5C", VA="0xF5AA5C")]
			get
			{
				return new InventoryItemSubData();
			}
		}

		public InventoryItemType Type
		{
			[Address(RVA="0xF5A9D4", Offset="0xF5A9D4", VA="0xF5A9D4")]
			get
			{
				return new InventoryItemType();
			}
		}

		public string UnavailableKey
		{
			[Address(RVA="0xF5AAA4", Offset="0xF5AAA4", VA="0xF5AAA4")]
			get
			{
				return null;
			}
		}

		public string WideIcon
		{
			[Address(RVA="0xF5AA6C", Offset="0xF5AA6C", VA="0xF5AA6C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF5A9B4", Offset="0xF5A9B4", VA="0xF5A9B4")]
		public InventoryItem __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItem();
		}

		[Address(RVA="0xF5A9A8", Offset="0xF5A9A8", VA="0xF5A9A8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2517960", Offset="0x2517960", VA="0x2517960")]
		public static void AddBuyAndEquipCost(FlatBufferBuilder builder, Offset<ItemCount> buyAndEquipCostOffset)
		{
		}

		[Address(RVA="0x2517CA8", Offset="0x2517CA8", VA="0x2517CA8")]
		public static void AddCanBeDonated(FlatBufferBuilder builder, bool canBeDonated)
		{
		}

		[Address(RVA="0x25178E8", Offset="0x25178E8", VA="0x25178E8")]
		public static void AddColorId(FlatBufferBuilder builder, uint colorId)
		{
		}

		[Address(RVA="0x2517A50", Offset="0x2517A50", VA="0x2517A50")]
		public static void AddCosts(FlatBufferBuilder builder, VectorOffset costsOffset)
		{
		}

		[Address(RVA="0x2517BF4", Offset="0x2517BF4", VA="0x2517BF4")]
		public static void AddDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation deepLinkLocation)
		{
		}

		[Address(RVA="0x2517870", Offset="0x2517870", VA="0x2517870")]
		public static void AddDeepLinkSublocation(FlatBufferBuilder builder, StringOffset deepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x2517B40", Offset="0x2517B40", VA="0x2517B40")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x2517BB8", Offset="0x2517BB8", VA="0x2517BB8")]
		public static void AddGetMoreDeepLinkLocation(FlatBufferBuilder builder, Gamedata.DeepLinkLocation getMoreDeepLinkLocation)
		{
		}

		[Address(RVA="0x2517834", Offset="0x2517834", VA="0x2517834")]
		public static void AddGetMoreDeepLinkSublocation(FlatBufferBuilder builder, StringOffset getMoreDeepLinkSublocationOffset)
		{
		}

		[Address(RVA="0x2517B04", Offset="0x2517B04", VA="0x2517B04")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x25177F8", Offset="0x25177F8", VA="0x25177F8")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x251799C", Offset="0x251799C", VA="0x251799C")]
		public static void AddInsufficientCountKey(FlatBufferBuilder builder, StringOffset insufficientCountKeyOffset)
		{
		}

		[Address(RVA="0x2517C30", Offset="0x2517C30", VA="0x2517C30")]
		public static void AddIsExclusive(FlatBufferBuilder builder, bool isExclusive)
		{
		}

		[Address(RVA="0x2517AC8", Offset="0x2517AC8", VA="0x2517AC8")]
		public static void AddLargeIcon(FlatBufferBuilder builder, StringOffset largeIconOffset)
		{
		}

		[Address(RVA="0x2517B7C", Offset="0x2517B7C", VA="0x2517B7C")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x2517A8C", Offset="0x2517A8C", VA="0x2517A8C")]
		public static void AddRecipe(FlatBufferBuilder builder, Offset<InventoryItemRecipe> recipeOffset)
		{
		}

		[Address(RVA="0x25178AC", Offset="0x25178AC", VA="0x25178AC")]
		public static void AddShipmentSort(FlatBufferBuilder builder, int shipmentSort)
		{
		}

		[Address(RVA="0x2517A14", Offset="0x2517A14", VA="0x2517A14")]
		public static void AddSubData(FlatBufferBuilder builder, int subDataOffset)
		{
		}

		[Address(RVA="0x2517C6C", Offset="0x2517C6C", VA="0x2517C6C")]
		public static void AddSubDataType(FlatBufferBuilder builder, InventoryItemSubData subDataType)
		{
		}

		[Address(RVA="0x2517CE4", Offset="0x2517CE4", VA="0x2517CE4")]
		public static void AddType(FlatBufferBuilder builder, InventoryItemType type)
		{
		}

		[Address(RVA="0x2517924", Offset="0x2517924", VA="0x2517924")]
		public static void AddUnavailableKey(FlatBufferBuilder builder, StringOffset unavailableKeyOffset)
		{
		}

		[Address(RVA="0x25179D8", Offset="0x25179D8", VA="0x25179D8")]
		public static void AddWideIcon(FlatBufferBuilder builder, StringOffset wideIconOffset)
		{
		}

		[Address(RVA="0xF5AA44", Offset="0xF5AA44", VA="0xF5AA44")]
		public ItemCount? Costs(int j)
		{
			return null;
		}

		[Address(RVA="0x2517DD0", Offset="0x2517DD0", VA="0x2517DD0")]
		public static VectorOffset CreateCostsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x2517604", Offset="0x2517604", VA="0x2517604")]
		public static Offset<InventoryItem> CreateInventoryItem(FlatBufferBuilder builder, ulong id = 0L, InventoryItemType type = 0, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.InventoryItem> Gamedata.InventoryItem::CreateInventoryItem(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.InventoryItemType,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.InventoryItemRecipe>,FlatBuffers.VectorOffset,System.Boolean,Gamedata.InventoryItemSubData,System.Int32,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset`1<Gamedata.ItemCount>,FlatBuffers.StringOffset,System.UInt32,System.Int32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.InventoryItem> CreateInventoryItem(FlatBuffers.FlatBufferBuilder,System.UInt64,Gamedata.InventoryItemType,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.InventoryItemRecipe>,FlatBuffers.VectorOffset,System.Boolean,Gamedata.InventoryItemSubData,System.Int32,System.Boolean,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.Offset<Gamedata.ItemCount>,FlatBuffers.StringOffset,System.UInt32,System.Int32,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset,Gamedata.DeepLinkLocation,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2517D20", Offset="0x2517D20", VA="0x2517D20")]
		public static Offset<InventoryItem> EndInventoryItem(FlatBufferBuilder builder)
		{
			return new Offset<InventoryItem>();
		}

		[Address(RVA="0x2517F04", Offset="0x2517F04", VA="0x2517F04")]
		public static void FinishInventoryItemBuffer(FlatBufferBuilder builder, Offset<InventoryItem> offset)
		{
		}

		[Address(RVA="0xF5AADC", Offset="0xF5AADC", VA="0xF5AADC")]
		public ArraySegment<byte>? GetDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A9FC", Offset="0xF5A9FC", VA="0xF5A9FC")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AAFC", Offset="0xF5AAFC", VA="0xF5AAFC")]
		public ArraySegment<byte>? GetGetMoreDeepLinkSublocationBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AA14", Offset="0xF5AA14", VA="0xF5AA14")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AA8C", Offset="0xF5AA8C", VA="0xF5AA8C")]
		public ArraySegment<byte>? GetInsufficientCountKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AA2C", Offset="0xF5AA2C", VA="0xF5AA2C")]
		public ArraySegment<byte>? GetLargeIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF5A9E4", Offset="0xF5A9E4", VA="0xF5A9E4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x2516BFC", Offset="0x2516BFC", VA="0x2516BFC")]
		public static InventoryItem GetRootAsInventoryItem(FlatBuffers.ByteBuffer _bb)
		{
			return new InventoryItem();
		}

		[Address(RVA="0x2516C08", Offset="0x2516C08", VA="0x2516C08")]
		public static InventoryItem GetRootAsInventoryItem(FlatBuffers.ByteBuffer _bb, InventoryItem obj)
		{
			return new InventoryItem();
		}

		[Address(RVA="0xF5AAAC", Offset="0xF5AAAC", VA="0xF5AAAC")]
		public ArraySegment<byte>? GetUnavailableKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF5AA74", Offset="0xF5AA74", VA="0xF5AA74")]
		public ArraySegment<byte>? GetWideIconBytes()
		{
			return null;
		}

		[Address(RVA="0x2517EC8", Offset="0x2517EC8", VA="0x2517EC8")]
		public static void StartCostsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2517DA0", Offset="0x2517DA0", VA="0x2517DA0")]
		public static void StartInventoryItem(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0xF22828", Offset="0xF22828", VA="0xF22828")]
		public Nullable<TTable> SubData<TTable>()
		where TTable : struct, IFlatbufferObject
		{
			return null;
		}
	}
}