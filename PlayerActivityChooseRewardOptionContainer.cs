using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayerActivityChooseRewardOptionContainer : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private RectTransform _optionParent;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Button _claimButton;

	public Button ClaimButton
	{
		[Address(RVA="0x132C0FC", Offset="0x132C0FC", VA="0x132C0FC")]
		get
		{
			return null;
		}
	}

	public RectTransform OptionParent
	{
		[Address(RVA="0x132C104", Offset="0x132C104", VA="0x132C104")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x132C10C", Offset="0x132C10C", VA="0x132C10C")]
	public PlayerActivityChooseRewardOptionContainer()
	{
	}
}