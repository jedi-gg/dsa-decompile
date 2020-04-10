using Glunies;
using Il2CppDummyDll;
using System;

public class DialogContext : ITransitionContext
{
	[FieldOffset(Offset="0x10")]
	public string Id;

	[FieldOffset(Offset="0x18")]
	public string TitleText;

	[FieldOffset(Offset="0x20")]
	public string Text;

	[FieldOffset(Offset="0x28")]
	public string CancelText;

	[FieldOffset(Offset="0x30")]
	public string ButtonOneText;

	[FieldOffset(Offset="0x38")]
	public DialogContext.DCost? ButtonOneCost;

	[FieldOffset(Offset="0x50")]
	public Action Canceled;

	[FieldOffset(Offset="0x58")]
	public Action ButtonOneClicked;

	[FieldOffset(Offset="0x60")]
	public DialogContext.CancelTypeEnum CancelType;

	[FieldOffset(Offset="0x64")]
	public bool Persist;

	[FieldOffset(Offset="0x65")]
	public bool NeverClose;

	[FieldOffset(Offset="0x66")]
	public bool SwapConfirmAndCancel;

	[Address(RVA="0x1203D88", Offset="0x1203D88", VA="0x1203D88")]
	public DialogContext()
	{
	}

	public enum CancelTypeEnum
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		ButtonOnly,
		[FieldOffset(Offset="0x0")]
		ScrimOnly,
		[FieldOffset(Offset="0x0")]
		ButtonAndScrim
	}

	public struct DCost
	{
		[FieldOffset(Offset="0x0")]
		public ulong ItemId;

		[FieldOffset(Offset="0x8")]
		public ulong Amount;

		[Address(RVA="0xEFD114", Offset="0xEFD114", VA="0xEFD114")]
		public DCost(ulong itemId, ulong amount)
		{
		}
	}
}