using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using Zenject;

namespace Glunies.Inferno
{
	public class InfernoInstaller : MonoInstaller<InfernoInstaller>
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private InputFallthrough _inputFallthrough;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private GameObject _groundPlaneGo;

		[Address(RVA="0x15242C8", Offset="0x15242C8", VA="0x15242C8")]
		public InfernoInstaller()
		{
		}

		[Address(RVA="0x1523E94", Offset="0x1523E94", VA="0x1523E94", Slot="8")]
		public override void InstallBindings()
		{
		}

		[Address(RVA="0x152424C", Offset="0x152424C", VA="0x152424C")]
		private void OnApplicationQuit()
		{
		}
	}
}