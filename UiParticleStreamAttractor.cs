using Il2CppDummyDll;
using System;
using UnityEngine;

[Attribute(Name="ExecuteInEditMode", RVA="0x1048F7C", Offset="0x1048F7C")]
public class UiParticleStreamAttractor : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private ParticleSystem _collisionParticles;

	[Attribute(Name="TooltipAttribute", RVA="0x105E4E8", Offset="0x105E4E8")]
	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private WindZone _staticWindZone;

	[Attribute(Name="TooltipAttribute", RVA="0x105E534", Offset="0x105E534")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private WindZone _dynamicWindZone;

	[Address(RVA="0x158AFE8", Offset="0x158AFE8", VA="0x158AFE8")]
	public UiParticleStreamAttractor()
	{
	}

	[Address(RVA="0x158AB58", Offset="0x158AB58", VA="0x158AB58")]
	public void EmitCollisionParticle()
	{
	}

	[Address(RVA="0x158ABF8", Offset="0x158ABF8", VA="0x158ABF8")]
	public void SetAttractorRadius(float radius)
	{
	}
}