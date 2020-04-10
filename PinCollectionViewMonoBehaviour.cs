using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PinCollectionViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private PinCollectionView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x140FB30", Offset="0x140FB30", VA="0x140FB30", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x140FB38", Offset="0x140FB38", VA="0x140FB38")]
	public PinCollectionViewMonoBehaviour()
	{
	}
}