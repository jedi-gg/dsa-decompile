using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubWarSquadRosterPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubWarSquadRosterPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x14E1F00", Offset="0x14E1F00", VA="0x14E1F00", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x14E1F08", Offset="0x14E1F08", VA="0x14E1F08")]
	public ClubWarSquadRosterPopupViewMonoBehaviour()
	{
	}
}