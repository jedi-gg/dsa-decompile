using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SinglePageFlipBook : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105DE80", Offset="0x105DE80")]
	[FieldOffset(Offset="0x18")]
	private Action<SinglePageFlipBook.FlipDirection> PageFlipped;

	[FieldOffset(Offset="0x0")]
	private const float NEXT_PAGE_CLIP_PIVOT_Y = 0.5f;

	[FieldOffset(Offset="0x0")]
	private const float TURNING_PAGE_CLIP_PIVOT_Y = 0.5f;

	[FieldOffset(Offset="0x20")]
	private SinglePageFlipBook.PageReleasedState _pageReleasedState;

	[FieldOffset(Offset="0x28")]
	private SinglePageFlipBook.AutoFlipState _autoFlipState;

	[FieldOffset(Offset="0x30")]
	private RectTransform _currentPage;

	[FieldOffset(Offset="0x38")]
	private RectTransform _previousPage;

	[FieldOffset(Offset="0x40")]
	private RectTransform _nextPage;

	[FieldOffset(Offset="0x48")]
	private Vector3 _spineBottom;

	[FieldOffset(Offset="0x54")]
	private Vector3 _spineTop;

	[FieldOffset(Offset="0x60")]
	private Vector3 _edgeBottomRight;

	[FieldOffset(Offset="0x6C")]
	private Vector3 _edgeBottomLeft;

	[FieldOffset(Offset="0x78")]
	private Vector3 _pageCornerPos;

	[FieldOffset(Offset="0x84")]
	private Vector3 _turningPagePosition;

	[FieldOffset(Offset="0x90")]
	private float _initialRightPageShadowAlpha;

	[FieldOffset(Offset="0x94")]
	private float _pageWidth;

	[FieldOffset(Offset="0x98")]
	private float _pageDiagonalDistance;

	[FieldOffset(Offset="0x9C")]
	private SinglePageFlipBook.FlipDirection _flipDirection;

	[FieldOffset(Offset="0xA0")]
	private SinglePageFlipBook.Mode _mode;

	[FieldOffset(Offset="0xA4")]
	private bool _leftInputEnabled;

	[FieldOffset(Offset="0xA5")]
	private bool _rightInputEnabled;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private RectTransform _bookPanel;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private RectTransform _leftPageBounds;

	[FieldOffset(Offset="0xB8")]
	[SerializeField]
	private RectTransform _rightPageBounds;

	[FieldOffset(Offset="0xC0")]
	[SerializeField]
	private RectTransform _turningPageClip;

	[FieldOffset(Offset="0xC8")]
	[SerializeField]
	private RectTransform _leftPage;

	[FieldOffset(Offset="0xD0")]
	[SerializeField]
	private RectTransform _rightPage;

	[FieldOffset(Offset="0xD8")]
	[SerializeField]
	private RectTransform _turningPageFront;

	[FieldOffset(Offset="0xE0")]
	[SerializeField]
	private RectTransform _turningPageBack;

	[Attribute(Name="HeaderAttribute", RVA="0x105DF10", Offset="0x105DF10")]
	[FieldOffset(Offset="0xE8")]
	[SerializeField]
	private UiDragHandler _leftDragHandler;

	[FieldOffset(Offset="0xF0")]
	[SerializeField]
	private UiDragHandler _rightDragHandler;

	[FieldOffset(Offset="0xF8")]
	[SerializeField]
	private UiDragHandler _swipeHandler;

	[Attribute(Name="RangeAttribute", RVA="0x105DF7C", Offset="0x105DF7C")]
	[FieldOffset(Offset="0x100")]
	[SerializeField]
	private float _dragReleaseFlipPercent;

	[Attribute(Name="HeaderAttribute", RVA="0x105DFBC", Offset="0x105DFBC")]
	[FieldOffset(Offset="0x108")]
	[SerializeField]
	private Graphic _rightPageShadow;

	[FieldOffset(Offset="0x110")]
	[SerializeField]
	private GameObject _turningPageBackShadow;

	[FieldOffset(Offset="0x118")]
	[SerializeField]
	private GameObject _turningPageFrontThickness;

	[FieldOffset(Offset="0x120")]
	[SerializeField]
	private GameObject _turningPageBackThickness;

	[Attribute(Name="HeaderAttribute", RVA="0x105E038", Offset="0x105E038")]
	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private float _pageReleasedTweenDuration;

	[FieldOffset(Offset="0x12C")]
	[SerializeField]
	private float _autoFlipDuration;

	private Vector3 EndFlipPos
	{
		[Address(RVA="0x14C5618", Offset="0x14C5618", VA="0x14C5618")]
		get
		{
			return new Vector3();
		}
	}

	public bool IsIdle
	{
		[Address(RVA="0x14C3A88", Offset="0x14C3A88", VA="0x14C3A88")]
		get
		{
			return new bool();
		}
	}

	private Vector3 SpineOppositePivot
	{
		[Address(RVA="0x14C64DC", Offset="0x14C64DC", VA="0x14C64DC")]
		get
		{
			return new Vector3();
		}
	}

	private Vector3 SpinePivot
	{
		[Address(RVA="0x14C64D0", Offset="0x14C64D0", VA="0x14C64D0")]
		get
		{
			return new Vector3();
		}
	}

	private Vector3 StartFlipPos
	{
		[Address(RVA="0x14C5654", Offset="0x14C5654", VA="0x14C5654")]
		get
		{
			return new Vector3();
		}
	}

	[Address(RVA="0x14C64E8", Offset="0x14C64E8", VA="0x14C64E8")]
	public SinglePageFlipBook()
	{
	}

	[Address(RVA="0x14C3B8C", Offset="0x14C3B8C", VA="0x14C3B8C")]
	public void AutoFlipPage(SinglePageFlipBook.FlipDirection flipDirection)
	{
	}

	[Address(RVA="0x14C60AC", Offset="0x14C60AC", VA="0x14C60AC")]
	private float Calc_T0_T1_Angle(out Vector3 t1)
	{
		t1 = new Vector3();
		return new float();
	}

	[Address(RVA="0x14C5DC4", Offset="0x14C5DC4", VA="0x14C5DC4")]
	private void CalculatePageCornerPos()
	{
	}

	[Address(RVA="0x14C3BC4", Offset="0x14C3BC4", VA="0x14C3BC4")]
	private bool CanFlip(SinglePageFlipBook.FlipDirection flipDirection)
	{
		return new bool();
	}

	[Address(RVA="0x14C5418", Offset="0x14C5418", VA="0x14C5418")]
	private void EndDrag(PointerEventData data, UiDragHandler.Swipe swipe, Vector2 dragDelta)
	{
	}

	[Address(RVA="0x14C56A4", Offset="0x14C56A4", VA="0x14C56A4")]
	private void EndSwipe(PointerEventData data, UiDragHandler.Swipe swipe, Vector2 dragDelta)
	{
	}

	[Address(RVA="0x14C482C", Offset="0x14C482C", VA="0x14C482C")]
	private Vector3 GetInputLocalPos()
	{
		return new Vector3();
	}

	[Address(RVA="0x14C55EC", Offset="0x14C55EC", VA="0x14C55EC")]
	private void HandleSwipe(float dragDeltaX, float currentXTweenPercent)
	{
	}

	[Address(RVA="0x14C56CC", Offset="0x14C56CC", VA="0x14C56CC")]
	private void InitializeFlip(Vector3 point)
	{
	}

	[Address(RVA="0x14C4DA4", Offset="0x14C4DA4", VA="0x14C4DA4")]
	private void ResetState()
	{
	}

	[Address(RVA="0x14C3A98", Offset="0x14C3A98", VA="0x14C3A98")]
	public void SetPages(RectTransform current, RectTransform previous, RectTransform next, bool leftInputEnabled, bool rightInputEnabled)
	{
	}

	[Address(RVA="0x14C3D08", Offset="0x14C3D08", VA="0x14C3D08")]
	private void Start()
	{
	}

	[Address(RVA="0x14C3BF0", Offset="0x14C3BF0", VA="0x14C3BF0")]
	private void StartAutoFlipPage(float startingTimePercent = 0f)
	{
	}

	[Address(RVA="0x14C5410", Offset="0x14C5410", VA="0x14C5410")]
	private void StartDragLeftToRight(PointerEventData data)
	{
	}

	[Address(RVA="0x14C53A4", Offset="0x14C53A4", VA="0x14C53A4")]
	private void StartDragRightToLeft(PointerEventData data)
	{
	}

	[Address(RVA="0x14C53AC", Offset="0x14C53AC", VA="0x14C53AC")]
	private void StartManualDrag(SinglePageFlipBook.FlipDirection flipDirection)
	{
	}

	[Address(RVA="0x14C46DC", Offset="0x14C46DC", VA="0x14C46DC")]
	private void Update()
	{
	}

	[Address(RVA="0x14C6268", Offset="0x14C6268", VA="0x14C6268")]
	private void UpdateShadow(float angle)
	{
	}

	[Address(RVA="0x14C4970", Offset="0x14C4970", VA="0x14C4970")]
	private void UpdateTurningPagePosition(Vector3 turningPagePosition)
	{
	}

	public event Action<SinglePageFlipBook.FlipDirection> PageFlipped
	{
		[Address(RVA="0x14C38B0", Offset="0x14C38B0", VA="0x14C38B0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070EFC", Offset="0x1070EFC")]
		add
		{
		}
		[Address(RVA="0x14C399C", Offset="0x14C399C", VA="0x14C399C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1070F0C", Offset="0x1070F0C")]
		remove
		{
		}
	}

	public class AutoFlipState
	{
		[FieldOffset(Offset="0x10")]
		private float _timer;

		[FieldOffset(Offset="0x14")]
		private float _duration;

		[FieldOffset(Offset="0x18")]
		private float _maxFlipHeight;

		[FieldOffset(Offset="0x1C")]
		private float _flipHeightModifier;

		[FieldOffset(Offset="0x20")]
		private float _startX;

		[FieldOffset(Offset="0x24")]
		private float _endX;

		public bool HasFinished
		{
			[Address(RVA="0x14C52A8", Offset="0x14C52A8", VA="0x14C52A8")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14C46A8", Offset="0x14C46A8", VA="0x14C46A8")]
		public AutoFlipState(float maxFlipHeight)
		{
		}

		[Address(RVA="0x14C52B8", Offset="0x14C52B8", VA="0x14C52B8")]
		public Vector3 GetCurrentCoordinates()
		{
			return new Vector3();
		}

		[Address(RVA="0x14C5DB0", Offset="0x14C5DB0", VA="0x14C5DB0")]
		public void Reset(float startX, float timer, float duration, float flipHeightModifier)
		{
		}

		[Address(RVA="0x14C522C", Offset="0x14C522C", VA="0x14C522C")]
		public void TickUpdate()
		{
		}
	}

	public enum FlipDirection
	{
		[FieldOffset(Offset="0x0")]
		RightToLeft,
		[FieldOffset(Offset="0x0")]
		LeftToRight
	}

	private enum Mode
	{
		[FieldOffset(Offset="0x0")]
		Idle,
		[FieldOffset(Offset="0x0")]
		ManualDrag,
		[FieldOffset(Offset="0x0")]
		AutoFlip,
		[FieldOffset(Offset="0x0")]
		PageReleasedFlipPage,
		[FieldOffset(Offset="0x0")]
		PageReleasedReturnToCurrent
	}

	public class PageReleasedState
	{
		[FieldOffset(Offset="0x10")]
		private float _timer;

		[FieldOffset(Offset="0x14")]
		private float _duration;

		[FieldOffset(Offset="0x18")]
		private Vector3 _startPos;

		[FieldOffset(Offset="0x24")]
		private Vector3 _destination;

		public bool HasFinished
		{
			[Address(RVA="0x14C4D94", Offset="0x14C4D94", VA="0x14C4D94")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x14C4674", Offset="0x14C4674", VA="0x14C4674")]
		public PageReleasedState(float duration)
		{
		}

		[Address(RVA="0x14C517C", Offset="0x14C517C", VA="0x14C517C")]
		public Vector3 GetCurrentCoordinates()
		{
			return new Vector3();
		}

		[Address(RVA="0x14C5690", Offset="0x14C5690", VA="0x14C5690")]
		public void Reset(Vector3 startPos, Vector3 destination)
		{
		}

		[Address(RVA="0x14C4D18", Offset="0x14C4D18", VA="0x14C4D18")]
		public void TickUpdate()
		{
		}
	}
}