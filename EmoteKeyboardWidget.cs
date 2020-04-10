using Gamedata;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmoteKeyboardWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private WrappedScrollRect _emotesScrollRect;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Toggle _keyboardToggle;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Toggle _muteToggle;

	[FieldOffset(Offset="0x30")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x38")]
	private List<InventoryItem> _emotes;

	public bool IsMuted
	{
		[Address(RVA="0x120AE58", Offset="0x120AE58", VA="0x120AE58")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x120B83C", Offset="0x120B83C", VA="0x120B83C")]
	public EmoteKeyboardWidget()
	{
	}

	[Address(RVA="0x120B3A4", Offset="0x120B3A4", VA="0x120B3A4")]
	private void BindEmotesListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x120B654", Offset="0x120B654", VA="0x120B654")]
	private void EmoteClicked(ulong emoteId)
	{
	}

	[Address(RVA="0x120AEF8", Offset="0x120AEF8", VA="0x120AEF8")]
	public void Initialize(WidgetDependencyContainer dependencies, bool isMuted = false)
	{
	}

	[Address(RVA="0x120B1C8", Offset="0x120B1C8", VA="0x120B1C8")]
	private void InitializeEmotesListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x120B134", Offset="0x120B134", VA="0x120B134")]
	public void LoadEmotes(List<InventoryItem> emotes)
	{
	}

	[Address(RVA="0x120B0C8", Offset="0x120B0C8", VA="0x120B0C8")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x120B7AC", Offset="0x120B7AC", VA="0x120B7AC")]
	private void ToggleKeyboard(bool isOn)
	{
	}
}