using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049DC0", Offset="0x1049DC0")]
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x1049DC0", Offset="0x1049DC0")]
	[Attribute(Name="ExecuteInEditMode", RVA="0x1049DC0", Offset="0x1049DC0")]
	[Attribute(Name="SaveDuringPlayAttribute", RVA="0x1049DC0", Offset="0x1049DC0")]
	public class CinemachineCollider : CinemachineExtension
	{
		[Attribute(Name="HeaderAttribute", RVA="0x1065FEC", Offset="0x1065FEC")]
		[Attribute(Name="TooltipAttribute", RVA="0x1065FEC", Offset="0x1065FEC")]
		[FieldOffset(Offset="0x28")]
		public LayerMask m_CollideAgainst;

		[Attribute(Name="TagFieldAttribute", RVA="0x106604C", Offset="0x106604C")]
		[Attribute(Name="TooltipAttribute", RVA="0x106604C", Offset="0x106604C")]
		[FieldOffset(Offset="0x30")]
		public string m_IgnoreTag;

		[Attribute(Name="TooltipAttribute", RVA="0x1066098", Offset="0x1066098")]
		[FieldOffset(Offset="0x38")]
		public float m_MinimumDistanceFromTarget;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10660D0", Offset="0x10660D0")]
		[Attribute(Name="SpaceAttribute", RVA="0x10660D0", Offset="0x10660D0")]
		[Attribute(Name="TooltipAttribute", RVA="0x10660D0", Offset="0x10660D0")]
		[FieldOffset(Offset="0x3C")]
		public bool m_AvoidObstacles;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066140", Offset="0x1066140")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066140", Offset="0x1066140")]
		[FieldOffset(Offset="0x40")]
		public float m_DistanceLimit;

		[Attribute(Name="TooltipAttribute", RVA="0x10661A0", Offset="0x10661A0")]
		[FieldOffset(Offset="0x44")]
		public float m_CameraRadius;

		[Attribute(Name="TooltipAttribute", RVA="0x10661D8", Offset="0x10661D8")]
		[FieldOffset(Offset="0x48")]
		public CinemachineCollider.ResolutionStrategy m_Strategy;

		[Attribute(Name="RangeAttribute", RVA="0x1066210", Offset="0x1066210")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066210", Offset="0x1066210")]
		[FieldOffset(Offset="0x4C")]
		public int m_MaximumEffort;

		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1066264", Offset="0x1066264")]
		[Attribute(Name="RangeAttribute", RVA="0x1066264", Offset="0x1066264")]
		[Attribute(Name="TooltipAttribute", RVA="0x1066264", Offset="0x1066264")]
		[FieldOffset(Offset="0x50")]
		public float m_Damping;

		[Attribute(Name="HeaderAttribute", RVA="0x10662DC", Offset="0x10662DC")]
		[Attribute(Name="TooltipAttribute", RVA="0x10662DC", Offset="0x10662DC")]
		[FieldOffset(Offset="0x54")]
		public float m_OptimalTargetDistance;

		[FieldOffset(Offset="0x0")]
		private const float PrecisionSlush = 0.001f;

		[FieldOffset(Offset="0x58")]
		private RaycastHit[] m_CornerBuffer;

		[FieldOffset(Offset="0x0")]
		private const float AngleThreshold = 0.1f;

		[FieldOffset(Offset="0x60")]
		private Collider[] mColliderBuffer;

		[FieldOffset(Offset="0x68")]
		private SphereCollider mCameraCollider;

		[FieldOffset(Offset="0x70")]
		private GameObject mCameraColliderGameObject;

		public List<List<Vector3>> DebugPaths
		{
			[Address(RVA="0x1D4262C", Offset="0x1D4262C", VA="0x1D4262C")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D45060", Offset="0x1D45060", VA="0x1D45060")]
		public CinemachineCollider()
		{
		}

		[Address(RVA="0x1D4231C", Offset="0x1D4231C", VA="0x1D4231C")]
		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D430F4", Offset="0x1D430F4", VA="0x1D430F4")]
		private bool CheckForTargetObstructions(CameraState state)
		{
			return new bool();
		}

		[Address(RVA="0x1D44990", Offset="0x1D44990", VA="0x1D44990")]
		private float ClampRayToBounds(Ray ray, float distance, Bounds bounds)
		{
			return new float();
		}

		[Address(RVA="0x1D42580", Offset="0x1D42580", VA="0x1D42580")]
		private void CleanupCameraCollider()
		{
		}

		[Address(RVA="0x1D44714", Offset="0x1D44714", VA="0x1D44714")]
		private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos)
		{
			return new float();
		}

		[Address(RVA="0x1D43FA4", Offset="0x1D43FA4", VA="0x1D43FA4")]
		private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir)
		{
			return new bool();
		}

		[Address(RVA="0x1D422A8", Offset="0x1D422A8", VA="0x1D422A8")]
		public bool IsTargetObscured(ICinemachineCamera vcam)
		{
			return new bool();
		}

		[Address(RVA="0x1D42458", Offset="0x1D42458", VA="0x1D42458", Slot="5")]
		protected override void OnDestroy()
		{
		}

		[Address(RVA="0x1D42398", Offset="0x1D42398", VA="0x1D42398")]
		private void OnValidate()
		{
		}

		[Address(RVA="0x1D427B8", Offset="0x1D427B8", VA="0x1D427B8", Slot="6")]
		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		[Address(RVA="0x1D42C08", Offset="0x1D42C08", VA="0x1D42C08")]
		private Vector3 PreserveLignOfSight(ref CameraState state, ref CinemachineCollider.VcamExtraState extra)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D43560", Offset="0x1D43560", VA="0x1D43560")]
		private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref CinemachineCollider.VcamExtraState extra)
		{
			return new Vector3();
		}

		[Address(RVA="0x1D432A8", Offset="0x1D432A8", VA="0x1D432A8")]
		private bool RaycastIgnoreTag(Ray ray, out RaycastHit hitInfo, float rayLength)
		{
			hitInfo = new RaycastHit();
			return new bool();
		}

		[Address(RVA="0x1D43B54", Offset="0x1D43B54", VA="0x1D43B54")]
		private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos)
		{
			return new Vector3();
		}

		public enum ResolutionStrategy
		{
			[FieldOffset(Offset="0x0")]
			PullCameraForward,
			[FieldOffset(Offset="0x0")]
			PreserveCameraHeight,
			[FieldOffset(Offset="0x0")]
			PreserveCameraDistance
		}

		private class VcamExtraState
		{
			[FieldOffset(Offset="0x10")]
			public Vector3 m_previousDisplacement;

			[FieldOffset(Offset="0x1C")]
			public float colliderDisplacement;

			[FieldOffset(Offset="0x20")]
			public bool targetObscured;

			[FieldOffset(Offset="0x28")]
			public List<Vector3> debugResolutionPath;

			[Address(RVA="0x1D45120", Offset="0x1D45120", VA="0x1D45120")]
			public VcamExtraState()
			{
			}

			[Address(RVA="0x1D4355C", Offset="0x1D4355C", VA="0x1D4355C")]
			public void AddPointToDebugPath(Vector3 p)
			{
			}
		}
	}
}