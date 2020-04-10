using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ClubInvitesListViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private ClubInvitesListView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x1253208", Offset="0x1253208", VA="0x1253208", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1253210", Offset="0x1253210", VA="0x1253210")]
	public ClubInvitesListViewMonoBehaviour()
	{
	}
}