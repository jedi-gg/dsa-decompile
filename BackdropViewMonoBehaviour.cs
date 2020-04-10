using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BackdropViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BackdropView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1160864", Offset="0x1160864", VA="0x1160864", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116086C", Offset="0x116086C", VA="0x116086C")]
	public BackdropViewMonoBehaviour()
	{
	}
}