using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_EnvironmentViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private EnvironmentView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15246D8", Offset="0x15246D8", VA="0x15246D8", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15246E0", Offset="0x15246E0", VA="0x15246E0")]
		public Inferno_EnvironmentViewMonoBehaviour()
		{
		}
	}
}