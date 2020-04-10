using Il2CppDummyDll;
using System;

namespace GooglePlayGames.BasicApi.Events
{
	internal class Event : IEvent
	{
		[FieldOffset(Offset="0x10")]
		private string mId;

		[FieldOffset(Offset="0x18")]
		private string mName;

		[FieldOffset(Offset="0x20")]
		private string mDescription;

		[FieldOffset(Offset="0x28")]
		private string mImageUrl;

		[FieldOffset(Offset="0x30")]
		private ulong mCurrentCount;

		[FieldOffset(Offset="0x38")]
		private EventVisibility mVisibility;

		public ulong CurrentCount
		{
			[Address(RVA="0x1EC3CEC", Offset="0x1EC3CEC", VA="0x1EC3CEC", Slot="8")]
			get
			{
				return new ulong();
			}
		}

		public string Description
		{
			[Address(RVA="0x1EC3CDC", Offset="0x1EC3CDC", VA="0x1EC3CDC", Slot="6")]
			get
			{
				return null;
			}
		}

		public string Id
		{
			[Address(RVA="0x1EC3CCC", Offset="0x1EC3CCC", VA="0x1EC3CCC", Slot="4")]
			get
			{
				return null;
			}
		}

		public string ImageUrl
		{
			[Address(RVA="0x1EC3CE4", Offset="0x1EC3CE4", VA="0x1EC3CE4", Slot="7")]
			get
			{
				return null;
			}
		}

		public string Name
		{
			[Address(RVA="0x1EC3CD4", Offset="0x1EC3CD4", VA="0x1EC3CD4", Slot="5")]
			get
			{
				return null;
			}
		}

		public EventVisibility Visibility
		{
			[Address(RVA="0x1EC3CF4", Offset="0x1EC3CF4", VA="0x1EC3CF4", Slot="9")]
			get
			{
				return new EventVisibility();
			}
		}

		[Address(RVA="0x1EC3C68", Offset="0x1EC3C68", VA="0x1EC3C68")]
		internal Event(string id, string name, string description, string imageUrl, ulong currentCount, EventVisibility visibility)
		{
		}
	}
}