using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubActivityController : AFeatureController, IDispatchHandler<DClubActivityViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10566FC", Offset="0x10566FC")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105670C", Offset="0x105670C")]
	[FieldOffset(Offset="0x70")]
	private ClubService _clubService;

	[FieldOffset(Offset="0x78")]
	private ClubActivityView _view;

	[FieldOffset(Offset="0x80")]
	private Club _club;

	[FieldOffset(Offset="0x88")]
	private IList<ClubActivity> _activities;

	[FieldOffset(Offset="0x90")]
	private DateTime _resetTime;

	[Address(RVA="0x14645A0", Offset="0x14645A0", VA="0x14645A0")]
	public ClubActivityController()
	{
	}

	[Address(RVA="0x1464678", Offset="0x1464678", VA="0x1464678")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF54", Offset="0x106EF54")]
	private void <RequestClub>b__5_0(ClubResponse response)
	{
	}

	[Address(RVA="0x14645A8", Offset="0x14645A8", VA="0x14645A8")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF34", Offset="0x106EF34")]
	private void <RequestClubActivities>b__4_0(ClubActivitiesResponse resp)
	{
	}

	[Address(RVA="0x1464670", Offset="0x1464670", VA="0x1464670")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EF44", Offset="0x106EF44")]
	private bool <RequestClubActivities>b__4_2()
	{
		return new bool();
	}

	[Address(RVA="0x14640D4", Offset="0x14640D4", VA="0x14640D4", Slot="10")]
	protected override GameStateTransitionContext CreateContext()
	{
		return null;
	}

	[Address(RVA="0x1464044", Offset="0x1464044", VA="0x1464044", Slot="13")]
	public void HandleDispatchAction(DClubActivityViewAction action)
	{
	}

	[Address(RVA="0x1463CE4", Offset="0x1463CE4", VA="0x1463CE4", Slot="6")]
	public override void Initialize(GameStateTransitionContext context)
	{
	}

	[Address(RVA="0x14644BC", Offset="0x14644BC", VA="0x14644BC")]
	private void LoadView(Action finished)
	{
	}

	[Address(RVA="0x14642CC", Offset="0x14642CC", VA="0x14642CC")]
	private void RequestClub(Action finished)
	{
	}

	[Address(RVA="0x1464130", Offset="0x1464130", VA="0x1464130")]
	private void RequestClubActivities(Action finished)
	{
	}

	[Address(RVA="0x1463EF8", Offset="0x1463EF8", VA="0x1463EF8", Slot="8")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B87C", Offset="0x104B87C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static ClubActivityController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Action<long> <>9__4_1;

		[FieldOffset(Offset="0x10")]
		public static Action<long> <>9__5_1;

		[Address(RVA="0x14646B4", Offset="0x14646B4", VA="0x14646B4")]
		static <>c()
		{
		}

		[Address(RVA="0x1464718", Offset="0x1464718", VA="0x1464718")]
		public <>c()
		{
		}

		[Address(RVA="0x14647DC", Offset="0x14647DC", VA="0x14647DC")]
		internal void <RequestClub>b__5_1(long failureCode)
		{
		}

		[Address(RVA="0x1464720", Offset="0x1464720", VA="0x1464720")]
		internal void <RequestClubActivities>b__4_1(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B86C", Offset="0x104B86C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubActivityController <>4__this;

		[FieldOffset(Offset="0x18")]
		public GameStateTransitionContext context;

		[Address(RVA="0x1463EF0", Offset="0x1463EF0", VA="0x1463EF0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1464898", Offset="0x1464898", VA="0x1464898")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B88C", Offset="0x104B88C")]
	private sealed class <>c__DisplayClass6_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubActivityController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1464598", Offset="0x1464598", VA="0x1464598")]
		public <>c__DisplayClass6_0()
		{
		}

		[Address(RVA="0x1464EF8", Offset="0x1464EF8", VA="0x1464EF8")]
		internal void <LoadView>b__0(ClubActivityView view)
		{
		}
	}
}