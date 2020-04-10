using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049AAC", Offset="0x1049AAC")]
	[Serializable]
	public class BoundInt : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private int _fallbackValue;

		public int Value
		{
			[Address(RVA="0x152E810", Offset="0x152E810", VA="0x152E810")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x152E82C", Offset="0x152E82C", VA="0x152E82C")]
		public BoundInt()
		{
		}
	}
}