using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CampaignNodeDetailsViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CampaignNodeDetailsView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11355EC", Offset="0x11355EC", VA="0x11355EC", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11355F4", Offset="0x11355F4", VA="0x11355F4")]
	public CampaignNodeDetailsViewMonoBehaviour()
	{
	}
}