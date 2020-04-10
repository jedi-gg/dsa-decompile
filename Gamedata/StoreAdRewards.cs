using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct StoreAdRewards : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF3AA80", Offset="0xF3AA80", VA="0xF3AA80", Slot="5")]
			get
			{
				return null;
			}
		}

		public int EntriesLength
		{
			[Address(RVA="0xF3AAB4", Offset="0xF3AAB4", VA="0xF3AAB4")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF3AA94", Offset="0xF3AA94", VA="0xF3AA94")]
		public StoreAdRewards __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new StoreAdRewards();
		}

		[Address(RVA="0xF3AA88", Offset="0xF3AA88", VA="0xF3AA88", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x22E5FA0", Offset="0x22E5FA0", VA="0x22E5FA0")]
		public static void AddEntries(FlatBufferBuilder builder, VectorOffset entriesOffset)
		{
		}

		[Address(RVA="0x22E608C", Offset="0x22E608C", VA="0x22E608C")]
		public static VectorOffset CreateEntriesVector(FlatBufferBuilder builder, Offset<StoreAdRewardEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x22E5F50", Offset="0x22E5F50", VA="0x22E5F50")]
		public static Offset<StoreAdRewards> CreateStoreAdRewards(FlatBufferBuilder builder, VectorOffset entriesOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.StoreAdRewards> Gamedata.StoreAdRewards::CreateStoreAdRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.StoreAdRewards> CreateStoreAdRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x22E5FDC", Offset="0x22E5FDC", VA="0x22E5FDC")]
		public static Offset<StoreAdRewards> EndStoreAdRewards(FlatBufferBuilder builder)
		{
			return new Offset<StoreAdRewards>();
		}

		[Address(RVA="0xF3AAAC", Offset="0xF3AAAC", VA="0xF3AAAC")]
		public StoreAdRewardEntry? Entries(int j)
		{
			return null;
		}

		[Address(RVA="0x22E5D74", Offset="0x22E5D74", VA="0x22E5D74")]
		public static StoreAdRewards GetRootAsStoreAdRewards(FlatBuffers.ByteBuffer _bb)
		{
			return new StoreAdRewards();
		}

		[Address(RVA="0x22E5D80", Offset="0x22E5D80", VA="0x22E5D80")]
		public static StoreAdRewards GetRootAsStoreAdRewards(FlatBuffers.ByteBuffer _bb, StoreAdRewards obj)
		{
			return new StoreAdRewards();
		}

		[Address(RVA="0x22E6184", Offset="0x22E6184", VA="0x22E6184")]
		public static void StartEntriesVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x22E605C", Offset="0x22E605C", VA="0x22E605C")]
		public static void StartStoreAdRewards(FlatBufferBuilder builder)
		{
		}
	}
}