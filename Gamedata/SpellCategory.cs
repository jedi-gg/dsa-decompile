using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SpellCategory : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59318", Offset="0xF59318", VA="0xF59318", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF59344", Offset="0xF59344", VA="0xF59344")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF5934C", Offset="0xF5934C", VA="0xF5934C")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF59364", Offset="0xF59364", VA="0xF59364")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5932C", Offset="0xF5932C", VA="0xF5932C")]
		public SpellCategory __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SpellCategory();
		}

		[Address(RVA="0xF59320", Offset="0xF59320", VA="0xF59320", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EE020", Offset="0x24EE020", VA="0x24EE020")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24EE098", Offset="0x24EE098", VA="0x24EE098")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24EE05C", Offset="0x24EE05C", VA="0x24EE05C")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x24EDFA8", Offset="0x24EDFA8", VA="0x24EDFA8")]
		public static Offset<SpellCategory> CreateSpellCategory(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SpellCategory> Gamedata.SpellCategory::CreateSpellCategory(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SpellCategory> CreateSpellCategory(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EE0D4", Offset="0x24EE0D4", VA="0x24EE0D4")]
		public static Offset<SpellCategory> EndSpellCategory(FlatBufferBuilder builder)
		{
			return new Offset<SpellCategory>();
		}

		[Address(RVA="0x24EE184", Offset="0x24EE184", VA="0x24EE184")]
		public static void FinishSpellCategoryBuffer(FlatBufferBuilder builder, Offset<SpellCategory> offset)
		{
		}

		[Address(RVA="0xF59354", Offset="0xF59354", VA="0xF59354")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24EDDA8", Offset="0x24EDDA8", VA="0x24EDDA8")]
		public static SpellCategory GetRootAsSpellCategory(FlatBuffers.ByteBuffer _bb)
		{
			return new SpellCategory();
		}

		[Address(RVA="0x24EDDB4", Offset="0x24EDDB4", VA="0x24EDDB4")]
		public static SpellCategory GetRootAsSpellCategory(FlatBuffers.ByteBuffer _bb, SpellCategory obj)
		{
			return new SpellCategory();
		}

		[Address(RVA="0x24EE154", Offset="0x24EE154", VA="0x24EE154")]
		public static void StartSpellCategory(FlatBufferBuilder builder)
		{
		}
	}
}