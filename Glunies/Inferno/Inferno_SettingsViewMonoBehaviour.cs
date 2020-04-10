using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_SettingsViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private SettingsView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15248BC", Offset="0x15248BC", VA="0x15248BC", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15248C4", Offset="0x15248C4", VA="0x15248C4")]
		public Inferno_SettingsViewMonoBehaviour()
		{
		}
	}
}