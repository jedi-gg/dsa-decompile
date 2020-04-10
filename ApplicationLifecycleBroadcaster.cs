using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class ApplicationLifecycleBroadcaster : MonoBehaviour
{
	[Attribute(Name="InjectAttribute", RVA="0x1052580", Offset="0x1052580")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Address(RVA="0x115D0B0", Offset="0x115D0B0", VA="0x115D0B0")]
	public ApplicationLifecycleBroadcaster()
	{
	}

	[Address(RVA="0x115CFA0", Offset="0x115CFA0", VA="0x115CFA0")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Address(RVA="0x115D028", Offset="0x115D028", VA="0x115D028")]
	private void OnApplicationPause(bool pause)
	{
	}
}