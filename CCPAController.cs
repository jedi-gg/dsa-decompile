using Glunies;
using Il2CppDummyDll;
using System;

public class CCPAController : APopupController, IDispatchHandler<DCCPAViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x10559D8", Offset="0x10559D8")]
	[FieldOffset(Offset="0x38")]
	private RevSdkController _revSdkController;

	[Attribute(Name="InjectAttribute", RVA="0x10559E8", Offset="0x10559E8")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[Address(RVA="0x1123868", Offset="0x1123868", VA="0x1123868")]
	public CCPAController()
	{
	}

	[Address(RVA="0x1123794", Offset="0x1123794", VA="0x1123794", Slot="14")]
	public void HandleDispatchAction(DCCPAViewAction action)
	{
	}

	[Address(RVA="0x1123680", Offset="0x1123680", VA="0x1123680", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B51C", Offset="0x104B51C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public CCPAController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x112378C", Offset="0x112378C", VA="0x112378C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1123870", Offset="0x1123870", VA="0x1123870")]
		internal void <Initialize>b__0(CCPAView view)
		{
		}
	}
}