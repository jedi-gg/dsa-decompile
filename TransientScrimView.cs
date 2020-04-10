using Glunies;
using Il2CppDummyDll;
using System;

public class TransientScrimView : AView
{
	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x143C0A8", Offset="0x143C0A8", VA="0x143C0A8", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x143C0A0", Offset="0x143C0A0", VA="0x143C0A0", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private TransientScrimView.SerializedFields Fields
	{
		[Address(RVA="0x143C0E0", Offset="0x143C0E0", VA="0x143C0E0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143C1C0", Offset="0x143C1C0", VA="0x143C1C0")]
	public TransientScrimView()
	{
	}

	[Address(RVA="0x143C0B0", Offset="0x143C0B0", VA="0x143C0B0", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x143C0B8", Offset="0x143C0B8", VA="0x143C0B8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Address(RVA="0x143C1C8", Offset="0x143C1C8", VA="0x143C1C8")]
		public SerializedFields()
		{
		}
	}
}