using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleUnitMaterialController
{
	[FieldOffset(Offset="0x0")]
	private const string UNIT_SHADER_NAME = "Glunies/Unit";

	[FieldOffset(Offset="0x0")]
	private readonly static int s_colorHash;

	[FieldOffset(Offset="0x4")]
	private readonly static int s_rimMinHash;

	[FieldOffset(Offset="0x8")]
	private readonly static int s_rimMaxHash;

	[FieldOffset(Offset="0xC")]
	private readonly static int s_rimColorHash;

	[FieldOffset(Offset="0x10")]
	private readonly static int s_outlineColorHash;

	[FieldOffset(Offset="0x14")]
	private readonly static int s_opacityHash;

	[FieldOffset(Offset="0x10")]
	private GameObject _rootGo;

	[FieldOffset(Offset="0x18")]
	private int _colorStackId;

	[FieldOffset(Offset="0x1C")]
	private int _outlineColorStackId;

	[FieldOffset(Offset="0x20")]
	private int _rimMinStackId;

	[FieldOffset(Offset="0x24")]
	private int _rimMaxStackId;

	[FieldOffset(Offset="0x28")]
	private int _rimColorStackId;

	[FieldOffset(Offset="0x2C")]
	private int _opacityStackId;

	[Address(RVA="0x129F1D8", Offset="0x129F1D8", VA="0x129F1D8")]
	static BattleUnitMaterialController()
	{
	}

	[Address(RVA="0x129BD50", Offset="0x129BD50", VA="0x129BD50")]
	public BattleUnitMaterialController(Transform unitRoot)
	{
	}

	[Address(RVA="0x129C134", Offset="0x129C134", VA="0x129C134")]
	public void Destroy()
	{
	}

	[Address(RVA="0x129C280", Offset="0x129C280", VA="0x129C280")]
	public void ResetColor()
	{
	}

	[Address(RVA="0x129F1A4", Offset="0x129F1A4", VA="0x129F1A4")]
	public void ResetMaterials()
	{
	}

	[Address(RVA="0x129D100", Offset="0x129D100", VA="0x129D100")]
	public void ResetOpacity()
	{
	}

	[Address(RVA="0x129C49C", Offset="0x129C49C", VA="0x129C49C")]
	public void ResetOutlineColor()
	{
	}

	[Address(RVA="0x129C70C", Offset="0x129C70C", VA="0x129C70C")]
	public void ResetRimValues()
	{
	}

	[Address(RVA="0x129C168", Offset="0x129C168", VA="0x129C168")]
	public void SetColor(Color color)
	{
	}

	[Address(RVA="0x129CFA4", Offset="0x129CFA4", VA="0x129CFA4")]
	public void SetOpacity(float opacity)
	{
	}

	[Address(RVA="0x129C384", Offset="0x129C384", VA="0x129C384")]
	public void SetOutlineColor(Color color)
	{
	}

	[Address(RVA="0x129C5A0", Offset="0x129C5A0", VA="0x129C5A0")]
	public void SetRimValues(float rimMin, float rimMax, Color rimColor)
	{
	}
}