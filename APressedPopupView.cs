using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;

public abstract class APressedPopupView : AView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _showSequence;

	public override ViewDepth Depth
	{
		[Address(RVA="0x10F17E8", Offset="0x10F17E8", VA="0x10F17E8", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private PressedPopupViewSerializedFields Fields
	{
		[Address(RVA="0x10F1A5C", Offset="0x10F1A5C", VA="0x10F1A5C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10F1B94", Offset="0x10F1B94", VA="0x10F1B94")]
	protected APressedPopupView()
	{
	}

	[Address(RVA="0x10F17F0", Offset="0x10F17F0", VA="0x10F17F0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x10F1B78", Offset="0x10F1B78", VA="0x10F1B78", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x10F1B3C", Offset="0x10F1B3C", VA="0x10F1B3C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}
}