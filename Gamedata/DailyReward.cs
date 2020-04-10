using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct DailyReward : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF59CC8", Offset="0xF59CC8", VA="0xF59CC8", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF59CF4", Offset="0xF59CF4", VA="0xF59CF4")]
			get
			{
				return new ulong();
			}
		}

		public int Priority
		{
			[Address(RVA="0xF59D0C", Offset="0xF59D0C", VA="0xF59D0C")]
			get
			{
				return new int();
			}
		}

		public string Requirement
		{
			[Address(RVA="0xF59D14", Offset="0xF59D14", VA="0xF59D14")]
			get
			{
				return null;
			}
		}

		public int TiersLength
		{
			[Address(RVA="0xF59D04", Offset="0xF59D04", VA="0xF59D04")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0xF59CDC", Offset="0xF59CDC", VA="0xF59CDC")]
		public DailyReward __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new DailyReward();
		}

		[Address(RVA="0xF59CD0", Offset="0xF59CD0", VA="0xF59CD0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x250EDE0", Offset="0x250EDE0", VA="0x250EDE0")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x250EE58", Offset="0x250EE58", VA="0x250EE58")]
		public static void AddPriority(FlatBufferBuilder builder, int priority)
		{
		}

		[Address(RVA="0x250EE1C", Offset="0x250EE1C", VA="0x250EE1C")]
		public static void AddRequirement(FlatBufferBuilder builder, StringOffset requirementOffset)
		{
		}

		[Address(RVA="0x250EE94", Offset="0x250EE94", VA="0x250EE94")]
		public static void AddTiers(FlatBufferBuilder builder, VectorOffset tiersOffset)
		{
		}

		[Address(RVA="0x250ED50", Offset="0x250ED50", VA="0x250ED50")]
		public static Offset<DailyReward> CreateDailyReward(FlatBufferBuilder builder, ulong id = 0L, VectorOffset tiersOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.DailyReward> Gamedata.DailyReward::CreateDailyReward(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Int32,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.DailyReward> CreateDailyReward(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.VectorOffset,System.Int32,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x250EF80", Offset="0x250EF80", VA="0x250EF80")]
		public static VectorOffset CreateTiersVector(FlatBufferBuilder builder, Offset<DailyRewardTier>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x250EED0", Offset="0x250EED0", VA="0x250EED0")]
		public static Offset<DailyReward> EndDailyReward(FlatBufferBuilder builder)
		{
			return new Offset<DailyReward>();
		}

		[Address(RVA="0x250F0B4", Offset="0x250F0B4", VA="0x250F0B4")]
		public static void FinishDailyRewardBuffer(FlatBufferBuilder builder, Offset<DailyReward> offset)
		{
		}

		[Address(RVA="0xF59D1C", Offset="0xF59D1C", VA="0xF59D1C")]
		public ArraySegment<byte>? GetRequirementBytes()
		{
			return null;
		}

		[Address(RVA="0x250EA30", Offset="0x250EA30", VA="0x250EA30")]
		public static DailyReward GetRootAsDailyReward(FlatBuffers.ByteBuffer _bb)
		{
			return new DailyReward();
		}

		[Address(RVA="0x250EA3C", Offset="0x250EA3C", VA="0x250EA3C")]
		public static DailyReward GetRootAsDailyReward(FlatBuffers.ByteBuffer _bb, DailyReward obj)
		{
			return new DailyReward();
		}

		[Address(RVA="0x250EF50", Offset="0x250EF50", VA="0x250EF50")]
		public static void StartDailyReward(FlatBufferBuilder builder)
		{
		}

		[Address(RVA="0x250F078", Offset="0x250F078", VA="0x250F078")]
		public static void StartTiersVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0xF59CFC", Offset="0xF59CFC", VA="0xF59CFC")]
		public DailyRewardTier? Tiers(int j)
		{
			return null;
		}
	}
}