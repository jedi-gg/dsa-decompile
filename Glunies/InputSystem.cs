using Il2CppDummyDll;
using System;
using UnityEngine.EventSystems;

namespace Glunies
{
	public class InputSystem
	{
		[FieldOffset(Offset="0x0")]
		private const int DEFAULT_DRAG_THRESHOLD = 10;

		[FieldOffset(Offset="0x0")]
		private const int STANDARD_DEVICE_DPI = 160;

		[FieldOffset(Offset="0x10")]
		private EventSystem _eventSystem;

		[FieldOffset(Offset="0x18")]
		private CustomStandaloneInputModule _inputModule;

		public CustomStandaloneInputModule InputModule
		{
			[Address(RVA="0x1526BEC", Offset="0x1526BEC", VA="0x1526BEC")]
			get
			{
				return null;
			}
		}

		[Address(RVA="0x1526C2C", Offset="0x1526C2C", VA="0x1526C2C")]
		public InputSystem()
		{
		}

		[Address(RVA="0x1526BF4", Offset="0x1526BF4", VA="0x1526BF4")]
		public void EnableInput(bool enable)
		{
		}

		[Address(RVA="0x151EFB8", Offset="0x151EFB8", VA="0x151EFB8")]
		public void Initialize()
		{
		}
	}
}