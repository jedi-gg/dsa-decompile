using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class KothBattleHistoryController : APopupController, IDispatchHandler<DKothBattleHistoryViewAction>, IDispatchHandler, IDispatchHandler<DKothBattleHistoryOpponentAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105A1EC", Offset="0x105A1EC")]
	[FieldOffset(Offset="0x38")]
	private PlayerService _playerService;

	[Attribute(Name="InjectAttribute", RVA="0x105A1FC", Offset="0x105A1FC")]
	[FieldOffset(Offset="0x40")]
	private Unit.Factory _unitFactory;

	[Attribute(Name="InjectAttribute", RVA="0x105A20C", Offset="0x105A20C")]
	[FieldOffset(Offset="0x48")]
	private Spell.Factory _spellFactory;

	[FieldOffset(Offset="0x50")]
	private KothBattleHistoryResponse _historyData;

	[FieldOffset(Offset="0x58")]
	private KothBattleHistoryView _view;

	[Address(RVA="0x11C9078", Offset="0x11C9078", VA="0x11C9078")]
	public KothBattleHistoryController()
	{
	}

	[Address(RVA="0x11C8EF4", Offset="0x11C8EF4", VA="0x11C8EF4")]
	private void GetPlayerKothBattleHistory(Action finished)
	{
	}

	[Address(RVA="0x11C8D70", Offset="0x11C8D70", VA="0x11C8D70", Slot="14")]
	public void HandleDispatchAction(DKothBattleHistoryViewAction action)
	{
	}

	[Address(RVA="0x11C8D74", Offset="0x11C8D74", VA="0x11C8D74", Slot="15")]
	public void HandleDispatchAction(DKothBattleHistoryOpponentAction action)
	{
	}

	[Address(RVA="0x11C8BBC", Offset="0x11C8BBC", VA="0x11C8BBC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x11C8E10", Offset="0x11C8E10", VA="0x11C8E10")]
	private void RequestView(Action finished)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2BC", Offset="0x104C2BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleHistoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11C8D68", Offset="0x11C8D68", VA="0x11C8D68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11C9080", Offset="0x11C9080", VA="0x11C9080")]
		internal void <Initialize>b__0()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2CC", Offset="0x104C2CC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleHistoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11C8EEC", Offset="0x11C8EEC", VA="0x11C8EEC")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x11C92B4", Offset="0x11C92B4", VA="0x11C92B4")]
		internal void <RequestView>b__0(KothBattleHistoryView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C2DC", Offset="0x104C2DC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public KothBattleHistoryController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x11C9070", Offset="0x11C9070", VA="0x11C9070")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x11C9308", Offset="0x11C9308", VA="0x11C9308")]
		internal void <GetPlayerKothBattleHistory>b__0(KothBattleHistoryResponse response)
		{
		}

		[Address(RVA="0x11C97D0", Offset="0x11C97D0", VA="0x11C97D0")]
		internal void <GetPlayerKothBattleHistory>b__1(long errorCode)
		{
		}
	}
}