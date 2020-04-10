using Il2CppDummyDll;
using System;
using UnityEngine;

public class RandomAnimationStartTimeOnExit : StateMachineBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private string stateName;

	[Address(RVA="0x2C2BDC0", Offset="0x2C2BDC0", VA="0x2C2BDC0")]
	public RandomAnimationStartTimeOnExit()
	{
	}

	[Address(RVA="0x2C2BD60", Offset="0x2C2BD60", VA="0x2C2BD60", Slot="6")]
	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}