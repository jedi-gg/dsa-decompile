using Glunies;
using Google.Protobuf;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

public class ClubDomainController : ILoggable<LogCategory>, IDispatchHandler<DPlayerChangeAction>, IDispatchHandler, IDispatchHandler<DPlayerClubChangedAction>, IDispatchHandler<DClubFetchedAction>, IDispatchHandler<DClubRosterChangedAction>, IDispatchHandler<DHomeClubDonationsResponse>, IDispatchHandler<DHomeClubInvitesResponse>, IDispatchHandler<DNewClubInviteAction>, IDispatchHandler<DClubInviteAcceptedAction>, IDispatchHandler<DClubInviteRejectedAction>, IDispatchHandler<DGetClubInvitesResponse>, IDispatchHandler<DClubSupportRequestChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1055EB8", Offset="0x1055EB8")]
	[FieldOffset(Offset="0x10")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x18")]
	private List<ClubRosterEntry> _lastKnownClubRoster;

	[FieldOffset(Offset="0x20")]
	private List<ClubInvite> _clubInvites;

	[FieldOffset(Offset="0x28")]
	private List<ClubItemRequest> _clubItemRequests;

	[FieldOffset(Offset="0x30")]
	private List<ClubSupportRequest> _clubSupportRequests;

	[FieldOffset(Offset="0x38")]
	private string _lastPlayerId;

	public LogCategory LogCategory
	{
		[Address(RVA="0x146A8B0", Offset="0x146A8B0", VA="0x146A8B0", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x146C660", Offset="0x146C660", VA="0x146C660")]
	public ClubDomainController()
	{
	}

	[Address(RVA="0x146A928", Offset="0x146A928", VA="0x146A928")]
	public ClubInvite GetClubInvite(string clubId)
	{
		return null;
	}

	[Address(RVA="0x146B4D0", Offset="0x146B4D0", VA="0x146B4D0")]
	public ClubItemRequest GetClubItemRequest(ByteString id)
	{
		return null;
	}

	[Address(RVA="0x146B4C8", Offset="0x146B4C8", VA="0x146B4C8")]
	public IEnumerable<ClubItemRequest> GetClubItemRequests()
	{
		return null;
	}

	[Address(RVA="0x146AECC", Offset="0x146AECC", VA="0x146AECC")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106EC30", Offset="0x106EC30")]
	public IEnumerable<ClubInvite> GetClubJoinRequests(Player player)
	{
		return null;
	}

	[Address(RVA="0x146B64C", Offset="0x146B64C", VA="0x146B64C")]
	public ClubSupportRequest GetClubSupportRequest(ClubSupportRequestType requestType, string playerId, uint maxRequestsPerDay)
	{
		return null;
	}

	[Address(RVA="0x146B898", Offset="0x146B898", VA="0x146B898")]
	public int GetCountOfClubSupportRequestsThatPlayerCanFulfill(string playerId)
	{
		return new int();
	}

	[Address(RVA="0x146AB74", Offset="0x146AB74", VA="0x146AB74")]
	[Attribute(Name="IteratorStateMachineAttribute", RVA="0x106EBCC", Offset="0x106EBCC")]
	public IEnumerable<ClubInvite> GetPendingClubInvites(string playerId)
	{
		return null;
	}

	[Address(RVA="0x146BAD8", Offset="0x146BAD8", VA="0x146BAD8", Slot="5")]
	public void HandleDispatchAction(DPlayerChangeAction action)
	{
	}

	[Address(RVA="0x146BBF0", Offset="0x146BBF0", VA="0x146BBF0", Slot="6")]
	public void HandleDispatchAction(DPlayerClubChangedAction action)
	{
	}

	[Address(RVA="0x146C008", Offset="0x146C008", VA="0x146C008", Slot="7")]
	public void HandleDispatchAction(DClubFetchedAction action)
	{
	}

	[Address(RVA="0x146C100", Offset="0x146C100", VA="0x146C100", Slot="8")]
	public void HandleDispatchAction(DClubRosterChangedAction action)
	{
	}

	[Address(RVA="0x146C150", Offset="0x146C150", VA="0x146C150", Slot="9")]
	public void HandleDispatchAction(DHomeClubDonationsResponse action)
	{
	}

	[Address(RVA="0x146C180", Offset="0x146C180", VA="0x146C180", Slot="10")]
	public void HandleDispatchAction(DHomeClubInvitesResponse action)
	{
	}

	[Address(RVA="0x146C184", Offset="0x146C184", VA="0x146C184", Slot="11")]
	public void HandleDispatchAction(DNewClubInviteAction action)
	{
	}

	[Address(RVA="0x146C21C", Offset="0x146C21C", VA="0x146C21C", Slot="12")]
	public void HandleDispatchAction(DClubInviteAcceptedAction action)
	{
	}

	[Address(RVA="0x146C2B4", Offset="0x146C2B4", VA="0x146C2B4", Slot="13")]
	public void HandleDispatchAction(DClubInviteRejectedAction action)
	{
	}

	[Address(RVA="0x146C34C", Offset="0x146C34C", VA="0x146C34C", Slot="14")]
	public void HandleDispatchAction(DGetClubInvitesResponse action)
	{
	}

	[Address(RVA="0x146C350", Offset="0x146C350", VA="0x146C350", Slot="15")]
	public void HandleDispatchAction(DClubSupportRequestChangedAction action)
	{
	}

	[Address(RVA="0x146A8B8", Offset="0x146A8B8", VA="0x146A8B8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x146B1E8", Offset="0x146B1E8", VA="0x146B1E8")]
	public bool IsPlayerInClubOrInvited(string playerId)
	{
		return new bool();
	}

	[Address(RVA="0x146AF64", Offset="0x146AF64", VA="0x146AF64")]
	public int NumClubJoinRequests(Player player)
	{
		return new int();
	}

	[Address(RVA="0x146AC0C", Offset="0x146AC0C", VA="0x146AC0C")]
	public int NumIncomingClubInvites(string playerId)
	{
		return new int();
	}

	[Address(RVA="0x146AA74", Offset="0x146AA74", VA="0x146AA74")]
	public void RemoveAllClubInvitesForClub(string clubId)
	{
	}

	[Address(RVA="0x146A8F0", Offset="0x146A8F0", VA="0x146A8F0")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x146BD50", Offset="0x146BD50", VA="0x146BD50")]
	private void UpdateClubInvites(IList<ClubInvite> clubInvites)
	{
	}

	[Address(RVA="0x146BEB8", Offset="0x146BEB8", VA="0x146BEB8")]
	private void UpdateItemRequests(IList<ClubItemRequest> clubItemRequests)
	{
	}

	[Address(RVA="0x146BE10", Offset="0x146BE10", VA="0x146BE10")]
	private void UpdateRoster(IList<ClubRosterEntry> clubRosterEntry)
	{
	}

	[Address(RVA="0x146BF60", Offset="0x146BF60", VA="0x146BF60")]
	private void UpdateSupportRequests(IList<ClubSupportRequest> clubSupportRequests)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B61C", Offset="0x104B61C")]
	private sealed class <GetClubJoinRequests>d__8 : IEnumerable<ClubInvite>, IEnumerable, IEnumerator<ClubInvite>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private ClubInvite <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		private Player player;

		[FieldOffset(Offset="0x30")]
		public Player <>3__player;

		[FieldOffset(Offset="0x38")]
		public ClubDomainController <>4__this;

		[FieldOffset(Offset="0x40")]
		private List<ClubInvite>.Enumerator <>7__wrap1;

		private ClubInvite System.Collections.Generic.IEnumerator<Serverproto.ClubInvite>.Current
		{
			[Address(RVA="0x11A69FC", Offset="0x11A69FC", VA="0x11A69FC", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x11A6A6C", Offset="0x11A6A6C", VA="0x11A6A6C", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x11A66F4", Offset="0x11A66F4", VA="0x11A66F4")]
		[DebuggerHidden]
		public <GetClubJoinRequests>d__8(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x11A6748", Offset="0x11A6748", VA="0x11A6748")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x11A67A0", Offset="0x11A67A0", VA="0x11A67A0", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x11A6A74", Offset="0x11A6A74", VA="0x11A6A74", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<ClubInvite> System.Collections.Generic.IEnumerable<Serverproto.ClubInvite>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x11A6B34", Offset="0x11A6B34", VA="0x11A6B34", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x11A6A04", Offset="0x11A6A04", VA="0x11A6A04", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x11A672C", Offset="0x11A672C", VA="0x11A672C", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B60C", Offset="0x104B60C")]
	private sealed class <GetPendingClubInvites>d__6 : IEnumerable<ClubInvite>, IEnumerable, IEnumerator<ClubInvite>, IEnumerator, IDisposable
	{
		[FieldOffset(Offset="0x10")]
		private int <>1__state;

		[FieldOffset(Offset="0x18")]
		private ClubInvite <>2__current;

		[FieldOffset(Offset="0x20")]
		private int <>l__initialThreadId;

		[FieldOffset(Offset="0x28")]
		public ClubDomainController <>4__this;

		[FieldOffset(Offset="0x30")]
		private string playerId;

		[FieldOffset(Offset="0x38")]
		public string <>3__playerId;

		[FieldOffset(Offset="0x40")]
		private List<ClubInvite>.Enumerator <>7__wrap1;

		private ClubInvite System.Collections.Generic.IEnumerator<Serverproto.ClubInvite>.Current
		{
			[Address(RVA="0x11A6D9C", Offset="0x11A6D9C", VA="0x11A6D9C", Slot="6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		private object System.Collections.IEnumerator.Current
		{
			[Address(RVA="0x11A6E0C", Offset="0x11A6E0C", VA="0x11A6E0C", Slot="9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x11A6B38", Offset="0x11A6B38", VA="0x11A6B38")]
		[DebuggerHidden]
		public <GetPendingClubInvites>d__6(int u003cu003e1__state)
		{
		}

		[Address(RVA="0x11A6B8C", Offset="0x11A6B8C", VA="0x11A6B8C")]
		private void <>m__Finally1()
		{
		}

		[Address(RVA="0x11A6BE4", Offset="0x11A6BE4", VA="0x11A6BE4", Slot="8")]
		private bool MoveNext()
		{
			return new bool();
		}

		[Address(RVA="0x11A6E14", Offset="0x11A6E14", VA="0x11A6E14", Slot="4")]
		[DebuggerHidden]
		private IEnumerator<ClubInvite> System.Collections.Generic.IEnumerable<Serverproto.ClubInvite>.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x11A6ED4", Offset="0x11A6ED4", VA="0x11A6ED4", Slot="5")]
		[DebuggerHidden]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Address(RVA="0x11A6DA4", Offset="0x11A6DA4", VA="0x11A6DA4", Slot="10")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}

		[Address(RVA="0x11A6B70", Offset="0x11A6B70", VA="0x11A6B70", Slot="7")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}
	}
}