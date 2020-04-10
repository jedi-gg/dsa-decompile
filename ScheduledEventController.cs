using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ScheduledEventController : AEventController
{
	[Attribute(Name="InjectAttribute", RVA="0x10583B0", Offset="0x10583B0")]
	[FieldOffset(Offset="0xF0")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x10583C0", Offset="0x10583C0")]
	[FieldOffset(Offset="0xF8")]
	private ClubServiceUtility _clubServiceUtility;

	protected override string EventExpiredLocKey
	{
		[Address(RVA="0x2C3F308", Offset="0x2C3F308", VA="0x2C3F308", Slot="26")]
		get
		{
			return null;
		}
	}

	protected override string EventRpcName
	{
		[Address(RVA="0x2C3F3A0", Offset="0x2C3F3A0", VA="0x2C3F3A0", Slot="28")]
		get
		{
			return null;
		}
	}

	protected override string EventStatusExpiredLocKey
	{
		[Address(RVA="0x2C3F350", Offset="0x2C3F350", VA="0x2C3F350", Slot="27")]
		get
		{
			return null;
		}
	}

	protected override EventGameStateContext.EventType EventType
	{
		[Address(RVA="0x2C3F398", Offset="0x2C3F398", VA="0x2C3F398", Slot="29")]
		get
		{
			return new EventGameStateContext.EventType();
		}
	}

	protected override string HudTitleKey
	{
		[Address(RVA="0x2C3F2C0", Offset="0x2C3F2C0", VA="0x2C3F2C0", Slot="25")]
		get
		{
			return null;
		}
	}

	protected override string RevSdkVgpActionName
	{
		[Address(RVA="0x2C3F3E8", Offset="0x2C3F3E8", VA="0x2C3F3E8", Slot="30")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C3F430", Offset="0x2C3F430", VA="0x2C3F430")]
	public ScheduledEventController()
	{
	}

	[Address(RVA="0x2C3F438", Offset="0x2C3F438", VA="0x2C3F438")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F754", Offset="0x106F754")]
	private void <GetEvents>b__0_0(Action done)
	{
	}

	[Address(RVA="0x2C3F474", Offset="0x2C3F474", VA="0x2C3F474")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F764", Offset="0x106F764")]
	private void <GetEvents>g__RequestEvents|0_1(Action done)
	{
	}

	[Address(RVA="0x2C3EB94", Offset="0x2C3EB94", VA="0x2C3EB94")]
	private void CreateCustomHudData(IEnumerable<Event> events)
	{
	}

	[Address(RVA="0x2C3E98C", Offset="0x2C3E98C", VA="0x2C3E98C", Slot="23")]
	protected override void GetEvents(Action finished)
	{
	}

	[Address(RVA="0x2C3EAB0", Offset="0x2C3EAB0", VA="0x2C3EAB0", Slot="24")]
	protected override void LoadView(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE6C", Offset="0x104BE6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action done;

		[FieldOffset(Offset="0x18")]
		public ScheduledEventController <>4__this;

		[Address(RVA="0x2C3F5F0", Offset="0x2C3F5F0", VA="0x2C3F5F0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x2C3F5F8", Offset="0x2C3F5F8", VA="0x2C3F5F8")]
		internal void <GetEvents>b__2(GetScheduledEventsResponse response)
		{
		}

		[Address(RVA="0x2C3F718", Offset="0x2C3F718", VA="0x2C3F718")]
		internal void <GetEvents>b__3(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BE7C", Offset="0x104BE7C")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public ScheduledEventController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x2C3EB8C", Offset="0x2C3EB8C", VA="0x2C3EB8C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x2C3F7B4", Offset="0x2C3F7B4", VA="0x2C3F7B4")]
		internal void <LoadView>b__0(ScheduledEventView view)
		{
		}
	}
}