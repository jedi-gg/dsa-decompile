using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class LoadingScrimViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private LoadingScrimView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11D95D8", Offset="0x11D95D8", VA="0x11D95D8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D95E0", Offset="0x11D95E0", VA="0x11D95E0")]
	public LoadingScrimViewMonoBehaviour()
	{
	}
}