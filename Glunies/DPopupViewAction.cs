using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DPopupViewAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DPopupViewAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public readonly APopupView View;

		[Address(RVA="0xF00C30", Offset="0xF00C30", VA="0xF00C30")]
		public DPopupViewAction(DPopupViewAction.Type actionType, APopupView view)
		{
		}

		public enum Type
		{
			[FieldOffset(Offset="0x0")]
			Close
		}
	}
}