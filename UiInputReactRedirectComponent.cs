using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UiInputReactRedirectComponent : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Graphic _maskSource;

	public Graphic MaskSource
	{
		[Address(RVA="0x1586218", Offset="0x1586218", VA="0x1586218")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1586220", Offset="0x1586220", VA="0x1586220")]
	public UiInputReactRedirectComponent()
	{
	}
}