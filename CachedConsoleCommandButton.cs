using Glunies;
using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CachedConsoleCommandButton : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x30")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private UiLabel _commandLabel;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Button _selectButton;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private TMP_InputField _inputField;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Button _deleteButton;

	[Address(RVA="0x1124488", Offset="0x1124488", VA="0x1124488")]
	public CachedConsoleCommandButton()
	{
	}

	[Address(RVA="0x1124284", Offset="0x1124284", VA="0x1124284")]
	private void CachedCommandButtonClicked()
	{
	}

	[Address(RVA="0x1124324", Offset="0x1124324", VA="0x1124324")]
	private void CachedCommandDeleteButtonClicked()
	{
	}

	[Address(RVA="0x11243CC", Offset="0x11243CC", VA="0x11243CC")]
	private void CachedCommandSaved(string command)
	{
	}

	[Address(RVA="0x1123DF8", Offset="0x1123DF8", VA="0x1123DF8")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x1124478", Offset="0x1124478", VA="0x1124478")]
	private char InputFieldValidator(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x11240DC", Offset="0x11240DC", VA="0x11240DC")]
	public void SetData()
	{
	}

	[Address(RVA="0x112401C", Offset="0x112401C", VA="0x112401C", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x11240E0", Offset="0x11240E0", VA="0x11240E0")]
	private void UpdateCommand()
	{
	}
}