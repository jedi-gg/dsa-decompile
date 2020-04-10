using Il2CppDummyDll;
using System;

public struct DDialogViewAction
{
	[FieldOffset(Offset="0x0")]
	public readonly ADialogView View;

	[FieldOffset(Offset="0x8")]
	public readonly DDialogViewAction.Type ActionType;

	[Address(RVA="0xF04C94", Offset="0xF04C94", VA="0xF04C94")]
	public DDialogViewAction(ADialogView view, DDialogViewAction.Type actionType)
	{
	}

	public enum Type
	{
		[FieldOffset(Offset="0x0")]
		Cancel,
		[FieldOffset(Offset="0x0")]
		ScrimCancel,
		[FieldOffset(Offset="0x0")]
		ButtonOneClick
	}
}