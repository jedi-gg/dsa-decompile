using Glunies;
using Il2CppDummyDll;
using System;

public class UnitStatsController : APopupController
{
	[Attribute(Name="InjectAttribute", RVA="0x105F830", Offset="0x105F830")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F840", Offset="0x105F840")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDC;

	[Attribute(Name="InjectAttribute", RVA="0x105F850", Offset="0x105F850")]
	[FieldOffset(Offset="0x48")]
	private UnitStatsDescriptionController _statDescriptionController;

	[Attribute(Name="InjectAttribute", RVA="0x105F860", Offset="0x105F860")]
	[FieldOffset(Offset="0x50")]
	private UnitRoleDetailController _unitRoleDetailController;

	[Address(RVA="0x1512B48", Offset="0x1512B48", VA="0x1512B48")]
	public UnitStatsController()
	{
	}

	[Address(RVA="0x151288C", Offset="0x151288C", VA="0x151288C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x1512A84", Offset="0x1512A84", VA="0x1512A84", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x1512AD0", Offset="0x1512AD0", VA="0x1512AD0", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D18C", Offset="0x104D18C")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public UnitStatsController <>4__this;

		[FieldOffset(Offset="0x18")]
		public ITransitionContext context;

		[Address(RVA="0x1512A7C", Offset="0x1512A7C", VA="0x1512A7C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x1512B50", Offset="0x1512B50", VA="0x1512B50")]
		internal void <Initialize>b__0(Action finished)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D19C", Offset="0x104D19C")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public UnitStatsController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x1512C3C", Offset="0x1512C3C", VA="0x1512C3C")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x1512C44", Offset="0x1512C44", VA="0x1512C44")]
		internal void <Initialize>b__1(UnitStatsView view)
		{
		}
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong UnitId;

		[Address(RVA="0x1513914", Offset="0x1513914", VA="0x1513914")]
		public Context(ulong unitId)
		{
		}
	}
}