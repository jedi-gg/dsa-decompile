using Glunies;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

public class CrashController : IDispatchHandler<DSetLogMetadataAction>, IDispatchHandler, IDispatchHandler<DClearLogMetadataAction>
{
	[Attribute(Name="InjectAttribute", RVA="0x105D458", Offset="0x105D458")]
	[FieldOffset(Offset="0x10")]
	private BootstrapConfig _bootstrapConfig;

	[Attribute(Name="InjectAttribute", RVA="0x105D468", Offset="0x105D468")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[FieldOffset(Offset="0x20")]
	private HashSet<string> _transientMetadataKeys;

	[Address(RVA="0x154E830", Offset="0x154E830", VA="0x154E830")]
	public CrashController()
	{
	}

	[Address(RVA="0x154E510", Offset="0x154E510", VA="0x154E510")]
	public void Crash()
	{
	}

	[Address(RVA="0x154E100", Offset="0x154E100", VA="0x154E100")]
	public static string GetStackTrace(string unityStacktrace, string skipMatch = // 
	// Current member / type: System.String CrashController::GetStackTrace(System.String,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.String GetStackTrace(System.String,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x154E590", Offset="0x154E590", VA="0x154E590", Slot="4")]
	public void HandleDispatchAction(DSetLogMetadataAction action)
	{
	}

	[Address(RVA="0x154E628", Offset="0x154E628", VA="0x154E628", Slot="5")]
	public void HandleDispatchAction(DClearLogMetadataAction action)
	{
	}

	[Address(RVA="0x154E764", Offset="0x154E764", VA="0x154E764")]
	private void HandleUnityLogThreaded(string logString, string stackTrace, LogType type)
	{
	}

	[Address(RVA="0x154E3E8", Offset="0x154E3E8", VA="0x154E3E8")]
	public void Initialize()
	{
	}

	[Address(RVA="0x154E7C4", Offset="0x154E7C4", VA="0x154E7C4")]
	private bool ShouldCrashOnLog(string logString)
	{
		return new bool();
	}

	[Address(RVA="0x154E47C", Offset="0x154E47C", VA="0x154E47C")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x154E51C", Offset="0x154E51C", VA="0x154E51C")]
	public void ThrowException()
	{
	}
}