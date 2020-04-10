using Glunies;
using Il2CppDummyDll;
using System;

public class ClubWarMemberRegisterPopupController : APopupController, IDispatchHandler<DClubWarMemberRegisterAction>, IDispatchHandler
{
	[Address(RVA="0x14CF6F8", Offset="0x14CF6F8", VA="0x14CF6F8")]
	public ClubWarMemberRegisterPopupController()
	{
	}

	[Address(RVA="0x14CF6F0", Offset="0x14CF6F0", VA="0x14CF6F0", Slot="14")]
	public void HandleDispatchAction(DClubWarMemberRegisterAction action)
	{
	}

	[Address(RVA="0x14CF5EC", Offset="0x14CF5EC", VA="0x14CF5EC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104BA6C", Offset="0x104BA6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[Address(RVA="0x14CF6E8", Offset="0x14CF6E8", VA="0x14CF6E8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x14CF700", Offset="0x14CF700", VA="0x14CF700")]
		internal void <Initialize>b__0(ClubWarMemberRegisterPopupView view)
		{
		}
	}
}