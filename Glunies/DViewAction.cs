using Il2CppDummyDll;
using System;

namespace Glunies
{
	public struct DViewAction
	{
		[FieldOffset(Offset="0x0")]
		public readonly DViewAction.Type ActionType;

		[FieldOffset(Offset="0x8")]
		public readonly AView View;

		[Address(RVA="0xF00D08", Offset="0xF00D08", VA="0xF00D08")]
		public DViewAction(DViewAction.Type action, AView view)
		{
		}

		public enum Type
		{
			[FieldOffset(Offset="0x0")]
			Back
		}
	}
}