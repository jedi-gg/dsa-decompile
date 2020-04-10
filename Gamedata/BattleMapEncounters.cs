using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct BattleMapEncounters : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0A518", Offset="0xF0A518", VA="0xF0A518", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EncountersLength
		{
			[Address(RVA="0xF0A54C", Offset="0xF0A54C", VA="0xF0A54C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF0A52C", Offset="0xF0A52C", VA="0xF0A52C")]
		public BattleMapEncounters __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapEncounters();
		}

		[Address(RVA="0xF0A520", Offset="0xF0A520", VA="0xF0A520", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15F2280", Offset="0x15F2280", VA="0x15F2280")]
		public static void AddEncounters(FlatBufferBuilder builder, VectorOffset encountersOffset)
		{
		}

		[Address(RVA="0x15F2230", Offset="0x15F2230", VA="0x15F2230")]
		public static Offset<BattleMapEncounters> CreateBattleMapEncounters(FlatBufferBuilder builder, VectorOffset encountersOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.BattleMapEncounters> Gamedata.BattleMapEncounters::CreateBattleMapEncounters(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.BattleMapEncounters> CreateBattleMapEncounters(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x15F236C", Offset="0x15F236C", VA="0x15F236C")]
		public static VectorOffset CreateEncountersVector(FlatBufferBuilder builder, Offset<BattleMapEncounterLoc>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0xF0A544", Offset="0xF0A544", VA="0xF0A544")]
		public BattleMapEncounterLoc? Encounters(int j)
		{
			return null;
		}

		[Address(RVA="0x15F22BC", Offset="0x15F22BC", VA="0x15F22BC")]
		public static Offset<BattleMapEncounters> EndBattleMapEncounters(FlatBufferBuilder builder)
		{
			return new Offset<BattleMapEncounters>();
		}

		[Address(RVA="0x15F206C", Offset="0x15F206C", VA="0x15F206C")]
		public static BattleMapEncounters GetRootAsBattleMapEncounters(FlatBuffers.ByteBuffer _bb)
		{
			return new BattleMapEncounters();
		}

		[Address(RVA="0x15F2078", Offset="0x15F2078", VA="0x15F2078")]
		public static BattleMapEncounters GetRootAsBattleMapEncounters(FlatBuffers.ByteBuffer _bb, BattleMapEncounters obj)
		{
			return new BattleMapEncounters();
		}

		[Address(RVA="0x15F233C", Offset="0x15F233C", VA="0x15F233C")]
		public static void StartBattleMapEncounters(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x15F2464", Offset="0x15F2464", VA="0x15F2464")]
		public static void StartEncountersVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}