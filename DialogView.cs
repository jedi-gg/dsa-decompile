using Glunies;
using Il2CppDummyDll;
using System;

public class DialogView : ADialogView
{
	public override ViewDepth Depth
	{
		[Address(RVA="0x1203F5C", Offset="0x1203F5C", VA="0x1203F5C", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	[Address(RVA="0x1203F64", Offset="0x1203F64", VA="0x1203F64")]
	public DialogView()
	{
	}
}