using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMap : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A3B0", Offset="0xF0A3B0", VA="0xF0A3B0", Slot="5")]
			get
			{
				return null;
			}
		}

		public BattleMapEncounters? Encounters
		{
			[Address(RVA="0xF0A3F4", Offset="0xF0A3F4", VA="0xF0A3F4")]
			get
			{
				return null;
			}
		}

		public float GridScale
		{
			[Address(RVA="0xF0A40C", Offset="0xF0A40C", VA="0xF0A40C")]
			get
			{
				return new float();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0A3DC", Offset="0xF0A3DC", VA="0xF0A3DC")]
			get
			{
				return new ulong();
			}
		}

		public int ObstructionsLength
		{
			[Address(RVA="0xF0A404", Offset="0xF0A404", VA="0xF0A404")]
			get
			{
				return new int();
			}
		}

		public float SizeX
		{
			[Address(RVA="0xF0A3E4", Offset="0xF0A3E4", VA="0xF0A3E4")]
			get
			{
				return new float();
			}
		}

		public float SizeY
		{
			[Address(RVA="0xF0A3EC", Offset="0xF0A3EC", VA="0xF0A3EC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0A3C4", Offset="0xF0A3C4", VA="0xF0A3C4")]
		public BattleMap __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMap();
		}

		[Address(RVA="0xF0A3B8", Offset="0xF0A3B8", VA="0xF0A3B8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F1758", Offset="0x15F1758", VA="0x15F1758")]
		public static void AddEncounters(FlatBufferBuilder builder, Offset<BattleMapEncounters> encountersOffset)
		{
		}

		[Address(RVA="0x15F16D8", Offset="0x15F16D8", VA="0x15F16D8")]
		public static void AddGridScale(FlatBufferBuilder builder, float gridScale)
		{
		}

		[Address(RVA="0x15F169C", Offset="0x15F169C", VA="0x15F169C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x15F171C", Offset="0x15F171C", VA="0x15F171C")]
		public static void AddObstructions(FlatBufferBuilder builder, VectorOffset obstructionsOffset)
		{
		}

		[Address(RVA="0x15F17D8", Offset="0x15F17D8", VA="0x15F17D8")]
		public static void AddSizeX(FlatBufferBuilder builder, float sizeX)
		{
		}

		[Address(RVA="0x15F1794", Offset="0x15F1794", VA="0x15F1794")]
		public static void AddSizeY(FlatBufferBuilder builder, float sizeY)
		{
		}

		[Address(RVA="0x15F15E4", Offset="0x15F15E4", VA="0x15F15E4")]
		public static Offset<BattleMap> CreateBattleMap(FlatBufferBuilder builder, ulong id = 0L, float size_x = 0f, float size_y = 0f, Offset<BattleMapEncounters> encountersOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleMap> Gamedata.BattleMap::CreateBattleMap(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Single,System.Single,FlatBuffers.Offset`1<Gamedata.BattleMapEncounters>,FlatBuffers.VectorOffset,System.Single)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleMap> CreateBattleMap(FlatBuffers.FlatBufferBuilder,System.UInt64,System.Single,System.Single,FlatBuffers.Offset<Gamedata.BattleMapEncounters>,FlatBuffers.VectorOffset,System.Single)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F18CC", Offset="0x15F18CC", VA="0x15F18CC")]
		public static VectorOffset CreateObstructionsVector(FlatBufferBuilder builder, Offset<BattleMapObstruction>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x15F181C", Offset="0x15F181C", VA="0x15F181C")]
		public static Offset<BattleMap> EndBattleMap(FlatBufferBuilder builder)
		{
			return new Offset<BattleMap>();
		}

		[Address(RVA="0x15F1A00", Offset="0x15F1A00", VA="0x15F1A00")]
		public static void FinishBattleMapBuffer(FlatBufferBuilder builder, Offset<BattleMap> offset)
		{
		}

		[Address(RVA="0x15F117C", Offset="0x15F117C", VA="0x15F117C")]
		public static BattleMap GetRootAsBattleMap(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMap();
		}

		[Address(RVA="0x15F1188", Offset="0x15F1188", VA="0x15F1188")]
		public static BattleMap GetRootAsBattleMap(FlatBuffers.ByteBuffer _bb, BattleMap obj)
		{
			return new BattleMap();
		}

		[Address(RVA="0xF0A3FC", Offset="0xF0A3FC", VA="0xF0A3FC")]
		public BattleMapObstruction? Obstructions(int j)
		{
			return null;
		}

		[Address(RVA="0x15F189C", Offset="0x15F189C", VA="0x15F189C")]
		public static void StartBattleMap(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F19C4", Offset="0x15F19C4", VA="0x15F19C4")]
		public static void StartObstructionsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}