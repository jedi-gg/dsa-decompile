using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerActivityTabViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ATabView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x132E934", Offset="0x132E934", VA="0x132E934", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x132E93C", Offset="0x132E93C", VA="0x132E93C")]
	public PlayerActivityTabViewMonoBehaviour()
	{
	}
}