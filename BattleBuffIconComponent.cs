using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleBuffIconComponent : MonoBehaviour, IMonoArchetypePooledItem, ILoggable<LogCategory>
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052EF8", Offset="0x1052EF8")]
	[FieldOffset(Offset="0x18")]
	private uint <IconType>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052F08", Offset="0x1052F08")]
	[FieldOffset(Offset="0x1C")]
	private uint <StackId>k__BackingField;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1052F18", Offset="0x1052F18")]
	[FieldOffset(Offset="0x20")]
	private int <SortOrder>k__BackingField;

	[Attribute(Name="FormerlySerializedAsAttribute", RVA="0x1052F28", Offset="0x1052F28")]
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private UiLabel _durationLabel;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private UiLabel _countLabel;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Image _iconImage;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private List<Graphic> _coloredGraphics;

	[FieldOffset(Offset="0x48")]
	private LocalizationManager _locManager;

	public uint IconType
	{
		[Address(RVA="0x11364B0", Offset="0x11364B0", VA="0x11364B0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E288", Offset="0x106E288")]
		get
		{
			return new uint();
		}
		[Address(RVA="0x11364B8", Offset="0x11364B8", VA="0x11364B8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E298", Offset="0x106E298")]
		private set
		{
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x11364A8", Offset="0x11364A8", VA="0x11364A8", Slot="7")]
		get
		{
			return new LogCategory();
		}
	}

	public int SortOrder
	{
		[Address(RVA="0x11364D0", Offset="0x11364D0", VA="0x11364D0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2C8", Offset="0x106E2C8")]
		get
		{
			return new int();
		}
		[Address(RVA="0x11364D8", Offset="0x11364D8", VA="0x11364D8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2D8", Offset="0x106E2D8")]
		private set
		{
		}
	}

	public uint StackId
	{
		[Address(RVA="0x11364C0", Offset="0x11364C0", VA="0x11364C0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2A8", Offset="0x106E2A8")]
		get
		{
			return new uint();
		}
		[Address(RVA="0x11364C8", Offset="0x11364C8", VA="0x11364C8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106E2B8", Offset="0x106E2B8")]
		private set
		{
		}
	}

	[Address(RVA="0x11368BC", Offset="0x11368BC", VA="0x11368BC")]
	public BattleBuffIconComponent()
	{
	}

	[Address(RVA="0x11364E4", Offset="0x11364E4", VA="0x11364E4")]
	public void Hide()
	{
	}

	[Address(RVA="0x11364E0", Offset="0x11364E0", VA="0x11364E0", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x1136544", Offset="0x1136544", VA="0x1136544", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x1136714", Offset="0x1136714", VA="0x1136714")]
	public void SetDuration(bool isPermanent, uint durationTurns)
	{
	}

	[Address(RVA="0x11367D8", Offset="0x11367D8", VA="0x11367D8")]
	public void SetStackCount(uint stackCount)
	{
	}

	[Address(RVA="0x1136548", Offset="0x1136548", VA="0x1136548")]
	public void SetupBuffIcon(uint iconType, uint stackId, BattleBuffIconUiDatum reference, LocalizationManager locManager)
	{
	}

	[Address(RVA="0x1136520", Offset="0x1136520", VA="0x1136520", Slot="5")]
	public void Shutdown()
	{
	}
}