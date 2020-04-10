using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049AC0", Offset="0x1049AC0")]
	[Serializable]
	public class BoundString : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private string _fallbackValue;

		public string Value
		{
			[Address(RVA="0x152CD58", Offset="0x152CD58", VA="0x152CD58")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x152E834", Offset="0x152E834", VA="0x152E834")]
		public BoundString()
		{
		}
	}
}