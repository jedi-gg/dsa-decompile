using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DPopupControllerAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DPopupControllerAction.ActionType Action;

		[FieldOffset(Offset="0x8")]
		public readonly APopupController PopupController;

		[Address(RVA="0xF00B2C", Offset="0xF00B2C", VA="0xF00B2C")]
		public DPopupControllerAction(DPopupControllerAction.ActionType action, APopupController controller)
		{
		}

		public enum ActionType
		{
			[FieldOffset(Offset="0x0")]
			Close
		}
	}
}