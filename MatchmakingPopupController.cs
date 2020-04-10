using Glunies;
using Il2CppDummyDll;
using System;

public class MatchmakingPopupController : APopupController, IDispatchHandler<DSquadSelectMatchmakingAction>, IDispatchHandler
{
	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x11DA828", Offset="0x11DA828", VA="0x11DA828", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11DAA20", Offset="0x11DAA20", VA="0x11DAA20")]
	public MatchmakingPopupController()
	{
	}

	[Address(RVA="0x11DAA08", Offset="0x11DAA08", VA="0x11DAA08", Slot="14")]
	public void HandleDispatchAction(DSquadSelectMatchmakingAction action)
	{
	}

	[Address(RVA="0x11DA830", Offset="0x11DA830", VA="0x11DA830", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3BC", Offset="0x104C3BC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public MatchmakingPopupController.Context popupContext;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11DAA00", Offset="0x11DAA00", VA="0x11DAA00")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x11DAA28", Offset="0x11DAA28", VA="0x11DAA28")]
		internal void <Initialize>b__0(MatchmakingPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly string MatchmakingText;

		[Address(RVA="0x11DAAE0", Offset="0x11DAAE0", VA="0x11DAAE0")]
		public Context(string matchmakingText)
		{
		}
	}
}