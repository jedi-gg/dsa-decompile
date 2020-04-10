using Glunies;
using Il2CppDummyDll;
using System;
using UTNotifications;

public class DeviceNotificationController : ANotificationController
{
	[Attribute(Name="InjectAttribute", RVA="0x105A834", Offset="0x105A834")]
	[FieldOffset(Offset="0x58")]
	private LocalizationManager _lm;

	[Address(RVA="0x1203D80", Offset="0x1203D80", VA="0x1203D80")]
	public DeviceNotificationController()
	{
	}

	[Address(RVA="0x1203798", Offset="0x1203798", VA="0x1203798", Slot="17")]
	protected override void ClearLocalNotification(LocalNotificationType notificationType)
	{
	}

	[Address(RVA="0x1203254", Offset="0x1203254", VA="0x1203254", Slot="12")]
	public override void Initialize()
	{
	}

	[Address(RVA="0x1203928", Offset="0x1203928", VA="0x1203928")]
	private void NotificationClicked(ReceivedNotification notification)
	{
	}

	[Address(RVA="0x12034C4", Offset="0x12034C4", VA="0x12034C4", Slot="14")]
	public override bool NotificationsAllowed()
	{
		return new bool();
	}

	[Address(RVA="0x1203540", Offset="0x1203540", VA="0x1203540", Slot="16")]
	protected override void ScheduleLocalNotification(LocalNotificationType notificationType, int secondsFromNow)
	{
	}

	[Address(RVA="0x12038A0", Offset="0x12038A0", VA="0x12038A0", Slot="18")]
	protected override void SetBadgeCount(int badgeCount)
	{
	}

	[Address(RVA="0x12033A4", Offset="0x12033A4", VA="0x12033A4", Slot="13")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1203C84", Offset="0x1203C84", VA="0x1203C84")]
	private void UTSendRegistrationIdHandler(string providerName, string registrationId)
	{
	}
}