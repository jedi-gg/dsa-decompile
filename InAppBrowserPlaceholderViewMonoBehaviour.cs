using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InAppBrowserPlaceholderViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private InAppBrowserPlaceholderView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x117E5A4", Offset="0x117E5A4", VA="0x117E5A4", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x117E5AC", Offset="0x117E5AC", VA="0x117E5AC")]
	public InAppBrowserPlaceholderViewMonoBehaviour()
	{
	}
}