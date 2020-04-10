using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[Attribute(Name="DocumentationSortingAttribute", RVA="0x104AB8C", Offset="0x104AB8C")]
	public abstract class CinemachineExtension : MonoBehaviour
	{
		[FieldOffset(Offset="0x0")]
		protected const float Epsilon = 0.0001f;

		[FieldOffset(Offset="0x18")]
		private CinemachineVirtualCameraBase m_vcamOwner;

		[FieldOffset(Offset="0x20")]
		private Dictionary<ICinemachineCamera, object> mExtraState;

		public CinemachineVirtualCameraBase VirtualCamera
		{
			[Address(RVA="0x1D49480", Offset="0x1D49480", VA="0x1D49480")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1D39B6C", Offset="0x1D39B6C", VA="0x1D39B6C")]
		protected CinemachineExtension()
		{
		}

		[Address(RVA="0x1D49518", Offset="0x1D49518", VA="0x1D49518", Slot="4")]
		protected virtual void Awake()
		{
		}

		[Address(RVA="0x1D4951C", Offset="0x1D4951C", VA="0x1D4951C")]
		private void ConnectToVcam()
		{
		}

		[Address(RVA="0x13EB77C", Offset="0x13EB77C", VA="0x13EB77C")]
		protected List<T> GetAllExtraStates<T>()
		where T : class, new()
		{
			return null;
		}

		[Address(RVA="0x16A7890", Offset="0x16A7890", VA="0x16A7890")]
		protected T GetExtraState<T>(ICinemachineCamera vcam)
		where T : class, new()
		{
			return null;
		}

		[Address(RVA="0x1D4247C", Offset="0x1D4247C", VA="0x1D4247C", Slot="5")]
		protected virtual void OnDestroy()
		{
		}

		protected abstract void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime);
	}
}