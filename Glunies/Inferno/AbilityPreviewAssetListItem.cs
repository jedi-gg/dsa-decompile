using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class AbilityPreviewAssetListItem : WrappedScrollRectListItem
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private TextMeshProUGUI _previewNameLabel;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private Button _previewButton;

		[Address(RVA="0x142D488", Offset="0x142D488", VA="0x142D488")]
		public AbilityPreviewAssetListItem()
		{
		}

		[Address(RVA="0x142D31C", Offset="0x142D31C", VA="0x142D31C")]
		public void SetData(string previewName, string previewAssetId, Action<string> onClick)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051178", Offset="0x1051178")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> onClick;

			[FieldOffset(Offset="0x18")]
			public string previewAssetId;

			[Address(RVA="0x142D480", Offset="0x142D480", VA="0x142D480")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x142D490", Offset="0x142D490", VA="0x142D490")]
			internal void <SetData>b__0()
			{
			}
		}
	}
}