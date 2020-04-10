using Il2CppDummyDll;
using System;
using UnityEngine;

public class UniWebViewInterface
{
	[FieldOffset(Offset="0x0")]
	private readonly static AndroidJavaClass plugin;

	[FieldOffset(Offset="0x8")]
	private static bool correctPlatform;

	[Address(RVA="0x159DD14", Offset="0x159DD14", VA="0x159DD14")]
	static UniWebViewInterface()
	{
	}

	[Address(RVA="0x159E3CC", Offset="0x159E3CC", VA="0x159E3CC")]
	public UniWebViewInterface()
	{
	}

	[Address(RVA="0x15939F4", Offset="0x15939F4", VA="0x15939F4")]
	public static void AddJavaScript(string name, string jsString, string identifier)
	{
	}

	[Address(RVA="0x1596E3C", Offset="0x1596E3C", VA="0x1596E3C")]
	public static void AddPermissionTrustDomain(string name, string domain)
	{
	}

	[Address(RVA="0x1594418", Offset="0x1594418", VA="0x1594418")]
	public static void AddSslExceptionDomain(string name, string domain)
	{
	}

	[Address(RVA="0x1593F68", Offset="0x1593F68", VA="0x1593F68")]
	public static void AddUrlScheme(string name, string scheme)
	{
	}

	[Address(RVA="0x1593500", Offset="0x1593500", VA="0x1593500")]
	public static bool AnimateTo(string name, int x, int y, int width, int height, float duration, float delay, string identifier)
	{
		return new bool();
	}

	[Address(RVA="0x159261C", Offset="0x159261C", VA="0x159261C")]
	public static bool CanGoBack(string name)
	{
		return new bool();
	}

	[Address(RVA="0x15927B4", Offset="0x15927B4", VA="0x15927B4")]
	public static bool CanGoForward(string name)
	{
		return new bool();
	}

	[Address(RVA="0x159DE38", Offset="0x159DE38", VA="0x159DE38")]
	public static void CheckPlatform()
	{
	}

	[Address(RVA="0x15952F4", Offset="0x15952F4", VA="0x15952F4")]
	public static void CleanCache(string name)
	{
	}

	[Address(RVA="0x1595458", Offset="0x1595458", VA="0x1595458")]
	public static void ClearCookies()
	{
	}

	[Address(RVA="0x1595910", Offset="0x1595910", VA="0x1595910")]
	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	[Address(RVA="0x1597F44", Offset="0x1597F44", VA="0x1597F44")]
	public static void Destroy(string name)
	{
	}

	[Address(RVA="0x1593CBC", Offset="0x1593CBC", VA="0x1593CBC")]
	public static void EvaluateJavaScript(string name, string jsString, string identifier)
	{
	}

	[Address(RVA="0x1595740", Offset="0x1595740", VA="0x1595740")]
	public static string GetCookie(string url, string key, bool skipEncoding)
	{
		return null;
	}

	[Address(RVA="0x1590158", Offset="0x1590158", VA="0x1590158")]
	public static string GetUrl(string name)
	{
		return null;
	}

	[Address(RVA="0x1594CAC", Offset="0x1594CAC", VA="0x1594CAC")]
	public static string GetUserAgent(string name)
	{
		return null;
	}

	[Address(RVA="0x1595E5C", Offset="0x1595E5C", VA="0x1595E5C")]
	public static float GetWebViewAlpha(string name)
	{
		return new float();
	}

	[Address(RVA="0x1592948", Offset="0x1592948", VA="0x1592948")]
	public static void GoBack(string name)
	{
	}

	[Address(RVA="0x1592AD4", Offset="0x1592AD4", VA="0x1592AD4")]
	public static void GoForward(string name)
	{
	}

	[Address(RVA="0x159309C", Offset="0x159309C", VA="0x159309C")]
	public static bool Hide(string name, bool fade, int edge, float duration, string identifier)
	{
		return new bool();
	}

	[Address(RVA="0x1590CB8", Offset="0x1590CB8", VA="0x1590CB8")]
	public static void Init(string name, int x, int y, int width, int height)
	{
	}

	[Address(RVA="0x1591EE0", Offset="0x1591EE0", VA="0x1591EE0")]
	public static void Load(string name, string url, bool skipEncoding, string readAccessURL)
	{
	}

	[Address(RVA="0x15920D4", Offset="0x15920D4", VA="0x15920D4")]
	public static void LoadHTMLString(string name, string html, string baseUrl, bool skipEncoding)
	{
	}

	[Address(RVA="0x1597C94", Offset="0x1597C94", VA="0x1597C94")]
	public static void Print(string name)
	{
	}

