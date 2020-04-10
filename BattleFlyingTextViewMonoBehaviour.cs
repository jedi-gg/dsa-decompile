using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleFlyingTextViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleFlyingTextView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1148388", Offset="0x1148388", VA="0x1148388", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1148390", Offset="0x1148390", VA="0x1148390")]
	public BattleFlyingTextViewMonoBehaviour()
	{
	}
}