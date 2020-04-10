using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Attribute(Name="SequencerBoundFieldAttribute", RVA="0x1049AD4", Offset="0x1049AD4")]
	[Serializable]
	public class BoundVector3 : ABoundField
	{
		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private Vector3 _fallbackValue;

		public Vector3 Value
		{
			[Address(RVA="0x152BE5C", Offset="0x152BE5C", VA="0x152BE5C")]
			get
			{
				return new Vector3();
			}
		}

		[Address(RVA="0x152E83C", Offset="0x152E83C", VA="0x152E83C")]
		public BoundVector3()
		{
		}
	}
}