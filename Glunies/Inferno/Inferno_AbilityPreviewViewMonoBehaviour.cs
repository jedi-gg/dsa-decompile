using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_AbilityPreviewViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private AbilityPreviewView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15246A8", Offset="0x15246A8", VA="0x15246A8", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15246B0", Offset="0x15246B0", VA="0x15246B0")]
		public Inferno_AbilityPreviewViewMonoBehaviour()
		{
		}
	}
}