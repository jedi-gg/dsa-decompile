using Il2CppDummyDll;
using System;
using UnityEngine;

public abstract class ABackdropAnimatable : MonoBehaviour
{
	[Address(RVA="0x10DE7E8", Offset="0x10DE7E8", VA="0x10DE7E8")]
	protected ABackdropAnimatable()
	{
	}

	public abstract void Initialize();

	public abstract void TickUpdate();
}