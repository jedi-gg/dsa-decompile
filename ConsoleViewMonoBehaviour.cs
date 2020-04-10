using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ConsoleViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ConsoleView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1547654", Offset="0x1547654", VA="0x1547654", Slot="4")]
		get
		{
			return null;
		}
	}

	public override bool UseFontMapping
	{
		[Address(RVA="0x154765C", Offset="0x154765C", VA="0x154765C", Slot="5")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1547664", Offset="0x1547664", VA="0x1547664")]
	public ConsoleViewMonoBehaviour()
	{
	}
}