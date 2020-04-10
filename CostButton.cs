using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CostButton : InteractableOverrideButton
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DB50", Offset="0x105DB50")]
	[FieldOffset(Offset="0xF8")]
	private ulong <CostItemId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DB60", Offset="0x105DB60")]
	[FieldOffset(Offset="0x100")]
	private ulong <CostAmount>k__BackingField;

	[FieldOffset(Offset="0x108")]
	private Color? _defaultLabelColor;

	[FieldOffset(Offset="0x120")]
	private ContentSizeFitter _costLabelContentFitter;

	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private bool _ignoreAutoLayout;

	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x138")]
	[SerializeField]
	private UiLabel _costLabel;

	[FieldOffset(Offset="0x140")]
	[SerializeField]
	private RawImage _costImage;

	[FieldOffset(Offset="0x148")]
	[SerializeField]
	private Color _disabledLabelColor;

	[FieldOffset(Offset="0x158")]
	[SerializeField]
	private float _buttonMargin;

	public ulong CostAmount
	{
		[Address(RVA="0x154C448", Offset="0x154C448", VA="0x154C448")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070EBC", Offset="0x1070EBC")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x154C450", Offset="0x154C450", VA="0x154C450")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070ECC", Offset="0x1070ECC")]
		private set
		{
		}
	}

	public RawImage CostImage
	{
		[Address(RVA="0x154C430", Offset="0x154C430", VA="0x154C430")]
		get
		{
			return null;
		}
	}

	public ulong CostItemId
	{
		[Address(RVA="0x154C438", Offset="0x154C438", VA="0x154C438")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070E9C", Offset="0x1070E9C")]
		get
		{
			return new ulong();
		}
		[Address(RVA="0x154C440", Offset="0x154C440", VA="0x154C440")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070EAC", Offset="0x1070EAC")]
		private set
		{
		}
	}

	public UiLabel CostLabel
	{
		[Address(RVA="0x154C460", Offset="0x154C460", VA="0x154C460")]
		get
		{
			return null;
		}
	}

	public UiLabel Label
	{
		[Address(RVA="0x154C458", Offset="0x154C458", VA="0x154C458")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x154CC6C", Offset="0x154CC6C", VA="0x154CC6C")]
	public CostButton()
	{
	}

	[Address(RVA="0x154CA20", Offset="0x154CA20", VA="0x154CA20", Slot="4")]
	protected override void Awake()
	{
	}

	[Address(RVA="0x154C98C", Offset="0x154C98C", VA="0x154C98C")]
	public void DisableCost()
	{
	}

	[Address(RVA="0x154CB18", Offset="0x154CB18", VA="0x154CB18", Slot="26")]
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
	{
	}

	[Address(RVA="0x154CAF0", Offset="0x154CAF0", VA="0x154CAF0", Slot="5")]
	protected override void OnEnable()
	{
	}

	[Address(RVA="0x154C4A4", Offset="0x154C4A4", VA="0x154C4A4")]
	public void SetCost(uint cost, ulong costItemId)
	{
	}

	[Address(RVA="0x154C4AC", Offset="0x154C4AC", VA="0x154C4AC")]
	public void SetCost(ulong cost, ulong costItemId)
	{
	}

	[Address(RVA="0x154C468", Offset="0x154C468", VA="0x154C468")]
	public void SetText(string text)
	{
	}

	[Address(RVA="0x154C5B4", Offset="0x154C5B4", VA="0x154C5B4")]
	private void UpdateLayout()
	{
	}
}