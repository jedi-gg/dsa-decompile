using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049A70", Offset="0x1049A70")]
	[Serializable]
	public class BoundEnum : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private int _fallbackValue;

		public int Value
		{
			[Address(RVA="0x152CA58", Offset="0x152CA58", VA="0x152CA58")]
			get
			{
				return new int();
			}
		}

		[Address(RVA="0x152E788", Offset="0x152E788", VA="0x152E788")]
		public BoundEnum()
		{
		}
	}
}