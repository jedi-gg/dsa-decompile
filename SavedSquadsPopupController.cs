using Glunies;
using Il2CppDummyDll;
using System;

public class SavedSquadsPopupController : APopupController, IDispatchHandler<DSavedSquadListItemAction>, IDispatchHandler, IDispatchHandler<DUnitListItemAction>, IDispatchHandler<DSpellListItemAction>, IDispatchHandler<DSavedSquadsChangedAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105C130", Offset="0x105C130")]
	[FieldOffset(Offset="0x38")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C140", Offset="0x105C140")]
	[FieldOffset(Offset="0x40")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x105C150", Offset="0x105C150")]
	[FieldOffset(Offset="0x48")]
	private DialogManager _dialogManager;

	[Attribute(Name="InjectAttribute", RVA="0x105C160", Offset="0x105C160")]
	[FieldOffset(Offset="0x50")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x58")]
	private SavedSquadsPopupView _view;

	[FieldOffset(Offset="0x60")]
	private uint _numFreeSquads;

	[Address(RVA="0x2C3E224", Offset="0x2C3E224", VA="0x2C3E224")]
	public SavedSquadsPopupController()
	{
	}

	[Address(RVA="0x2C3D97C", Offset="0x2C3D97C", VA="0x2C3D97C", Slot="14")]
	public void HandleDispatchAction(DSavedSquadListItemAction action)
	{
	}

	[Address(RVA="0x2C3DE2C", Offset="0x2C3DE2C", VA="0x2C3DE2C", Slot="15")]
	public void HandleDispatchAction(DUnitListItemAction action)
	{
	}

	[Address(RVA="0x2C3DF20", Offset="0x2C3DF20", VA="0x2C3DF20", Slot="16")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x2C3DFC8", Offset="0x2C3DFC8", VA="0x2C3DFC8", Slot="17")]
	public void HandleDispatchAction(DSavedSquadsChangedAction action)
	{
	}

	[Address(RVA="0x2C3D6E0", Offset="0x2C3D6E0", VA="0x2C3D6E0", Slot="8")]
	public override void Initialize(ITransitionContext context, Action completed)
	{
	}

	[Address(RVA="0x2C3D8A4", Offset="0x2C3D8A4", VA="0x2C3D8A4", Slot="9")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x2C3D910", Offset="0x2C3D910", VA="0x2C3D910", Slot="10")]
	public override void TickUpdate()
	{
	}

	[Address(RVA="0x2C3DFCC", Offset="0x2C3DFCC", VA="0x2C3DFCC")]
	private void UpdateSquadData()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8DC", Offset="0x104C8DC")]
	private sealed class <>c__DisplayClass0_0
	{
		[FieldOffset(Offset="0x10")]
		public SavedSquadsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action completed;

		[Address(RVA="0x2C3D89C", Offset="0x2C3D89C", VA="0x2C3D89C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Address(RVA="0x2C3E22C", Offset="0x2C3E22C", VA="0x2C3E22C")]
		internal void <Initialize>b__0(Action finished)
		{
		}

		[Address(RVA="0x2C3E320", Offset="0x2C3E320", VA="0x2C3E320")]
		internal void <Initialize>b__1()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8EC", Offset="0x104C8EC")]
	private sealed class <>c__DisplayClass0_1
	{
		[FieldOffset(Offset="0x10")]
		public Action finished;

		[FieldOffset(Offset="0x18")]
		public SavedSquadsPopupController.<>c__DisplayClass0_0 CS$<>8__locals1;

		[Address(RVA="0x2C3E318", Offset="0x2C3E318", VA="0x2C3E318")]
		public <>c__DisplayClass0_1()
		{
		}

		[Address(RVA="0x2C3E3D8", Offset="0x2C3E3D8", VA="0x2C3E3D8")]
		internal void <Initialize>b__2(SavedSquadsPopupView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104C8FC", Offset="0x104C8FC")]
	private sealed class <>c__DisplayClass3_0
	{
		[FieldOffset(Offset="0x10")]
		public SavedSquadsPopupController <>4__this;

		[FieldOffset(Offset="0x18")]
		public DSavedSquadListItemAction action;

		[Address(RVA="0x2C3DD8C", Offset="0x2C3DD8C", VA="0x2C3DD8C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Address(RVA="0x2C3DD94", Offset="0x2C3DD94", VA="0x2C3DD94")]
		internal void <HandleDispatchAction>g__saveFunc|0()
		{
		}
	}
}