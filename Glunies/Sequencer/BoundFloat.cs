using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049A84", Offset="0x1049A84")]
	[Serializable]
	public class BoundFloat : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private float _fallbackValue;

		public float Value
		{
			[Address(RVA="0x152C1A4", Offset="0x152C1A4", VA="0x152C1A4")]
			get
			{
				return new float();
			}
		}

		[Address(RVA="0x152E790", Offset="0x152E790", VA="0x152E790")]
		public BoundFloat()
		{
		}
	}
}