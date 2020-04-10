using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubWarRewards : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF4419C", Offset="0xF4419C", VA="0xF4419C", Slot="5")]
			get
			{
				return null;
			}
		}

		public int ChestsLength
		{
			[Address(RVA="0xF441F0", Offset="0xF441F0", VA="0xF441F0")]
			get
			{
				return new int();
			}
		}

		public ulong FillInChest
		{
			[Address(RVA="0xF441F8", Offset="0xF441F8", VA="0xF441F8")]
			get
			{
				return new ulong();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF441C8", Offset="0xF441C8", VA="0xF441C8")]
			get
			{
				return new ulong();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF441D0", Offset="0xF441D0", VA="0xF441D0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0xF441B0", Offset="0xF441B0", VA="0xF441B0")]
		public ClubWarRewards __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarRewards();
		}

		[Address(RVA="0xF441A4", Offset="0xF441A4", VA="0xF441A4", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x23279B0", Offset="0x23279B0", VA="0x23279B0")]
		public static void AddChests(FlatBufferBuilder builder, VectorOffset chestsOffset)
		{
		}

		[Address(RVA="0x2327938", Offset="0x2327938", VA="0x2327938")]
		public static void AddFillInChest(FlatBufferBuilder builder, ulong fillInChest)
		{
		}

		[Address(RVA="0x2327974", Offset="0x2327974", VA="0x2327974")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x23279EC", Offset="0x23279EC", VA="0x23279EC")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0xF441E8", Offset="0xF441E8", VA="0xF441E8")]
		public ClubWarChestWithPercentage? Chests(int j)
		{
			return null;
		}

		[Address(RVA="0x2327AD8", Offset="0x2327AD8", VA="0x2327AD8")]
		public static VectorOffset CreateChestsVector(FlatBufferBuilder builder, Offset<ClubWarChestWithPercentage>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x23278A8", Offset="0x23278A8", VA="0x23278A8")]
		public static Offset<ClubWarRewards> CreateClubWarRewards(FlatBufferBuilder builder, ulong id = 0L, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubWarRewards> Gamedata.ClubWarRewards::CreateClubWarRewards(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubWarRewards> CreateClubWarRewards(FlatBuffers.FlatBufferBuilder,System.UInt64,FlatBuffers.StringOffset,FlatBuffers.VectorOffset,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2327A28", Offset="0x2327A28", VA="0x2327A28")]
		public static Offset<ClubWarRewards> EndClubWarRewards(FlatBufferBuilder builder)
		{
			return new Offset<ClubWarRewards>();
		}

		[Address(RVA="0x2327C0C", Offset="0x2327C0C", VA="0x2327C0C")]
		public static void FinishClubWarRewardsBuffer(FlatBufferBuilder builder, Offset<ClubWarRewards> offset)
		{
		}

		[Address(RVA="0xF441D8", Offset="0xF441D8", VA="0xF441D8")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x232759C", Offset="0x232759C", VA="0x232759C")]
		public static ClubWarRewards GetRootAsClubWarRewards(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubWarRewards();
		}

		[Address(RVA="0x23275A8", Offset="0x23275A8", VA="0x23275A8")]
		public static ClubWarRewards GetRootAsClubWarRewards(FlatBuffers.ByteBuffer _bb, ClubWarRewards obj)
		{
			return new ClubWarRewards();
		}

		[Address(RVA="0x2327BD0", Offset="0x2327BD0", VA="0x2327BD0")]
		public static void StartChestsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2327AA8", Offset="0x2327AA8", VA="0x2327AA8")]
		public static void StartClubWarRewards(FlatBufferBuilder builder)
		{
		}
	}
}