using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public abstract class ADialogView : AView, IDispatchHandler<DInventoryDeltaProcessedAction>, IDispatchHandler
{
	[Attribute(Name="InjectAttribute", RVA="0x1057B74", Offset="0x1057B74")]
	[FieldOffset(Offset="0x68")]
	private PlayerDomainController _playerDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057B84", Offset="0x1057B84")]
	[FieldOffset(Offset="0x70")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1057B94", Offset="0x1057B94")]
	[FieldOffset(Offset="0x78")]
	private SingleAssetRegistry _costTextureRegistry;

	[Attribute(Name="InjectAttribute", RVA="0x1057BA4", Offset="0x1057BA4")]
	[FieldOffset(Offset="0x80")]
	private CostController _costController;

	[FieldOffset(Offset="0x88")]
	private ulong _currentCostItemId;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x10E0CE0", Offset="0x10E0CE0", VA="0x10E0CE0", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x10E0C90", Offset="0x10E0C90", VA="0x10E0C90", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private ADialogView.SerializedFields Fields
	{
		[Address(RVA="0x10E14F4", Offset="0x10E14F4", VA="0x10E14F4")]
		get
		{
			return null;
		}
	}

	public override string PrefabName
	{
		[Address(RVA="0x10E0C98", Offset="0x10E0C98", VA="0x10E0C98", Slot="8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10E1C74", Offset="0x10E1C74", VA="0x10E1C74")]
	protected ADialogView()
	{
	}

	[Address(RVA="0x10E1C7C", Offset="0x10E1C7C", VA="0x10E1C7C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4E4", Offset="0x106F4E4")]
	private void <ViewAssetLoaded>b__9_0()
	{
	}

	[Address(RVA="0x10E1C84", Offset="0x10E1C84", VA="0x10E1C84")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F4F4", Offset="0x106F4F4")]
	private void <ViewAssetLoaded>b__9_1()
	{
	}

	[Address(RVA="0x10E1C8C", Offset="0x10E1C8C", VA="0x10E1C8C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F504", Offset="0x106F504")]
	private void <ViewAssetLoaded>b__9_2()
	{
	}

	[Address(RVA="0x10E1C94", Offset="0x10E1C94", VA="0x10E1C94")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F514", Offset="0x106F514")]
	private void <ViewAssetLoaded>b__9_3()
	{
	}

	[Address(RVA="0x10E0CE8", Offset="0x10E0CE8", VA="0x10E0CE8")]
	public void Configure(DialogContext context)
	{
	}

	[Address(RVA="0x10E1BE0", Offset="0x10E1BE0", VA="0x10E1BE0")]
	private void Dispatch(DDialogViewAction.Type actionType)
	{
	}

	[Address(RVA="0x10E1790", Offset="0x10E1790", VA="0x10E1790", Slot="21")]
	public void HandleDispatchAction(DInventoryDeltaProcessedAction action)
	{
	}

	[Address(RVA="0x10E16A8", Offset="0x10E16A8", VA="0x10E16A8")]
	public void Suppress(bool suppress)
	{
	}

	[Address(RVA="0x10E15D4", Offset="0x10E15D4", VA="0x10E15D4")]
	private void UpdateCostText()
	{
	}

	[Address(RVA="0x10E13A8", Offset="0x10E13A8", VA="0x10E13A8")]
	private void ValidFonts()
	{
	}

	[Address(RVA="0x10E1818", Offset="0x10E1818", VA="0x10E1818", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10E1A5C", Offset="0x10E1A5C", VA="0x10E1A5C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106A3FC", Offset="0x106A3FC")]
		[FieldOffset(Offset="0x30")]
		public Button Scrim;

		[FieldOffset(Offset="0x38")]
		public UiLabel TitleLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel Text;

		[FieldOffset(Offset="0x48")]
		public UiLabel CancelText;

		[FieldOffset(Offset="0x50")]
		public Button CancelButton;

		[FieldOffset(Offset="0x58")]
		public UiLabel ButtonOneText;

		[FieldOffset(Offset="0x60")]
		public Button ButtonOne;

		[FieldOffset(Offset="0x68")]
		public CostButton CostButtonOne;

		[FieldOffset(Offset="0x70")]
		public RawImage OwnedCostItemImage;

		[FieldOffset(Offset="0x78")]
		public UiLabel OwnedCostItemText;

		[Address(RVA="0x10E1C9C", Offset="0x10E1C9C", VA="0x10E1C9C")]
		public SerializedFields()
		{
		}
	}
}