using Glunies.Audio;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Glunies.Sequencer
{
	public class UnitAudioRefComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private List<UnitAudioRefComponent.AudioClipReference> _references;

		[Address(RVA="0x1613B40", Offset="0x1613B40", VA="0x1613B40")]
		public UnitAudioRefComponent()
		{
		}

		[Address(RVA="0x16139F0", Offset="0x16139F0", VA="0x16139F0")]
		public AudioClipGroup GetReferencedClip(string id)
		{
			return null;
		}

		[Serializable]
		public class AudioClipReference
		{
			[FieldOffset(Offset="0x10")]
			public string Id;

			[FieldOffset(Offset="0x18")]
			public AudioClipGroup AudioClip;

			[Address(RVA="0x1613B48", Offset="0x1613B48", VA="0x1613B48")]
			public AudioClipReference()
			{
			}
		}
	}
}