using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_UnitViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private UnitView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x1524A70", Offset="0x1524A70", VA="0x1524A70", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1524A78", Offset="0x1524A78", VA="0x1524A78")]
		public Inferno_UnitViewMonoBehaviour()
		{
		}
	}
}