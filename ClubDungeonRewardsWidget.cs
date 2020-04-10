using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class ClubDungeonRewardsWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private WrappedScrollRect _rewardGroupsScrollRect;

	[FieldOffset(Offset="0x20")]
	private WidgetDependencyContainer _dependencies;

	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDc;

	[FieldOffset(Offset="0x30")]
	private List<DClubDungeonRewardGroup> _rewardGroups;

	public bool IsShowing
	{
		[Address(RVA="0x11B3B5C", Offset="0x11B3B5C", VA="0x11B3B5C")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11B4958", Offset="0x11B4958", VA="0x11B4958")]
	public ClubDungeonRewardsWidget()
	{
	}

	[Address(RVA="0x11B4840", Offset="0x11B4840", VA="0x11B4840")]
	private void BindRewardsGroupListItem(WrappedScrollRectListItem listItem, int index)
	{
	}

	[Address(RVA="0x11B4738", Offset="0x11B4738", VA="0x11B4738")]
	public void Hide()
	{
	}

	[Address(RVA="0x11B3B90", Offset="0x11B3B90", VA="0x11B3B90")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11B4770", Offset="0x11B4770", VA="0x11B4770")]
	private void InitializeRewardsGroupListItem(WrappedScrollRectListItem listItem)
	{
	}

	[Address(RVA="0x11B3CC0", Offset="0x11B3CC0", VA="0x11B3CC0")]
	public void SetData(ClubDungeonContext dungeonContext)
	{
	}

	[Address(RVA="0x11B3D34", Offset="0x11B3D34", VA="0x11B3D34")]
	private void SetRewardGroups(ulong currentRewardsNodeId, IList<ClubDungeonRewardGroup> groups)
	{
	}

	[Address(RVA="0x11B4700", Offset="0x11B4700", VA="0x11B4700")]
	public void Show()
	{
	}

	[Address(RVA="0x11B3C80", Offset="0x11B3C80", VA="0x11B3C80")]
	public void Shutdown()
	{
	}
}