using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleNodeOverrideDetailsPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleNodeOverrideDetailsPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11159B0", Offset="0x11159B0", VA="0x11159B0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11159B8", Offset="0x11159B8", VA="0x11159B8")]
	public BattleNodeOverrideDetailsPopupViewMonoBehaviour()
	{
	}
}