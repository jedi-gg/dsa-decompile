using DG.Tweening;
using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ClubDungeonDoorWidget : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const string ANIMATOR_SUB_OBJ_REF = "animator";

	[FieldOffset(Offset="0x0")]
	private const string IDLE_ANIM_TRIGGER = "Idle";

	[FieldOffset(Offset="0x0")]
	private readonly static int DISSOLVE_SHADER_PROPERTY;

	[FieldOffset(Offset="0x18")]
	[SerializeField]
	private Button _button;

	[FieldOffset(Offset="0x20")]
	[SerializeField]
	private GameObject _door;

	[FieldOffset(Offset="0x28")]
	[SerializeField]
	private GameObject _failContainer;

	[FieldOffset(Offset="0x30")]
	private Procrastinator _procrastinator;

	[FieldOffset(Offset="0x38")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x40")]
	private int _doorIndex;

	[FieldOffset(Offset="0x48")]
	private Tweener _hideTweener;

	[FieldOffset(Offset="0x50")]
	private int _materialStackId;

	[Address(RVA="0x11AF440", Offset="0x11AF440", VA="0x11AF440")]
	static ClubDungeonDoorWidget()
	{
	}

	[Address(RVA="0x11AF3C8", Offset="0x11AF3C8", VA="0x11AF3C8")]
	public ClubDungeonDoorWidget()
	{
	}

	[Address(RVA="0x11AF4A4", Offset="0x11AF4A4", VA="0x11AF4A4")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0B4", Offset="0x106F0B4")]
	private float <Initialize>b__0_0()
	{
		return new float();
	}

	[Address(RVA="0x11AF51C", Offset="0x11AF51C", VA="0x11AF51C")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106F0C4", Offset="0x106F0C4")]
	private void <Initialize>b__0_1(float dissolveAmount)
	{
	}

	[Address(RVA="0x11AF340", Offset="0x11AF340", VA="0x11AF340")]
	private void DoorClicked()
	{
	}

	[Address(RVA="0x11AF2DC", Offset="0x11AF2DC", VA="0x11AF2DC")]
	public void Hide()
	{
	}

	[Address(RVA="0x11AEE44", Offset="0x11AEE44", VA="0x11AEE44")]
	public void Initialize(WidgetDependencyContainer dependencies)
	{
	}

	[Address(RVA="0x11AF088", Offset="0x11AF088", VA="0x11AF088")]
	public void SetData(int doorIndex, bool isFailedDoor)
	{
	}

	[Address(RVA="0x11AF018", Offset="0x11AF018", VA="0x11AF018")]
	public void Shutdown()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B95C", Offset="0x104B95C")]
	private sealed class <>c__DisplayClass2_0
	{
		[FieldOffset(Offset="0x10")]
		public Animator animator;

		[Address(RVA="0x11AF2D4", Offset="0x11AF2D4", VA="0x11AF2D4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Address(RVA="0x11AF5B4", Offset="0x11AF5B4", VA="0x11AF5B4")]
		internal void <SetData>b__0()
		{
		}
	}
}