using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitStatListItem : WrappedScrollRectListItem
{
	[FieldOffset(Offset="0x28")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x30")]
	private UnitStatListItem.DData _statData;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private Color _evenBgColor;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private Color _oddBgColor;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Graphic _bg;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _statNameLabel;

	[FieldOffset(Offset="0x88")]
	[SerializeField]
	private UiLabel _statValueLabel;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private Image _statIcon;

	[FieldOffset(Offset="0x98")]
	[SerializeField]
	private PressEventHandler _pressHandler;

	[Address(RVA="0x1512870", Offset="0x1512870", VA="0x1512870")]
	public UnitStatListItem()
	{
	}

	[Address(RVA="0x1512504", Offset="0x1512504", VA="0x1512504")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x15127EC", Offset="0x15127EC", VA="0x15127EC")]
	private void Pressed()
	{
	}

	[Address(RVA="0x1512628", Offset="0x1512628", VA="0x1512628")]
	public void SetStatData(UnitStatListItem.DData statData)
	{
	}

	[Address(RVA="0x15125CC", Offset="0x15125CC", VA="0x15125CC", Slot="4")]
	public override void Shutdown()
	{
	}

	public struct DData
	{
		[FieldOffset(Offset="0x0")]
		public string StatName;

		[FieldOffset(Offset="0x8")]
		public string StatDescription;

		[FieldOffset(Offset="0x10")]
		public double StatValue;

		[FieldOffset(Offset="0x18")]
		public UnitStatListItem.DData.NumberType TypeOfNumber;

		[FieldOffset(Offset="0x20")]
		public Sprite StatTexture;

		[Address(RVA="0xF01B54", Offset="0xF01B54", VA="0xF01B54")]
		public DData(string statName, string statDescription, Sprite statTexture, UnitStatListItem.DData.NumberType typeOfNumber = 0)
		{
		}

		public enum NumberType
		{
			[FieldOffset(Offset="0x0")]
			Integer,
			[FieldOffset(Offset="0x0")]
			Percentage
		}
	}
}