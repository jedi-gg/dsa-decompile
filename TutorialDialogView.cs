using Glunies;
using Il2CppDummyDll;
using System;

public class TutorialDialogView : ADialogView
{
	public override ViewDepth Depth
	{
		[Address(RVA="0x143D388", Offset="0x143D388", VA="0x143D388", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	public override string PrefabName
	{
		[Address(RVA="0x143D390", Offset="0x143D390", VA="0x143D390", Slot="8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143D3D8", Offset="0x143D3D8", VA="0x143D3D8")]
	public TutorialDialogView()
	{
	}
}