using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class UnitPromotionCelebrationController : APopupController
{
	[Attribute(Name="InjectAttribute", RVA="0x105F750", Offset="0x105F750")]
	[FieldOffset(Offset="0x38")]
	private ViewSequencerController _sequencerController;

	[Attribute(Name="InjectAttribute", RVA="0x105F760", Offset="0x105F760")]
	[FieldOffset(Offset="0x40")]
	private HudController _hudController;

	[FieldOffset(Offset="0x48")]
	private UnitPromotionCelebrationView _view;

	public override bool ShouldBeRestoredFromHistory
	{
		[Address(RVA="0x150B364", Offset="0x150B364", VA="0x150B364", Slot="7")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x150B5F4", Offset="0x150B5F4", VA="0x150B5F4")]
	public UnitPromotionCelebrationController()
	{
	}

	[Address(RVA="0x150B36C", Offset="0x150B36C", VA="0x150B36C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x150B558", Offset="0x150B558", VA="0x150B558", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x150B5B8", Offset="0x150B5B8", VA="0x150B5B8", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D16C", Offset="0x104D16C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitPromotionCelebrationController <>4__this;

		[FieldOffset(Offset="0x18")]
		public UnitPromotionCelebrationController.Context celebrationContext;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x150B550", Offset="0x150B550", VA="0x150B550")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x150B5FC", Offset="0x150B5FC", VA="0x150B5FC")]
		internal void <Initialize>b__0(UnitPromotionCelebrationView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly UnitPromotionCelebrationController.DStats OldStats;

		[FieldOffset(Offset="0x40")]
		public readonly UnitPromotionCelebrationController.DStats NewStats;

		[Address(RVA="0x150BF6C", Offset="0x150BF6C", VA="0x150BF6C")]
		public Context(Unit oldUnit, Unit newUnit)
		{
		}
	}

	public struct DStats
	{
		[FieldOffset(Offset="0x0")]
		public readonly ulong Offense;

		[FieldOffset(Offset="0x8")]
		public readonly ulong Defense;

		[FieldOffset(Offset="0x10")]
		public readonly ulong Health;

		[FieldOffset(Offset="0x18")]
		public readonly ulong Power;

		[FieldOffset(Offset="0x20")]
		public readonly ulong Rarity;

		[FieldOffset(Offset="0x28")]
		public readonly ulong Level;

		[Address(RVA="0xF01B00", Offset="0xF01B00", VA="0xF01B00")]
		public DStats(Unit unit)
		{
		}
	}
}