using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct DailyRewardTier : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59D78", Offset="0xF59D78", VA="0xF59D78", Slot="5")]
			get
			{
				return null;
			}
		}

		public string Image
		{
			[Address(RVA="0xF59DB4", Offset="0xF59DB4", VA="0xF59DB4")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF59DCC", Offset="0xF59DCC", VA="0xF59DCC")]
			get
			{
				return null;
			}
		}

		public int RewardsLength
		{
			[Address(RVA="0xF59DAC", Offset="0xF59DAC", VA="0xF59DAC")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF59D8C", Offset="0xF59D8C", VA="0xF59D8C")]
		public DailyRewardTier __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new DailyRewardTier();
		}

		[Address(RVA="0xF59D80", Offset="0xF59D80", VA="0xF59D80", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250F418", Offset="0x250F418", VA="0x250F418")]
		public static void AddImage(FlatBufferBuilder builder, StringOffset imageOffset)
		{
		}

		[Address(RVA="0x250F3DC", Offset="0x250F3DC", VA="0x250F3DC")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x250F454", Offset="0x250F454", VA="0x250F454")]
		public static void AddRewards(FlatBufferBuilder builder, VectorOffset rewardsOffset)
		{
		}

		[Address(RVA="0x250F364", Offset="0x250F364", VA="0x250F364")]
		public static Offset<DailyRewardTier> CreateDailyRewardTier(FlatBufferBuilder builder, VectorOffset rewardsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.DailyRewardTier> Gamedata.DailyRewardTier::CreateDailyRewardTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.DailyRewardTier> CreateDailyRewardTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.VectorOffset,FlatBuffers.StringOffset,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250F540", Offset="0x250F540", VA="0x250F540")]
		public static VectorOffset CreateRewardsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250F490", Offset="0x250F490", VA="0x250F490")]
		public static Offset<DailyRewardTier> EndDailyRewardTier(FlatBufferBuilder builder)
		{
			return new Offset<DailyRewardTier>();
		}

		[Address(RVA="0xF59DBC", Offset="0xF59DBC", VA="0xF59DBC")]
		public ArraySegment<byte>? GetImageBytes()
		{
			return null;
		}

		[Address(RVA="0xF59DD4", Offset="0xF59DD4", VA="0xF59DD4")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x250F0F0", Offset="0x250F0F0", VA="0x250F0F0")]
		public static DailyRewardTier GetRootAsDailyRewardTier(FlatBuffers.ByteBuffer _bb)
		{
			return new DailyRewardTier();
		}

		[Address(RVA="0x250F0FC", Offset="0x250F0FC", VA="0x250F0FC")]
		public static DailyRewardTier GetRootAsDailyRewardTier(FlatBuffers.ByteBuffer _bb, DailyRewardTier obj)
		{
			return new DailyRewardTier();
		}

		[Address(RVA="0xF59DA4", Offset="0xF59DA4", VA="0xF59DA4")]
		public ItemCount? Rewards(int j)
		{
			return null;
		}

		[Address(RVA="0x250F510", Offset="0x250F510", VA="0x250F510")]
		public static void StartDailyRewardTier(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x250F638", Offset="0x250F638", VA="0x250F638")]
		public static void StartRewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}
	}
}