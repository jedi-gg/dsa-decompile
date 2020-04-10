using Glunies;
using Il2CppDummyDll;
using System;

public class LanguageSelectController : APopupController, IDispatchHandler<DLanguageSelectAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x105A664", Offset="0x105A664")]
	[FieldOffset(Offset="0x38")]
	private GameLanguageManager _gameLanguageManager;

	[Address(RVA="0x11D7FBC", Offset="0x11D7FBC", VA="0x11D7FBC")]
	public LanguageSelectController()
	{
	}

	[Address(RVA="0x11D7EC4", Offset="0x11D7EC4", VA="0x11D7EC4", Slot="14")]
	public void HandleDispatchAction(DLanguageSelectAction action)
	{
	}

	[Address(RVA="0x11D7DB0", Offset="0x11D7DB0", VA="0x11D7DB0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C39C", Offset="0x104C39C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public LanguageSelectController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x11D7EBC", Offset="0x11D7EBC", VA="0x11D7EBC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x11D7FC4", Offset="0x11D7FC4", VA="0x11D7FC4")]
		internal void <Initialize>b__0(LanguageSelectView view)
		{
		}
	}
}