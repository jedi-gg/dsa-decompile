using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct PlayerLevelTableEntry : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF57AA8", Offset="0xF57AA8", VA="0xF57AA8", Slot="5")]
			get
			{
				return null;
			}
		}

		public uint ClubItemDonationDailyLimit
		{
			[Address(RVA="0xF57AEC", Offset="0xF57AEC", VA="0xF57AEC")]
			get
			{
				return new uint();
			}
		}

		public int ClubItemDonationRewardsLength
		{
			[Address(RVA="0xF57AFC", Offset="0xF57AFC", VA="0xF57AFC")]
			get
			{
				return new int();
			}
		}

		public uint ClubItemRequestCapacity
		{
			[Address(RVA="0xF57AE4", Offset="0xF57AE4", VA="0xF57AE4")]
			get
			{
				return new uint();
			}
		}

		public ulong Rewards
		{
			[Address(RVA="0xF57ADC", Offset="0xF57ADC", VA="0xF57ADC")]
			get
			{
				return new ulong();
			}
		}

		public uint XpRequired
		{
			[Address(RVA="0xF57AD4", Offset="0xF57AD4", VA="0xF57AD4")]
			get
			{
				return new uint();
			}
		}

		[Address(RVA="0xF57ABC", Offset="0xF57ABC", VA="0xF57ABC")]
		public PlayerLevelTableEntry __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelTableEntry();
		}

		[Address(RVA="0xF57AB0", Offset="0xF57AB0", VA="0xF57AB0", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x24DEB28", Offset="0x24DEB28", VA="0x24DEB28")]
		public static void AddClubItemDonationDailyLimit(FlatBufferBuilder builder, uint clubItemDonationDailyLimit)
		{
		}

		[Address(RVA="0x24DEAEC", Offset="0x24DEAEC", VA="0x24DEAEC")]
		public static void AddClubItemDonationRewards(FlatBufferBuilder builder, VectorOffset clubItemDonationRewardsOffset)
		{
		}

		[Address(RVA="0x24DEB64", Offset="0x24DEB64", VA="0x24DEB64")]
		public static void AddClubItemRequestCapacity(FlatBufferBuilder builder, uint clubItemRequestCapacity)
		{
		}

		[Address(RVA="0x24DEAB0", Offset="0x24DEAB0", VA="0x24DEAB0")]
		public static void AddRewards(FlatBufferBuilder builder, ulong rewards)
		{
		}

		[Address(RVA="0x24DEBA0", Offset="0x24DEBA0", VA="0x24DEBA0")]
		public static void AddXpRequired(FlatBufferBuilder builder, uint xpRequired)
		{
		}

		[Address(RVA="0xF57AF4", Offset="0xF57AF4", VA="0xF57AF4")]
		public ItemCount? ClubItemDonationRewards(int j)
		{
			return null;
		}

		[Address(RVA="0x24DEC8C", Offset="0x24DEC8C", VA="0x24DEC8C")]
		public static VectorOffset CreateClubItemDonationRewardsVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x24DEA10", Offset="0x24DEA10", VA="0x24DEA10")]
		public static Offset<PlayerLevelTableEntry> CreatePlayerLevelTableEntry(FlatBufferBuilder builder, uint xp_required = 0, ulong rewards = 0L, uint club_item_request_capacity = 0, uint club_item_donation_daily_limit = 0, VectorOffset club_item_donation_rewardsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.PlayerLevelTableEntry> Gamedata.PlayerLevelTableEntry::CreatePlayerLevelTableEntry(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt64,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.PlayerLevelTableEntry> CreatePlayerLevelTableEntry(FlatBuffers.FlatBufferBuilder,System.UInt32,System.UInt64,System.UInt32,System.UInt32,FlatBuffers.VectorOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x24DEBDC", Offset="0x24DEBDC", VA="0x24DEBDC")]
		public static Offset<PlayerLevelTableEntry> EndPlayerLevelTableEntry(FlatBufferBuilder builder)
		{
			return new Offset<PlayerLevelTableEntry>();
		}

		[Address(RVA="0x24DE684", Offset="0x24DE684", VA="0x24DE684")]
		public static PlayerLevelTableEntry GetRootAsPlayerLevelTableEntry(FlatBuffers.ByteBuffer _bb)
		{
			return new PlayerLevelTableEntry();
		}

		[Address(RVA="0x24DE690", Offset="0x24DE690", VA="0x24DE690")]
		public static PlayerLevelTableEntry GetRootAsPlayerLevelTableEntry(FlatBuffers.ByteBuffer _bb, PlayerLevelTableEntry obj)
		{
			return new PlayerLevelTableEntry();
		}

		[Address(RVA="0x24DED84", Offset="0x24DED84", VA="0x24DED84")]
		public static void StartClubItemDonationRewardsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x24DEC5C", Offset="0x24DEC5C", VA="0x24DEC5C")]
		public static void StartPlayerLevelTableEntry(FlatBufferBuilder builder)
		{
		}
	}
}