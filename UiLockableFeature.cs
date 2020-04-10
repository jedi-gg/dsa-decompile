using DG.Tweening;
using Gamedata;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UiLockableFeature : MonoBehaviour
{
	[FieldOffset(Offset="0x18")]
	private Sequence _unlockSequence;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private Gamedata.LockableFeature _lockableFeature;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private Graphic _lockIcon;

	[FieldOffset(Offset="0x30")]
	[SerializeField]
	private GameObject _lockedContainer;

	[FieldOffset(Offset="0x38")]
	[SerializeField]
	private GameObject _unlockedContainer;

	[FieldOffset(Offset="0x40")]
	[SerializeField]
	private Badge _badge;

	[FieldOffset(Offset="0x48")]
	[SerializeField]
	private Graphic _iconToFade;

	[FieldOffset(Offset="0x50")]
	[SerializeField]
	private Material _fadeMaterial;

	[Attribute(Name="HeaderAttribute", RVA="0x105E3A4", Offset="0x105E3A4")]
	[FieldOffset(Offset="0x58")]
	[SerializeField]
	private UiLockableFeature.AnimationType _animationType;

	public Gamedata.LockableFeature LockableFeature
	{
		[Address(RVA="0x1586DDC", Offset="0x1586DDC", VA="0x1586DDC")]
		get
		{
			return new Gamedata.LockableFeature();
		}
	}

	[Address(RVA="0x158743C", Offset="0x158743C", VA="0x158743C")]
	public UiLockableFeature()
	{
	}

	[Address(RVA="0x1587418", Offset="0x1587418", VA="0x1587418")]
	public void PlayUnlockAnimation()
	{
	}

	[Address(RVA="0x1587074", Offset="0x1587074", VA="0x1587074")]
	public void QueueUnlockAnimation()
	{
	}

	[Address(RVA="0x1587434", Offset="0x1587434", VA="0x1587434")]
	private void SetAnimatedSequenceUnlocked()
	{
	}

	[Address(RVA="0x1586E18", Offset="0x1586E18", VA="0x1586E18")]
	public void SetUnlocked(bool unlocked)
	{
	}

	[Address(RVA="0x1586DE4", Offset="0x1586DE4", VA="0x1586DE4")]
	public void Shutdown()
	{
	}

	public enum AnimationType
	{
		[FieldOffset(Offset="0x0")]
		None,
		[FieldOffset(Offset="0x0")]
		LockAndScrim,
		[FieldOffset(Offset="0x0")]
		LockOpening
	}
}