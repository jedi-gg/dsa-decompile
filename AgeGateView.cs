using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class AgeGateView : AStandardView
{
	private AgeGateView.SerializedFields Fields
	{
		[Address(RVA="0x1158DDC", Offset="0x1158DDC", VA="0x1158DDC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1159064", Offset="0x1159064", VA="0x1159064")]
	public AgeGateView()
	{
	}

	[Address(RVA="0x115906C", Offset="0x115906C", VA="0x115906C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFA8", Offset="0x106DFA8")]
	private void <ViewAssetLoaded>b__0_0()
	{
	}

	[Address(RVA="0x1159074", Offset="0x1159074", VA="0x1159074")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFB8", Offset="0x106DFB8")]
	private void <ViewAssetLoaded>b__0_1()
	{
	}

	[Address(RVA="0x1158FA8", Offset="0x1158FA8", VA="0x1158FA8")]
	private void DispatchViewAction(DAgeGateViewAction.Type type)
	{
	}

	[Address(RVA="0x1158BB0", Offset="0x1158BB0", VA="0x1158BB0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1158EBC", Offset="0x1158EBC", VA="0x1158EBC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x10697EC", Offset="0x10697EC")]
		[FieldOffset(Offset="0x28")]
		public Button AgreeButton;

		[FieldOffset(Offset="0x30")]
		public UiSuperSlider AgeSlider;

		[FieldOffset(Offset="0x38")]
		public Button PrivacyButton;

		[Address(RVA="0x115907C", Offset="0x115907C", VA="0x115907C")]
		public SerializedFields()
		{
		}
	}
}