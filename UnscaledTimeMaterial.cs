using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x1048354", Offset="0x1048354")]
public class UnscaledTimeMaterial : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private readonly static int s_UnscaledTimeHash;

	[FieldOffset(Offset="0x18")]
	private Material _material;

	[FieldOffset(Offset="0x20")]
	private bool _valid;

	[Address(RVA="0x15A2738", Offset="0x15A2738", VA="0x15A2738")]
	static UnscaledTimeMaterial()
	{
	}

	[Address(RVA="0x15A2730", Offset="0x15A2730", VA="0x15A2730")]
	public UnscaledTimeMaterial()
	{
	}

	[Address(RVA="0x15A2650", Offset="0x15A2650", VA="0x15A2650")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x15A2654", Offset="0x15A2654", VA="0x15A2654")]
	private void Update()
	{
	}

	[Address(RVA="0x15A2494", Offset="0x15A2494", VA="0x15A2494")]
	public void Validate()
	{
	}
}