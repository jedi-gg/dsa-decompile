using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBattleHudOverlayView : AView
{
	[FieldOffset(Offset="0x68")]
	private List<Sequence> _sequences;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x143CAF0", Offset="0x143CAF0", VA="0x143CAF0", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x143CAE8", Offset="0x143CAE8", VA="0x143CAE8", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private TutorialBattleHudOverlayView.SerializedFields Fields
	{
		[Address(RVA="0x143CEA4", Offset="0x143CEA4", VA="0x143CEA4")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x143D300", Offset="0x143D300", VA="0x143D300")]
	public TutorialBattleHudOverlayView()
	{
	}

	[Address(RVA="0x143CAF8", Offset="0x143CAF8", VA="0x143CAF8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x143D1F0", Offset="0x143D1F0", VA="0x143D1F0", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x143D0D4", Offset="0x143D0D4", VA="0x143D0D4", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x143CF84", Offset="0x143CF84", VA="0x143CF84", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public CanvasGroup[] Bubbles;

		[FieldOffset(Offset="0x30")]
		public RectTransform[] Pointers;

		[Address(RVA="0x143D370", Offset="0x143D370", VA="0x143D370")]
		public SerializedFields()
		{
		}
	}
}