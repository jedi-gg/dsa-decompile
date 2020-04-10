using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;

public class ClubDungeonPlayersPopupController : APopupController, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1056C28", Offset="0x1056C28")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[FieldOffset(Offset="0x40")]
	private ClubDungeonPlayersPopupController.Context _context;

	[Address(RVA="0x11B2B58", Offset="0x11B2B58", VA="0x11B2B58")]
	public ClubDungeonPlayersPopupController()
	{
	}

	[Address(RVA="0x11B2B50", Offset="0x11B2B50", VA="0x11B2B50", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x11B2AB4", Offset="0x11B2AB4", VA="0x11B2AB4", Slot="14")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x11B295C", Offset="0x11B295C", VA="0x11B295C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B97C", Offset="0x104B97C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonPlayersPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11B2AAC", Offset="0x11B2AAC", VA="0x11B2AAC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11B2B60", Offset="0x11B2B60", VA="0x11B2B60")]
		internal void <Initialize>b__0(ClubDungeonPlayersPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly List<PlayerProfileSimple> Players;

		[Address(RVA="0x11AA118", Offset="0x11AA118", VA="0x11AA118")]
		public Context(List<PlayerProfileSimple> players)
		{
		}
	}
}