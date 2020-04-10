using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class StoreItemGrantOddsPopupController : APopupController
{
	[FieldOffset(Offset="0x38")]
	private StoreItemGrantOddsPopupController.Context _context;

	[Address(RVA="0x130E640", Offset="0x130E640", VA="0x130E640")]
	public StoreItemGrantOddsPopupController()
	{
	}

	[Address(RVA="0x130E638", Offset="0x130E638", VA="0x130E638", Slot="11")]
	public override ITransitionContext GetCurrentContext()
	{
		return null;
	}

	[Address(RVA="0x130E4E0", Offset="0x130E4E0", VA="0x130E4E0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104CDEC", Offset="0x104CDEC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public StoreItemGrantOddsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x130E630", Offset="0x130E630", VA="0x130E630")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x130E648", Offset="0x130E648", VA="0x130E648")]
		internal void <Initialize>b__0(StoreItemGrantOddsPopupView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly StoreItemGrant Grant;

		[Address(RVA="0x130E89C", Offset="0x130E89C", VA="0x130E89C")]
		public Context(StoreItemGrant grant)
		{
		}
	}
}