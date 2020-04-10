using Glunies;
using Il2CppDummyDll;
using System;

public class AboutGameController : APopupController, IDispatchHandler<DAboutGameViewAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1052430", Offset="0x1052430")]
	[FieldOffset(Offset="0x38")]
	private GamedataDomainController _gamedataDc;

	[Address(RVA="0x1154D44", Offset="0x1154D44", VA="0x1154D44")]
	public AboutGameController()
	{
	}

	[Address(RVA="0x1154C70", Offset="0x1154C70", VA="0x1154C70", Slot="14")]
	public void HandleDispatchAction(DAboutGameViewAction action)
	{
	}

	[Address(RVA="0x1154B5C", Offset="0x1154B5C", VA="0x1154B5C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104ADEC", Offset="0x104ADEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public AboutGameController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x1154C68", Offset="0x1154C68", VA="0x1154C68")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1154D4C", Offset="0x1154D4C", VA="0x1154D4C")]
		internal void <Initialize>b__0(AboutGameView view)
		{
		}
	}
}