using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TutorialPointAtViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TutorialPointAtView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143F010", Offset="0x143F010", VA="0x143F010", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143F018", Offset="0x143F018", VA="0x143F018")]
	public TutorialPointAtViewMonoBehaviour()
	{
	}
}