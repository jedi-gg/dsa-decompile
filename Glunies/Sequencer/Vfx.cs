using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="AddComponentMenu", RVA="0x1049B84", Offset="0x1049B84")]
	public class Vfx : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private Vfx.DParticleSystem[] _particleSystems;

		[Address(RVA="0x1613E28", Offset="0x1613E28", VA="0x1613E28")]
		public Vfx()
		{
		}

		[Address(RVA="0x1613B50", Offset="0x1613B50", VA="0x1613B50")]
		public void Play()
		{
		}

		[Address(RVA="0x1613D20", Offset="0x1613D20", VA="0x1613D20")]
		public void SetCollisionPlane(Transform plane)
		{
		}

		[Address(RVA="0x1613C40", Offset="0x1613C40", VA="0x1613C40")]
		public void Stop()
		{
		}

		[Serializable]
		public struct DParticleSystem
		{
			[FieldOffset(Offset="0x0")]
			public ParticleSystem Component;

			[FieldOffset(Offset="0x8")]
			public bool Play;
		}
	}
}