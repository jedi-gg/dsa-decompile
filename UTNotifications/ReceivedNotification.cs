using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace UTNotifications
{
	public class ReceivedNotification
	{
		[FieldOffset(Offset="0x10")]
		public readonly string title;

		[FieldOffset(Offset="0x18")]
		public readonly string text;

		[FieldOffset(Offset="0x20")]
		public readonly int id;

		[FieldOffset(Offset="0x28")]
		public readonly IDictionary<string, string> userData;

		[FieldOffset(Offset="0x30")]
		public readonly string notificationProfile;

		[FieldOffset(Offset="0x38")]
		public readonly int badgeNumber;

		[Address(RVA="0x15821C0", Offset="0x15821C0", VA="0x15821C0")]
		public ReceivedNotification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber)
		{
		}
	}
}