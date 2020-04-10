using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleInviteMessageViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleInviteMessageView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1101A8C", Offset="0x1101A8C", VA="0x1101A8C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1101A94", Offset="0x1101A94", VA="0x1101A94")]
	public BattleInviteMessageViewMonoBehaviour()
	{
	}
}