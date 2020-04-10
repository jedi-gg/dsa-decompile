using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

[Attribute(Name="RequireComponent", RVA="0x10487C8", Offset="0x10487C8")]
public class CampaignMapButtonComponent : MonoBehaviour, IMonoArchetypePooledItem
{
	[Attribute(Name="InjectAttribute", RVA="0x10553FC", Offset="0x10553FC")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x105540C", Offset="0x105540C")]
	[FieldOffset(Offset="0x20")]
	private LocalizationManager _lm;

	[FieldOffset(Offset="0x28")]
	private DCampaignAddress _mapAddress;

	[FieldOffset(Offset="0x40")]
	private Sequence _unlockSequence;

	[FieldOffset(Offset="0x48")]
	private Button _button;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private GameObject _lockRoot;

	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private GameObject _unlockedRoot;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RectTransform _selectedRoot;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private float _selectedYOffset;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private UiLabel _starsLabel;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private UiLabel _lockedMapLabel;

	[FieldOffset(Offset="0x80")]
	[SerializeField]
	private UiLabel _unlockedMapLabel;

	public DCampaignAddress MapAddress
	{
		[Address(RVA="0x112EE1C", Offset="0x112EE1C", VA="0x112EE1C")]
		get
		{
			return new DCampaignAddress();
		}
	}

	[Address(RVA="0x112F75C", Offset="0x112F75C", VA="0x112F75C")]
	public CampaignMapButtonComponent()
	{
	}

	[Address(RVA="0x112F6B0", Offset="0x112F6B0", VA="0x112F6B0")]
	private void HandleClick()
	{
	}

	[Address(RVA="0x112EE30", Offset="0x112EE30", VA="0x112EE30", Slot="4")]
	public void Initialize()
	{
	}

	[Address(RVA="0x112F208", Offset="0x112F208", VA="0x112F208", Slot="6")]
	public void Reinitialize()
	{
	}

	[Address(RVA="0x112F540", Offset="0x112F540", VA="0x112F540")]
	private void SetIsLocked(bool locked)
	{
	}

	[Address(RVA="0x112F304", Offset="0x112F304", VA="0x112F304")]
	public void SetMapData(DCampaignAddress address, int mapDisplayNumber, CampaignMapButtonComponent.LockedStatus lockedStatus, int acquiredStars, int possibleStars)
	{
	}

	[Address(RVA="0x112F644", Offset="0x112F644", VA="0x112F644")]
	public void SetSelected(bool selected)
	{
	}

	[Address(RVA="0x112F13C", Offset="0x112F13C", VA="0x112F13C", Slot="5")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x112F754", Offset="0x112F754", VA="0x112F754")]
	private void UnlockSequenceHalfCompleted()
	{
	}

	public enum LockedStatus
	{
		[FieldOffset(Offset="0x0")]
		Locked,
		[FieldOffset(Offset="0x0")]
		Unlocked,
		[FieldOffset(Offset="0x0")]
		JustUnlocked
	}
}