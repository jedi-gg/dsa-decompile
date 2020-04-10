using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct KothRewards : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF56228", Offset="0xF56228", VA="0xF56228", Slot="5")]
			get
			{
				return null;
			}
		}

		public int KothRewardsListLength
		{
			[Address(RVA="0xF5625C", Offset="0xF5625C", VA="0xF5625C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF5623C", Offset="0xF5623C", VA="0xF5623C")]
		public KothRewards __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new KothRewards();
		}

		[Address(RVA="0xF56230", Offset="0xF56230", VA="0xF56230", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24D1AAC", Offset="0x24D1AAC", VA="0x24D1AAC")]
		public static void AddKothRewardsList(FlatBufferBuilder builder, VectorOffset kothRewardsListOffset)
		{
		}

		[Address(RVA="0x24D1A5C", Offset="0x24D1A5C", VA="0x24D1A5C")]
		public static Offset<KothRewards> CreateKothRewards(FlatBufferBuilder builder, VectorOffset koth_rewards_listOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.KothRewards> Gamedata.KothRewards::CreateKothRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.KothRewards> CreateKothRewards(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24D1B98", Offset="0x24D1B98", VA="0x24D1B98")]
		public static VectorOffset CreateKothRewardsListVector(FlatBufferBuilder builder, Offset<KothRewardEntry>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24D1AE8", Offset="0x24D1AE8", VA="0x24D1AE8")]
		public static Offset<KothRewards> EndKothRewards(FlatBufferBuilder builder)
		{
			return new Offset<KothRewards>();
		}

		[Address(RVA="0x24D1880", Offset="0x24D1880", VA="0x24D1880")]
		public static KothRewards GetRootAsKothRewards(FlatBuffers.ByteBuffer _bb)
		{
			return new KothRewards();
		}

		[Address(RVA="0x24D188C", Offset="0x24D188C", VA="0x24D188C")]
		public static KothRewards GetRootAsKothRewards(FlatBuffers.ByteBuffer _bb, KothRewards obj)
		{
			return new KothRewards();
		}

		[Address(RVA="0xF56254", Offset="0xF56254", VA="0xF56254")]
		public KothRewardEntry? KothRewardsList(int j)
		{
			return null;
		}

		[Address(RVA="0x24D1B68", Offset="0x24D1B68", VA="0x24D1B68")]
		public static void StartKothRewards(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x24D1C90", Offset="0x24D1C90", VA="0x24D1C90")]
		public static void StartKothRewardsListVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}