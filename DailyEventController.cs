using Il2CppDummyDll;
using Serverproto;
using System;

public class DailyEventController : AEventController
{
	protected override string EventExpiredLocKey
	{
		[Address(RVA="0x12ADA10", Offset="0x12ADA10", VA="0x12ADA10", Slot="26")]
		get
		{
			return null;
		}
	}

	protected override string EventRpcName
	{
		[Address(RVA="0x12ADAA8", Offset="0x12ADAA8", VA="0x12ADAA8", Slot="28")]
		get
		{
			return null;
		}
	}

	protected override string EventStatusExpiredLocKey
	{
		[Address(RVA="0x12ADA58", Offset="0x12ADA58", VA="0x12ADA58", Slot="27")]
		get
		{
			return null;
		}
	}

	protected override EventGameStateContext.EventType EventType
	{
		[Address(RVA="0x12ADAA0", Offset="0x12ADAA0", VA="0x12ADAA0", Slot="29")]
		get
		{
			return new EventGameStateContext.EventType();
		}
	}

	protected override string HudTitleKey
	{
		[Address(RVA="0x12AD9C8", Offset="0x12AD9C8", VA="0x12AD9C8", Slot="25")]
		get
		{
			return null;
		}
	}

	protected override string RevSdkVgpActionName
	{
		[Address(RVA="0x12ADAF0", Offset="0x12ADAF0", VA="0x12ADAF0", Slot="30")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x12ADB38", Offset="0x12ADB38", VA="0x12ADB38")]
	public DailyEventController()
	{
	}

	[Address(RVA="0x12AD72C", Offset="0x12AD72C", VA="0x12AD72C", Slot="23")]
	protected override void GetEvents(Action finished)
	{
	}

	[Address(RVA="0x12AD8E4", Offset="0x12AD8E4", VA="0x12AD8E4", Slot="24")]
	protected override void LoadView(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE2C", Offset="0x104BE2C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12AD8DC", Offset="0x12AD8DC", VA="0x12AD8DC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x12ADB40", Offset="0x12ADB40", VA="0x12ADB40")]
		internal void <GetEvents>b__0(GetDailyEventsResponse response)
		{
		}

		[Address(RVA="0x12ADB9C", Offset="0x12ADB9C", VA="0x12ADB9C")]
		internal void <GetEvents>b__1(long failureCode)
		{
		}

		[Address(RVA="0x12ADC1C", Offset="0x12ADC1C", VA="0x12ADC1C")]
		internal void <GetEvents>b__2()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE3C", Offset="0x104BE3C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public DailyEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x12AD9C0", Offset="0x12AD9C0", VA="0x12AD9C0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x12ADC30", Offset="0x12ADC30", VA="0x12ADC30")]
		internal void <LoadView>b__0(DailyEventView view)
		{
		}
	}
}