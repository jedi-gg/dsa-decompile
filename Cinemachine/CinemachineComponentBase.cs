using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AB74", Offset="0x104AB74")]
	public abstract class CinemachineComponentBase : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		protected const float Epsilon = 0.0001f;

		[FieldOffset(Offset="0x18")]
		private CinemachineVirtualCameraBase m_vcamOwner;

		public Transform FollowTarget
		{
			[Address(RVA="0x1D45220", Offset="0x1D45220", VA="0x1D45220")]
			get
			{
				return null;
			}
		}

		public abstract bool IsValid
		{
			get;
		}

		public Transform LookAtTarget
		{
			[Address(RVA="0x1D452D0", Offset="0x1D452D0", VA="0x1D452D0")]
			get
			{
				return null;
			}
		}

		public abstract CinemachineCore.Stage Stage
		{
			get;
		}

		public CameraState VcamState
		{
			[Address(RVA="0x1D45380", Offset="0x1D45380", VA="0x1D45380")]
			get
			{
				return new CameraState();
			}
		}

		public CinemachineVirtualCameraBase VirtualCamera
		{
			[Address(RVA="0x1D45128", Offset="0x1D45128", VA="0x1D45128")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D3BF68", Offset="0x1D3BF68", VA="0x1D3BF68")]
		protected CinemachineComponentBase()
		{
		}

		public abstract void MutateCameraState(ref CameraState curState, float deltaTime);

		[Address(RVA="0x1D45468", Offset="0x1D45468", VA="0x1D45468", Slot="8")]
		public virtual void OnPositionDragged(Vector3 delta)
		{
		}

		[Address(RVA="0x1D45464", Offset="0x1D45464", VA="0x1D45464", Slot="5")]
		public virtual void PrePipelineMutateCameraState(ref CameraState state)
		{
		}
	}
}