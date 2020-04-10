using Glunies;
using Il2CppDummyDll;
using System;

public class UiTimerLabel : ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x10")]
	private char[] _timerCharArray;

	[FieldOffset(Offset="0x18")]
	private UiLabel _label;

	[FieldOffset(Offset="0x20")]
	private TimeSpan _lastFixedUpdateTime;

	[FieldOffset(Offset="0x28")]
	private string _expiredString;

	[FieldOffset(Offset="0x30")]
	private DateTime _expireTimeUtc;

	[FieldOffset(Offset="0x38")]
	private DateTime _lastTickSyncTime;

	public DateTime ExpireTimeUtc
	{
		[Address(RVA="0x158EB70", Offset="0x158EB70", VA="0x158EB70")]
		get
		{
			return new DateTime();
		}
		[Address(RVA="0x158EB78", Offset="0x158EB78", VA="0x158EB78")]
		set
		{
		}
	}

	public bool HasExpired
	{
		[Address(RVA="0x158EB84", Offset="0x158EB84", VA="0x158EB84")]
		get
		{
			return new bool();
		}
	}

	public bool IsVisible
	{
		[Address(RVA="0x158EBF4", Offset="0x158EBF4", VA="0x158EBF4")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x158EB68", Offset="0x158EB68", VA="0x158EB68", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	public TimeSpan TimeRemaining
	{
		[Address(RVA="0x158ECAC", Offset="0x158ECAC", VA="0x158ECAC")]
		get
		{
			return new TimeSpan();
		}
	}

	[Address(RVA="0x158ED20", Offset="0x158ED20", VA="0x158ED20")]
	public UiTimerLabel(UiLabel label, WidgetDependencyContainer dependencies, string expiredLocKey = "")
	{
	}

	[Address(RVA="0x158ED6C", Offset="0x158ED6C", VA="0x158ED6C")]
	public UiTimerLabel(UiLabel label, LocalizationManager locManager, string expiredLocKey = "")
	{
	}

	[Address(RVA="0x158EFF4", Offset="0x158EFF4", VA="0x158EFF4")]
	public void Show(bool show)
	{
	}

	[Address(RVA="0x158EEAC", Offset="0x158EEAC", VA="0x158EEAC")]
	public void TickUpdate()
	{
	}
}