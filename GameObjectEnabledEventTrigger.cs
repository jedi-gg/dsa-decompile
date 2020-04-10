using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.Events;

public class GameObjectEnabledEventTrigger : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private UnityEvent _enabledEvent;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private UnityEvent _disabledEvent;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UnityEvent _startEvent;

	[Address(RVA="0x15EC270", Offset="0x15EC270", VA="0x15EC270")]
	public GameObjectEnabledEventTrigger()
	{
	}

	[Address(RVA="0x15EC25C", Offset="0x15EC25C", VA="0x15EC25C")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x15EC248", Offset="0x15EC248", VA="0x15EC248")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x15EC234", Offset="0x15EC234", VA="0x15EC234")]
	private void Start()
	{
	}
}