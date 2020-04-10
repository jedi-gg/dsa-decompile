using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct LevelBandedReward : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56340", Offset="0xF56340", VA="0xF56340", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EntriesLength
		{
			[Address(RVA="0xF56374", Offset="0xF56374", VA="0xF56374")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF56354", Offset="0xF56354", VA="0xF56354")]
		public LevelBandedReward __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedReward();
		}

		[Address(RVA="0xF56348", Offset="0xF56348", VA="0xF56348", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D2484", Offset="0x24D2484", VA="0x24D2484")]
		public static void AddEntries(FlatBufferBuilder builder, VectorOffset entriesOffset)
		{
		}

		[Address(RVA="0x24D2570", Offset="0x24D2570", VA="0x24D2570")]
		public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, Offset<LevelBandedRewardEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D2434", Offset="0x24D2434", VA="0x24D2434")]
		public static Offset<LevelBandedReward> CreateLevelBandedReward(FlatBufferBuilder builder, VectorOffset entriesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.LevelBandedReward> Gamedata.LevelBandedReward::CreateLevelBandedReward(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.LevelBandedReward> CreateLevelBandedReward(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D24C0", Offset="0x24D24C0", VA="0x24D24C0")]
		public static Offset<LevelBandedReward> EndLevelBandedReward(FlatBufferBuilder builder)
		{
			return new Offset<LevelBandedReward>();
		}

		[Address(RVA="0xF5636C", Offset="0xF5636C", VA="0xF5636C")]
		public LevelBandedRewardEntry? Entries(int j)
		{
			return null;
		}

		[Address(RVA="0x24D2240", Offset="0x24D2240", VA="0x24D2240")]
		public static LevelBandedReward GetRootAsLevelBandedReward(FlatBuffers.ByteBuffer _bb)
		{
			return new LevelBandedReward();
		}

		[Address(RVA="0x24D224C", Offset="0x24D224C", VA="0x24D224C")]
		public static LevelBandedReward GetRootAsLevelBandedReward(FlatBuffers.ByteBuffer _bb, LevelBandedReward obj)
		{
			return new LevelBandedReward();
		}

		[Address(RVA="0x24D2668", Offset="0x24D2668", VA="0x24D2668")]
		public static void StartEntriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24D2540", Offset="0x24D2540", VA="0x24D2540")]
		public static void StartLevelBandedReward(FlatBufferBuilder builder)
		{
		}
	}
}