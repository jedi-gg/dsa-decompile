using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class CameraController : AInfernoController, IDispatchHandler<DCameraAction>, IDispatchHandler, IDispatchHandler<DInputFallthroughAction>
	{
		[FieldOffset(Offset="0x0")]
		private const float ROTATE_DRAG_RATE = 0.8f;

		[FieldOffset(Offset="0x0")]
		private const float MOVE_DRAG_RATE = -0.002f;

		[FieldOffset(Offset="0x0")]
		private const float SCROLL_RATE = -0.02f;

		[FieldOffset(Offset="0x0")]
		private const float MIN_ZOOM_DIST = 5f;

		[FieldOffset(Offset="0x0")]
		private const float MAX_ZOOM_DIST = 50f;

		[FieldOffset(Offset="0x0")]
		private readonly static Vector3 DEFAULT_CAM_WORLD_POS;

		[Attribute(Name="InjectAttribute", RVA="0x10648A8", Offset="0x10648A8")]
		[FieldOffset(Offset="0x28")]
		private DispatchSystem _dispatchSystem;

		[FieldOffset(Offset="0x30")]
		private Camera _camera;

		[FieldOffset(Offset="0x38")]
		private CameraDragAction _currentDragAction;

		[FieldOffset(Offset="0x40")]
		private Transform _lookAtTarget;

		[FieldOffset(Offset="0x48")]
		private Vector3 _lookAtPos;

		[FieldOffset(Offset="0x54")]
		private float _zoomPercent;

		[Address(RVA="0x151FF1C", Offset="0x151FF1C", VA="0x151FF1C")]
		static CameraController()
		{
		}

		[Address(RVA="0x151FF14", Offset="0x151FF14", VA="0x151FF14")]
		public CameraController()
		{
		}

		[Address(RVA="0x151F4A8", Offset="0x151F4A8", VA="0x151F4A8", Slot="7")]
		public void HandleDispatchAction(DCameraAction action)
		{
		}

		[Address(RVA="0x151F9D0", Offset="0x151F9D0", VA="0x151F9D0", Slot="8")]
		public void HandleDispatchAction(DInputFallthroughAction action)
		{
		}

		[Address(RVA="0x151F36C", Offset="0x151F36C", VA="0x151F36C", Slot="4")]
		public override void Initialize(Action finished)
		{
		}

		[Address(RVA="0x151F4E0", Offset="0x151F4E0", VA="0x151F4E0")]
		private void LookAt(Transform lookAtTarget)
		{
		}

		[Address(RVA="0x151FC4C", Offset="0x151FC4C", VA="0x151FC4C")]
		private void MoveCamera(Vector2 dragDelta)
		{
		}

		[Address(RVA="0x151FAA8", Offset="0x151FAA8", VA="0x151FAA8")]
		private void RotateCamera(Vector2 dragDelta)
		{
		}

		[Address(RVA="0x151F464", Offset="0x151F464", VA="0x151F464", Slot="5")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x151F674", Offset="0x151F674", VA="0x151F674")]
		private void ZoomCamera(float zoomPercent, bool updateView = false)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10511D8", Offset="0x10511D8")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action finished;

			[Address(RVA="0x151F45C", Offset="0x151F45C", VA="0x151F45C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x151FFA0", Offset="0x151FFA0", VA="0x151FFA0")]
			internal void <Initialize>b__0(CameraMenuView view)
			{
			}
		}
	}
}