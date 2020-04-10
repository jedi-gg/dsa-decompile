using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class LanguageSelectViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private LanguageSelectView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x11D8DF0", Offset="0x11D8DF0", VA="0x11D8DF0", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11D8DF8", Offset="0x11D8DF8", VA="0x11D8DF8")]
	public LanguageSelectViewMonoBehaviour()
	{
	}
}