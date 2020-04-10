using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;

public class BattleHealthBarBuffIconsComponent : MonoBehaviour, ILoggable<LogCategory>
{
	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private RectTransform _iconParent;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private int MaxBuffIcons;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _moreBuffsIcon;

	[FieldOffset(Offset="0x30")]
	private List<BattleBuffIconComponent> _allBuffIcons;

	[FieldOffset(Offset="0x38")]
	private BattleHealthBarsView.SpawnBattleBuffIcon _spawnBuffIcon;

	[FieldOffset(Offset="0x40")]
	private BattleHealthBarsView.DespawnBattleBuffIcon _despawnBuffIcon;

	[FieldOffset(Offset="0x48")]
	private List<BattleLib_UpdateResult.Types.Effect> _effects;

	public LogCategory LogCategory
	{
		[Address(RVA="0x1150BD4", Offset="0x1150BD4", VA="0x1150BD4", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1150BDC", Offset="0x1150BDC", VA="0x1150BDC")]
	public BattleHealthBarBuffIconsComponent()
	{
	}

	[Address(RVA="0x11500C8", Offset="0x11500C8", VA="0x11500C8")]
	public void GetAllCurrentBuffTypes(ref HashSet<uint> activeBuffTypes)
	{
	}

	[Address(RVA="0x11507FC", Offset="0x11507FC", VA="0x11507FC")]
	public RectTransform GetBuffIconPointAt(uint iconType)
	{
		return null;
	}

	[Address(RVA="0x114EEC0", Offset="0x114EEC0", VA="0x114EEC0")]
	public void ResetState()
	{
	}

	[Address(RVA="0x114F0FC", Offset="0x114F0FC", VA="0x114F0FC")]
	public void SetBuffIconPoolDelegates(BattleHealthBarsView.SpawnBattleBuffIcon spawn, BattleHealthBarsView.DespawnBattleBuffIcon despawn)
	{
	}

	[Address(RVA="0x114F914", Offset="0x114F914", VA="0x114F914")]
	public void UpdateBuffIcons(IReadOnlyList<BattleLib_UpdateResult.Types.Effect> effects, BattleBuffIconUiData buffIconUiData, LocalizationManager locManager)
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFDC", Offset="0x104AFDC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleBuffIconUiData buffIconUiData;

		[Address(RVA="0x10F927C", Offset="0x10F927C", VA="0x10F927C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x10F9284", Offset="0x10F9284", VA="0x10F9284")]
		internal int <UpdateBuffIcons>b__0(BattleLib_UpdateResult.Types.Effect a, BattleLib_UpdateResult.Types.Effect b)
		{
			return new int();
		}
	}
}