using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DPopupHistory
	{
		[FieldOffset(Offset="0x0")]
		public readonly Type ControllerType;

		[FieldOffset(Offset="0x8")]
		public readonly ITransitionContext ContextOnExit;

		[Address(RVA="0xF00B84", Offset="0xF00B84", VA="0xF00B84")]
		public DPopupHistory(APopupController popupController)
		{
		}
	}
}