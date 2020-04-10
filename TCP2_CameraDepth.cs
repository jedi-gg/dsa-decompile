using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x10491E4", Offset="0x10491E4")]
[Attribute(Name="RequireComponent", RVA="0x10491E4", Offset="0x10491E4")]
public class TCP2_CameraDepth : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public bool RenderDepth;

	[Address(RVA="0x131C0F8", Offset="0x131C0F8", VA="0x131C0F8")]
	public TCP2_CameraDepth()
	{
	}

	[Address(RVA="0x131C040", Offset="0x131C040", VA="0x131C040")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x131C0F4", Offset="0x131C0F4", VA="0x131C0F4")]
	private void OnValidate()
	{
	}

	[Address(RVA="0x131C044", Offset="0x131C044", VA="0x131C044")]
	private void SetCameraDepth()
	{
	}
}