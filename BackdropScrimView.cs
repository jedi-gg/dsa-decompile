using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class BackdropScrimView : AScrimView
{
	[FieldOffset(Offset="0x70")]
	private Sequence _revealSequence;

	[FieldOffset(Offset="0x78")]
	private Sequence _hideSequence;

	private BackdropScrimView.SerializedFields Fields
	{
		[Address(RVA="0x115F28C", Offset="0x115F28C", VA="0x115F28C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x115F504", Offset="0x115F504", VA="0x115F504")]
	public BackdropScrimView()
	{
	}

	[Address(RVA="0x115F50C", Offset="0x115F50C", VA="0x115F50C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070804", Offset="0x1070804")]
	private void <ViewAssetLoaded>b__2_0()
	{
	}

	[Address(RVA="0x115F008", Offset="0x115F008", VA="0x115F008")]
	public void Hide()
	{
	}

	[Address(RVA="0x115F080", Offset="0x115F080", VA="0x115F080")]
	public bool IsHiding()
	{
		return new bool();
	}

	[Address(RVA="0x115F08C", Offset="0x115F08C", VA="0x115F08C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x115F494", Offset="0x115F494", VA="0x115F494", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x115F3C0", Offset="0x115F3C0", VA="0x115F3C0", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x115F36C", Offset="0x115F36C", VA="0x115F36C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : AScrimView.SerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public CanvasGroup CanvasGroup;

		[FieldOffset(Offset="0x38")]
		public float HideDuration;

		[Address(RVA="0x115F518", Offset="0x115F518", VA="0x115F518")]
		public SerializedFields()
		{
		}
	}
}