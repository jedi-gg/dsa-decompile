using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class AgeGateNameView : AStandardView
{
	private AgeGateNameView.SerializedFields Fields
	{
		[Address(RVA="0x11585F4", Offset="0x11585F4", VA="0x11585F4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1158B28", Offset="0x1158B28", VA="0x1158B28")]
	public AgeGateNameView()
	{
	}

	[Address(RVA="0x1158B30", Offset="0x1158B30", VA="0x1158B30")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106DFC8", Offset="0x106DFC8")]
	private char <ViewAssetLoaded>b__3_0(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x1158A70", Offset="0x1158A70", VA="0x1158A70")]
	private void AcceptClicked()
	{
	}

	[Address(RVA="0x1157A5C", Offset="0x1157A5C", VA="0x1157A5C")]
	public void SetApplyButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x11580BC", Offset="0x11580BC", VA="0x11580BC")]
	public void SetUsername(string username)
	{
	}

	[Address(RVA="0x1157A14", Offset="0x1157A14", VA="0x1157A14")]
	public void ShowUsernameWarning(bool showing)
	{
	}

	[Address(RVA="0x11589B8", Offset="0x11589B8", VA="0x11589B8")]
	private void UsernameInputTextChanged(string username)
	{
	}

	[Address(RVA="0x11586D4", Offset="0x11586D4", VA="0x11586D4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11588C8", Offset="0x11588C8", VA="0x11588C8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1069824", Offset="0x1069824")]
		[FieldOffset(Offset="0x28")]
		public Button AcceptButton;

		[FieldOffset(Offset="0x30")]
		public UiInputField UsernameInput;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject UsernameWarning;

		[Address(RVA="0x1158B98", Offset="0x1158B98", VA="0x1158B98")]
		public SerializedFields()
		{
		}
	}
}