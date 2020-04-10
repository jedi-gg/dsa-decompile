using Il2CppDummyDll;
using System;

public class DailyEventView : AEventView
{
	[Attribute(Name="InjectAttribute", RVA="0x1057E74", Offset="0x1057E74")]
	[FieldOffset(Offset="0xA0")]
	private FeatureLockController _featureLockController;

	[Address(RVA="0x12ADE6C", Offset="0x12ADE6C", VA="0x12ADE6C")]
	public DailyEventView()
	{
	}

	[Address(RVA="0x12ADD78", Offset="0x12ADD78", VA="0x12ADD78", Slot="23")]
	protected override void BindEventTierListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x12ADCF0", Offset="0x12ADCF0", VA="0x12ADCF0", Slot="22")]
	public override void Initialize(string title)
	{
	}
}