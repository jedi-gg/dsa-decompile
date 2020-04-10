using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class SpellListViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private SpellListView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1243F1C", Offset="0x1243F1C", VA="0x1243F1C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1243F24", Offset="0x1243F24", VA="0x1243F24")]
	public SpellListViewMonoBehaviour()
	{
	}
}