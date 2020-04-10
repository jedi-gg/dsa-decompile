using Il2CppDummyDll;
using System;
using UnityEngine;

public class RandomAnimationSelector : StateMachineBehaviour
{
	[FieldOffset(Offset="0x18")]
	private int _parameterHash;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private string _parameterName;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private int _maxOptions;

	[Address(RVA="0x2C2BD58", Offset="0x2C2BD58", VA="0x2C2BD58")]
	public RandomAnimationSelector()
	{
	}

	[Address(RVA="0x2C2BCD0", Offset="0x2C2BCD0", VA="0x2C2BCD0")]
	private void Awake()
	{
	}

	[Address(RVA="0x2C2BCFC", Offset="0x2C2BCFC", VA="0x2C2BCFC", Slot="4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}