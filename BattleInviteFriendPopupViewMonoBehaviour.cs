using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BattleInviteFriendPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private BattleInviteFriendPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x10FF360", Offset="0x10FF360", VA="0x10FF360", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x10FF368", Offset="0x10FF368", VA="0x10FF368")]
	public BattleInviteFriendPopupViewMonoBehaviour()
	{
	}
}