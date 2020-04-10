using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfileEditPopupView : APopupView
{
	[Attribute(Name="InjectAttribute", RVA="0x105BA50", Offset="0x105BA50")]
	[FieldOffset(Offset="0x68")]
	private PassportSeasonUtility _passportSeasonUtility;

	[Attribute(Name="InjectAttribute", RVA="0x105BA60", Offset="0x105BA60")]
	[FieldOffset(Offset="0x70")]
	private PlayerDomainController _playerDC;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<InventoryItem?> _avatars;

	[FieldOffset(Offset="0x80")]
	private ulong _selectedAvatarId;

	private PlayerProfileEditPopupView.SerializedFields Fields
	{
		[Address(RVA="0x133FE28", Offset="0x133FE28", VA="0x133FE28")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1340C60", Offset="0x1340C60", VA="0x1340C60")]
	public PlayerProfileEditPopupView()
	{
	}

	[Address(RVA="0x1340C68", Offset="0x1340C68", VA="0x1340C68")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10706A4", Offset="0x10706A4")]
	private char <ViewAssetLoaded>b__5_0(string text, int charIndex, char addedChar)
	{
		return new char();
	}

	[Address(RVA="0x1340B48", Offset="0x1340B48", VA="0x1340B48")]
	private void ApplyButtonClicked()
	{
	}

	[Address(RVA="0x1340718", Offset="0x1340718", VA="0x1340718")]
	private void BindAvatarListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1340A6C", Offset="0x1340A6C", VA="0x1340A6C")]
	private void DefaultBgToggled(bool isOn)
	{
	}

	[Address(RVA="0x1340628", Offset="0x1340628", VA="0x1340628")]
	private void InitializeAvatarListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1340BAC", Offset="0x1340BAC", VA="0x1340BAC")]
	private void ScrimClicked()
	{
	}

	[Address(RVA="0x133EC34", Offset="0x133EC34", VA="0x133EC34")]
	public void SetApplyButtonInteractable(bool interactable)
	{
	}

	[Address(RVA="0x133F8EC", Offset="0x133F8EC", VA="0x133F8EC")]
	public void SetAvatars(IReadOnlyList<InventoryItem?> avatars)
	{
	}

	[Address(RVA="0x133ED58", Offset="0x133ED58", VA="0x133ED58")]
	public void SetPlayerAvatar(InventoryItem? playerAvatar)
	{
	}

	[Address(RVA="0x133F9EC", Offset="0x133F9EC", VA="0x133F9EC")]
	public void SetUsername(string username)
	{
	}

	[Address(RVA="0x133EBEC", Offset="0x133EBEC", VA="0x133EBEC")]
	public void ShowUsernameWarning(bool showing)
	{
	}

	[Address(RVA="0x134090C", Offset="0x134090C", VA="0x134090C")]
	private void UsernameInputTextChanged(string username)
	{
	}

	[Address(RVA="0x133FF08", Offset="0x133FF08", VA="0x133FF08", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1340434", Offset="0x1340434", VA="0x1340434", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Address(RVA="0x1340994", Offset="0x1340994", VA="0x1340994")]
	private void VipBgToggled(bool isOn)
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public Button ApplyButton;

		[FieldOffset(Offset="0x38")]
		public Button ScrimButton;

		[FieldOffset(Offset="0x40")]
		public UiInputField UsernameInput;

		[FieldOffset(Offset="0x48")]
		public WrappedScrollRect AvatarScrollRect;

		[FieldOffset(Offset="0x50")]
		public RawImage AvatarImage;

		[FieldOffset(Offset="0x58")]
		public Image VipBg;

		[FieldOffset(Offset="0x60")]
		public UnityEngine.GameObject VipBgToggleContainer;

		[FieldOffset(Offset="0x68")]
		public Toggle VipBgToggle;

		[FieldOffset(Offset="0x70")]
		public Toggle DefaultBgToggle;

		[FieldOffset(Offset="0x78")]
		public UnityEngine.GameObject UsernameWarning;

		[Address(RVA="0x1340CB4", Offset="0x1340CB4", VA="0x1340CB4")]
		public SerializedFields()
		{
		}
	}
}