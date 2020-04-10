using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class CampaignViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private CampaignView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x118AF00", Offset="0x118AF00", VA="0x118AF00", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x118AF08", Offset="0x118AF08", VA="0x118AF08")]
	public CampaignViewMonoBehaviour()
	{
	}
}