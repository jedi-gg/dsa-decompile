using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct VipSubscription : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF0C540", Offset="0xF0C540", VA="0xF0C540", Slot="5")]
			get
			{
				return null;
			}
		}

		public int DailyRewardLength
		{
			[Address(RVA="0xF0C584", Offset="0xF0C584", VA="0xF0C584")]
			get
			{
				return new int();
			}
		}

		public uint DaysLeftReminder
		{
			[Address(RVA="0xF0C59C", Offset="0xF0C59C", VA="0xF0C59C")]
			get
			{
				return new uint();
			}
		}

		public ulong Id
		{
			[Address(RVA="0xF0C56C", Offset="0xF0C56C", VA="0xF0C56C")]
			get
			{
				return new ulong();
			}
		}

		public ulong InboxMsg
		{
			[Address(RVA="0xF0C58C", Offset="0xF0C58C", VA="0xF0C58C")]
			get
			{
				return new ulong();
			}
		}

		public uint Length
		{
			[Address(RVA="0xF0C574", Offset="0xF0C574", VA="0xF0C574")]
			get
			{
				return new uint();
			}
		}

		public string NameKey
		{
			[Address(RVA="0xF0C5A4", Offset="0xF0C5A4", VA="0xF0C5A4")]
			get
			{
				return null;
			}
		}

		public ulong ReminderInboxMsg
		{
			[Address(RVA="0xF0C594", Offset="0xF0C594", VA="0xF0C594")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF0C554", Offset="0xF0C554", VA="0xF0C554")]
		public VipSubscription __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new VipSubscription();
		}

		[Address(RVA="0xF0C548", Offset="0xF0C548", VA="0xF0C548", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x16814D0", Offset="0x16814D0", VA="0x16814D0")]
		public static void AddDailyReward(FlatBufferBuilder builder, VectorOffset dailyRewardOffset)
		{
		}

		[Address(RVA="0x1681494", Offset="0x1681494", VA="0x1681494")]
		public static void AddDaysLeftReminder(FlatBufferBuilder builder, uint daysLeftReminder)
		{
		}

		[Address(RVA="0x168141C", Offset="0x168141C", VA="0x168141C")]
		public static void AddId(FlatBufferBuilder builder, ulong id)
		{
		}

		[Address(RVA="0x16813E0", Offset="0x16813E0", VA="0x16813E0")]
		public static void AddInboxMsg(FlatBufferBuilder builder, ulong inboxMsg)
		{
		}

		[Address(RVA="0x168150C", Offset="0x168150C", VA="0x168150C")]
		public static void AddLength(FlatBufferBuilder builder, uint length)
		{
		}

		[Address(RVA="0x1681458", Offset="0x1681458", VA="0x1681458")]
		public static void AddNameKey(FlatBufferBuilder builder, StringOffset nameKeyOffset)
		{
		}

		[Address(RVA="0x16813A4", Offset="0x16813A4", VA="0x16813A4")]
		public static void AddReminderInboxMsg(FlatBufferBuilder builder, ulong reminderInboxMsg)
		{
		}

		[Address(RVA="0x16815F8", Offset="0x16815F8", VA="0x16815F8")]
		public static VectorOffset CreateDailyRewardVector(FlatBufferBuilder builder, Offset<ItemCount>[] data)
		{
			return new VectorOffset();
		}

		[Address(RVA="0x16812DC", Offset="0x16812DC", VA="0x16812DC")]
		public static Offset<VipSubscription> CreateVipSubscription(FlatBufferBuilder builder, ulong id = 0L, uint length = 0, VectorOffset daily_rewardOffset = // 
		// Current member / type: FlatBuffers.Offset`1<Gamedata.VipSubscription> Gamedata.VipSubscription::CreateVipSubscription(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt32,FlatBuffers.StringOffset)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: FlatBuffers.Offset<Gamedata.VipSubscription> CreateVipSubscription(FlatBuffers.FlatBufferBuilder,System.UInt64,System.UInt32,FlatBuffers.VectorOffset,System.UInt64,System.UInt64,System.UInt32,FlatBuffers.StringOffset)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0xF0C57C", Offset="0xF0C57C", VA="0xF0C57C")]
		public ItemCount? DailyReward(int j)
		{
			return null;
		}

		[Address(RVA="0x1681548", Offset="0x1681548", VA="0x1681548")]
		public static Offset<VipSubscription> EndVipSubscription(FlatBufferBuilder builder)
		{
			return new Offset<VipSubscription>();
		}

		[Address(RVA="0x168172C", Offset="0x168172C", VA="0x168172C")]
		public static void FinishVipSubscriptionBuffer(FlatBufferBuilder builder, Offset<VipSubscription> offset)
		{
		}

		[Address(RVA="0xF0C5AC", Offset="0xF0C5AC", VA="0xF0C5AC")]
		public ArraySegment<byte>? GetNameKeyBytes()
		{
			return null;
		}

		[Address(RVA="0x1680E70", Offset="0x1680E70", VA="0x1680E70")]
		public static VipSubscription GetRootAsVipSubscription(FlatBuffers.ByteBuffer _bb)
		{
			return new VipSubscription();
		}

		[Address(RVA="0x1680E7C", Offset="0x1680E7C", VA="0x1680E7C")]
		public static VipSubscription GetRootAsVipSubscription(FlatBuffers.ByteBuffer _bb, VipSubscription obj)
		{
			return new VipSubscription();
		}

		[Address(RVA="0x16816F0", Offset="0x16816F0", VA="0x16816F0")]
		public static void StartDailyRewardVector(FlatBufferBuilder builder, int numElems)
		{
		}

		[Address(RVA="0x16815C8", Offset="0x16815C8", VA="0x16815C8")]
		public static void StartVipSubscription(FlatBufferBuilder builder)
		{
		}
	}
}