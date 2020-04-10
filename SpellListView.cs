using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class SpellListView : APopupView, IDispatchHandler<DSpellListItemAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x68")]
	private IReadOnlyList<Spell> _spells;

	[FieldOffset(Offset="0x70")]
	private IReadOnlyList<Spell> _selectedSpells;

	[FieldOffset(Offset="0x78")]
	private IReadOnlyList<Spell> _ineligibleSpells;

	[FieldOffset(Offset="0x80")]
	private IReadOnlyList<Spell> _activeBonusSpells;

	private SpellListView.SerializedFields Fields
	{
		[Address(RVA="0x1242BF4", Offset="0x1242BF4", VA="0x1242BF4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1243F0C", Offset="0x1243F0C", VA="0x1243F0C")]
	public SpellListView()
	{
	}

	[Address(RVA="0x1243594", Offset="0x1243594", VA="0x1243594")]
	private void BindListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x1242F78", Offset="0x1242F78", VA="0x1242F78", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1242CD4", Offset="0x1242CD4", VA="0x1242CD4", Slot="22")]
	public void HandleDispatchAction(DSpellListItemAction action)
	{
	}

	[Address(RVA="0x12434B0", Offset="0x12434B0", VA="0x12434B0")]
	private void InitializeListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x12425B4", Offset="0x12425B4", VA="0x12425B4")]
	public void SetSpellList(IReadOnlyList<Spell> spells, IReadOnlyList<Spell> selectedSpells, IReadOnlyList<Spell> ineligibleSpells, IReadOnlyList<Spell> activeBonusSpells)
	{
	}

	[Address(RVA="0x1242DF4", Offset="0x1242DF4", VA="0x1242DF4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1242EF8", Offset="0x1242EF8", VA="0x1242EF8", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : PopupViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106BBFC", Offset="0x106BBFC")]
		[FieldOffset(Offset="0x30")]
		public WrappedScrollRect ScrollRect;

		[Address(RVA="0x1243F14", Offset="0x1243F14", VA="0x1243F14")]
		public SerializedFields()
		{
		}
	}
}