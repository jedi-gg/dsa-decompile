using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreTabDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B178", Offset="0xF3B178", VA="0xF3B178", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF3B1C4", Offset="0xF3B1C4", VA="0xF3B1C4")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3B1A4", Offset="0xF3B1A4", VA="0xF3B1A4")]
			get
			{
				return new ulong();
			}
		}

		public StoreItemSize ItemSize
		{
			[Address(RVA="0xF3B1E4", Offset="0xF3B1E4", VA="0xF3B1E4")]
			get
			{
				return new StoreItemSize();
			}
		}

		public int ItemsLength
		{
			[Address(RVA="0xF3B1F4", Offset="0xF3B1F4", VA="0xF3B1F4")]
			get
			{
				return new int();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF3B1AC", Offset="0xF3B1AC", VA="0xF3B1AC")]
			get
			{
				return null;
			}
		}

		public int ShowcaseItemsLength
		{
			[Address(RVA="0xF3B214", Offset="0xF3B214", VA="0xF3B214")]
			get
			{
				return new int();
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF3B1DC", Offset="0xF3B1DC", VA="0xF3B1DC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3B18C", Offset="0xF3B18C", VA="0xF3B18C")]
		public StoreTabDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreTabDef();
		}

		[Address(RVA="0xF3B180", Offset="0xF3B180", VA="0xF3B180", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22EB0E4", Offset="0x22EB0E4", VA="0x22EB0E4")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x22EAFF4", Offset="0x22EAFF4", VA="0x22EAFF4")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22EB06C", Offset="0x22EB06C", VA="0x22EB06C")]
		public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset)
		{
		}

		[Address(RVA="0x22EB15C", Offset="0x22EB15C", VA="0x22EB15C")]
		public static void AddItemSize(FlatBufferBuilder builder, StoreItemSize itemSize)
		{
		}

		[Address(RVA="0x22EB120", Offset="0x22EB120", VA="0x22EB120")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x22EB030", Offset="0x22EB030", VA="0x22EB030")]
		public static void AddShowcaseItems(FlatBufferBuilder builder, VectorOffset showcaseItemsOffset)
		{
		}

		[Address(RVA="0x22EB0A8", Offset="0x22EB0A8", VA="0x22EB0A8")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x22EB248", Offset="0x22EB248", VA="0x22EB248")]
		public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EB37C", Offset="0x22EB37C", VA="0x22EB37C")]
		public static VectorOffset CreateShowcaseItemsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EAF2C", Offset="0x22EAF2C", VA="0x22EAF2C")]
		public static Offset<StoreTabDef> CreateStoreTabDef(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreTabDef> Gamedata.StoreTabDef::CreateStoreTabDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,Gamedata.StoreItemSize,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreTabDef> CreateStoreTabDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,Gamedata.StoreItemSize,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22EB198", Offset="0x22EB198", VA="0x22EB198")]
		public static Offset<StoreTabDef> EndStoreTabDef(FlatBufferBuilder builder)
		{
			return new Offset<StoreTabDef>();
		}

		[Address(RVA="0x22EB4B0", Offset="0x22EB4B0", VA="0x22EB4B0")]
		public static void FinishStoreTabDefBuffer(FlatBufferBuilder builder, Offset<StoreTabDef> offset)
		{
		}

		[Address(RVA="0xF3B1CC", Offset="0xF3B1CC", VA="0xF3B1CC")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B1FC", Offset="0xF3B1FC", VA="0xF3B1FC")]
		public ArraySegment<byte>? GetItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B1B4", Offset="0xF3B1B4", VA="0xF3B1B4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x22EAAC4", Offset="0x22EAAC4", VA="0x22EAAC4")]
		public static StoreTabDef GetRootAsStoreTabDef(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreTabDef();
		}

		[Address(RVA="0x22EAAD0", Offset="0x22EAAD0", VA="0x22EAAD0")]
		public static StoreTabDef GetRootAsStoreTabDef(FlatBuffers.ByteBuffer _bb, StoreTabDef obj)
		{
			return new StoreTabDef();
		}

		[Address(RVA="0xF3B21C", Offset="0xF3B21C", VA="0xF3B21C")]
		public ArraySegment<byte>? GetShowcaseItemsBytes()
		{
			return null;
		}

		[Address(RVA="0xF3B1EC", Offset="0xF3B1EC", VA="0xF3B1EC")]
		public ulong Items(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF3B20C", Offset="0xF3B20C", VA="0xF3B20C")]
		public ulong ShowcaseItems(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x22EB340", Offset="0x22EB340", VA="0x22EB340")]
		public static void StartItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EB474", Offset="0x22EB474", VA="0x22EB474")]
		public static void StartShowcaseItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EB218", Offset="0x22EB218", VA="0x22EB218")]
		public static void StartStoreTabDef(FlatBufferBuilder builder)
		{
		}
	}
}