using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

public class PinPageGridLayout : APinPageLayout
{
	[FieldOffset(Offset="0x18")]
	private List<PinPageItemComponent> _itemComponents;

	[Address(RVA="0x1410EC0", Offset="0x1410EC0", VA="0x1410EC0")]
	public PinPageGridLayout()
	{
	}

	[Address(RVA="0x141036C", Offset="0x141036C", VA="0x141036C", Slot="4")]
	public override void Initialize(WidgetDependencyContainer dependencies, PinPageItemComponent pinPageItemArchetype)
	{
	}

	[Address(RVA="0x1410D9C", Offset="0x1410D9C", VA="0x1410D9C", Slot="7")]
	public override void MarkAsNoLongerCurrentPage()
	{
	}

	[Address(RVA="0x1410810", Offset="0x1410810", VA="0x1410810", Slot="6")]
	public override void SetData(List<PinPageItemData> pinData)
	{
	}

	[Address(RVA="0x14105D4", Offset="0x14105D4", VA="0x14105D4", Slot="5")]
	public override void Shutdown()
	{
	}
}