using Glunies;
using Il2CppDummyDll;
using System;

public class SorcererStoneInfoController : APopupController, IDispatchHandler<DSorcererStoneInfoViewAction>, IDispatchHandler
{
	[Address(RVA="0x123C8F0", Offset="0x123C8F0", VA="0x123C8F0")]
	public SorcererStoneInfoController()
	{
	}

	[Address(RVA="0x123C8EC", Offset="0x123C8EC", VA="0x123C8EC", Slot="14")]
	public void HandleDispatchAction(DSorcererStoneInfoViewAction action)
	{
	}

	[Address(RVA="0x123C7E8", Offset="0x123C7E8", VA="0x123C7E8", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CA6C", Offset="0x104CA6C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public Action completed;

		[Address(RVA="0x123C8E4", Offset="0x123C8E4", VA="0x123C8E4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x123C8F8", Offset="0x123C8F8", VA="0x123C8F8")]
		internal void <Initialize>b__0(SorcererStoneInfoView view)
		{
		}
	}
}