using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class LoadingScrimView : AScrimView
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105C1A0", Offset="0x105C1A0")]
	[FieldOffset(Offset="0x69")]
	private bool <HeavyScrim>k__BackingField;

	[FieldOffset(Offset="0x70")]
	private Sequence _revealSequence;

	private LoadingScrimView.SerializedFields Fields
	{
		[Address(RVA="0x11D919C", Offset="0x11D919C", VA="0x11D919C")]
		get
		{
			return null;
		}
	}

	public bool HeavyScrim
	{
		[Address(RVA="0x11D9004", Offset="0x11D9004", VA="0x11D9004")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070814", Offset="0x1070814")]
		private get
		{
			return new bool();
		}
		[Address(RVA="0x11D900C", Offset="0x11D900C", VA="0x11D900C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070824", Offset="0x1070824")]
		set
		{
		}
	}

	[Address(RVA="0x11D95C8", Offset="0x11D95C8", VA="0x11D95C8")]
	public LoadingScrimView()
	{
	}

	[Address(RVA="0x11D9018", Offset="0x11D9018", VA="0x11D9018")]
	public void SetLabelText(string labelText, float? labelTextArg)
	{
	}

	[Address(RVA="0x11D927C", Offset="0x11D927C", VA="0x11D927C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x11D95B0", Offset="0x11D95B0", VA="0x11D95B0", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x11D9494", Offset="0x11D9494", VA="0x11D9494", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x11D9454", Offset="0x11D9454", VA="0x11D9454", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : AScrimView.SerializedFields
	{
		[FieldOffset(Offset="0x30")]
		public UnityEngine.GameObject LightScrim;

		[FieldOffset(Offset="0x38")]
		public UnityEngine.GameObject HeavyScrim;

		[FieldOffset(Offset="0x40")]
		public UnityEngine.GameObject LabelParent;

		[FieldOffset(Offset="0x48")]
		public UiLabel Label;

		[FieldOffset(Offset="0x50")]
		public CanvasGroup CanvasGroup;

		[Address(RVA="0x11D95D0", Offset="0x11D95D0", VA="0x11D95D0")]
		public SerializedFields()
		{
		}
	}
}