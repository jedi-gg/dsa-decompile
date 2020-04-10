using Il2CppDummyDll;
using System;
using TMPro;
using UnityEngine;

namespace Glunies.Inferno
{
	public class Inferno_UnitDetailsComponent : MonoBehaviour
	{
		[FieldOffset(Offset="0x18")]
		[SerializeField]
		private TextMeshProUGUI _unitNameLabel;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private TextMeshProUGUI _unitVertCountLabel;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private TextMeshProUGUI _unitTriCountLabel;

		[Address(RVA="0x1524A68", Offset="0x1524A68", VA="0x1524A68")]
		public Inferno_UnitDetailsComponent()
		{
		}

		[Address(RVA="0x1524A30", Offset="0x1524A30", VA="0x1524A30")]
		public void Hide()
		{
		}

		[Address(RVA="0x15248CC", Offset="0x15248CC", VA="0x15248CC")]
		public void Show(DUnitDisplayData data)
		{
		}
	}
}