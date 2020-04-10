using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class RemoteBattleStateTransitionViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private RemoteBattleStateTransitionView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x2C2EEB0", Offset="0x2C2EEB0", VA="0x2C2EEB0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x2C2EEB8", Offset="0x2C2EEB8", VA="0x2C2EEB8")]
	public RemoteBattleStateTransitionViewMonoBehaviour()
	{
	}
}