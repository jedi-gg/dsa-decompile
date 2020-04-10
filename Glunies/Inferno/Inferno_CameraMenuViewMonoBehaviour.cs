using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_CameraMenuViewMonoBehaviour : AViewMonoBehaviour
	{
		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private CameraMenuView.SerializedFields _serializedFields;

		public override ViewSerializedFields SerializedFields
		{
			[Address(RVA="0x15246B8", Offset="0x15246B8", VA="0x15246B8", Slot="4")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x15246C0", Offset="0x15246C0", VA="0x15246C0")]
		public Inferno_CameraMenuViewMonoBehaviour()
		{
		}
	}
}