using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class AppRatingViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private AppRatingView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x115CF90", Offset="0x115CF90", VA="0x115CF90", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115CF98", Offset="0x115CF98", VA="0x115CF98")]
	public AppRatingViewMonoBehaviour()
	{
	}
}