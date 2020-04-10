using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class PlayerCollectionPowerView : AView
{
	[FieldOffset(Offset="0x68")]
	private Sequence _tween;

	public sealed override ViewDepth Depth
	{
		[Address(RVA="0x132EDE0", Offset="0x132EDE0", VA="0x132EDE0", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private PlayerCollectionPowerView.SerializedFields Fields
	{
		[Address(RVA="0x132EDE8", Offset="0x132EDE8", VA="0x132EDE8")]
		get
		{
			return null;
		}
	}

	protected override bool WillHandleBackButton
	{
		[Address(RVA="0x132F810", Offset="0x132F810", VA="0x132F810", Slot="19")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x132F818", Offset="0x132F818", VA="0x132F818")]
	public PlayerCollectionPowerView()
	{
	}

	[Address(RVA="0x132F820", Offset="0x132F820", VA="0x132F820")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070654", Offset="0x1070654")]
	private void <ViewAssetLoaded>b__3_0()
	{
	}

	[Address(RVA="0x132F87C", Offset="0x132F87C", VA="0x132F87C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070664", Offset="0x1070664")]
	private void <ViewAssetLoaded>b__3_1()
	{
	}

	[Address(RVA="0x132F6A4", Offset="0x132F6A4", VA="0x132F6A4")]
	private void BeginTally()
	{
	}

	[Address(RVA="0x132EBA0", Offset="0x132EBA0", VA="0x132EBA0")]
	public void BeginTween(ulong startValue, ulong endValue)
	{
	}

	[Address(RVA="0x132F750", Offset="0x132F750", VA="0x132F750")]
	private void EndTally()
	{
	}

	[Address(RVA="0x132F7AC", Offset="0x132F7AC", VA="0x132F7AC")]
	private void TweenFinished()
	{
	}

	[Address(RVA="0x132EEC8", Offset="0x132EEC8", VA="0x132EEC8", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x132F660", Offset="0x132F660", VA="0x132F660", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[Attribute(Name="HeaderAttribute", RVA="0x106B46C", Offset="0x106B46C")]
		[FieldOffset(Offset="0x28")]
		public RectTransform RootRect;

		[FieldOffset(Offset="0x30")]
		public TallyLabelUnsigned CurrentPowerLabel;

		[FieldOffset(Offset="0x38")]
		public TallyLabelUnsigned PowerDiffLabel;

		[FieldOffset(Offset="0x40")]
		public UiLabel PlusLabel;

		[FieldOffset(Offset="0x48")]
		public Color FilledLabelColor;

		[Attribute(Name="HeaderAttribute", RVA="0x106B4A4", Offset="0x106B4A4")]
		[FieldOffset(Offset="0x58")]
		public float AppearDuration;

		[FieldOffset(Offset="0x5C")]
		public float TallyStartDelay;

		[FieldOffset(Offset="0x60")]
		public float TallyDuration;

		[FieldOffset(Offset="0x64")]
		public float TallyEndDelay;

		[FieldOffset(Offset="0x68")]
		public float DiffScaleDuration;

		[FieldOffset(Offset="0x6C")]
		public Vector3 DiffStartScale;

		[FieldOffset(Offset="0x78")]
		public Vector3 DiffEndScale;

		[Address(RVA="0x132F8D8", Offset="0x132F8D8", VA="0x132F8D8")]
		public SerializedFields()
		{
		}
	}
}