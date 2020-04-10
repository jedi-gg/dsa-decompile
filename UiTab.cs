using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UiTab : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UnityEngine.UI.Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLockableFeature _lockableFeature;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiInputSquish _inputSquish;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Image _image;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Color _selectedColor;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Color _unselectedColor;

	public Badge Badge
	{
		[Address(RVA="0x158D31C", Offset="0x158D31C", VA="0x158D31C")]
		get
		{
			return null;
		}
	}

	public UnityEngine.UI.Button Button
	{
		[Address(RVA="0x158D314", Offset="0x158D314", VA="0x158D314")]
		get
		{
			return null;
		}
	}

	public UiInputSquish InputSquish
	{
		[Address(RVA="0x158D32C", Offset="0x158D32C", VA="0x158D32C")]
		get
		{
			return null;
		}
	}

	public UiLockableFeature LockableFeature
	{
		[Address(RVA="0x158D324", Offset="0x158D324", VA="0x158D324")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x158D504", Offset="0x158D504", VA="0x158D504")]
	public UiTab()
	{
	}

	[Address(RVA="0x158D334", Offset="0x158D334", VA="0x158D334")]
	public void SetSelected(bool selected, bool immediate = false)
	{
	}
}