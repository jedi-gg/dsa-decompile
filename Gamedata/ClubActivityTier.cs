using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ClubActivityTier : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF43744", Offset="0xF43744", VA="0xF43744", Slot="5")]
			get
			{
				return null;
			}
		}

		public string DescriptionKey
		{
			[Address(RVA="0xF43788", Offset="0xF43788", VA="0xF43788")]
			get
			{
				return null;
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF43770", Offset="0xF43770", VA="0xF43770")]
			get
			{
				return null;
			}
		}

		public int RequiredValue
		{
			[Address(RVA="0xF437A8", Offset="0xF437A8", VA="0xF437A8")]
			get
			{
				return new int();
			}
		}

		public ulong RewardsTable
		{
			[Address(RVA="0xF437A0", Offset="0xF437A0", VA="0xF437A0")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF43758", Offset="0xF43758", VA="0xF43758")]
		public ClubActivityTier __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ClubActivityTier();
		}

		[Address(RVA="0xF4374C", Offset="0xF4374C", VA="0xF4374C", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2321974", Offset="0x2321974", VA="0x2321974")]
		public static void AddDescriptionKey(FlatBufferBuilder builder, StringOffset descriptionKeyOffset)
		{
		}

		[Address(RVA="0x23219B0", Offset="0x23219B0", VA="0x23219B0")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x2321938", Offset="0x2321938", VA="0x2321938")]
		public static void AddRequiredValue(FlatBufferBuilder builder, int requiredValue)
		{
		}

		[Address(RVA="0x23218FC", Offset="0x23218FC", VA="0x23218FC")]
		public static void AddRewardsTable(FlatBufferBuilder builder, ulong rewardsTable)
		{
		}

		[Address(RVA="0x232186C", Offset="0x232186C", VA="0x232186C")]
		public static Offset<ClubActivityTier> CreateClubActivityTier(FlatBufferBuilder builder, StringOffset name_keyOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.ClubActivityTier> Gamedata.ClubActivityTier::CreateClubActivityTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.ClubActivityTier> CreateClubActivityTier(FlatBuffers.FlatBufferBuilder,FlatBuffers.StringOffset,FlatBuffers.StringOffset,System.UInt64,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x23219EC", Offset="0x23219EC", VA="0x23219EC")]
		public static Offset<ClubActivityTier> EndClubActivityTier(FlatBufferBuilder builder)
		{
			return new Offset<ClubActivityTier>();
		}

		[Address(RVA="0xF43790", Offset="0xF43790", VA="0xF43790")]
		public ArraySegment<byte>? GetDescriptionKeyBytes()
		{
			return null;
		}

		[Address(RVA="0xF43778", Offset="0xF43778", VA="0xF43778")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x232162C", Offset="0x232162C", VA="0x232162C")]
		public static ClubActivityTier GetRootAsClubActivityTier(FlatBuffers.ByteBuffer _bb)
		{
			return new ClubActivityTier();
		}

		[Address(RVA="0x2321638", Offset="0x2321638", VA="0x2321638")]
		public static ClubActivityTier GetRootAsClubActivityTier(FlatBuffers.ByteBuffer _bb, ClubActivityTier obj)
		{
			return new ClubActivityTier();
		}

		[Address(RVA="0x2321A6C", Offset="0x2321A6C", VA="0x2321A6C")]
		public static void StartClubActivityTier(FlatBufferBuilder builder)
		{
		}
	}
}