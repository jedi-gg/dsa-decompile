using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AchievementsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AchievementsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11567F8", Offset="0x11567F8", VA="0x11567F8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1156800", Offset="0x1156800", VA="0x1156800")]
	public AchievementsViewMonoBehaviour()
	{
	}
}