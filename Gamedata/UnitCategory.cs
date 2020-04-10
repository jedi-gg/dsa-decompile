using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct UnitCategory : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0B708", Offset="0xF0B708", VA="0xF0B708", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF0B75C", Offset="0xF0B75C", VA="0xF0B75C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0B734", Offset="0xF0B734", VA="0xF0B734")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0B73C", Offset="0xF0B73C", VA="0xF0B73C")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF0B754", Offset="0xF0B754", VA="0xF0B754")]
			get
			{
				return new int();
			}
		}

		public int StrongAgainstLength
		{
			[Address(RVA="0xF0B784", Offset="0xF0B784", VA="0xF0B784")]
			get
			{
				return new int();
			}
		}

		public UnitCategoryType Type
		{
			[Address(RVA="0xF0B774", Offset="0xF0B774", VA="0xF0B774")]
			get
			{
				return new UnitCategoryType();
			}
		}

		public int WeakAgainstLength
		{
			[Address(RVA="0xF0B7A4", Offset="0xF0B7A4", VA="0xF0B7A4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0B71C", Offset="0xF0B71C", VA="0xF0B71C")]
		public UnitCategory __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new UnitCategory();
		}

		[Address(RVA="0xF0B710", Offset="0xF0B710", VA="0xF0B710", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x1679C0C", Offset="0x1679C0C", VA="0x1679C0C")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x1679B58", Offset="0x1679B58", VA="0x1679B58")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x1679C84", Offset="0x1679C84", VA="0x1679C84")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x1679C48", Offset="0x1679C48", VA="0x1679C48")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x1679BD0", Offset="0x1679BD0", VA="0x1679BD0")]
		public static void AddStrongAgainst(FlatBufferBuilder builder, VectorOffset strongAgainstOffset)
		{
		}

		[Address(RVA="0x1679CC0", Offset="0x1679CC0", VA="0x1679CC0")]
		public static void AddType(FlatBufferBuilder builder, UnitCategoryType type)
		{
		}

		[Address(RVA="0x1679B94", Offset="0x1679B94", VA="0x1679B94")]
		public static void AddWeakAgainst(FlatBufferBuilder builder, VectorOffset weakAgainstOffset)
		{
		}

		[Address(RVA="0x1679DAC", Offset="0x1679DAC", VA="0x1679DAC")]
		public static VectorOffset CreateStrongAgainstVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1679A90", Offset="0x1679A90", VA="0x1679A90")]
		public static Offset<UnitCategory> CreateUnitCategory(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.UnitCategory> Gamedata.UnitCategory::CreateUnitCategory(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32,FlatBuffers.StringOffset,Gamedata.UnitCategoryType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.UnitCategory> CreateUnitCategory(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32,FlatBuffers.StringOffset,Gamedata.UnitCategoryType,FlatBuffers.VectorOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1679EE0", Offset="0x1679EE0", VA="0x1679EE0")]
		public static VectorOffset CreateWeakAgainstVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x1679CFC", Offset="0x1679CFC", VA="0x1679CFC")]
		public static Offset<UnitCategory> EndUnitCategory(FlatBufferBuilder builder)
		{
			return new Offset<UnitCategory>();
		}

		[Address(RVA="0x167A014", Offset="0x167A014", VA="0x167A014")]
		public static void FinishUnitCategoryBuffer(FlatBufferBuilder builder, Offset<UnitCategory> offset)
		{
		}

		[Address(RVA="0xF0B764", Offset="0xF0B764", VA="0xF0B764")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B744", Offset="0xF0B744", VA="0xF0B744")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x1679628", Offset="0x1679628", VA="0x1679628")]
		public static UnitCategory GetRootAsUnitCategory(FlatBuffers.ByteBuffer _bb)
		{
			return new UnitCategory();
		}

		[Address(RVA="0x1679634", Offset="0x1679634", VA="0x1679634")]
		public static UnitCategory GetRootAsUnitCategory(FlatBuffers.ByteBuffer _bb, UnitCategory obj)
		{
			return new UnitCategory();
		}

		[Address(RVA="0xF0B78C", Offset="0xF0B78C", VA="0xF0B78C")]
		public ArraySegment<byte>? GetStrongAgainstBytes()
		{
			return null;
		}

		[Address(RVA="0xF0B7AC", Offset="0xF0B7AC", VA="0xF0B7AC")]
		public ArraySegment<byte>? GetWeakAgainstBytes()
		{
			return null;
		}

		[Address(RVA="0x1679EA4", Offset="0x1679EA4", VA="0x1679EA4")]
		public static void StartStrongAgainstVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x1679D7C", Offset="0x1679D7C", VA="0x1679D7C")]
		public static void StartUnitCategory(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x1679FD8", Offset="0x1679FD8", VA="0x1679FD8")]
		public static void StartWeakAgainstVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF0B77C", Offset="0xF0B77C", VA="0xF0B77C")]
		public ulong StrongAgainst(int j)
		{
			return new ulong();
		}

		[Address(RVA="0xF0B79C", Offset="0xF0B79C", VA="0xF0B79C")]
		public ulong WeakAgainst(int j)
		{
			return new ulong();
		}
	}
}