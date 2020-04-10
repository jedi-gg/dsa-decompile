using Cinemachine;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CameraShake : CinemachineExtension
{
	[FieldOffset(Offset="0x0")]
	public static Vector3 ShakeOffset;

	[Address(RVA="0x1124D94", Offset="0x1124D94", VA="0x1124D94")]
	static CameraShake()
	{
	}

	[Address(RVA="0x1124D8C", Offset="0x1124D8C", VA="0x1124D8C")]
	public CameraShake()
	{
	}

	[Address(RVA="0x1124C78", Offset="0x1124C78", VA="0x1124C78", Slot="6")]
	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}
}