using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class ClubWarMembersPopupController : APopupController, IDispatchHandler<DPlayerListItemClickedAction>, IDispatchHandler, IDispatchHandler<DPlayerListItemUtilityAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x1057298", Offset="0x1057298")]
	[FieldOffset(Offset="0x38")]
	private ClubWarDomainController _clubWarDc;

	[Attribute(Name="InjectAttribute", RVA="0x10572A8", Offset="0x10572A8")]
	[FieldOffset(Offset="0x40")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x10572B8", Offset="0x10572B8")]
	[FieldOffset(Offset="0x48")]
	private GamedataDomainController _gamedataDC;

	[FieldOffset(Offset="0x50")]
	private ClubWarMembersPopupController.Context _context;

	[Address(RVA="0x14CFDE4", Offset="0x14CFDE4", VA="0x14CFDE4")]
	public ClubWarMembersPopupController()
	{
	}

	[Address(RVA="0x14CFDDC", Offset="0x14CFDDC", VA="0x14CFDDC", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x14CFC04", Offset="0x14CFC04", VA="0x14CFC04", Slot="14")]
	public void HandleDispatchAction(DPlayerListItemClickedAction action)
	{
	}

	[Address(RVA="0x14CFCA0", Offset="0x14CFCA0", VA="0x14CFCA0", Slot="15")]
	public void HandleDispatchAction(DPlayerListItemUtilityAction action)
	{
	}

	[Address(RVA="0x14CFAAC", Offset="0x14CFAAC", VA="0x14CFAAC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA7C", Offset="0x104BA7C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubWarMembersPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x14CFBFC", Offset="0x14CFBFC", VA="0x14CFBFC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14CFDEC", Offset="0x14CFDEC", VA="0x14CFDEC")]
		internal void <Initialize>b__0(ClubWarMembersPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly Club Club;

		[Address(RVA="0x14D0810", Offset="0x14D0810", VA="0x14D0810")]
		public Context(Club club)
		{
		}
	}
}