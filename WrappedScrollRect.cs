using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WrappedScrollRect : ScrollRect
{
	[FieldOffset(Offset="0x128")]
	[SerializeField]
	private WrappedScrollRectListItem _listItem;

	[Attribute(Name="TooltipAttribute", RVA="0x105E750", Offset="0x105E750")]
	[FieldOffset(Offset="0x130")]
	[SerializeField]
	private WrappedScrollRect.ContentScale _contentScale;

	[FieldOffset(Offset="0x138")]
	private List<WrappedScrollRectListItem> _pooledListItems;

	[FieldOffset(Offset="0x140")]
	private AWrappedLayoutGroup _contentLayout;

	[FieldOffset(Offset="0x148")]
	private WrappedScrollRect.BindDataDelegate _dataBindingCallback;

	[FieldOffset(Offset="0x150")]
	private WrappedScrollRect.InitializeListItemDelegate _itemInitializeCallback;

	[FieldOffset(Offset="0x158")]
	private int _timesWrapped;

	[FieldOffset(Offset="0x15C")]
	private int _dataCount;

	[FieldOffset(Offset="0x160")]
	private WrappedScrollRect.AutoScroller _autoScroller;

	public int DataCount
	{
		[Address(RVA="0x15A63DC", Offset="0x15A63DC", VA="0x15A63DC")]
		get
		{
			return new int();
		}
	}

	public bool IsAutoScrolling
	{
		[Address(RVA="0x15A63E4", Offset="0x15A63E4", VA="0x15A63E4")]
		get
		{
			return new bool();
		}
	}

	public int ItemCountAlongNonScrollAxis
	{
		[Address(RVA="0x15A6414", Offset="0x15A6414", VA="0x15A6414")]
		get
		{
			return new int();
		}
	}

	public int ItemCountAlongScrollAxis
	{
		[Address(RVA="0x15A6444", Offset="0x15A6444", VA="0x15A6444")]
		get
		{
			return new int();
		}
	}

	public WrappedScrollRectListItem ListItem
	{
		[Address(RVA="0x15A640C", Offset="0x15A640C", VA="0x15A640C")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x15A8CDC", Offset="0x15A8CDC", VA="0x15A8CDC")]
	public WrappedScrollRect()
	{
	}

	[Address(RVA="0x15A77F8", Offset="0x15A77F8", VA="0x15A77F8")]
	public void BindAllListItemData()
	{
	}

	[Address(RVA="0x15A81B4", Offset="0x15A81B4", VA="0x15A81B4")]
	public WrappedScrollRectListItem GetItem(int dataIndex)
	{
		return null;
	}

	[Address(RVA="0x15A79E4", Offset="0x15A79E4", VA="0x15A79E4")]
	private Vector2 GetScrollToPos(int dataIndex)
	{
		return new Vector2();
	}

	[Address(RVA="0x15A7994", Offset="0x15A7994", VA="0x15A7994")]
	public void GoToIndex(int dataIndex)
	{
	}

	[Address(RVA="0x15A6474", Offset="0x15A6474", VA="0x15A6474")]
	public void Initialize(WrappedScrollRect.BindDataDelegate dataBindingCallback, WrappedScrollRect.InitializeListItemDelegate itemInitializeCallback = // 
	// Current member / type: System.Void WrappedScrollRect::Initialize(WrappedScrollRect/BindDataDelegate,WrappedScrollRect/InitializeListItemDelegate,System.Int32)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Initialize(WrappedScrollRect/BindDataDelegate,WrappedScrollRect/InitializeListItemDelegate,System.Int32)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x15A82E8", Offset="0x15A82E8", VA="0x15A82E8", Slot="44")]
	public override void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Address(RVA="0x15A7C68", Offset="0x15A7C68", VA="0x15A7C68")]
	public void ScrollToIndex(int dataIndex, float durationS)
	{
	}

	[Address(RVA="0x15A83C4", Offset="0x15A83C4", VA="0x15A83C4", Slot="47")]
	protected override void SetContentAnchoredPosition(Vector2 position)
	{
	}

	[Address(RVA="0x15A7F30", Offset="0x15A7F30", VA="0x15A7F30")]
	private void SetContentLayoutTimesWrapped(Vector2 contentAnchoredPosition)
	{
	}

	[Address(RVA="0x15A6A38", Offset="0x15A6A38", VA="0x15A6A38")]
	public void SetDataCount(int dataCount, bool resetScrollPosition = true)
	{
	}

	[Address(RVA="0x15A7EB0", Offset="0x15A7EB0", VA="0x15A7EB0")]
	public void SetNormalizedPosition(float normalizedPos)
	{
	}

	[Address(RVA="0x15A6CA4", Offset="0x15A6CA4", VA="0x15A6CA4")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x15A6E04", Offset="0x15A6E04", VA="0x15A6E04")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x15A7800", Offset="0x15A7800", VA="0x15A7800")]
	private void UpdateListItems(bool forceDataBind)
	{
	}

	[Address(RVA="0x15A8CD4", Offset="0x15A8CD4", VA="0x15A8CD4")]
	private void UpdateListItemsWithoutDataBind()
	{
	}

	[Address(RVA="0x15A6770", Offset="0x15A6770", VA="0x15A6770")]
	private Vector2 ValidateViewportSize(Vector2 viewportSize, RectTransform.Axis scrollAxis)
	{
		return new Vector2();
	}

	private class AutoScroller
	{
		[FieldOffset(Offset="0x10")]
		private bool _enabled;

		[FieldOffset(Offset="0x14")]
		private Vector2 _initialPosition;

		[FieldOffset(Offset="0x1C")]
		private Vector2 _currentPosition;

		[FieldOffset(Offset="0x24")]
		private Vector2 _desiredPosition;

		[FieldOffset(Offset="0x2C")]
		private float _durationS;

		[FieldOffset(Offset="0x30")]
		private float _elapsedS;

		[FieldOffset(Offset="0x38")]
		private WrappedScrollRect _scrollRect;

		public bool Enabled
		{
			[Address(RVA="0x15A6404", Offset="0x15A6404", VA="0x15A6404")]
			get
			{
				return new bool();
			}
		}

		[Address(RVA="0x15A7D50", Offset="0x15A7D50", VA="0x15A7D50")]
		public AutoScroller(WrappedScrollRect scrollRect)
		{
		}

		[Address(RVA="0x15A7D80", Offset="0x15A7D80", VA="0x15A7D80")]
		public void Start(Vector2 desiredPosition, float duration)
		{
		}

		[Address(RVA="0x15A8328", Offset="0x15A8328", VA="0x15A8328")]
		public void Stop()
		{
		}

		[Address(RVA="0x15A6F40", Offset="0x15A6F40", VA="0x15A6F40")]
		public void TickUpdate()
		{
		}
	}

	public delegate void BindDataDelegate(WrappedScrollRectListItem listItem, int dataIndex);

	public enum ContentScale
	{
		[FieldOffset(Offset="0x0")]
		Viewport,
		[FieldOffset(Offset="0x0")]
		ScrollRect
	}

	public delegate void InitializeListItemDelegate(WrappedScrollRectListItem listItem);
}