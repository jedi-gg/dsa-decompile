using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class KothLeaderboardViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private KothLeaderboardView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11CE428", Offset="0x11CE428", VA="0x11CE428", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11CE430", Offset="0x11CE430", VA="0x11CE430")]
	public KothLeaderboardViewMonoBehaviour()
	{
	}
}