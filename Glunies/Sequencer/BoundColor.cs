using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049A5C", Offset="0x1049A5C")]
	[Serializable]
	public class BoundColor : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private Color _fallbackValue;

		public Color Value
		{
			[Address(RVA="0x152E714", Offset="0x152E714", VA="0x152E714")]
			get
			{
				return new Color();
			}
		}

		[Address(RVA="0x152E754", Offset="0x152E754", VA="0x152E754")]
		public BoundColor()
		{
		}
	}
}