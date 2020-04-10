using Glunies;
using Il2CppDummyDll;
using System;

public class SystemDialogView : ADialogView
{
	public override ViewDepth Depth
	{
		[Address(RVA="0x131C020", Offset="0x131C020", VA="0x131C020", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	public override bool OverridesContextualMessageInput
	{
		[Address(RVA="0x131C028", Offset="0x131C028", VA="0x131C028", Slot="9")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x131C030", Offset="0x131C030", VA="0x131C030")]
	public SystemDialogView()
	{
	}
}