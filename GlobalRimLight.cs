using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteAlways", RVA="0x1048A9C", Offset="0x1048A9C")]
public class GlobalRimLight : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private readonly static int s_rimColorHash;

	[FieldOffset(Offset="0x4")]
	private readonly static int s_rimDirHash;

	[FieldOffset(Offset="0x8")]
	private readonly static int s_rimMinHash;

	[FieldOffset(Offset="0xC")]
	private readonly static int s_rimMaxHash;

	[Attribute(Name="RangeAttribute", RVA="0x105BF30", Offset="0x105BF30")]
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private float _rimMin;

	[Attribute(Name="RangeAttribute", RVA="0x105BF70", Offset="0x105BF70")]
	[FieldOffset(Offset="0x1C")]
	[SerializeField]
	private float _rimMax;

	[FieldOffset(Offset="0x20")]
	private Light _light;

	[FieldOffset(Offset="0x28")]
	private Transform _lightTransform;

	[Address(RVA="0x14EC9E8", Offset="0x14EC9E8", VA="0x14EC9E8")]
	static GlobalRimLight()
	{
	}

	[Address(RVA="0x14EC9D0", Offset="0x14EC9D0", VA="0x14EC9D0")]
	public GlobalRimLight()
	{
	}

	[Address(RVA="0x14EC958", Offset="0x14EC958", VA="0x14EC958", Slot="6")]
	protected virtual void OnDisable()
	{
	}

	[Address(RVA="0x14EC864", Offset="0x14EC864", VA="0x14EC864", Slot="4")]
	protected virtual void OnEnable()
	{
	}

	[Address(RVA="0x14EC954", Offset="0x14EC954", VA="0x14EC954", Slot="5")]
	protected virtual void Update()
	{
	}

	[Address(RVA="0x14EC65C", Offset="0x14EC65C", VA="0x14EC65C")]
	private void UpdateGlobalShaderVars()
	{
	}
}