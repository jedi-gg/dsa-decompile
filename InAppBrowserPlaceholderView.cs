using Glunies;
using Il2CppDummyDll;
using System;
using UnityEngine;

public class InAppBrowserPlaceholderView : AStandardView
{
	[FieldOffset(Offset="0x68")]
	private UniWebView _webView;

	private InAppBrowserPlaceholderView.SerializedFields Fields
	{
		[Address(RVA="0x117DADC", Offset="0x117DADC", VA="0x117DADC")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x117E508", Offset="0x117E508", VA="0x117E508")]
	public InAppBrowserPlaceholderView()
	{
	}

	[Address(RVA="0x117E510", Offset="0x117E510", VA="0x117E510")]
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x106FE64", Offset="0x106FE64")]
	private bool <ViewAssetLoaded>b__3_0(UniWebView wv)
	{
		return new bool();
	}

	[Address(RVA="0x117E0A0", Offset="0x117E0A0", VA="0x117E0A0")]
	private void ListenForLoadResult()
	{
	}

	[Address(RVA="0x117D850", Offset="0x117D850", VA="0x117D850")]
	public void NavigateToUrl(string url)
	{
	}

	[Address(RVA="0x117DBBC", Offset="0x117DBBC", VA="0x117DBBC", Slot="21")]
	protected virtual void OnRectTransformDimensionsChange()
	{
	}

	[Address(RVA="0x117E3C0", Offset="0x117E3C0", VA="0x117E3C0")]
	private void PageFinishedLoading(UniWebView webView, int statusCode, string url)
	{
	}

	[Address(RVA="0x117E47C", Offset="0x117E47C", VA="0x117E47C")]
	private void PageHadError(UniWebView webView, int errorCode, string errorMessage)
	{
	}

	[Address(RVA="0x117D5B0", Offset="0x117D5B0", VA="0x117D5B0")]
	public void ShowWebView(bool showing)
	{
	}

	[Address(RVA="0x117E29C", Offset="0x117E29C", VA="0x117E29C")]
	private void StopListeningForLoadResult()
	{
	}

	[Address(RVA="0x117DBC0", Offset="0x117DBC0", VA="0x117DBC0")]
	private void UpdateWebViewFrame()
	{
	}

	[Address(RVA="0x117DE70", Offset="0x117DE70", VA="0x117DE70", Slot="11")]
	protected override void ViewAssetLoaded()
	{
	}

	[Address(RVA="0x117E1CC", Offset="0x117E1CC", VA="0x117E1CC", Slot="12")]
	protected override void ViewShuttingDown()
	{
	}

	[Serializable]
	public class SerializedFields : ViewSerializedFields
	{
		[FieldOffset(Offset="0x28")]
		public UiLabel MessageLabel;

		[FieldOffset(Offset="0x30")]
		public RectTransform BrowserRect;

		[Address(RVA="0x117E59C", Offset="0x117E59C", VA="0x117E59C")]
		public SerializedFields()
		{
		}
	}
}