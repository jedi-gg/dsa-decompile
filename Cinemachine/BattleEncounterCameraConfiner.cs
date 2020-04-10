using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	public class BattleEncounterCameraConfiner : CinemachineExtension
	{
		[FieldOffset(Offset="0x0")]
		private const float DAMPING = 5f;

		[FieldOffset(Offset="0x28")]
		private Rect? _currentEncounterBounds;

		[FieldOffset(Offset="0x3C")]
		private Vector3 _previousCorrection;

		[Address(RVA="0x1D39B64", Offset="0x1D39B64", VA="0x1D39B64")]
		public BattleEncounterCameraConfiner()
		{
		}

		[Address(RVA="0x1D3915C", Offset="0x1D3915C", VA="0x1D3915C")]
		private Vector3 CalculateOffset(CameraState state)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D38FB4", Offset="0x1D38FB4", VA="0x1D38FB4")]
		public void ClearEncounterBounds()
		{
		}

		[Address(RVA="0x1D39A48", Offset="0x1D39A48", VA="0x1D39A48")]
		private Vector3 GetFloorIntersection(Ray ray)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D38FC0", Offset="0x1D38FC0", VA="0x1D38FC0", Slot="6")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Address(RVA="0x1D38EEC", Offset="0x1D38EEC", VA="0x1D38EEC")]
		public void SetEncounterBounds(Vector2 center, Vector2 size)
		{
		}
	}
}