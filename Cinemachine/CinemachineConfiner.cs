using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049E34", Offset="0x1049E34")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049E34", Offset="0x1049E34")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049E34", Offset="0x1049E34")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x1049E34", Offset="0x1049E34")]
	public class CinemachineConfiner : CinemachineExtension
	{
		[Attribute(Name="TooltipAttribute", RVA="0x106633C", Offset="0x106633C")]
		[FieldOffset(Offset="0x28")]
		public CinemachineConfiner.Mode m_ConfineMode;

		[Attribute(Name="TooltipAttribute", RVA="0x1066374", Offset="0x1066374")]
		[FieldOffset(Offset="0x30")]
		public Collider m_BoundingVolume;

		[Attribute(Name="TooltipAttribute", RVA="0x10663AC", Offset="0x10663AC")]
		[FieldOffset(Offset="0x38")]
		public Collider2D m_BoundingShape2D;

		[Attribute(Name="TooltipAttribute", RVA="0x10663E4", Offset="0x10663E4")]
		[FieldOffset(Offset="0x40")]
		public bool m_ConfineScreenEdges;

		[Attribute(Name="RangeAttribute", RVA="0x106641C", Offset="0x106641C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106641C", Offset="0x106641C")]
		[FieldOffset(Offset="0x44")]
		public float m_Damping;

		[FieldOffset(Offset="0x48")]
		private List<List<Vector2>> m_pathCache;

		public bool IsValid
		{
			[Address(RVA="0x1D46E20", Offset="0x1D46E20", VA="0x1D46E20")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x1D47F88", Offset="0x1D47F88", VA="0x1D47F88")]
		public CinemachineConfiner()
		{
		}

		[Address(RVA="0x1D46D24", Offset="0x1D46D24", VA="0x1D46D24")]
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D47564", Offset="0x1D47564", VA="0x1D47564")]
		private Vector3 ConfinePoint(Vector3 camPos)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D47158", Offset="0x1D47158", VA="0x1D47158")]
		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D47AA4", Offset="0x1D47AA4", VA="0x1D47AA4")]
		public void InvalidatePathCache()
		{
		}

		[Address(RVA="0x1D46DA0", Offset="0x1D46DA0", VA="0x1D46DA0")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x1D46EF4", Offset="0x1D46EF4", VA="0x1D46EF4", Slot="6")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Address(RVA="0x1D47AAC", Offset="0x1D47AAC", VA="0x1D47AAC")]
		private bool ValidatePathCache()
		{
			return new bool();
		}

		public enum Mode
		{
			[FieldOffset(Offset="0x0")]
			Confine2D,
			[FieldOffset(Offset="0x0")]
			Confine3D
		}

		private class VcamExtraState
		{
			[FieldOffset(Offset="0x10")]
			public Vector3 m_previousDisplacement;

			[FieldOffset(Offset="0x1C")]
			public float confinerDisplacement;

			[Address(RVA="0x1D47F98", Offset="0x1D47F98", VA="0x1D47F98")]
			public VcamExtraState()
			{
			}
		}
	}
}