using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class StorePackOpeningHelpingHand : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private DOTweenAnimation _fadeTween;

	[Address(RVA="0x1315CEC", Offset="0x1315CEC", VA="0x1315CEC")]
	public StorePackOpeningHelpingHand()
	{
	}

	[Address(RVA="0x1315C48", Offset="0x1315C48", VA="0x1315C48")]
	private void OnEnable()
	{
	}
}