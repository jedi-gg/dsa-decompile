using Cinemachine;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class AbilityCameraActionComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		public CinemachineVirtualCameraBase VirtualCamera;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		public Transform Source;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		public Transform Target;

		[Address(RVA="0x152CB90", Offset="0x152CB90", VA="0x152CB90")]
		public AbilityCameraActionComponent()
		{
		}
	}
}