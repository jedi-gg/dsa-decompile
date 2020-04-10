using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class TutorialMessageBubbleViewMonoBehaviour : AViewMonoBehaviour
{
	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private TutorialMessageBubbleView.SerializedFields _serializedFields;

	public override ViewSerializedFields SerializedFields
	{
		[Address(RVA="0x143DFC8", Offset="0x143DFC8", VA="0x143DFC8", Slot="4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143DFD0", Offset="0x143DFD0", VA="0x143DFD0")]
	public TutorialMessageBubbleViewMonoBehaviour()
	{
	}
}