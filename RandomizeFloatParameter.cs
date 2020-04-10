using Il2CppDummyDll;
using System;
using UnityEngine;

public class RandomizeFloatParameter : StateMachineBehaviour
{
	[FieldOffset(Offset="0x18")]
	private int _parameterHash;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private string _parameterName;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private float _minRange;

	[FieldOffset(Offset="0x2C")]
	[SerializeField]
	private float _maxRange;

	[Address(RVA="0x2C2BE98", Offset="0x2C2BE98", VA="0x2C2BE98")]
	public RandomizeFloatParameter()
	{
	}

	[Address(RVA="0x2C2BE18", Offset="0x2C2BE18", VA="0x2C2BE18")]
	private void Awake()
	{
	}

	[Address(RVA="0x2C2BE44", Offset="0x2C2BE44", VA="0x2C2BE44", Slot="4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}