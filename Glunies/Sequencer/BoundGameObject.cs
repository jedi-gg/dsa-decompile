using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049A98", Offset="0x1049A98")]
	[Serializable]
	public class BoundGameObject : ABoundField
	{
		public GameObject RawValue
		{
			[Address(RVA="0x152E798", Offset="0x152E798", VA="0x152E798")]
			get
			{
				return null;
			}
		}

		public GameObject Value
		{
			[Address(RVA="0x152B1A0", Offset="0x152B1A0", VA="0x152B1A0")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x152E808", Offset="0x152E808", VA="0x152E808")]
		public BoundGameObject()
		{
		}

		[Address(RVA="0x152B674", Offset="0x152B674", VA="0x152B674")]
		public bool IsSelfOrChildOf(GameObject go)
		{
			return new bool();
		}
	}
}