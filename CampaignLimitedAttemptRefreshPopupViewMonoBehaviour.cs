using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CampaignLimitedAttemptRefreshPopupViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CampaignLimitedAttemptRefreshPopupView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x112EE0C", Offset="0x112EE0C", VA="0x112EE0C", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x112EE14", Offset="0x112EE14", VA="0x112EE14")]
	public CampaignLimitedAttemptRefreshPopupViewMonoBehaviour()
	{
	}
}