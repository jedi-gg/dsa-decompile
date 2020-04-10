using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;

public abstract class ANotificationController : ILoggable<LogCategory>, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler, IDispatchHandler<DNotificationSettingsChangedAction>, IDispatchHandler<DApplicationFocusAction>, IDispatchHandler<DPlayerChangeProcessedAction>, IDispatchHandler<DHomeResponseProcessed>, IDispatchHandler<DBonusEnergyGenerateBeginAction>, IDispatchHandler<DSpecialOfferChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105A7C4", Offset="0x105A7C4")]
	[FieldOffset(Offset="0x10")]
	protected DispatchSystem _dispatchSystem;

	[Attribute(Name="InjectAttribute", RVA="0x105A7D4", Offset="0x105A7D4")]
	[FieldOffset(Offset="0x18")]
	private EnergyGenerateController _energyGenerateController;

	[Attribute(Name="InjectAttribute", RVA="0x105A7E4", Offset="0x105A7E4")]
	[FieldOffset(Offset="0x20")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A7F4", Offset="0x105A7F4")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A804", Offset="0x105A804")]
	[FieldOffset(Offset="0x30")]
	private StoreDomainController _storeDc;

	[Attribute(Name="InjectAttribute", RVA="0x105A814", Offset="0x105A814")]
	[FieldOffset(Offset="0x38")]
	private SharedPrefs _sharedPrefs;

	[Attribute(Name="InjectAttribute", RVA="0x105A824", Offset="0x105A824")]
	[FieldOffset(Offset="0x40")]
	private FeatureLockController _featureLockController;

	[FieldOffset(Offset="0x48")]
	protected string _pushTokenApns;

	[FieldOffset(Offset="0x50")]
	protected string _pushTokenFcm;

	public LogCategory LogCategory
	{
		[Address(RVA="0x10EBC3C", Offset="0x10EBC3C", VA="0x10EBC3C", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public string PlatformDefaultPushToken
	{
		[Address(RVA="0x10EBC44", Offset="0x10EBC44", VA="0x10EBC44")]
		get
		{
			return null;
		}
	}

	public string PushTokenApns
	{
		[Address(RVA="0x10EBC7C", Offset="0x10EBC7C", VA="0x10EBC7C")]
		get
		{
			return null;
		}
	}

	public string PushTokenFcm
	{
		[Address(RVA="0x10EBC84", Offset="0x10EBC84", VA="0x10EBC84")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10ED43C", Offset="0x10ED43C", VA="0x10ED43C")]
	protected ANotificationController()
	{
	}

	protected abstract void ClearLocalNotification(LocalNotificationType notificationType);

	[Address(RVA="0x10EC2D0", Offset="0x10EC2D0", VA="0x10EC2D0")]
	private void ClearLocalNotifications()
	{
	}

	[Address(RVA="0x10ED29C", Offset="0x10ED29C", VA="0x10ED29C")]
	protected string GetBodyLocalizationKey(LocalNotificationType notificationType)
	{
		return null;
	}

	[Address(RVA="0x10ED308", Offset="0x10ED308", VA="0x10ED308")]
	protected DeepLinkLocation GetDeepLinkLocation(LocalNotificationType notificationType)
	{
		return new DeepLinkLocation();
	}

	[Address(RVA="0x10ED334", Offset="0x10ED334", VA="0x10ED334")]
	protected string GetDeepLinkSubLocation(LocalNotificationType notificationType)
	{
		return null;
	}

	[Address(RVA="0x10ED128", Offset="0x10ED128", VA="0x10ED128")]
	private TimeSpan GetSpecialOfferEndEtaInSeconds()
	{
		return new TimeSpan();
	}

	[Address(RVA="0x10ED230", Offset="0x10ED230", VA="0x10ED230")]
	protected string GetTitleLocalizationKey(LocalNotificationType notificationType)
	{
		return null;
	}

	[Address(RVA="0x10EBDF4", Offset="0x10EBDF4", VA="0x10EBDF4", Slot="5")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x10EBE34", Offset="0x10EBE34", VA="0x10EBE34", Slot="6")]
	public void HandleDispatchAction(DNotificationSettingsChangedAction action)
	{
	}

	[Address(RVA="0x10EBE38", Offset="0x10EBE38", VA="0x10EBE38", Slot="7")]
	public void HandleDispatchAction(DApplicationFocusAction action)
	{
	}

	[Address(RVA="0x10EBE8C", Offset="0x10EBE8C", VA="0x10EBE8C", Slot="8")]
	public void HandleDispatchAction(DPlayerChangeProcessedAction action)
	{
	}

	[Address(RVA="0x10EBE90", Offset="0x10EBE90", VA="0x10EBE90", Slot="9")]
	public void HandleDispatchAction(DHomeResponseProcessed action)
	{
	}

	[Address(RVA="0x10EBE94", Offset="0x10EBE94", VA="0x10EBE94", Slot="11")]
	public void HandleDispatchAction(DSpecialOfferChangedAction action)
	{
	}

	[Address(RVA="0x10EBFF4", Offset="0x10EBFF4", VA="0x10EBFF4", Slot="10")]
	public void HandleDispatchAction(DBonusEnergyGenerateBeginAction action)
	{
	}

	[Address(RVA="0x10EBC8C", Offset="0x10EBC8C", VA="0x10EBC8C", Slot="12")]
	public virtual void Initialize()
	{
	}

	[Address(RVA="0x10EBCFC", Offset="0x10EBCFC", VA="0x10EBCFC", Slot="14")]
	public virtual bool NotificationsAllowed()
	{
		return new bool();
	}

	[Address(RVA="0x10EC268", Offset="0x10EC268", VA="0x10EC268")]
	protected bool NotificationsEnabled()
	{
		return new bool();
	}

	[Address(RVA="0x10EC7A8", Offset="0x10EC7A8", VA="0x10EC7A8")]
	private void ScheduleDailyEnergyGiftLocalNotification()
	{
	}

	[Address(RVA="0x10EC624", Offset="0x10EC624", VA="0x10EC624")]
	private void ScheduleFreeStoreItemLocalNotification()
	{
	}

	protected abstract void ScheduleLocalNotification(LocalNotificationType notificationType, int secondsFromNow);

	[Address(RVA="0x10EBDF8", Offset="0x10EBDF8", VA="0x10EBDF8")]
	private void ScheduleLocalNotifications()
	{
	}

	[Address(RVA="0x10EC164", Offset="0x10EC164", VA="0x10EC164")]
	private void SchedulePveEnergyFullLocalNotification()
	{
	}

	[Address(RVA="0x10EBEC8", Offset="0x10EBEC8", VA="0x10EBEC8")]
	private void ScheduleSpecialOfferEndsInNotification()
	{
	}

	protected abstract void SetBadgeCount(int badgeCount);

	[Address(RVA="0x10EBD80", Offset="0x10EBD80", VA="0x10EBD80")]
	public void SetFcmToken(string token)
	{
	}

	[Address(RVA="0x10EBCC4", Offset="0x10EBCC4", VA="0x10EBCC4", Slot="13")]
	public virtual void Shutdown()
	{
	}

	[Address(RVA="0x10EBD04", Offset="0x10EBD04", VA="0x10EBD04", Slot="15")]
	public virtual void TestNotification(int secondsDelay)
	{
	}
}