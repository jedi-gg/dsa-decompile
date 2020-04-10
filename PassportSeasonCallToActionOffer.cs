using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PassportSeasonCallToActionOffer : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UiLabel _label;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private RawImage[] _images;

	public RawImage[] Images
	{
		[Address(RVA="0x13FB7A0", Offset="0x13FB7A0", VA="0x13FB7A0")]
		get
		{
			return null;
		}
	}

	public UiLabel Label
	{
		[Address(RVA="0x13FB798", Offset="0x13FB798", VA="0x13FB798")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x13FB7A8", Offset="0x13FB7A8", VA="0x13FB7A8")]
	public PassportSeasonCallToActionOffer()
	{
	}
}