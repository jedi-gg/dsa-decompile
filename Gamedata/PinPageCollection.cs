using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PinPageCollection : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57650", Offset="0xF57650", VA="0xF57650", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF57684", Offset="0xF57684", VA="0xF57684")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF5767C", Offset="0xF5767C", VA="0xF5767C")]
			get
			{
				return new ulong();
			}
		}

		public int PagesLength
		{
			[Address(RVA="0xF576C4", Offset="0xF576C4", VA="0xF576C4")]
			get
			{
				return new int();
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF576B4", Offset="0xF576B4", VA="0xF576B4")]
			get
			{
				return new int();
			}
		}

		public string Title
		{
			[Address(RVA="0xF5769C", Offset="0xF5769C", VA="0xF5769C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF57664", Offset="0xF57664", VA="0xF57664")]
		public PinPageCollection __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PinPageCollection();
		}

		[Address(RVA="0xF57658", Offset="0xF57658", VA="0xF57658", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DC38C", Offset="0x24DC38C", VA="0x24DC38C")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x24DC29C", Offset="0x24DC29C", VA="0x24DC29C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24DC2D8", Offset="0x24DC2D8", VA="0x24DC2D8")]
		public static void AddPages(FlatBufferBuilder builder, VectorOffset pagesOffset)
		{
		}

		[Address(RVA="0x24DC314", Offset="0x24DC314", VA="0x24DC314")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24DC350", Offset="0x24DC350", VA="0x24DC350")]
		public static void AddTitle(FlatBufferBuilder builder, StringOffset titleOffset)
		{
		}

		[Address(RVA="0x24DC478", Offset="0x24DC478", VA="0x24DC478")]
		public static VectorOffset CreatePagesVector(FlatBufferBuilder builder, Offset<PinPage>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DC1FC", Offset="0x24DC1FC", VA="0x24DC1FC")]
		public static Offset<PinPageCollection> CreatePinPageCollection(FlatBufferBuilder builder, ulong id = 0L, StringOffset iconOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PinPageCollection> Gamedata.PinPageCollection::CreatePinPageCollection(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PinPageCollection> CreatePinPageCollection(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.Int32,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DC3C8", Offset="0x24DC3C8", VA="0x24DC3C8")]
		public static Offset<PinPageCollection> EndPinPageCollection(FlatBufferBuilder builder)
		{
			return new Offset<PinPageCollection>();
		}

		[Address(RVA="0x24DC5AC", Offset="0x24DC5AC", VA="0x24DC5AC")]
		public static void FinishPinPageCollectionBuffer(FlatBufferBuilder builder, Offset<PinPageCollection> offset)
		{
		}

		[Address(RVA="0xF5768C", Offset="0xF5768C", VA="0xF5768C")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0x24DBE9C", Offset="0x24DBE9C", VA="0x24DBE9C")]
		public static PinPageCollection GetRootAsPinPageCollection(FlatBuffers.ByteBuffer _bb)
		{
			return new PinPageCollection();
		}

		[Address(RVA="0x24DBEA8", Offset="0x24DBEA8", VA="0x24DBEA8")]
		public static PinPageCollection GetRootAsPinPageCollection(FlatBuffers.ByteBuffer _bb, PinPageCollection obj)
		{
			return new PinPageCollection();
		}

		[Address(RVA="0xF576A4", Offset="0xF576A4", VA="0xF576A4")]
		public ArraySegment<byte>? GetTitleBytes()
		{
			return null;
		}

		[Address(RVA="0xF576BC", Offset="0xF576BC", VA="0xF576BC")]
		public PinPage? Pages(int j)
		{
			return null;
		}

		[Address(RVA="0x24DC570", Offset="0x24DC570", VA="0x24DC570")]
		public static void StartPagesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DC448", Offset="0x24DC448", VA="0x24DC448")]
		public static void StartPinPageCollection(FlatBufferBuilder builder)
		{
		}
	}
}