using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_MenuBarViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private MenuBarView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15246E8", Offset="0x15246E8", VA="0x15246E8", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15246F0", Offset="0x15246F0", VA="0x15246F0")]
		public Inferno_MenuBarViewMonoBehaviour()
		{
		}
	}
}