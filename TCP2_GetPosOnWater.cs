using Il2CppDummyDll;
using System;
using UnityEngine;

public class TCP2_GetPosOnWater : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public Material WaterMaterial;

	[Attribute(Name="TooltipAttribute", RVA="0x105FB90", Offset="0x105FB90")]
	[FieldOffset(Offset="0x20")]
	public float heightScale;

	[Attribute(Name="SpaceAttribute", RVA="0x105FBC8", Offset="0x105FBC8")]
	[Attribute(Name="TooltipAttribute", RVA="0x105FBC8", Offset="0x105FBC8")]
	[FieldOffset(Offset="0x24")]
	public bool followWaterHeight;

	[Attribute(Name="TooltipAttribute", RVA="0x105FC14", Offset="0x105FC14")]
	[FieldOffset(Offset="0x28")]
	public float heightOffset;

	[Attribute(Name="SpaceAttribute", RVA="0x105FC4C", Offset="0x105FC4C")]
	[Attribute(Name="TooltipAttribute", RVA="0x105FC4C", Offset="0x105FC4C")]
	[FieldOffset(Offset="0x2C")]
	public bool followWaterNormal;

	[Attribute(Name="TooltipAttribute", RVA="0x105FC98", Offset="0x105FC98")]
	[FieldOffset(Offset="0x30")]
	public Vector3 upAxis;

	[Attribute(Name="TooltipAttribute", RVA="0x105FCD0", Offset="0x105FCD0")]
	[FieldOffset(Offset="0x3C")]
	public Vector3 postRotation;

	[Attribute(Name="HideInInspector", RVA="0x105FD08", Offset="0x105FD08")]
	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private bool isValid;

	[Attribute(Name="HideInInspector", RVA="0x105FD40", Offset="0x105FD40")]
	[FieldOffset(Offset="0x4C")]
	[SerializeField]
	private int sineCount;

	[FieldOffset(Offset="0x50")]
	private float[] sinePosOffsetsX;

	[FieldOffset(Offset="0x58")]
	private float[] sinePosOffsetsZ;

	[FieldOffset(Offset="0x60")]
	private float[] sinePhsOffsetsX;

	[FieldOffset(Offset="0x68")]
	private float[] sinePhsOffsetsZ;

	[Address(RVA="0x131E8A4", Offset="0x131E8A4", VA="0x131E8A4")]
	public TCP2_GetPosOnWater()
	{
	}

	[Address(RVA="0x131D2C8", Offset="0x131D2C8", VA="0x131D2C8")]
	public Vector3 GetNormalOnWater(Vector3 worldPosition)
	{
		return new Vector3();
	}

	[Address(RVA="0x131C300", Offset="0x131C300", VA="0x131C300")]
	public Vector3 GetPositionOnWater(Vector3 worldPosition)
	{
		return new Vector3();
	}

	[Address(RVA="0x131C108", Offset="0x131C108", VA="0x131C108")]
	private void LateUpdate()
	{
	}
}