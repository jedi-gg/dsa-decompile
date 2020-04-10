using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class UnitAssetListItem : WrappedScrollRectListItem
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private TextMeshProUGUI _unitNameLabel;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private Button _unitButton;

		[Address(RVA="0x1525B8C", Offset="0x1525B8C", VA="0x1525B8C")]
		public UnitAssetListItem()
		{
		}

		[Address(RVA="0x1525A20", Offset="0x1525A20", VA="0x1525A20")]
		public void SetData(string unitName, string unitAssetId, Action<string> onClick)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051268", Offset="0x1051268")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> onClick;

			[FieldOffset(Offset="0x18")]
			public string unitAssetId;

			[Address(RVA="0x1525B84", Offset="0x1525B84", VA="0x1525B84")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1525B94", Offset="0x1525B94", VA="0x1525B94")]
			internal void <SetData>b__0()
			{
			}
		}
	}
}