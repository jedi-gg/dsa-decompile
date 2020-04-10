using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="RequireComponent", RVA="0x1048FF0", Offset="0x1048FF0")]
public class WrappedScrollRectListItem : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105E79C", Offset="0x105E79C")]
	[FieldOffset(Offset="0x18")]
	private int <ListItemDataIndex>k__BackingField;

	[FieldOffset(Offset="0x0")]
	private const float FULL_ALPHA = 1f;

	[FieldOffset(Offset="0x0")]
	private const float GHOSTED_ALPHA = 0.5f;

	[FieldOffset(Offset="0x1C")]
	private bool _inputEnabled;

	[FieldOffset(Offset="0x1D")]
	private bool _isGhosted;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	protected CanvasGroup _canvasGroup;

	public bool IsVisible
	{
		[Address(RVA="0x15A6F04", Offset="0x15A6F04", VA="0x15A6F04")]
		get
		{
			return new bool();
		}
	}

	public int ListItemDataIndex
	{
		[Address(RVA="0x15A82E0", Offset="0x15A82E0", VA="0x15A82E0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F7C", Offset="0x1070F7C")]
		get
		{
			return new int();
		}
		[Address(RVA="0x15A854C", Offset="0x15A854C", VA="0x15A854C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F8C", Offset="0x1070F8C")]
		set
		{
		}
	}

	[Address(RVA="0x15A8FFC", Offset="0x15A8FFC", VA="0x15A8FFC")]
	public WrappedScrollRectListItem()
	{
	}

	[Address(RVA="0x15A8F48", Offset="0x15A8F48", VA="0x15A8F48")]
	public void EnableInput(bool enabled)
	{
	}

	[Address(RVA="0x15A8FA4", Offset="0x15A8FA4", VA="0x15A8FA4")]
	private void Reset()
	{
	}

	[Address(RVA="0x15A8EE0", Offset="0x15A8EE0", VA="0x15A8EE0")]
	private void SetCanvasGroupInteractable(bool interactable)
	{
	}

	[Address(RVA="0x15A8F54", Offset="0x15A8F54", VA="0x15A8F54")]
	public void SetGhosted(bool ghosted)
	{
	}

	[Address(RVA="0x15A8E4C", Offset="0x15A8E4C", VA="0x15A8E4C", Slot="6")]
	public virtual void SetVisible(bool visible)
	{
	}

	[Address(RVA="0x15A8E44", Offset="0x15A8E44", VA="0x15A8E44", Slot="4")]
	public virtual void Shutdown()
	{
	}

	[Address(RVA="0x15A8E48", Offset="0x15A8E48", VA="0x15A8E48", Slot="5")]
	public virtual void TickUpdate()
	{
	}
}