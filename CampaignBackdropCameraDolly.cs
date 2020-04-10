using Il2CppDummyDll;
using System;
using UnityEngine;

public class CampaignBackdropCameraDolly : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	public UnityEngine.Camera Camera;

	[FieldOffset(Offset="0x20")]
	public Vector3 MinPosition;

	[FieldOffset(Offset="0x2C")]
	public Vector3 MaxPosition;

	[Address(RVA="0x1124F48", Offset="0x1124F48", VA="0x1124F48")]
	public CampaignBackdropCameraDolly()
	{
	}
}