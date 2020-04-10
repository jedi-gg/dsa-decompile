using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class KothRankRewardsController : APopupController, IDispatchHandler<DInventoryItemListItemAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105A614", Offset="0x105A614")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105A624", Offset="0x105A624")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105A634", Offset="0x105A634")]
	[FieldOffset(Offset="0x48")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105A644", Offset="0x105A644")]
	[FieldOffset(Offset="0x50")]
	private PassportSeasonUtility _passportSeasonUtility;

	[FieldOffset(Offset="0x58")]
	private KothRankRewardsView _view;

	[Address(RVA="0x11D68B0", Offset="0x11D68B0", VA="0x11D68B0")]
	public KothRankRewardsController()
	{
	}

	[Address(RVA="0x11D6780", Offset="0x11D6780", VA="0x11D6780", Slot="14")]
	public void HandleDispatchAction(DInventoryItemListItemAction action)
	{
	}

	[Address(RVA="0x11D63A0", Offset="0x11D63A0", VA="0x11D63A0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x11D65C0", Offset="0x11D65C0", VA="0x11D65C0", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C37C", Offset="0x104C37C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public KothRankRewardsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public IList<KothRankRewardPreview> rankRewardPreviews;

		[FieldOffset(Offset="0x20")]
		public ulong playerKothRank;

		[FieldOffset(Offset="0x28")]
		public Action completed;

		[FieldOffset(Offset="0x30")]
		public Action<KothRankRewardPreviewResponse> <>9__3;

		[FieldOffset(Offset="0x38")]
		public Action<long> <>9__4;

		[Address(RVA="0x11D65B8", Offset="0x11D65B8", VA="0x11D65B8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11D68B8", Offset="0x11D68B8", VA="0x11D68B8")]
		internal void <Initialize>b__0(Action executed)
		{
		}

		[Address(RVA="0x11D6AE0", Offset="0x11D6AE0", VA="0x11D6AE0")]
		internal void <Initialize>b__1(Action executed)
		{
		}

		[Address(RVA="0x11D6BD4", Offset="0x11D6BD4", VA="0x11D6BD4")]
		internal void <Initialize>b__2()
		{
		}

		[Address(RVA="0x11D6A24", Offset="0x11D6A24", VA="0x11D6A24")]
		internal void <Initialize>b__3(KothRankRewardPreviewResponse response)
		{
		}

		[Address(RVA="0x11D6A60", Offset="0x11D6A60", VA="0x11D6A60")]
		internal void <Initialize>b__4(long failureCode)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C38C", Offset="0x104C38C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public KothRankRewardsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x11D6BCC", Offset="0x11D6BCC", VA="0x11D6BCC")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x11D7200", Offset="0x11D7200", VA="0x11D7200")]
		internal void <Initialize>b__5(KothRankRewardsView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong PlayerRank;

		[Address(RVA="0x11CF1B0", Offset="0x11CF1B0", VA="0x11CF1B0")]
		public Context(ulong rank)
		{
		}
	}
}