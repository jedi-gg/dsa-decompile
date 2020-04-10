using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class BattleInviteMessageController : IAssetDependentLifecycleObject, IDispatchHandler<DSystemMessageAction<BattleInviteMsg>>, IDispatchHandler, IDispatchHandler<DSystemMessageAction<CancelBattleInviteMsg>>, IDispatchHandler<DBattleInviteViewAction>, IDispatchHandler<DBattleInviteAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x10549FC", Offset="0x10549FC")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1054A0C", Offset="0x1054A0C")]
	[FieldOffset(Offset="0x18")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1054A1C", Offset="0x1054A1C")]
	[FieldOffset(Offset="0x20")]
	private BattleService _battleService;

	[Attribute(Name="InjectAttribute", RVA="0x1054A2C", Offset="0x1054A2C")]
	[FieldOffset(Offset="0x28")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1054A3C", Offset="0x1054A3C")]
	[FieldOffset(Offset="0x30")]
	private RemoteBattleStateTransitionController _remoteBattleStateTransitionController;

	[FieldOffset(Offset="0x38")]
	private BattleInviteMessageView _view;

	[FieldOffset(Offset="0x40")]
	private BattleInviteMessageController.InviteMessageStack _pendingInvites;

	[FieldOffset(Offset="0x48")]
	private bool _autoDeclineInvites;

	[FieldOffset(Offset="0x49")]
	private bool _isShutdown;

	[Address(RVA="0x1101040", Offset="0x1101040", VA="0x1101040")]
	public BattleInviteMessageController()
	{
	}

	[Address(RVA="0x1101288", Offset="0x1101288", VA="0x1101288")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7F8", Offset="0x106E7F8")]
	private void <AcceptCoopPveBattleInvite>b__13_0()
	{
	}

	[Address(RVA="0x1101118", Offset="0x1101118", VA="0x1101118")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7D8", Offset="0x106E7D8")]
	private void <AcceptCoopPveBattleInvite>b__13_1(CoopFindMatchResponse response)
	{
	}

	[Address(RVA="0x11011E4", Offset="0x11011E4", VA="0x11011E4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E7E8", Offset="0x106E7E8")]
	private void <AcceptCoopPveBattleInvite>b__13_2(long errorCode)
	{
	}

	[Address(RVA="0x11012EC", Offset="0x11012EC", VA="0x11012EC")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E808", Offset="0x106E808")]
	private void <DeclineCoopPveBattleInvite>b__14_0()
	{
	}

	[Address(RVA="0x11001BC", Offset="0x11001BC", VA="0x11001BC")]
	private void AcceptCoopPveBattleInvite(BattleInvite invite)
	{
	}

	[Address(RVA="0x10FFA88", Offset="0x10FFA88", VA="0x10FFA88")]
	public void DeclineAllInvites(Action finished)
	{
	}

	[Address(RVA="0x110050C", Offset="0x110050C", VA="0x110050C")]
	private void DeclineCoopPveBattleInvite(BattleInvite invite)
	{
	}

	[Address(RVA="0x10FFA70", Offset="0x10FFA70", VA="0x10FFA70")]
	public void EnableAutoDecline(bool enable)
	{
	}

	[Address(RVA="0x1100680", Offset="0x1100680", VA="0x1100680")]
	private PlayerSquadSelection GetSquad(Gamedata.GameMode mode)
	{
		return null;
	}

	[Address(RVA="0x10FFD14", Offset="0x10FFD14", VA="0x10FFD14", Slot="8")]
	public void HandleDispatchAction(DSystemMessageAction<BattleInviteMsg> action)
	{
	}

	[Address(RVA="0x10FFF64", Offset="0x10FFF64", VA="0x10FFF64", Slot="9")]
	public void HandleDispatchAction(DSystemMessageAction<CancelBattleInviteMsg> action)
	{
	}

	[Address(RVA="0x11000D8", Offset="0x11000D8", VA="0x11000D8", Slot="10")]
	public void HandleDispatchAction(DBattleInviteViewAction action)
	{
	}

	[Address(RVA="0x11005FC", Offset="0x11005FC", VA="0x11005FC", Slot="11")]
	public void HandleDispatchAction(DBattleInviteAction action)
	{
	}

	[Address(RVA="0x10FF370", Offset="0x10FF370", VA="0x10FF370", Slot="4")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x1100678", Offset="0x1100678", VA="0x1100678")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x10FF374", Offset="0x10FF374", VA="0x10FF374", Slot="6")]
	public void LoadAssets(Action finished)
	{
	}

	[Address(RVA="0x1100CC8", Offset="0x1100CC8", VA="0x1100CC8")]
	private List<Serverproto.Spell> LookupPlayerSpells(IList<ulong> spellIds)
	{
		return null;
	}

	[Address(RVA="0x1100950", Offset="0x1100950", VA="0x1100950")]
	private List<Serverproto.Unit> LookupPlayerUnits(IList<ulong> unitIds)
	{
		return null;
	}

	[Address(RVA="0x10FF4A8", Offset="0x10FF4A8", VA="0x10FF4A8", Slot="7")]
	public void ReleaseAssets()
	{
	}

	[Address(RVA="0x1100710", Offset="0x1100710", VA="0x1100710")]
	private void SendDeclineRequest(BattleInvite declinedInvite, Action finished)
	{
	}

	[Address(RVA="0x10FF664", Offset="0x10FF664", VA="0x10FF664")]
	public void ShowPendingInvites()
	{
	}

	[Address(RVA="0x10FF49C", Offset="0x10FF49C", VA="0x10FF49C", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x10FF51C", Offset="0x10FF51C", VA="0x10FF51C")]
	public void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B3AC", Offset="0x104B3AC")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static BattleInviteMessageController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static Func<bool> <>9__13_3;

		[FieldOffset(Offset="0x10")]
		public static Action<long> <>9__15_0;

		[FieldOffset(Offset="0x18")]
		public static Func<bool> <>9__15_1;

		[Address(RVA="0x1101358", Offset="0x1101358", VA="0x1101358")]
		static <>c()
		{
		}

		[Address(RVA="0x11013BC", Offset="0x11013BC", VA="0x11013BC")]
		public <>c()
		{
		}

		[Address(RVA="0x11013C4", Offset="0x11013C4", VA="0x11013C4")]
		internal bool <AcceptCoopPveBattleInvite>b__13_3()
		{
			return new bool();
		}

		[Address(RVA="0x11013CC", Offset="0x11013CC", VA="0x11013CC")]
		internal void <SendDeclineRequest>b__15_0(long errorCode)
		{
		}

		[Address(RVA="0x1101444", Offset="0x1101444", VA="0x1101444")]
		internal bool <SendDeclineRequest>b__15_1()
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B39C", Offset="0x104B39C")]
	private sealed class <>c__DisplayClass13_0
	{
		[FieldOffset(Offset="0x10")]
		public CoopFindMatchResponse response;

		[FieldOffset(Offset="0x18")]
		public BattleInviteMessageController <>4__this;

		[Address(RVA="0x11011DC", Offset="0x11011DC", VA="0x11011DC")]
		public <>c__DisplayClass13_0()
		{
		}

		[Address(RVA="0x110144C", Offset="0x110144C", VA="0x110144C")]
		internal void <AcceptCoopPveBattleInvite>b__4()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B37C", Offset="0x104B37C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleInviteMessageController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x10FF514", Offset="0x10FF514", VA="0x10FF514")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x1101574", Offset="0x1101574", VA="0x1101574")]
		internal void <LoadAssets>b__0(BattleInviteMessageView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B38C", Offset="0x104B38C")]
	private sealed class <>c__DisplayClass7_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleInviteMsg invite;

		[FieldOffset(Offset="0x18")]
		public BattleInviteMessageController <>4__this;

		[Address(RVA="0x10FFC4C", Offset="0x10FFC4C", VA="0x10FFC4C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Address(RVA="0x1101604", Offset="0x1101604", VA="0x1101604")]
		internal void <DeclineAllInvites>b__0(Action executed)
		{
		}
	}

	private class InviteMessageStack
	{
		[FieldOffset(Offset="0x10")]
		private List<BattleInviteMsg> _messages;

		public int Count
		{
			[Address(RVA="0x10FF70C", Offset="0x10FF70C", VA="0x10FF70C")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x11010A4", Offset="0x11010A4", VA="0x11010A4")]
		public InviteMessageStack()
		{
		}

		[Address(RVA="0x10FFE28", Offset="0x10FFE28", VA="0x10FFE28")]
		public static bool IsInviteExpired(BattleInvite invite)
		{
			return new bool();
		}

		[Address(RVA="0x10FF76C", Offset="0x10FF76C", VA="0x10FF76C")]
		public BattleInviteMsg Peek()
		{
			return null;
		}

		[Address(RVA="0x10FFC54", Offset="0x10FFC54", VA="0x10FFC54")]
		public BattleInviteMsg Pop()
		{
			return null;
		}

		[Address(RVA="0x10FFEF4", Offset="0x10FFEF4", VA="0x10FFEF4")]
		public void Push(BattleInviteMsg msg)
		{
		}

		[Address(RVA="0x10FF564", Offset="0x10FF564", VA="0x10FF564")]
		public bool RemoveExpired()
		{
			return new bool();
		}

		[Address(RVA="0x10FFFC8", Offset="0x10FFFC8", VA="0x10FFFC8")]
		public void RemoveInvite(BattleInvite invite)
		{
		}
	}
}