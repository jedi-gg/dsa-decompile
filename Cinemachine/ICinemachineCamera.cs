using System;
using UnityEngine;

namespace Cinemachine
{
	public interface ICinemachineCamera
	{
		string Description
		{
			get;
		}

		Transform Follow
		{
			get;
			set;
		}

		ICinemachineCamera LiveChildOrSelf
		{
			get;
		}

		Transform LookAt
		{
			get;
			set;
		}

		string Name
		{
			get;
		}

		ICinemachineCamera ParentCamera
		{
			get;
		}

		int Priority
		{
			get;
			set;
		}

		CameraState State
		{
			get;
		}

		GameObject VirtualCameraGameObject
		{
			get;
		}

		bool IsLiveChild(ICinemachineCamera vcam);

		void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime);

		void UpdateCameraState(Vector3 worldUp, float deltaTime);
	}
}