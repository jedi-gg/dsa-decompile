using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct SorcererStoneCollection : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF58F50", Offset="0xF58F50", VA="0xF58F50", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Icon
		{
			[Address(RVA="0xF58F9C", Offset="0xF58F9C", VA="0xF58F9C")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF58F7C", Offset="0xF58F7C", VA="0xF58F7C")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF58F84", Offset="0xF58F84", VA="0xF58F84")]
			get
			{
				return null;
			}
		}

		public int StonesLength
		{
			[Address(RVA="0xF58FBC", Offset="0xF58FBC", VA="0xF58FBC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF58F64", Offset="0xF58F64", VA="0xF58F64")]
		public SorcererStoneCollection __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new SorcererStoneCollection();
		}

		[Address(RVA="0xF58F58", Offset="0xF58F58", VA="0xF58F58", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24EB6C8", Offset="0x24EB6C8", VA="0x24EB6C8")]
		public static void AddIcon(FlatBufferBuilder builder, StringOffset iconOffset)
		{
		}

		[Address(RVA="0x24EB650", Offset="0x24EB650", VA="0x24EB650")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x24EB704", Offset="0x24EB704", VA="0x24EB704")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x24EB68C", Offset="0x24EB68C", VA="0x24EB68C")]
		public static void AddStones(FlatBufferBuilder builder, VectorOffset stonesOffset)
		{
		}

		[Address(RVA="0x24EB5C0", Offset="0x24EB5C0", VA="0x24EB5C0")]
		public static Offset<SorcererStoneCollection> CreateSorcererStoneCollection(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.SorcererStoneCollection> Gamedata.SorcererStoneCollection::CreateSorcererStoneCollection(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.SorcererStoneCollection> CreateSorcererStoneCollection(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.StringOffset,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24EB7F0", Offset="0x24EB7F0", VA="0x24EB7F0")]
		public static VectorOffset CreateStonesVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24EB740", Offset="0x24EB740", VA="0x24EB740")]
		public static Offset<SorcererStoneCollection> EndSorcererStoneCollection(FlatBufferBuilder builder)
		{
			return new Offset<SorcererStoneCollection>();
		}

		[Address(RVA="0x24EB924", Offset="0x24EB924", VA="0x24EB924")]
		public static void FinishSorcererStoneCollectionBuffer(FlatBufferBuilder builder, Offset<SorcererStoneCollection> offset)
		{
		}

		[Address(RVA="0xF58FA4", Offset="0xF58FA4", VA="0xF58FA4")]
		public ArraySegment<byte>? GetIconBytes()
		{
			return null;
		}

		[Address(RVA="0xF58F8C", Offset="0xF58F8C", VA="0xF58F8C")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x24EB2FC", Offset="0x24EB2FC", VA="0x24EB2FC")]
		public static SorcererStoneCollection GetRootAsSorcererStoneCollection(FlatBuffers.ByteBuffer _bb)
		{
			return new SorcererStoneCollection();
		}

		[Address(RVA="0x24EB308", Offset="0x24EB308", VA="0x24EB308")]
		public static SorcererStoneCollection GetRootAsSorcererStoneCollection(FlatBuffers.ByteBuffer _bb, SorcererStoneCollection obj)
		{
			return new SorcererStoneCollection();
		}

		[Address(RVA="0xF58FC4", Offset="0xF58FC4", VA="0xF58FC4")]
		public ArraySegment<byte>? GetStonesBytes()
		{
			return null;
		}

		[Address(RVA="0x24EB7C0", Offset="0x24EB7C0", VA="0x24EB7C0")]
		public static void StartSorcererStoneCollection(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24EB8E8", Offset="0x24EB8E8", VA="0x24EB8E8")]
		public static void StartStonesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF58FB4", Offset="0xF58FB4", VA="0xF58FB4")]
		public ulong Stones(int j)
		{
			return new ulong();
		}
	}
}