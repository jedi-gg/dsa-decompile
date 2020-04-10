using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Sequencer
{
	[Serializable]
	public struct DSubObjectReference
	{
		[FieldOffset(Offset="0x0")]
		public string Id;

		[FieldOffset(Offset="0x8")]
		public GameObject Object;
	}
}