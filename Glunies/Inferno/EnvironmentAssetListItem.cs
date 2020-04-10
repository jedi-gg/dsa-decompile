using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class EnvironmentAssetListItem : WrappedScrollRectListItem
	{
		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private TextMeshProUGUI _envNameLabel;

		[FieldOffset(Offset="0x30")]
		[SerializeField]
		private Button _envButton;

		[Address(RVA="0x1523178", Offset="0x1523178", VA="0x1523178")]
		public EnvironmentAssetListItem()
		{
		}

		[Address(RVA="0x152300C", Offset="0x152300C", VA="0x152300C")]
		public void SetData(string envName, string envAssetId, Action<string> onClick)
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051208", Offset="0x1051208")]
		private sealed class <>c__DisplayClass0_0
		{
			[FieldOffset(Offset="0x10")]
			public Action<string> onClick;

			[FieldOffset(Offset="0x18")]
			public string envAssetId;

			[Address(RVA="0x1523170", Offset="0x1523170", VA="0x1523170")]
			public <>c__DisplayClass0_0()
			{
			}

			[Address(RVA="0x1523180", Offset="0x1523180", VA="0x1523180")]
			internal void <SetData>b__0()
			{
			}
		}
	}
}