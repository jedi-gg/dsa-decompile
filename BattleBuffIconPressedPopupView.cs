using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class BattleBuffIconPressedPopupView : APressedPopupView
{
	private BattleBuffIconPressedPopupView.SerializedFields Fields
	{
		[Address(RVA="0x1137D98", Offset="0x1137D98", VA="0x1137D98")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1137F10", Offset="0x1137F10", VA="0x1137F10")]
	public BattleBuffIconPressedPopupView()
	{
	}

	[Address(RVA="0x1137B64", Offset="0x1137B64", VA="0x1137B64")]
	public void TryShow(string buffIconLocNameKey)
	{
	}

	[Serializable]
	public class SerializedFields : PressedPopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public BattleBuffIconUiData BuffIconUiData;

		[FieldOffset(Offset="0x38")]
		public Image BuffIcon;

		[FieldOffset(Offset="0x40")]
		public UiLabel BuffName;

		[FieldOffset(Offset="0x48")]
		public UiLabel BuffDescription;

		[Address(RVA="0x1137F18", Offset="0x1137F18", VA="0x1137F18")]
		public SerializedFields()
		{
		}
	}
}