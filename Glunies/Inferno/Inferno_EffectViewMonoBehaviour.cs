using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_EffectViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private EffectView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15246C8", Offset="0x15246C8", VA="0x15246C8", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15246D0", Offset="0x15246D0", VA="0x15246D0")]
		public Inferno_EffectViewMonoBehaviour()
		{
		}
	}
}