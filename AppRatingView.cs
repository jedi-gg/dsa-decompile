using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class AppRatingView : APopupView
{
	private AppRatingView.SerializedFields Fields
	{
		[Address(RVA="0x115CCDC", Offset="0x115CCDC", VA="0x115CCDC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115CE78", Offset="0x115CE78", VA="0x115CE78")]
	public AppRatingView()
	{
	}

	[Address(RVA="0x115CE80", Offset="0x115CE80", VA="0x115CE80")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFE8", Offset="0x106DFE8")]
	private void <ViewAssetLoaded>b__0_0()
	{
	}

	[Address(RVA="0x115CF04", Offset="0x115CF04", VA="0x115CF04")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFF8", Offset="0x106DFF8")]
	private void <ViewAssetLoaded>b__0_1()
	{
	}

	[Address(RVA="0x115CB94", Offset="0x115CB94", VA="0x115CB94", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x115CDBC", Offset="0x115CDBC", VA="0x115CDBC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x10698CC", Offset="0x10698CC")]
		[FieldOffset(Offset="0x30")]
		public Button GoButton;

		[FieldOffset(Offset="0x38")]
		public Button CancelButton;

		[Address(RVA="0x115CF88", Offset="0x115CF88", VA="0x115CF88")]
		public SerializedFields()
		{
		}
	}
}