using Il2CppDummyDll;
using System;
using System.Collections.Generic;

namespace UTNotifications
{
	public class ManagerImpl : Manager
	{
		[FieldOffset(Offset="0x39")]
		private bool m_willHandleReceivedNotifications;

		[FieldOffset(Offset="0x0")]
		private const float m_timeBetweenCheckingForIncomingNotifications = 0.5f;

		[FieldOffset(Offset="0x3C")]
		private float m_timeToCheckForIncomingNotifications;

		[Address(RVA="0x144D800", Offset="0x144D800", VA="0x144D800")]
		public ManagerImpl()
		{
		}

		[Address(RVA="0x144C5B8", Offset="0x144C5B8", VA="0x144C5B8")]
		public void _OnAndroidIdReceived(string providerAndId)
		{
		}

		[Address(RVA="0x144BE64", Offset="0x144BE64", VA="0x144BE64", Slot="15")]
		public override void CancelAllNotifications()
		{
		}

		[Address(RVA="0x144B694", Offset="0x144B694", VA="0x144B694", Slot="13")]
		public override void CancelNotification(int id)
		{
		}

		[Address(RVA="0x144C0A8", Offset="0x144C0A8", VA="0x144C0A8", Slot="17")]
		public override int GetBadge()
		{
			return new int();
		}

		[Address(RVA="0x144CB28", Offset="0x144CB28", VA="0x144CB28")]
		private void HandleClickedNotification(string receivedNotificationPacked)
		{
		}

		[Address(RVA="0x144CB78", Offset="0x144CB78", VA="0x144CB78")]
		private void HandleReceivedNotifications(string receivedNotificationsPacked)
		{
		}

		[Address(RVA="0x144BC20", Offset="0x144BC20", VA="0x144BC20", Slot="16")]
		public override void HideAllNotifications()
		{
		}

		[Address(RVA="0x144B96C", Offset="0x144B96C", VA="0x144B96C", Slot="14")]
		public override void HideNotification(int id)
		{
		}

		[Address(RVA="0x1448620", Offset="0x1448620", VA="0x1448620", Slot="4")]
		public override bool Initialize(bool willHandleReceivedNotifications, int startId = 0, bool incrementalId = false)
		{
			return new bool();
		}

		[Address(RVA="0x144C658", Offset="0x144C658", VA="0x144C658")]
		protected void LateUpdate()
		{
		}

		[Address(RVA="0x144AAD4", Offset="0x144AAD4", VA="0x144AAD4", Slot="9")]
		public override bool NotificationsAllowed()
		{
			return new bool();
		}

		[Address(RVA="0x144A878", Offset="0x144A878", VA="0x144A878", Slot="8")]
		public override bool NotificationsEnabled()
		{
			return new bool();
		}

		[Address(RVA="0x144CD94", Offset="0x144CD94", VA="0x144CD94")]
		protected void OnApplicationPause(bool paused)
		{
		}

		[Address(RVA="0x144D04C", Offset="0x144D04C", VA="0x144D04C")]
		private static ReceivedNotification ParseReceivedNotification(JSONNode json)
		{
			return null;
		}

		[Address(RVA="0x14496AC", Offset="0x14496AC", VA="0x14496AC", Slot="5")]
		public override void PostLocalNotification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
		{
		}

		[Address(RVA="0x14492A0", Offset="0x14492A0", VA="0x14492A0")]
		private static string ProfilesSettingsJson()
		{
			return null;
		}

		[Address(RVA="0x144AFE8", Offset="0x144AFE8", VA="0x144AFE8", Slot="11")]
		public override bool PushNotificationsEnabled()
		{
			return new bool();
		}

		[Address(RVA="0x1449CB8", Offset="0x1449CB8", VA="0x1449CB8", Slot="6")]
		public override void ScheduleNotification(int triggerInSeconds, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
		{
		}

		[Address(RVA="0x144A264", Offset="0x144A264", VA="0x144A264", Slot="7")]
		public override void ScheduleNotificationRepeating(int firstTriggerInSeconds, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
		{
		}

		[Address(RVA="0x144C304", Offset="0x144C304", VA="0x144C304", Slot="18")]
		public override void SetBadge(int bandgeNumber)
		{
		}

		[Address(RVA="0x144AD30", Offset="0x144AD30", VA="0x144AD30", Slot="10")]
		public override void SetNotificationsEnabled(bool enabled)
		{
		}

		[Address(RVA="0x144B3B0", Offset="0x144B3B0", VA="0x144B3B0", Slot="12")]
		public override bool SetPushNotificationsEnabled(bool enabled)
		{
			return new bool();
		}

		[Address(RVA="0x1449BE8", Offset="0x1449BE8", VA="0x1449BE8")]
		private static string ToBase64(string str)
		{
			return null;
		}

		[Address(RVA="0x1449CA4", Offset="0x1449CA4", VA="0x1449CA4")]
		private static string ToString(object o)
		{
			return null;
		}
	}
}