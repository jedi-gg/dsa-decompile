using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class CCPAView : APopupView
{
	private CCPAView.SerializedFields Fields
	{
		[Address(RVA="0x11239C4", Offset="0x11239C4", VA="0x11239C4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1123D54", Offset="0x1123D54", VA="0x1123D54")]
	public CCPAView()
	{
	}

	[Address(RVA="0x1123D5C", Offset="0x1123D5C", VA="0x1123D5C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106EA08", Offset="0x106EA08")]
	private void <ViewAssetLoaded>b__1_0()
	{
	}

	[Address(RVA="0x1123CA8", Offset="0x1123CA8", VA="0x1123CA8")]
	private void GeneratePinConfirmationClicked()
	{
	}

	[Address(RVA="0x11238F8", Offset="0x11238F8", VA="0x11238F8")]
	public void SetIdentityPin(string pin)
	{
	}

	[Address(RVA="0x1123AA4", Offset="0x1123AA4", VA="0x1123AA4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1123BEC", Offset="0x1123BEC", VA="0x1123BEC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button PrivacyNTermsButton;

		[FieldOffset(Offset="0x38")]
		public Button GeneratePinButton;

		[FieldOffset(Offset="0x40")]
		public UiLabel GeneratedPinField;

		[Address(RVA="0x1123DE0", Offset="0x1123DE0", VA="0x1123DE0")]
		public SerializedFields()
		{
		}
	}
}