using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct GlobalInboxMessages : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public ulong AdOfferWallRewardsMsg
		{
			[Address(RVA="0xF5A624", Offset="0xF5A624", VA="0xF5A624")]
			get
			{
				return new ulong();
			}
		}

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF5A5C0", Offset="0xF5A5C0", VA="0xF5A5C0", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong ClubActivityRewardsFallbackMsg
		{
			[Address(RVA="0xF5A5F4", Offset="0xF5A5F4", VA="0xF5A5F4")]
			get
			{
				return new ulong();
			}
		}

		public int ClubActivityRewardsMsgsLength
		{
			[Address(RVA="0xF5A604", Offset="0xF5A604", VA="0xF5A604")]
			get
			{
				return new int();
			}
		}

		public ulong ClubDungeonRewardsMsg
		{
			[Address(RVA="0xF5A5EC", Offset="0xF5A5EC", VA="0xF5A5EC")]
			get
			{
				return new ulong();
			}
		}

		public ulong ClubGiftAnonInboxMessage
		{
			[Address(RVA="0xF5A634", Offset="0xF5A634", VA="0xF5A634")]
			get
			{
				return new ulong();
			}
		}

		public ulong ClubGiftInboxMessage
		{
			[Address(RVA="0xF5A62C", Offset="0xF5A62C", VA="0xF5A62C")]
			get
			{
				return new ulong();
			}
		}

		public ulong DeferredStorePurchaseMsg
		{
			[Address(RVA="0xF5A61C", Offset="0xF5A61C", VA="0xF5A61C")]
			get
			{
				return new ulong();
			}
		}

		public ulong VipSubscriptionLapsedMessage
		{
			[Address(RVA="0xF5A644", Offset="0xF5A644", VA="0xF5A644")]
			get
			{
				return new ulong();
			}
		}

		public ulong VipSubscriptionReupMessage
		{
			[Address(RVA="0xF5A63C", Offset="0xF5A63C", VA="0xF5A63C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF5A5D4", Offset="0xF5A5D4", VA="0xF5A5D4")]
		public GlobalInboxMessages __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new GlobalInboxMessages();
		}

		[Address(RVA="0xF5A5C8", Offset="0xF5A5C8", VA="0xF5A5C8", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x2514A7C", Offset="0x2514A7C", VA="0x2514A7C")]
		public static void AddAdOfferWallRewardsMsg(FlatBufferBuilder builder, ulong adOfferWallRewardsMsg)
		{
		}

		[Address(RVA="0x2514AF4", Offset="0x2514AF4", VA="0x2514AF4")]
		public static void AddClubActivityRewardsFallbackMsg(FlatBufferBuilder builder, ulong clubActivityRewardsFallbackMsg)
		{
		}

		[Address(RVA="0x2514B6C", Offset="0x2514B6C", VA="0x2514B6C")]
		public static void AddClubActivityRewardsMsgs(FlatBufferBuilder builder, VectorOffset clubActivityRewardsMsgsOffset)
		{
		}

		[Address(RVA="0x2514B30", Offset="0x2514B30", VA="0x2514B30")]
		public static void AddClubDungeonRewardsMsg(FlatBufferBuilder builder, ulong clubDungeonRewardsMsg)
		{
		}

		[Address(RVA="0x2514A04", Offset="0x2514A04", VA="0x2514A04")]
		public static void AddClubGiftAnonInboxMessage(FlatBufferBuilder builder, ulong clubGiftAnonInboxMessage)
		{
		}

		[Address(RVA="0x2514A40", Offset="0x2514A40", VA="0x2514A40")]
		public static void AddClubGiftInboxMessage(FlatBufferBuilder builder, ulong clubGiftInboxMessage)
		{
		}

		[Address(RVA="0x2514AB8", Offset="0x2514AB8", VA="0x2514AB8")]
		public static void AddDeferredStorePurchaseMsg(FlatBufferBuilder builder, ulong deferredStorePurchaseMsg)
		{
		}

		[Address(RVA="0x251498C", Offset="0x251498C", VA="0x251498C")]
		public static void AddVipSubscriptionLapsedMessage(FlatBufferBuilder builder, ulong vipSubscriptionLapsedMessage)
		{
		}

		[Address(RVA="0x25149C8", Offset="0x25149C8", VA="0x25149C8")]
		public static void AddVipSubscriptionReupMessage(FlatBufferBuilder builder, ulong vipSubscriptionReupMessage)
		{
		}

		[Address(RVA="0xF5A5FC", Offset="0xF5A5FC", VA="0xF5A5FC")]
		public ulong ClubActivityRewardsMsgs(int j)
		{
			return new ulong();
		}

		[Address(RVA="0x2514C58", Offset="0x2514C58", VA="0x2514C58")]
		public static VectorOffset CreateClubActivityRewardsMsgsVector(FlatBufferBuilder builder, ulong[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x25148A0", Offset="0x25148A0", VA="0x25148A0")]
		public static Offset<GlobalInboxMessages> CreateGlobalInboxMessages(FlatBufferBuilder builder, ulong club_dungeon_rewards_msg = 0L, ulong club_activity_rewards_fallback_msg = 0L, VectorOffset club_activity_rewards_msgsOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.GlobalInboxMessages> Gamedata.GlobalInboxMessages::CreateGlobalInboxMessages(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.UInt64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.GlobalInboxMessages> CreateGlobalInboxMessages(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt64,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.UInt64,System.UInt64)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x2514BA8", Offset="0x2514BA8", VA="0x2514BA8")]
		public static Offset<GlobalInboxMessages> EndGlobalInboxMessages(FlatBufferBuilder builder)
		{
			return new Offset<GlobalInboxMessages>();
		}

		[Address(RVA="0xF5A60C", Offset="0xF5A60C", VA="0xF5A60C")]
		public ArraySegment<byte>? GetClubActivityRewardsMsgsBytes()
		{
			return null;
		}

		[Address(RVA="0x2514398", Offset="0x2514398", VA="0x2514398")]
		public static GlobalInboxMessages GetRootAsGlobalInboxMessages(FlatBuffers.ByteBuffer _bb)
		{
			return new GlobalInboxMessages();
		}

		[Address(RVA="0x25143A4", Offset="0x25143A4", VA="0x25143A4")]
		public static GlobalInboxMessages GetRootAsGlobalInboxMessages(FlatBuffers.ByteBuffer _bb, GlobalInboxMessages obj)
		{
			return new GlobalInboxMessages();
		}

		[Address(RVA="0x2514D50", Offset="0x2514D50", VA="0x2514D50")]
		public static void StartClubActivityRewardsMsgsVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x2514C28", Offset="0x2514C28", VA="0x2514C28")]
		public static void StartGlobalInboxMessages(FlatBufferBuilder builder)
		{
		}
	}
}