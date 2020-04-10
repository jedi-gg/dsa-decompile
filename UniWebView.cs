using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UniWebView : MonoBehaviour
{
	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FD78", Offset="0x105FD78")]
	[FieldOffset(Offset="0x18")]
	private UniWebView.PageStartedDelegate OnPageStarted;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FD88", Offset="0x105FD88")]
	[FieldOffset(Offset="0x20")]
	private UniWebView.PageFinishedDelegate OnPageFinished;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FD98", Offset="0x105FD98")]
	[FieldOffset(Offset="0x28")]
	private UniWebView.PageErrorReceivedDelegate OnPageErrorReceived;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FDA8", Offset="0x105FDA8")]
	[FieldOffset(Offset="0x30")]
	private UniWebView.MessageReceivedDelegate OnMessageReceived;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FDB8", Offset="0x105FDB8")]
	[FieldOffset(Offset="0x38")]
	private UniWebView.ShouldCloseDelegate OnShouldClose;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FDC8", Offset="0x105FDC8")]
	[FieldOffset(Offset="0x40")]
	private UniWebView.KeyCodeReceivedDelegate OnKeyCodeReceived;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FDD8", Offset="0x105FDD8")]
	[FieldOffset(Offset="0x48")]
	private UniWebView.OrientationChangedDelegate OnOrientationChanged;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FDE8", Offset="0x105FDE8")]
	[FieldOffset(Offset="0x50")]
	private UniWebView.OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated;

	[FieldOffset(Offset="0x58")]
	private string id;

	[FieldOffset(Offset="0x60")]
	private UniWebViewNativeListener listener;

	[FieldOffset(Offset="0x68")]
	private bool isPortrait;

	[FieldOffset(Offset="0x70")]
	[SerializeField]
	private string urlOnStart;

	[FieldOffset(Offset="0x78")]
	[SerializeField]
	private bool showOnStart;

	[FieldOffset(Offset="0x80")]
	private Dictionary<string, Action> actions;

	[FieldOffset(Offset="0x88")]
	private Dictionary<string, Action<UniWebViewNativeResultPayload>> payloadActions;

	[FieldOffset(Offset="0x90")]
	[SerializeField]
	private bool fullScreen;

	[FieldOffset(Offset="0x94")]
	[SerializeField]
	private Rect frame;

	[FieldOffset(Offset="0xA8")]
	[SerializeField]
	private RectTransform referenceRectTransform;

	[FieldOffset(Offset="0xB0")]
	[SerializeField]
	private bool useToolbar;

	[FieldOffset(Offset="0xB4")]
	[SerializeField]
	private UniWebViewToolbarPosition toolbarPosition;

	[FieldOffset(Offset="0xB8")]
	private bool started;

	[FieldOffset(Offset="0xBC")]
	private Color backgroundColor;

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x105FE68", Offset="0x105FE68")]
	[FieldOffset(Offset="0xD0")]
	private UniWebView.OrientationChangedDelegate OnOreintationChanged;

	public float Alpha
	{
		[Address(RVA="0x1595DD8", Offset="0x1595DD8", VA="0x1595DD8")]
		get
		{
			return new float();
		}
		[Address(RVA="0x1595F6C", Offset="0x1595F6C", VA="0x1595F6C")]
		set
		{
		}
	}

	public Color BackgroundColor
	{
		[Address(RVA="0x1595A64", Offset="0x1595A64", VA="0x1595A64")]
		get
		{
			return new Color();
		}
		[Address(RVA="0x1595A70", Offset="0x1595A70", VA="0x1595A70")]
		set
		{
		}
	}

	public bool CanGoBack
	{
		[Address(RVA="0x1592594", Offset="0x1592594", VA="0x1592594")]
		get
		{
			return new bool();
		}
	}

	public bool CanGoForward
	{
		[Address(RVA="0x159272C", Offset="0x159272C", VA="0x159272C")]
		get
		{
			return new bool();
		}
	}

	public Rect Frame
	{
		[Address(RVA="0x158FF7C", Offset="0x158FF7C", VA="0x158FF7C")]
		get
		{
			return new Rect();
		}
		[Address(RVA="0x158FF88", Offset="0x158FF88", VA="0x158FF88")]
		set
		{
		}
	}

	public RectTransform ReferenceRectTransform
	{
		[Address(RVA="0x1590090", Offset="0x1590090", VA="0x1590090")]
		get
		{
			return null;
		}
		[Address(RVA="0x1590098", Offset="0x1590098", VA="0x1590098")]
		set
		{
		}
	}

	public string Url
	{
		[Address(RVA="0x15900A0", Offset="0x15900A0", VA="0x15900A0")]
		get
		{
			return null;
		}
	}

	[Address(RVA="0x159C838", Offset="0x159C838", VA="0x159C838")]
	public UniWebView()
	{
	}

	[Address(RVA="0x15938D4", Offset="0x15938D4", VA="0x15938D4")]
	public void AddJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = // 
	// Current member / type: System.Void UniWebView::AddJavaScript(System.String,System.Action`1<UniWebViewNativeResultPayload>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void AddJavaScript(System.String,System.Action<UniWebViewNativeResultPayload>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1596DA8", Offset="0x1596DA8", VA="0x1596DA8")]
	public void AddPermissionTrustDomain(string domain)
	{
	}

	[Address(RVA="0x1594314", Offset="0x1594314", VA="0x1594314")]
	public void AddSslExceptionDomain(string domain)
	{
	}

	[Address(RVA="0x1593E64", Offset="0x1593E64", VA="0x1593E64")]
	public void AddUrlScheme(string scheme)
	{
	}

	[Address(RVA="0x159334C", Offset="0x159334C", VA="0x159334C")]
	public bool AnimateTo(Rect frame, float duration, float delay = 0f, Action completionHandler = // 
	// Current member / type: System.Boolean UniWebView::AnimateTo(UnityEngine.Rect,System.Single,System.Single,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean AnimateTo(UnityEngine.Rect,System.Single,System.Single,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x15909D4", Offset="0x15909D4", VA="0x15909D4")]
	private void Awake()
	{
	}

	[Address(RVA="0x1595270", Offset="0x1595270", VA="0x1595270")]
	public void CleanCache()
	{
	}

	[Address(RVA="0x15953FC", Offset="0x15953FC", VA="0x15953FC")]
	public static void ClearCookies()
	{
	}

	[Address(RVA="0x159589C", Offset="0x159589C", VA="0x159589C")]
	public static void ClearHttpAuthUsernamePassword(string host, string realm)
	{
	}

	[Address(RVA="0x1593B9C", Offset="0x1593B9C", VA="0x1593B9C")]
	public void EvaluateJavaScript(string jsString, Action<UniWebViewNativeResultPayload> completionHandler = // 
	// Current member / type: System.Void UniWebView::EvaluateJavaScript(System.String,System.Action`1<UniWebViewNativeResultPayload>)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void EvaluateJavaScript(System.String,System.Action<UniWebViewNativeResultPayload>)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x15956C8", Offset="0x15956C8", VA="0x15956C8")]
	public static string GetCookie(string url, string key, bool skipEncoding = false)
	{
		return null;
	}

	[Address(RVA="0x1597B40", Offset="0x1597B40", VA="0x1597B40")]
	public void GetHTMLContent(Action<string> handler)
	{
	}

	[Address(RVA="0x1594C28", Offset="0x1594C28", VA="0x1594C28")]
	public string GetUserAgent()
	{
		return null;
	}

	[Address(RVA="0x15928C4", Offset="0x15928C4", VA="0x15928C4")]
	public void GoBack()
	{
	}

	[Address(RVA="0x1592A50", Offset="0x1592A50", VA="0x1592A50")]
	public void GoForward()
	{
	}

	[Address(RVA="0x1591D80", Offset="0x1591D80", VA="0x1591D80")]
	public bool Hide(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4f, Action completionHandler = // 
	// Current member / type: System.Boolean UniWebView::Hide(System.Boolean,UniWebViewTransitionEdge,System.Single,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean Hide(System.Boolean,UniWebViewTransitionEdge,System.Single,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1598330", Offset="0x1598330", VA="0x1598330")]
	internal void InternalOnAddJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	[Address(RVA="0x159826C", Offset="0x159826C", VA="0x159826C")]
	internal void InternalOnAnimateToFinished(string identifier)
	{
	}

	[Address(RVA="0x1598418", Offset="0x1598418", VA="0x1598418")]
	internal void InternalOnEvalJavaScriptFinished(UniWebViewNativeResultPayload payload)
	{
	}

	[Address(RVA="0x15981A8", Offset="0x15981A8", VA="0x15981A8")]
	internal void InternalOnHideTransitionFinished(string identifier)
	{
	}

	[Address(RVA="0x1599E18", Offset="0x1599E18", VA="0x1599E18")]
	internal void InternalOnMessageReceived(string result)
	{
	}

	[Address(RVA="0x159955C", Offset="0x159955C", VA="0x159955C")]
	internal void InternalOnPageErrorReceived(UniWebViewNativeResultPayload payload)
	{
	}

	[Address(RVA="0x1598500", Offset="0x1598500", VA="0x1598500")]
	internal void InternalOnPageFinished(UniWebViewNativeResultPayload payload)
	{
	}

	[Address(RVA="0x1598DBC", Offset="0x1598DBC", VA="0x1598DBC")]
	internal void InternalOnPageStarted(string url)
	{
	}

	[Address(RVA="0x159B734", Offset="0x159B734", VA="0x159B734")]
	internal void InternalOnShouldClose()
	{
	}

	[Address(RVA="0x15980E4", Offset="0x15980E4", VA="0x15980E4")]
	internal void InternalOnShowTransitionFinished(string identifier)
	{
	}

	[Address(RVA="0x159AF94", Offset="0x159AF94", VA="0x159AF94")]
	internal void InternalOnWebViewKeyDown(int keyCode)
	{
	}

	[Address(RVA="0x159BF14", Offset="0x159BF14", VA="0x159BF14")]
	internal void InternalWebContentProcessDidTerminate()
	{
	}

	[Address(RVA="0x159119C", Offset="0x159119C", VA="0x159119C")]
	public void Load(string url, bool skipEncoding = false, string readAccessURL = // 
	// Current member / type: System.Void UniWebView::Load(System.String,System.Boolean,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Void Load(System.String,System.Boolean,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1592034", Offset="0x1592034", VA="0x1592034")]
	public void LoadHTMLString(string htmlString, string baseUrl, bool skipEncoding = false)
	{
	}

	[Address(RVA="0x1590268", Offset="0x1590268", VA="0x1590268")]
	private Rect NextFrameRect()
	{
		return new Rect();
	}

	[Address(RVA="0x159804C", Offset="0x159804C", VA="0x159804C")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Address(RVA="0x1597D9C", Offset="0x1597D9C", VA="0x1597D9C")]
	private void OnDestroy()
	{
	}

	[Address(RVA="0x1591CC8", Offset="0x1591CC8", VA="0x1591CC8")]
	private void OnDisable()
	{
	}

	[Address(RVA="0x1591A98", Offset="0x1591A98", VA="0x1591A98")]
	private void OnEnable()
	{
	}

	[Address(RVA="0x1597C0C", Offset="0x1597C0C", VA="0x1597C0C")]
	public void Print()
	{
	}

	[Address(RVA="0x159227C", Offset="0x159227C", VA="0x159227C")]
	public void Reload()
	{
	}

	[Address(RVA="0x1596F90", Offset="0x1596F90", VA="0x1596F90")]
	public void RemovePermissionTrustDomain(string domain)
	{
	}

	[Address(RVA="0x159456C", Offset="0x159456C", VA="0x159456C")]
	public void RemoveSslExceptionDomain(string domain)
	{
	}

	[Address(RVA="0x15940BC", Offset="0x15940BC", VA="0x15940BC")]
	public void RemoveUrlScheme(string scheme)
	{
	}

	[Address(RVA="0x1594DBC", Offset="0x1594DBC", VA="0x1594DBC")]
	public static void SetAllowAutoPlay(bool flag)
	{
	}

	[Address(RVA="0x1597C08", Offset="0x1597C08", VA="0x1597C08")]
	public void SetAllowFileAccessFromFileURLs(bool flag)
	{
	}

	[Address(RVA="0x1594F4C", Offset="0x1594F4C", VA="0x1594F4C")]
	public static void SetAllowInlinePlay(bool flag)
	{
	}

	[Address(RVA="0x15950E0", Offset="0x15950E0", VA="0x15950E0")]
	public static void SetAllowJavaScriptOpenWindow(bool flag)
	{
	}

	[Address(RVA="0x1597178", Offset="0x1597178", VA="0x1597178")]
	public void SetBackButtonEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1596990", Offset="0x1596990", VA="0x1596990")]
	public void SetBouncesEnabled(bool enabled)
	{
	}

	[Address(RVA="0x15954FC", Offset="0x15954FC", VA="0x15954FC")]
	public static void SetCookie(string url, string cookie, bool skipEncoding = false)
	{
	}

	[Address(RVA="0x15947C4", Offset="0x15947C4", VA="0x15947C4")]
	public void SetHeaderField(string key, string value)
	{
	}

	[Address(RVA="0x1596578", Offset="0x1596578", VA="0x1596578")]
	public void SetHorizontalScrollBarEnabled(bool enabled)
	{
	}

	[Address(RVA="0x159779C", Offset="0x159779C", VA="0x159779C")]
	public void SetImmersiveModeEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1594F50", Offset="0x1594F50", VA="0x1594F50")]
	public static void SetJavaScriptEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1597590", Offset="0x1597590", VA="0x1597590")]
	public void SetLoadWithOverviewMode(bool flag)
	{
	}

	[Address(RVA="0x1592BDC", Offset="0x1592BDC", VA="0x1592BDC")]
	public void SetOpenLinksInExternalBrowser(bool flag)
	{
	}

	[Address(RVA="0x1596184", Offset="0x1596184", VA="0x1596184")]
	public void SetShowSpinnerWhileLoading(bool flag)
	{
	}

	[Address(RVA="0x1593098", Offset="0x1593098", VA="0x1593098")]
	public void SetShowToolbar(bool show, bool animated = false, bool onTop = true, bool adjustInset = false)
	{
	}

	[Address(RVA="0x1596390", Offset="0x1596390", VA="0x1596390")]
	public void SetSpinnerText(string text)
	{
	}

	[Address(RVA="0x15979A8", Offset="0x15979A8", VA="0x15979A8")]
	public void SetToolbarDoneButtonText(string text)
	{
	}

	[Address(RVA="0x1594A40", Offset="0x1594A40", VA="0x1594A40")]
	public void SetUserAgent(string agent)
	{
	}

	[Address(RVA="0x1597384", Offset="0x1597384", VA="0x1597384")]
	public void SetUseWideViewPort(bool flag)
	{
	}

	[Address(RVA="0x1596784", Offset="0x1596784", VA="0x1596784")]
	public void SetVerticalScrollBarEnabled(bool enabled)
	{
	}

	[Address(RVA="0x15979AC", Offset="0x15979AC", VA="0x15979AC")]
	public static void SetWebContentsDebuggingEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1597B3C", Offset="0x1597B3C", VA="0x1597B3C")]
	public void SetWindowUserResizeEnabled(bool enabled)
	{
	}

	[Address(RVA="0x1596B9C", Offset="0x1596B9C", VA="0x1596B9C")]
	public void SetZoomEnabled(bool enabled)
	{
	}

	[Address(RVA="0x159103C", Offset="0x159103C", VA="0x159103C")]
	public bool Show(bool fade = false, UniWebViewTransitionEdge edge = 0, float duration = 0.4f, Action completionHandler = // 
	// Current member / type: System.Boolean UniWebView::Show(System.Boolean,UniWebViewTransitionEdge,System.Single,System.Action)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean Show(System.Boolean,UniWebViewTransitionEdge,System.Single,System.Action)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1590F64", Offset="0x1590F64", VA="0x1590F64")]
	private void Start()
	{
	}

	[Address(RVA="0x1592408", Offset="0x1592408", VA="0x1592408")]
	public void Stop()
	{
	}

	[Address(RVA="0x1591234", Offset="0x1591234", VA="0x1591234")]
	private void Update()
	{
	}

	[Address(RVA="0x158FF94", Offset="0x158FF94", VA="0x158FF94")]
	public void UpdateFrame()
	{
	}

	public event UniWebView.KeyCodeReceivedDelegate OnKeyCodeReceived
	{
		[Address(RVA="0x158F9F4", Offset="0x158F9F4", VA="0x158F9F4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071320", Offset="0x1071320")]
		add
		{
		}
		[Address(RVA="0x158FAE0", Offset="0x158FAE0", VA="0x158FAE0")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071330", Offset="0x1071330")]
		remove
		{
		}
	}

	public event UniWebView.MessageReceivedDelegate OnMessageReceived
	{
		[Address(RVA="0x158F644", Offset="0x158F644", VA="0x158F644")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712E0", Offset="0x10712E0")]
		add
		{
		}
		[Address(RVA="0x158F730", Offset="0x158F730", VA="0x158F730")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712F0", Offset="0x10712F0")]
		remove
		{
		}
	}

	[Attribute(Name="ObsoleteAttribute", RVA="0x10915C8", Offset="0x10915C8")]
	public event UniWebView.OrientationChangedDelegate OnOreintationChanged
	{
		[Address(RVA="0x159C660", Offset="0x159C660", VA="0x159C660")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071380", Offset="0x1071380")]
		add
		{
		}
		[Address(RVA="0x159C74C", Offset="0x159C74C", VA="0x159C74C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071390", Offset="0x1071390")]
		remove
		{
		}
	}

	public event UniWebView.OrientationChangedDelegate OnOrientationChanged
	{
		[Address(RVA="0x158FBCC", Offset="0x158FBCC", VA="0x158FBCC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071340", Offset="0x1071340")]
		add
		{
		}
		[Address(RVA="0x158FCB8", Offset="0x158FCB8", VA="0x158FCB8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071350", Offset="0x1071350")]
		remove
		{
		}
	}

	public event UniWebView.PageErrorReceivedDelegate OnPageErrorReceived
	{
		[Address(RVA="0x158F46C", Offset="0x158F46C", VA="0x158F46C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712C0", Offset="0x10712C0")]
		add
		{
		}
		[Address(RVA="0x158F558", Offset="0x158F558", VA="0x158F558")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712D0", Offset="0x10712D0")]
		remove
		{
		}
	}

	public event UniWebView.PageFinishedDelegate OnPageFinished
	{
		[Address(RVA="0x158F294", Offset="0x158F294", VA="0x158F294")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712A0", Offset="0x10712A0")]
		add
		{
		}
		[Address(RVA="0x158F380", Offset="0x158F380", VA="0x158F380")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x10712B0", Offset="0x10712B0")]
		remove
		{
		}
	}

	public event UniWebView.PageStartedDelegate OnPageStarted
	{
		[Address(RVA="0x158F0BC", Offset="0x158F0BC", VA="0x158F0BC")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071280", Offset="0x1071280")]
		add
		{
		}
		[Address(RVA="0x158F1A8", Offset="0x158F1A8", VA="0x158F1A8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071290", Offset="0x1071290")]
		remove
		{
		}
	}

	public event UniWebView.ShouldCloseDelegate OnShouldClose
	{
		[Address(RVA="0x158F81C", Offset="0x158F81C", VA="0x158F81C")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071300", Offset="0x1071300")]
		add
		{
		}
		[Address(RVA="0x158F908", Offset="0x158F908", VA="0x158F908")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071310", Offset="0x1071310")]
		remove
		{
		}
	}

	public event UniWebView.OnWebContentProcessTerminatedDelegate OnWebContentProcessTerminated
	{
		[Address(RVA="0x158FDA4", Offset="0x158FDA4", VA="0x158FDA4")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071360", Offset="0x1071360")]
		add
		{
		}
		[Address(RVA="0x158FE90", Offset="0x158FE90", VA="0x158FE90")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1071370", Offset="0x1071370")]
		remove
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104D278", Offset="0x104D278")]
	private sealed class <>c__DisplayClass115_0
	{
		[FieldOffset(Offset="0x10")]
		public Action<string> handler;

		[Address(RVA="0x1597C00", Offset="0x1597C00", VA="0x1597C00")]
		public <>c__DisplayClass115_0()
		{
		}

		[Address(RVA="0x159C92C", Offset="0x159C92C", VA="0x159C92C")]
		internal void <GetHTMLContent>b__0(UniWebViewNativeResultPayload payload)
		{
		}
	}

	public delegate void KeyCodeReceivedDelegate(UniWebView webView, int keyCode);

	public delegate void MessageReceivedDelegate(UniWebView webView, UniWebViewMessage message);

	public delegate void OnWebContentProcessTerminatedDelegate(UniWebView webView);

	[Attribute(Name="ObsoleteAttribute", RVA="0x104D23C", Offset="0x104D23C")]
	public delegate void OreintationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	public delegate void OrientationChangedDelegate(UniWebView webView, ScreenOrientation orientation);

	public delegate void PageErrorReceivedDelegate(UniWebView webView, int errorCode, string errorMessage);

	public delegate void PageFinishedDelegate(UniWebView webView, int statusCode, string url);

	public delegate void PageStartedDelegate(UniWebView webView, string url);

	public delegate bool ShouldCloseDelegate(UniWebView webView);
}