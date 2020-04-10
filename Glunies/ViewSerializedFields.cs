using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Glunies
{
	[Serializable]
	public class ViewSerializedFields
	{
		[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x10644C8", Offset="0x10644C8")]
		[FieldOffset(Offset="0x10")]
		public Canvas MainCanvas;

		[FieldOffset(Offset="0x18")]
		public List<ViewSerializedFields.AutoLocalizedLabel> AutoLocalizedFields;

		[FieldOffset(Offset="0x20")]
		public List<TMP_FontAsset> FontsForBundledFallbackInjection;

		[Address(RVA="0x16188B0", Offset="0x16188B0", VA="0x16188B0")]
		public ViewSerializedFields()
		{
		}

		[Serializable]
		public class AutoLocalizedLabel
		{
			[FieldOffset(Offset="0x10")]
			public UiLabel Label;

			[FieldOffset(Offset="0x18")]
			public string LocKey;

			[Address(RVA="0x16188B8", Offset="0x16188B8", VA="0x16188B8")]
			public AutoLocalizedLabel()
			{
			}
		}
	}
}