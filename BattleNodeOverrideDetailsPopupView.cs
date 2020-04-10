using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class BattleNodeOverrideDetailsPopupView : APopupView
{
	private BattleNodeOverrideDetailsPopupView.SerializedFields Fields
	{
		[Address(RVA="0x11158C0", Offset="0x11158C0", VA="0x11158C0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11159A0", Offset="0x11159A0", VA="0x11159A0")]
	public BattleNodeOverrideDetailsPopupView()
	{
	}

	[Address(RVA="0x11156B8", Offset="0x11156B8", VA="0x11156B8")]
	public void SetData(string title, string description, string image)
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UiLabel Title;

		[FieldOffset(Offset="0x38")]
		public UiLabel Description;

		[FieldOffset(Offset="0x40")]
		public RawImage Image;

		[Address(RVA="0x11159A8", Offset="0x11159A8", VA="0x11159A8")]
		public SerializedFields()
		{
		}
	}
}