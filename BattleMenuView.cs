using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine.UI;

public class BattleMenuView : AView
{
	[Attribute(Name="InjectAttribute", RVA="0x1054AC4", Offset="0x1054AC4")]
	[FieldOffset(Offset="0x68")]
	private SharedPrefs _sharedPrefs;

	[FieldOffset(Offset="0x70")]
	private bool _allowPause;

	[FieldOffset(Offset="0x74")]
	private uint _pauseRequestId;

	public override bool CanTriggerContextualMessages
	{
		[Address(RVA="0x1112570", Offset="0x1112570", VA="0x1112570", Slot="7")]
		get
		{
			return new bool();
		}
	}

	public override ViewDepth Depth
	{
		[Address(RVA="0x1112568", Offset="0x1112568", VA="0x1112568", Slot="5")]
		get
		{
			return new ViewDepth();
		}
	}

	private BattleMenuView.SerializedFields Fields
	{
		[Address(RVA="0x11125F4", Offset="0x11125F4", VA="0x11125F4")]
		get
		{
			return null;
		}
	}

	public override bool OverridesContextualMessageInput
	{
		[Address(RVA="0x1112578", Offset="0x1112578", VA="0x1112578", Slot="9")]
		get
		{
			return new bool();
		}
	}

	[Address(RVA="0x11132A8", Offset="0x11132A8", VA="0x11132A8")]
	public BattleMenuView()
	{
	}

	[Address(RVA="0x11126D4", Offset="0x11126D4", VA="0x11126D4")]
	public void EnableCanvas(bool enabled)
	{
	}

	[Address(RVA="0x1112580", Offset="0x1112580", VA="0x1112580")]
	public void Initialize(bool allowQuit, bool allowPause)
	{
	}

	[Address(RVA="0x1112EC0", Offset="0x1112EC0", VA="0x1112EC0")]
	private void QuitClicked()
	{
	}

	[Address(RVA="0x1112EB4", Offset="0x1112EB4", VA="0x1112EB4")]
	private void ResumeClicked()
	{
	}

	[Address(RVA="0x1112F44", Offset="0x1112F44", VA="0x1112F44")]
	private void StatusEffectsClicked()
	{
	}

	[Address(RVA="0x11131F0", Offset="0x11131F0", VA="0x11131F0")]
	private void ToggleAbilityCamerasChanged(bool on)
	{
	}

	[Address(RVA="0x1113138", Offset="0x1113138", VA="0x1113138")]
	private void ToggleDamageNumbersChanged(bool on)
	{
	}

	[Address(RVA="0x1112FC8", Offset="0x1112FC8", VA="0x1112FC8")]
	private void ToggleMusicChanged(bool on)
	{
	}

	[Address(RVA="0x1113080", Offset="0x1113080", VA="0x1113080")]
	private void ToggleSfxChanged(bool on)
	{
	}

	[Address(RVA="0x111271C", Offset="0x111271C", VA="0x111271C", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x1112DD8", Offset="0x1112DD8", VA="0x1112DD8", Slot="14")]
	protected override void ViewHidden()
	{
	}

	[Address(RVA="0x1112CF0", Offset="0x1112CF0", VA="0x1112CF0", Slot="13")]
	protected override void ViewShown()
	{
	}

	[Address(RVA="0x1112B5C", Offset="0x1112B5C", VA="0x1112B5C", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public Button ResumeButton;

		[FieldOffset(Offset="0x30")]
		public Button QuitButton;

		[FieldOffset(Offset="0x38")]
		public ToggleEx MusicToggle;

		[FieldOffset(Offset="0x40")]
		public ToggleEx SfxToggle;

		[FieldOffset(Offset="0x48")]
		public ToggleEx DamageNumbersToggle;

		[FieldOffset(Offset="0x50")]
		public Button StatusEffectsButton;

		[FieldOffset(Offset="0x58")]
		public ToggleEx AbilityCamerasToggle;

		[Address(RVA="0x11132B0", Offset="0x11132B0", VA="0x11132B0")]
		public SerializedFields()
		{
		}
	}
}