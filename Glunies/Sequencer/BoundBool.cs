using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049A48", Offset="0x1049A48")]
	[Serializable]
	public class BoundBool : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private bool _fallbackValue;

		public bool Value
		{
			[Address(RVA="0x152C188", Offset="0x152C188", VA="0x152C188")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x152E70C", Offset="0x152E70C", VA="0x152E70C")]
		public BoundBool()
		{
		}
	}
}