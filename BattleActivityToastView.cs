using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;

public class BattleActivityToastView : AStandardView
{
	[FieldOffset(Offset="0x0")]
	private const float FLY_OUT_FROM = 650f;

	[FieldOffset(Offset="0x0")]
	private const float FLY_OUT_TO = 42f;

	[FieldOffset(Offset="0x0")]
	private const float TWEEN_DURATION_S = 0.5f;

	[FieldOffset(Offset="0x0")]
	private const float HOLD_DURATION_S = 3.5f;

	[FieldOffset(Offset="0x0")]
	private const float FADE_OUT_DURATION_S = 1f;

	[FieldOffset(Offset="0x68")]
	private Sequence _flyOutSequence;

	private BattleActivityToastView.SerializedFields Fields
	{
		[Address(RVA="0x11685F8", Offset="0x11685F8", VA="0x11685F8")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x1168974", Offset="0x1168974", VA="0x1168974")]
	public BattleActivityToastView()
	{
	}

	[Address(RVA="0x1168454", Offset="0x1168454", VA="0x1168454")]
	public void ShowUpdatedValue(string activityNameKey, ulong currentValue, ulong maxValue, PlayerActivityType activityType)
	{
	}

	[Address(RVA="0x11686D8", Offset="0x11686D8", VA="0x11686D8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1168934", Offset="0x1168934", VA="0x1168934", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public CanvasGroup FlyOutRoot;

		[FieldOffset(Offset="0x30")]
		public UiLabel ActivityNameLabel;

		[FieldOffset(Offset="0x38")]
		public UiLabel ProgressLabel;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject PassportFreeContainer;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject PassportPremiumContainer;

		[Address(RVA="0x116897C", Offset="0x116897C", VA="0x116897C")]
		public SerializedFields()
		{
		}
	}
}