using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMapEncounterLoc : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A460", Offset="0xF0A460", VA="0xF0A460", Slot="5")]
			get
			{
				return null;
			}
		}

		public byte GridGap
		{
			[Address(RVA="0xF0A4BC", Offset="0xF0A4BC", VA="0xF0A4BC")]
			get
			{
				return new byte();
			}
		}

		public string Id
		{
			[Address(RVA="0xF0A48C", Offset="0xF0A48C", VA="0xF0A48C")]
			get
			{
				return null;
			}
		}

		public byte NumLanes
		{
			[Address(RVA="0xF0A4B4", Offset="0xF0A4B4", VA="0xF0A4B4")]
			get
			{
				return new byte();
			}
		}

		public float Verticality
		{
			[Address(RVA="0xF0A4C4", Offset="0xF0A4C4", VA="0xF0A4C4")]
			get
			{
				return new float();
			}
		}

		public float X
		{
			[Address(RVA="0xF0A4A4", Offset="0xF0A4A4", VA="0xF0A4A4")]
			get
			{
				return new float();
			}
		}

		public float Y
		{
			[Address(RVA="0xF0A4AC", Offset="0xF0A4AC", VA="0xF0A4AC")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0xF0A474", Offset="0xF0A474", VA="0xF0A474")]
		public BattleMapEncounterLoc __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapEncounterLoc();
		}

		[Address(RVA="0xF0A468", Offset="0xF0A468", VA="0xF0A468", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F1F3C", Offset="0x15F1F3C", VA="0x15F1F3C")]
		public static void AddGridGap(FlatBufferBuilder builder, byte gridGap)
		{
		}

		[Address(RVA="0x15F1F00", Offset="0x15F1F00", VA="0x15F1F00")]
		public static void AddId(FlatBufferBuilder builder, StringOffset idOffset)
		{
		}

		[Address(RVA="0x15F1F78", Offset="0x15F1F78", VA="0x15F1F78")]
		public static void AddNumLanes(FlatBufferBuilder builder, byte numLanes)
		{
		}

		[Address(RVA="0x15F1E34", Offset="0x15F1E34", VA="0x15F1E34")]
		public static void AddVerticality(FlatBufferBuilder builder, float verticality)
		{
		}

		[Address(RVA="0x15F1EBC", Offset="0x15F1EBC", VA="0x15F1EBC")]
		public static void AddX(FlatBufferBuilder builder, float x)
		{
		}

		[Address(RVA="0x15F1E78", Offset="0x15F1E78", VA="0x15F1E78")]
		public static void AddY(FlatBufferBuilder builder, float y)
		{
		}

		[Address(RVA="0x15F1D7C", Offset="0x15F1D7C", VA="0x15F1D7C")]
		public static Offset<BattleMapEncounterLoc> CreateBattleMapEncounterLoc(FlatBufferBuilder builder, StringOffset idOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleMapEncounterLoc> Gamedata.BattleMapEncounterLoc::CreateBattleMapEncounterLoc(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Single,System.Single,System.Byte,System.Byte,System.Single)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleMapEncounterLoc> CreateBattleMapEncounterLoc(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,System.Single,System.Single,System.Byte,System.Byte,System.Single)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F1FB4", Offset="0x15F1FB4", VA="0x15F1FB4")]
		public static Offset<BattleMapEncounterLoc> EndBattleMapEncounterLoc(FlatBufferBuilder builder)
		{
			return new Offset<BattleMapEncounterLoc>();
		}

		[Address(RVA="0xF0A494", Offset="0xF0A494", VA="0xF0A494")]
		public ArraySegment<byte>? GetIdBytes()
		{
			return null;
		}

		[Address(RVA="0x15F1A3C", Offset="0x15F1A3C", VA="0x15F1A3C")]
		public static BattleMapEncounterLoc GetRootAsBattleMapEncounterLoc(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapEncounterLoc();
		}

		[Address(RVA="0x15F1A48", Offset="0x15F1A48", VA="0x15F1A48")]
		public static BattleMapEncounterLoc GetRootAsBattleMapEncounterLoc(FlatBuffers.ByteBuffer _bb, BattleMapEncounterLoc obj)
		{
			return new BattleMapEncounterLoc();
		}

		[Address(RVA="0x15F2034", Offset="0x15F2034", VA="0x15F2034")]
		public static void StartBattleMapEncounterLoc(FlatBufferBuilder builder)
		{
		}
	}
}