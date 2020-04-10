using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14E5AB0", Offset="0x14E5AB0", VA="0x14E5AB0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14E5AB8", Offset="0x14E5AB8", VA="0x14E5AB8")]
	public ClubWarViewMonoBehaviour()
	{
	}
}