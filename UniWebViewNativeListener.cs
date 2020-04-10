using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UniWebViewNativeListener : MonoBehaviour
{
	[FieldOffset(Offset="0x0")]
	private static Dictionary<string, UniWebViewNativeListener> listeners;

	[Attribute(Name="HideInInspector", RVA="0x105FEB8", Offset="0x105FEB8")]
	[FieldOffset(Offset="0x18")]
	public UniWebView webView;

	public string Name
	{
		[Address(RVA="0x1590124", Offset="0x1590124", VA="0x1590124")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x159EEA0", Offset="0x159EEA0", VA="0x159EEA0")]
	static UniWebViewNativeListener()
	{
	}

	[Address(RVA="0x159EE98", Offset="0x159EE98", VA="0x159EE98")]
	public UniWebViewNativeListener()
	{
	}

	[Address(RVA="0x159EA44", Offset="0x159EA44", VA="0x159EA44")]
	public void AddJavaScriptFinished(string result)
	{
	}

	[Address(RVA="0x1590C08", Offset="0x1590C08", VA="0x1590C08")]
	public static void AddListener(UniWebViewNativeListener target)
	{
	}

	[Address(RVA="0x159E99C", Offset="0x159E99C", VA="0x159E99C")]
	public void AnimateToFinished(string identifer)
	{
	}

	[Address(RVA="0x159EB04", Offset="0x159EB04", VA="0x159EB04")]
	public void EvalJavaScriptFinished(string result)
	{
	}

	[Address(RVA="0x159DB4C", Offset="0x159DB4C", VA="0x159DB4C")]
	public static UniWebViewNativeListener GetListener(string name)
	{
		return null;
	}

	[Address(RVA="0x159E8F4", Offset="0x159E8F4", VA="0x159E8F4")]
	public void HideTransitionFinished(string identifer)
	{
	}

	[Address(RVA="0x159EBC4", Offset="0x159EBC4", VA="0x159EBC4")]
	public void MessageReceived(string result)
	{
	}

	[Address(RVA="0x159E78C", Offset="0x159E78C", VA="0x159E78C")]
	public void PageErrorReceived(string result)
	{
	}

	[Address(RVA="0x159E6CC", Offset="0x159E6CC", VA="0x159E6CC")]
	public void PageFinished(string result)
	{
	}

	[Address(RVA="0x159E60C", Offset="0x159E60C", VA="0x159E60C")]
	public void PageStarted(string url)
	{
	}

	[Address(RVA="0x1597EB8", Offset="0x1597EB8", VA="0x1597EB8")]
	public static void RemoveListener(string name)
	{
	}

	[Address(RVA="0x159E84C", Offset="0x159E84C", VA="0x159E84C")]
	public void ShowTransitionFinished(string identifer)
	{
	}

	[Address(RVA="0x159EE08", Offset="0x159EE08", VA="0x159EE08")]
	public void WebContentProcessDidTerminate(string param)
	{
	}

	[Address(RVA="0x159ED8C", Offset="0x159ED8C", VA="0x159ED8C")]
	public void WebViewDone(string param)
	{
	}

	[Address(RVA="0x159EC6C", Offset="0x159EC6C", VA="0x159EC6C")]
	public void WebViewKeyDown(string keyCode)
	{
	}
}