	[Address(RVA="0x1592300", Offset="0x1592300", VA="0x1592300")]
	public static void Reload(string name)
	{
	}

	[Address(RVA="0x1597024", Offset="0x1597024", VA="0x1597024")]
	public static void RemovePermissionTrustDomain(string name, string domain)
	{
	}

	[Address(RVA="0x1594670", Offset="0x1594670", VA="0x1594670")]
	public static void RemoveSslExceptionDomain(string name, string domain)
	{
	}

	[Address(RVA="0x15941C0", Offset="0x15941C0", VA="0x15941C0")]
	public static void RemoveUrlScheme(string name, string scheme)
	{
	}

	[Address(RVA="0x1594E20", Offset="0x1594E20", VA="0x1594E20")]
	public static void SetAllowAutoPlay(bool flag)
	{
	}

	[Address(RVA="0x1595144", Offset="0x1595144", VA="0x1595144")]
	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	[Address(RVA="0x159720C", Offset="0x159720C", VA="0x159720C")]
	public static void SetBackButtonEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1595B2C", Offset="0x1595B2C", VA="0x1595B2C")]
	public static void SetBackgroundColor(string name, float r, float g, float b, float a)
	{
	}

	[Address(RVA="0x1596A24", Offset="0x1596A24", VA="0x1596A24")]
	public static void SetBouncesEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1595574", Offset="0x1595574", VA="0x1595574")]
	public static void SetCookie(string url, string cookie, bool skipEncoding)
	{
	}

	[Address(RVA="0x1590680", Offset="0x1590680", VA="0x1590680")]
	public static void SetFrame(string name, int x, int y, int width, int height)
	{
	}

	[Address(RVA="0x1594898", Offset="0x1594898", VA="0x1594898")]
	public static void SetHeaderField(string name, string key, string value)
	{
	}

	[Address(RVA="0x159660C", Offset="0x159660C", VA="0x159660C")]
	public static void SetHorizontalScrollBarEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1597830", Offset="0x1597830", VA="0x1597830")]
	public static void SetImmersiveModeEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1594FB4", Offset="0x1594FB4", VA="0x1594FB4")]
	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1597624", Offset="0x1597624", VA="0x1597624")]
	public static void SetLoadWithOverviewMode(string name, bool overview)
	{
	}

	[Address(RVA="0x159DEE8", Offset="0x159DEE8", VA="0x159DEE8")]
	public static void SetLogLevel(int level)
	{
	}

	[Address(RVA="0x1592C70", Offset="0x1592C70", VA="0x1592C70")]
	public static void SetOpenLinksInExternalBrowser(string name, bool flag)
	{
	}

	[Address(RVA="0x159E014", Offset="0x159E014", VA="0x159E014")]
	public static void SetPosition(string name, int x, int y)
	{
	}

	[Address(RVA="0x1596218", Offset="0x1596218", VA="0x1596218")]
	public static void SetShowSpinnerWhileLoading(string name, bool show)
	{
	}

	[Address(RVA="0x159E1F0", Offset="0x159E1F0", VA="0x159E1F0")]
	public static void SetSize(string name, int width, int height)
	{
	}

	[Address(RVA="0x1596424", Offset="0x1596424", VA="0x1596424")]
	public static void SetSpinnerText(string name, string text)
	{
	}

	[Address(RVA="0x1594AD4", Offset="0x1594AD4", VA="0x1594AD4")]
	public static void SetUserAgent(string name, string userAgent)
	{
	}

	[Address(RVA="0x1597418", Offset="0x1597418", VA="0x1597418")]
	public static void SetUseWideViewPort(string name, bool use)
	{
	}

	[Address(RVA="0x1596818", Offset="0x1596818", VA="0x1596818")]
	public static void SetVerticalScrollBarEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1597A10", Offset="0x1597A10", VA="0x1597A10")]
	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1596000", Offset="0x1596000", VA="0x1596000")]
	public static void SetWebViewAlpha(string name, float alpha)
	{
	}

	[Address(RVA="0x1596C30", Offset="0x1596C30", VA="0x1596C30")]
	public static void SetZoomEnabled(string name, bool enabled)
	{
	}

	[Address(RVA="0x1592DE8", Offset="0x1592DE8", VA="0x1592DE8")]
	public static bool Show(string name, bool fade, int edge, float duration, string identifier)
	{
		return new bool();
	}

	[Address(RVA="0x1591B50", Offset="0x1591B50", VA="0x1591B50")]
	public static void ShowWebViewDialog(string name, bool show)
	{
	}

	[Address(RVA="0x159248C", Offset="0x159248C", VA="0x159248C")]
	public static void Stop(string name)
	{
	}
}