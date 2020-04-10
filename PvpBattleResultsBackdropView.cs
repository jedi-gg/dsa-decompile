using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PvpBattleResultsBackdropView : AStandardView
{
	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1282BD4", Offset="0x1282BD4", VA="0x1282BD4", Slot="7")]
		get
		{
			return new bool();
		}
	}

	private PvpBattleResultsBackdropView.SerializedFields Fields
	{
		[Address(RVA="0x1282C60", Offset="0x1282C60", VA="0x1282C60")]
		get
		{
			return null;
		}
	}

	public override RenderMode MainCanvasRenderMode
	{
		[Address(RVA="0x1282BDC", Offset="0x1282BDC", VA="0x1282BDC", Slot="6")]
		get
		{
			return new RenderMode();
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x1282DEC", Offset="0x1282DEC", VA="0x1282DEC", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x1282DF4", Offset="0x1282DF4", VA="0x1282DF4")]
	public PvpBattleResultsBackdropView()
	{
	}

	[Address(RVA="0x1282D40", Offset="0x1282D40", VA="0x1282D40")]
	public void ShowDefeat()
	{
	}

	[Address(RVA="0x1282BE4", Offset="0x1282BE4", VA="0x1282BE4")]
	public void ShowVictory()
	{
	}

	[Address(RVA="0x1282DBC", Offset="0x1282DBC", VA="0x1282DBC", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1282DC4", Offset="0x1282DC4", VA="0x1282DC4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B69C", Offset="0x106B69C")]
		[FieldOffset(Offset="0x28")]
		public UnityEngine.GameObject Victory;

		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject Defeat;

		[Address(RVA="0x1282DFC", Offset="0x1282DFC", VA="0x1282DFC")]
		public SerializedFields()
		{
		}
	}
}