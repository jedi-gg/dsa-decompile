using Glunies;
using Glunies.Sequencer;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClubDungeonDoorSelectView : AStandardView
{
	[FieldOffset(Offset="0x68")]
	private ClubDungeonMapWidget _mapWidget;

	[FieldOffset(Offset="0x70")]
	private UnityEngine.GameObject _selectedDoor;

	public ClubDungeonDoorSelectViewSequencer FailSequencer
	{
		[Address(RVA="0x11ACFA4", Offset="0x11ACFA4", VA="0x11ACFA4")]
		get
		{
			return null;
		}
	}

	private ClubDungeonDoorSelectView.SerializedFields Fields
	{
		[Address(RVA="0x11ADA4C", Offset="0x11ADA4C", VA="0x11ADA4C")]
		get
		{
			return null;
		}
	}

	public override RenderMode MainCanvasRenderMode
	{
		[Address(RVA="0x11ADA44", Offset="0x11ADA44", VA="0x11ADA44", Slot="6")]
		get
		{
			return new RenderMode();
		}
	}

	public ClubDungeonDoorSelectViewSequencer SuccessSequencer
	{
		[Address(RVA="0x11ACF88", Offset="0x11ACF88", VA="0x11ACF88")]
		get
		{
			return null;
		}
	}

	public ClubDungeonDoorSelectViewSequencer TrySequencer
	{
		[Address(RVA="0x11ACDB0", Offset="0x11ACDB0", VA="0x11ACDB0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x11AE310", Offset="0x11AE310", VA="0x11AE310")]
	public ClubDungeonDoorSelectView()
	{
	}

	[Address(RVA="0x11ADBE0", Offset="0x11ADBE0", VA="0x11ADBE0")]
	public void ApplySequencerOverrides(ClubDungeonDoorSelectViewSequencer.RuntimeBindingType type, Binding binding)
	{
	}

	[Address(RVA="0x11AE1BC", Offset="0x11AE1BC", VA="0x11AE1BC")]
	private void ContinueClicked()
	{
	}

	[Address(RVA="0x11AD604", Offset="0x11AD604", VA="0x11AD604")]
	public void Initialize(List<ulong> failedDoors, string mapPrefab, Action finished)
	{
	}

	[Address(RVA="0x11AE240", Offset="0x11AE240", VA="0x11AE240")]
	private void ScreenClicked()
	{
	}

	[Address(RVA="0x11ACA30", Offset="0x11ACA30", VA="0x11ACA30")]
	public void SetSelectedDoor(UnityEngine.GameObject door, int doorIndex)
	{
	}

	[Address(RVA="0x11ADDC4", Offset="0x11ADDC4", VA="0x11ADDC4", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11ADFA4", Offset="0x11ADFA4", VA="0x11ADFA4", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B93C", Offset="0x104B93C")]
	private sealed class <>c__DisplayClass8_0
	{
		[FieldOffset(Offset="0x10")]
		public ClubDungeonDoorSelectView <>4__this;

		[FieldOffset(Offset="0x18")]
		public List<ulong> failedDoors;

		[FieldOffset(Offset="0x20")]
		public string mapPrefab;

		[FieldOffset(Offset="0x28")]
		public Action finished;

		[Address(RVA="0x11ADB2C", Offset="0x11ADB2C", VA="0x11ADB2C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Address(RVA="0x11AE318", Offset="0x11AE318", VA="0x11AE318")]
		internal void <Initialize>b__0(AssetHandle handle)
		{
		}
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public Transform CenterPos;

		[FieldOffset(Offset="0x30")]
		public Button ContinueButton;

		[FieldOffset(Offset="0x38")]
		public Button FullScreenInput;

		[FieldOffset(Offset="0x40")]
		public Camera WorldCamera;

		[FieldOffset(Offset="0x48")]
		public UnityEngine.GameObject MapParent;

		[Attribute(Name="HeaderAttribute", RVA="0x106A01C", Offset="0x106A01C")]
		[FieldOffset(Offset="0x50")]
		public ClubDungeonDoorSelectViewSequencer TrySequencer;

		[FieldOffset(Offset="0x58")]
		public ClubDungeonDoorSelectViewSequencer SuccessSequencer;

		[FieldOffset(Offset="0x60")]
		public ClubDungeonDoorSelectViewSequencer FailSequencer;

		[Address(RVA="0x11AEA20", Offset="0x11AEA20", VA="0x11AEA20")]
		public SerializedFields()
		{
		}
	}
}