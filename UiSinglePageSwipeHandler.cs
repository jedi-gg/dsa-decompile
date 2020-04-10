using DG.Tweening;
using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UiSinglePageSwipeHandler : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private const float DRAG_NAVIGATE_THRESHOLD = 250f;

	[FieldOffset(Offset="0x0")]
	private const float DRAG_RESISTANCE = 1000f;

	[FieldOffset(Offset="0x18")]
	private Vector2 _pageRectStartingPos;

	[FieldOffset(Offset="0x20")]
	private Vector2 _dragDelta;

	[FieldOffset(Offset="0x28")]
	private Action _tweenOutFinished;

	[FieldOffset(Offset="0x30")]
	private Action _navigateLeft;

	[FieldOffset(Offset="0x38")]
	private Action _navigateRight;

	[FieldOffset(Offset="0x40")]
	private Func<bool> _canNavigateLeftFunc;

	[FieldOffset(Offset="0x48")]
	private Func<bool> _canNavigateRightFunc;

	[FieldOffset(Offset="0x50")]
	private Sequence _tweenLeftSequence;

	[FieldOffset(Offset="0x58")]
	private Sequence _tweenRightSequence;

	[FieldOffset(Offset="0x60")]
	[SerializeField]
	private RectTransform _pageRect;

	[FieldOffset(Offset="0x68")]
	[SerializeField]
	private UiDragHandler _dragHandler;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private Button _navigateLeftButton;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private Button _navigateRightButton;

	[Address(RVA="0x158BEB4", Offset="0x158BEB4", VA="0x158BEB4")]
	public UiSinglePageSwipeHandler()
	{
	}

	[Address(RVA="0x158B934", Offset="0x158B934", VA="0x158B934")]
	public void DoNavigate(bool playTween, bool moveLeft, bool moveRight)
	{
	}

	[Address(RVA="0x158BEA0", Offset="0x158BEA0", VA="0x158BEA0")]
	private void DoNavigateLeft()
	{
	}

	[Address(RVA="0x158BE8C", Offset="0x158BE8C", VA="0x158BE8C")]
	private void DoNavigateRight()
	{
	}

	[Address(RVA="0x158BA38", Offset="0x158BA38", VA="0x158BA38")]
	private void DoTweenOutFinished()
	{
	}

	[Address(RVA="0x158BB24", Offset="0x158BB24", VA="0x158BB24")]
	private void HandlePreviewContainerBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA="0x158BB90", Offset="0x158BB90", VA="0x158BB90")]
	private void HandlePreviewContainerDrag(PointerEventData eventData)
	{
	}

	[Address(RVA="0x158BCD0", Offset="0x158BCD0", VA="0x158BCD0")]
	private void HandlePreviewContainerEndDrag(PointerEventData eventData, UiDragHandler.Swipe swipe, Vector2 dragDelta)
	{
	}

	[Address(RVA="0x158B2C8", Offset="0x158B2C8", VA="0x158B2C8")]
	public void Initialize(Action tweenOutFinished, Action navigateLeft, Action navigateRight, Func<bool> canNavigateLeftFunc, Func<bool> canNavigateRightFunc)
	{
	}

	[Address(RVA="0x158B9A8", Offset="0x158B9A8", VA="0x158B9A8")]
	private void PauseTweens()
	{
	}

	[Address(RVA="0x158B75C", Offset="0x158B75C", VA="0x158B75C")]
	public void Shutdown()
	{
	}
}