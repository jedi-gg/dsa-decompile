using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TransientScrimViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TransientScrimView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143C1D0", Offset="0x143C1D0", VA="0x143C1D0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143C1D8", Offset="0x143C1D8", VA="0x143C1D8")]
	public TransientScrimViewMonoBehaviour()
	{
	}
}