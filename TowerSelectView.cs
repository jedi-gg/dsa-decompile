using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerSelectView : AStandardView
{
	[FieldOffset(Offset="0x68")]
	private IList<TowerMap> _towerMaps;

	[FieldOffset(Offset="0x70")]
	private IList<TowerStatus> _statuses;

	private TowerSelectView.SerializedFields Fields
	{
		[Address(RVA="0x1439CB4", Offset="0x1439CB4", VA="0x1439CB4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143AAE8", Offset="0x143AAE8", VA="0x143AAE8")]
	public TowerSelectView()
	{
	}

	[Address(RVA="0x143A360", Offset="0x143A360", VA="0x143A360")]
	private void BindTowerSelectListItem(WrappedScrollRectListItem listItem, int dataIndex)
	{
	}

	[Address(RVA="0x1439ED4", Offset="0x1439ED4", VA="0x1439ED4", Slot="15")]
	protected override RectTransform GetDynamicPointAtObject(string pointAtId)
	{
		return null;
	}

	[Address(RVA="0x1438234", Offset="0x1438234", VA="0x1438234")]
	public void GoToIndex(int index)
	{
	}

	[Address(RVA="0x143A284", Offset="0x143A284", VA="0x143A284")]
	private void InitializeTowerSelectListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x1438134", Offset="0x1438134", VA="0x1438134")]
	public void SetData(IList<TowerMap> towerMaps, IList<TowerStatus> statuses)
	{
	}

	[Address(RVA="0x1439D94", Offset="0x1439D94", VA="0x1439D94", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1439E78", Offset="0x1439E78", VA="0x1439E78", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106C07C", Offset="0x106C07C")]
		[FieldOffset(Offset="0x28")]
		public WrappedScrollRect TowerListScrollRect;

		[Address(RVA="0x143AAF0", Offset="0x143AAF0", VA="0x143AAF0")]
		public SerializedFields()
		{
		}
	}
}