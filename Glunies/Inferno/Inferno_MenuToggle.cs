using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Glunies.Inferno
{
	public class Inferno_MenuToggle : MonoBehaviour
	{
		[Attribute(Name="InjectAttribute", RVA="0x1064A80", Offset="0x1064A80")]
		[FieldOffset(Offset="0x18")]
		private DispatchSystem _dispatchSystem;

		[FieldOffset(Offset="0x20")]
		[SerializeField]
		private Toggle _menuToggle;

		[FieldOffset(Offset="0x28")]
		[SerializeField]
		private DMenuToggleAction.MenuType _menuType;

		[Address(RVA="0x15248B4", Offset="0x15248B4", VA="0x15248B4")]
		public Inferno_MenuToggle()
		{
		}

		[Address(RVA="0x15246F8", Offset="0x15246F8", VA="0x15246F8")]
		private void Awake()
		{
		}

		[Address(RVA="0x1524838", Offset="0x1524838", VA="0x1524838")]
		private void MenuToggled(bool isOn)
		{
		}

		[Address(RVA="0x15247A8", Offset="0x15247A8", VA="0x15247A8")]
		private void OnValidate()
		{
		}
	}
}