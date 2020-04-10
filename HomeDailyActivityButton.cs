using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using UnityEngine;
using UnityEngine.UI;

public class HomeDailyActivityButton : WrappedScrollRectListItem, IDispatchHandler<DPlayerActivityUpdatedAction>, IDispatchHandler
{
	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private Button _goButton;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private Button _claimButton;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private UiLabel _nameText;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private UiLabel _progressText;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private SlicedFilledImage _progressFill;

	[Attribute(Name="HeaderAttribute", RVA="0x1058AA8", Offset="0x1058AA8")]
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private float _tickerDelayS;

	[FieldOffset(Offset="0x5C")]
	[SerializeField]
	private float _tickerDurationS;

	[FieldOffset(Offset="0x60")]
	private Serverproto.PlayerActivity _playerActivity;

	[FieldOffset(Offset="0x68")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x70")]
	private DispatchSystem _dispatchSystem;

	[FieldOffset(Offset="0x78")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x80")]
	private Tweener _labelTickerTweenLeft;

	public RectTransform ClaimButtonRectTransform
	{
		[Address(RVA="0x116E220", Offset="0x116E220", VA="0x116E220")]
		get
		{
			return null;
		}
	}

	public RectTransform GoButtonRectTransform
	{
		[Address(RVA="0x116E298", Offset="0x116E298", VA="0x116E298")]
		get
		{
			return null;
		}
	}

	public Serverproto.PlayerActivity PlayerActivity
	{
		[Address(RVA="0x116E310", Offset="0x116E310", VA="0x116E310")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x116EFDC", Offset="0x116EFDC", VA="0x116EFDC")]
	public HomeDailyActivityButton()
	{
	}

	[Address(RVA="0x116EFF0", Offset="0x116EFF0", VA="0x116EFF0")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FC94", Offset="0x106FC94")]
	private void <TickerTweenCompleted>b__14_0()
	{
	}

	[Address(RVA="0x116E71C", Offset="0x116E71C", VA="0x116E71C")]
	private void ActivityChanged()
	{
	}

	[Address(RVA="0x116EDCC", Offset="0x116EDCC", VA="0x116EDCC")]
	private void ClaimClicked()
	{
	}

	[Address(RVA="0x116ED2C", Offset="0x116ED2C", VA="0x116ED2C")]
	private void Clicked()
	{
	}

	[Address(RVA="0x116EE6C", Offset="0x116EE6C", VA="0x116EE6C")]
	private void GoClicked()
	{
	}

	[Address(RVA="0x116EC4C", Offset="0x116EC4C", VA="0x116EC4C", Slot="7")]
	public void HandleDispatchAction(DPlayerActivityUpdatedAction action)
	{
	}

	[Address(RVA="0x116E318", Offset="0x116E318", VA="0x116E318")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x116E714", Offset="0x116E714", VA="0x116E714")]
	public void SetData(Serverproto.PlayerActivity playerActivity)
	{
	}

	[Address(RVA="0x116E610", Offset="0x116E610", VA="0x116E610", Slot="4")]
	public override void Shutdown()
	{
	}

	[Address(RVA="0x116EF0C", Offset="0x116EF0C", VA="0x116EF0C")]
	private void TickerTweenCompleted()
	{
	}
}