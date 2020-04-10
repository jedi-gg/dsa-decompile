using FlatBuffers;
using Il2CppDummyDll;
using System;

namespace Gamedata
{
	public struct ActivityBattleFilterCampaign : IFlatbufferObject
	{
		[FieldOffset(Offset="0x0")]
		private Table __p;

		public FlatBuffers.ByteBuffer ByteBuffer
		{
			[Address(RVA="0xF09C70", Offset="0xF09C70", VA="0xF09C70", Slot="5")]
			get
			{
				return null;
			}
		}

		public ulong Campaign
		{
			[Address(RVA="0xF09C9C", Offset="0xF09C9C", VA="0xF09C9C")]
			get
			{
				return new ulong();
			}
		}

		[Address(RVA="0xF09C84", Offset="0xF09C84", VA="0xF09C84")]
		public ActivityBattleFilterCampaign __assign(int _i, FlatBuffers.ByteBuffer _bb)
		{
			return new ActivityBattleFilterCampaign();
		}

		[Address(RVA="0xF09C78", Offset="0xF09C78", VA="0xF09C78", Slot="4")]
		public void __init(int _i, FlatBuffers.ByteBuffer _bb)
		{
		}

		[Address(RVA="0x15EDE0C", Offset="0x15EDE0C", VA="0x15EDE0C")]
		public static void AddCampaign(FlatBufferBuilder builder, ulong campaign)
		{
		}

		[Address(RVA="0x15EDDBC", Offset="0x15EDDBC", VA="0x15EDDBC")]
		public static Offset<ActivityBattleFilterCampaign> CreateActivityBattleFilterCampaign(FlatBufferBuilder builder, ulong campaign = 0L)
		{
			return new Offset<ActivityBattleFilterCampaign>();
		}

		[Address(RVA="0x15EDE48", Offset="0x15EDE48", VA="0x15EDE48")]
		public static Offset<ActivityBattleFilterCampaign> EndActivityBattleFilterCampaign(FlatBufferBuilder builder)
		{
			return new Offset<ActivityBattleFilterCampaign>();
		}

		[Address(RVA="0x15EDC94", Offset="0x15EDC94", VA="0x15EDC94")]
		public static ActivityBattleFilterCampaign GetRootAsActivityBattleFilterCampaign(FlatBuffers.ByteBuffer _bb)
		{
			return new ActivityBattleFilterCampaign();
		}

		[Address(RVA="0x15EDCA0", Offset="0x15EDCA0", VA="0x15EDCA0")]
		public static ActivityBattleFilterCampaign GetRootAsActivityBattleFilterCampaign(FlatBuffers.ByteBuffer _bb, ActivityBattleFilterCampaign obj)
		{
			return new ActivityBattleFilterCampaign();
		}

		[Address(RVA="0x15EDEC8", Offset="0x15EDEC8", VA="0x15EDEC8")]
		public static void StartActivityBattleFilterCampaign(FlatBufferBuilder builder)
		{
		}
	}
}