using Il2CppDummyDll;
using System;

namespace Glunies.Inferno
{
	public struct DMenuToggleAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DMenuToggleAction.MenuType ToggledMenu;

		[FieldOffset(Offset="0x4")]
		public readonly bool ToggledOn;

		[Address(RVA="0xF01ED8", Offset="0xF01ED8", VA="0xF01ED8")]
		public DMenuToggleAction(DMenuToggleAction.MenuType toggledMenu, bool toggledOn)
		{
		}

		public enum MenuType
		{
			[FieldOffset(Offset="0x0")]
			SettingsMenu,
			[FieldOffset(Offset="0x0")]
			UnitMenu,
			[FieldOffset(Offset="0x0")]
			CameraMenu,
			[FieldOffset(Offset="0x0")]
			EffectMenu,
			[FieldOffset(Offset="0x0")]
			EnvironmentMenu,
			[FieldOffset(Offset="0x0")]
			AbilityPreviewMenu
		}
	}
}