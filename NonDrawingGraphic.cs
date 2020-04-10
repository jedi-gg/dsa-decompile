using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class NonDrawingGraphic : MaskableGraphic
{
	[Address(RVA="0x12FDBA4", Offset="0x12FDBA4", VA="0x12FDBA4")]
	public NonDrawingGraphic()
	{
	}

	[Address(RVA="0x12FDB74", Offset="0x12FDB74", VA="0x12FDB74", Slot="44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Address(RVA="0x12FDB6C", Offset="0x12FDB6C", VA="0x12FDB6C", Slot="29")]
	public override void SetMaterialDirty()
	{
	}

	[Address(RVA="0x12FDB70", Offset="0x12FDB70", VA="0x12FDB70", Slot="28")]
	public override void SetVerticesDirty()
	{
	}
}