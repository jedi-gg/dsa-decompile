using Glunies;
using Il2CppDummyDll;
using System;

public class BattleUnitDetailPopupController : APopupController, IDispatchHandler<DViewShownAction>, IDispatchHandler, IDispatchHandler<DBattleUnitDetailPopupControllerAction>
{
	[Address(RVA="0x129DB3C", Offset="0x129DB3C", VA="0x129DB3C")]
	public BattleUnitDetailPopupController()
	{
	}

	[Address(RVA="0x129DA64", Offset="0x129DA64", VA="0x129DA64", Slot="14")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x129DB2C", Offset="0x129DB2C", VA="0x129DB2C", Slot="15")]
	public void HandleDispatchAction(DBattleUnitDetailPopupControllerAction action)
	{
	}

	[Address(RVA="0x129D8AC", Offset="0x129D8AC", VA="0x129D8AC", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B0BC", Offset="0x104B0BC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleUnitDetailPopupController.Context popupContext;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x129DA5C", Offset="0x129DA5C", VA="0x129DA5C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x129DB44", Offset="0x129DB44", VA="0x129DB44")]
		internal void <Initialize>b__0(BattleUnitDetailPopupView view)
		{
		}
	}

	public enum AnchorPos
	{
		[FieldOffset(Offset="0x0")]
		Left,
		[FieldOffset(Offset="0x0")]
		Right
	}

	public class Context : ITransitionContext
	{
		[FieldOffset(Offset="0x10")]
		public readonly BattleUnitDetailPopupController.AnchorPos AnchorPos;

		[FieldOffset(Offset="0x18")]
		public readonly BattleUnit BattleUnit;

		[Address(RVA="0x129E460", Offset="0x129E460", VA="0x129E460")]
		public Context(BattleUnitDetailPopupController.AnchorPos anchorPos, BattleUnit battleUnit)
		{
		}
	}
}