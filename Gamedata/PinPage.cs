using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PinPage : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF575C0", Offset="0xF575C0", VA="0xF575C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public PinPageLayout Layout
		{
			[Address(RVA="0xF575EC", Offset="0xF575EC", VA="0xF575EC")]
			get
			{
				return new PinPageLayout();
			}
		}

		public int PinItemsLength
		{
			[Address(RVA="0xF575FC", Offset="0xF575FC", VA="0xF575FC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF575D4", Offset="0xF575D4", VA="0xF575D4")]
		public PinPage __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PinPage();
		}

		[Address(RVA="0xF575C8", Offset="0xF575C8", VA="0xF575C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DBC74", Offset="0x24DBC74", VA="0x24DBC74")]
		public static void AddLayout(FlatBufferBuilder builder, PinPageLayout layout)
		{
		}

		[Address(RVA="0x24DBC38", Offset="0x24DBC38", VA="0x24DBC38")]
		public static void AddPinItems(FlatBufferBuilder builder, VectorOffset pinItemsOffset)
		{
		}

		[Address(RVA="0x24DBD60", Offset="0x24DBD60", VA="0x24DBD60")]
		public static VectorOffset CreatePinItemsVector(FlatBufferBuilder builder, Offset<PinPageItem>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DBBD0", Offset="0x24DBBD0", VA="0x24DBBD0")]
		public static Offset<PinPage> CreatePinPage(FlatBufferBuilder builder, PinPageLayout layout = 0, VectorOffset pin_itemsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PinPage> Gamedata.PinPage::CreatePinPage(FlatBuffers.FlatBufferBuilder,Gamedata.PinPageLayout,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PinPage> CreatePinPage(FlatBuffers.FlatBufferBuilder,Gamedata.PinPageLayout,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DBCB0", Offset="0x24DBCB0", VA="0x24DBCB0")]
		public static Offset<PinPage> EndPinPage(FlatBufferBuilder builder)
		{
			return new Offset<PinPage>();
		}

		[Address(RVA="0x24DB974", Offset="0x24DB974", VA="0x24DB974")]
		public static PinPage GetRootAsPinPage(FlatBuffers.ByteBuffer _bb)
		{
			return new PinPage();
		}

		[Address(RVA="0x24DB980", Offset="0x24DB980", VA="0x24DB980")]
		public static PinPage GetRootAsPinPage(FlatBuffers.ByteBuffer _bb, PinPage obj)
		{
			return new PinPage();
		}

		[Address(RVA="0xF575F4", Offset="0xF575F4", VA="0xF575F4")]
		public PinPageItem? PinItems(int j)
		{
			return null;
		}

		[Address(RVA="0x24DBE58", Offset="0x24DBE58", VA="0x24DBE58")]
		public static void StartPinItemsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DBD30", Offset="0x24DBD30", VA="0x24DBD30")]
		public static void StartPinPage(FlatBufferBuilder builder)
		{
		}
	}
}