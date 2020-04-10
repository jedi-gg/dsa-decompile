using Il2CppDummyDll;
using System;

public class EditorNotificationController : ANotificationController
{
	[Address(RVA="0x1206484", Offset="0x1206484", VA="0x1206484")]
	public EditorNotificationController()
	{
	}

	[Address(RVA="0x12063C0", Offset="0x12063C0", VA="0x12063C0", Slot="17")]
	protected override void ClearLocalNotification(LocalNotificationType notificationType)
	{
	}

	[Address(RVA="0x12062D4", Offset="0x12062D4", VA="0x12062D4", Slot="16")]
	protected override void ScheduleLocalNotification(LocalNotificationType notificationType, int secondsFromNow)
	{
	}

	[Address(RVA="0x1206480", Offset="0x1206480", VA="0x1206480", Slot="18")]
	protected override void SetBadgeCount(int badgeCount)
	{
	}
}