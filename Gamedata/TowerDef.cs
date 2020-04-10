using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct TowerDef : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3B308", Offset="0xF3B308", VA="0xF3B308", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF3B334", Offset="0xF3B334", VA="0xF3B334")]
			get
			{
				return new ulong();
			}
		}

		public int MapsLength
		{
			[Address(RVA="0xF3B35C", Offset="0xF3B35C", VA="0xF3B35C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF3B33C", Offset="0xF3B33C", VA="0xF3B33C")]
			get
			{
				return null;
			}
		}

		public int SortOrder
		{
			[Address(RVA="0xF3B364", Offset="0xF3B364", VA="0xF3B364")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3B31C", Offset="0xF3B31C", VA="0xF3B31C")]
		public TowerDef __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new TowerDef();
		}

		[Address(RVA="0xF3B310", Offset="0xF3B310", VA="0xF3B310", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22EBC98", Offset="0x22EBC98", VA="0x22EBC98")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x22EBD10", Offset="0x22EBD10", VA="0x22EBD10")]
		public static void AddMaps(FlatBufferBuilder builder, VectorOffset mapsOffset)
		{
		}

		[Address(RVA="0x22EBD4C", Offset="0x22EBD4C", VA="0x22EBD4C")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x22EBCD4", Offset="0x22EBCD4", VA="0x22EBCD4")]
		public static void AddSortOrder(FlatBufferBuilder builder, int sortOrder)
		{
		}

		[Address(RVA="0x22EBE38", Offset="0x22EBE38", VA="0x22EBE38")]
		public static VectorOffset CreateMapsVector(FlatBufferBuilder builder, Offset<TowerMap>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22EBC08", Offset="0x22EBC08", VA="0x22EBC08")]
		public static Offset<TowerDef> CreateTowerDef(FlatBufferBuilder builder, ulong id = 0L, StringOffset requirementOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.TowerDef> Gamedata.TowerDef::CreateTowerDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.TowerDef> CreateTowerDef(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22EBD88", Offset="0x22EBD88", VA="0x22EBD88")]
		public static Offset<TowerDef> EndTowerDef(FlatBufferBuilder builder)
		{
			return new Offset<TowerDef>();
		}

		[Address(RVA="0x22EBF6C", Offset="0x22EBF6C", VA="0x22EBF6C")]
		public static void FinishTowerDefBuffer(FlatBufferBuilder builder, Offset<TowerDef> offset)
		{
		}

		[Address(RVA="0xF3B344", Offset="0xF3B344", VA="0xF3B344")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x22EB8E8", Offset="0x22EB8E8", VA="0x22EB8E8")]
		public static TowerDef GetRootAsTowerDef(FlatBuffers.ByteBuffer _bb)
		{
			return new TowerDef();
		}

		[Address(RVA="0x22EB8F4", Offset="0x22EB8F4", VA="0x22EB8F4")]
		public static TowerDef GetRootAsTowerDef(FlatBuffers.ByteBuffer _bb, TowerDef obj)
		{
			return new TowerDef();
		}

		[Address(RVA="0xF3B354", Offset="0xF3B354", VA="0xF3B354")]
		public TowerMap? Maps(int j)
		{
			return null;
		}

		[Address(RVA="0x22EBF30", Offset="0x22EBF30", VA="0x22EBF30")]
		public static void StartMapsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22EBE08", Offset="0x22EBE08", VA="0x22EBE08")]
		public static void StartTowerDef(FlatBufferBuilder builder)
		{
		}
	}
}