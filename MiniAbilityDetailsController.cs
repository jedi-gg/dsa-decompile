using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;

public class MiniAbilityDetailsController : APopupController
{
	[Attribute(Name="InjectAttribute", RVA="0x105A6B4", Offset="0x105A6B4")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Address(RVA="0x12F16BC", Offset="0x12F16BC", VA="0x12F16BC")]
	public MiniAbilityDetailsController()
	{
	}

	[Address(RVA="0x12F122C", Offset="0x12F122C", VA="0x12F122C", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x12F154C", Offset="0x12F154C", VA="0x12F154C")]
	private void InitializeWithSpell(MiniAbilityDetailsController.SpellContext spellContext, Action completed)
	{
	}

	[Address(RVA="0x12F1384", Offset="0x12F1384", VA="0x12F1384")]
	private void InitializeWithUnit(MiniAbilityDetailsController.UnitContext unitContext, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3CC", Offset="0x104C3CC")]
	private sealed class <>c__DisplayClass1_0
	{
		[FieldOffset(Offset="0x10")]
		public Serverproto.Unit unit;

		[FieldOffset(Offset="0x18")]
		public MiniAbilityDetailsController.UnitContext unitContext;

		[FieldOffset(Offset="0x20")]
		public Action completed;

		[Address(RVA="0x12F16AC", Offset="0x12F16AC", VA="0x12F16AC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Address(RVA="0x12F16C4", Offset="0x12F16C4", VA="0x12F16C4")]
		internal void <InitializeWithUnit>b__0(MiniAbilityDetailsView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C3DC", Offset="0x104C3DC")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public Serverproto.Spell spell;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x12F16B4", Offset="0x12F16B4", VA="0x12F16B4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x12F1E34", Offset="0x12F1E34", VA="0x12F1E34")]
		internal void <InitializeWithSpell>b__0(MiniAbilityDetailsView view)
		{
		}
	}

	public class SpellContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong SpellId;

		[Address(RVA="0x12F2180", Offset="0x12F2180", VA="0x12F2180")]
		public SpellContext(ulong spellId)
		{
		}
	}

	public class UnitContext : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly ulong UnitId;

		[FieldOffset(Offset="0x18")]
		public readonly Gamedata.GameMode GameMode;

		[Address(RVA="0x12F21AC", Offset="0x12F21AC", VA="0x12F21AC")]
		public UnitContext(ulong unitId, Gamedata.GameMode gameMode)
		{
		}
	}
}