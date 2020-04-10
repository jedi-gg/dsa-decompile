using Google.Protobuf;
using Il2CppDummyDll;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BattleLib
{
	public class LocalBattle : ABattle
	{
		[FieldOffset(Offset="0x0")]
		public static bool DebugScripts;

		[FieldOffset(Offset="0x0")]
		private const string DLL_NAME = "cas-battle";

		[FieldOffset(Offset="0x0")]
		private const int INITIAL_RESULT_BUFFER_SIZE = 2048;

		[Attribute(Name="InjectAttribute", RVA="0x1063D5C", Offset="0x1063D5C")]
		[FieldOffset(Offset="0xF8")]
		private GamedataManager _gamedataManager;

		[FieldOffset(Offset="0x100")]
		private int _battleId;

		[FieldOffset(Offset="0x108")]
		private byte[] _resultBb;

		[FieldOffset(Offset="0x110")]
		private LocalBattle.State _state;

		[FieldOffset(Offset="0x114")]
		private bool _runThreaded;

		[FieldOffset(Offset="0x115")]
		private bool _threadRunning;

		[FieldOffset(Offset="0x118")]
		private uint _libTotalMem;

		[FieldOffset(Offset="0x120")]
		private Stopwatch _libUpdateTimer;

		[FieldOffset(Offset="0x128")]
		private Stopwatch _unscaledDeltaTimer;

		[FieldOffset(Offset="0x130")]
		private float _lastBattleClockS;

		[Address(RVA="0x110F7E4", Offset="0x110F7E4", VA="0x110F7E4")]
		static LocalBattle()
		{
		}

		[Address(RVA="0x110E324", Offset="0x110E324", VA="0x110E324")]
		public LocalBattle(byte localPlayerId, ByteString battleDataBuffer, bool runThreaded)
		{
		}

		[Address(RVA="0x110F7E8", Offset="0x110F7E8", VA="0x110F7E8")]
		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1089FAC", Offset="0x1089FAC")]
		private void <StartBattleThread>b__7_0()
		{
		}

		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_Begin(System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_Begin(System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_Bootstrap(System.Int32,System.Byte[],System.Int32,System.Byte[],System.Int32,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_Bootstrap(System.Int32,System.Byte[],System.Int32,System.Byte[],System.Int32,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.IntPtr BattleLib.LocalBattle::Battle_GetCatchUpBuffer(System.Int32,System.Int32&)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.IntPtr Battle_GetCatchUpBuffer(System.Int32,System.Int32&)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.IntPtr BattleLib.LocalBattle::Battle_GetLastFatalError(System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.IntPtr Battle_GetLastFatalError(System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.UInt32 BattleLib.LocalBattle::Battle_GetTotalMem(System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.UInt32 Battle_GetTotalMem(System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.IntPtr BattleLib.LocalBattle::Battle_GetUpdateResultBuffer(System.Int32,System.Int32&)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.IntPtr Battle_GetUpdateResultBuffer(System.Int32,System.Int32&)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Int32 BattleLib.LocalBattle::Battle_GetVersion()
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Int32 Battle_GetVersion()
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Boolean BattleLib.LocalBattle::Battle_HadFatalError(System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Boolean Battle_HadFatalError(System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_HandlePlayerMessage(System.Int32,System.Byte,System.Byte[],System.Int32,System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_HandlePlayerMessage(System.Int32,System.Byte,System.Byte[],System.Int32,System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Boolean BattleLib.LocalBattle::Battle_Init(System.Int32&)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Boolean Battle_Init(System.Int32&)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_Shutdown(System.Int32)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_Shutdown(System.Int32)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_ShutdownAll()
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_ShutdownAll()
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		// 
		// Current member / type: System.Void BattleLib.LocalBattle::Battle_Update(System.Int32,System.Single,System.Single,System.Int64)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Battle_Update(System.Int32,System.Single,System.Single,System.Int64)
		// 
		// Object reference not set to an instance of an object.
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Decompiler\AttributesUtilities.cs:line 312
		//    at ..(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 381
		//    at ..(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 330
		//    at ..(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 67
		//    at Telerik.JustDecompiler.Languages.CSharp.CSharpAttributeWriter.(IMemberDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\CSharp\CSharpAttributeWriter.cs:line 45
		//    at ..(IMemberDefinition , IEnumerable`1 , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\AttributeWriter.cs:line 40
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(IMemberDefinition , IEnumerable`1 ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 106
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 438
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x110E3F0", Offset="0x110E3F0", VA="0x110E3F0", Slot="7")]
		public override void Begin()
		{
		}

		[Address(RVA="0x110F154", Offset="0x110F154", VA="0x110F154")]
		private string GetLastFatalError()
		{
			return null;
		}

		[Address(RVA="0x110EE10", Offset="0x110EE10", VA="0x110EE10", Slot="13")]
		protected override DBattleLibMetrics GetMetrics(int payloadSize)
		{
			return new DBattleLibMetrics();
		}

		[Address(RVA="0x110F364", Offset="0x110F364", VA="0x110F364")]
		private static void GrowByteBuffer(ref byte[] buffer, int requiredSize)
		{
		}

		[Address(RVA="0x110ED18", Offset="0x110ED18", VA="0x110ED18", Slot="12")]
		protected override void InternalInit(Action<bool> finished)
		{
		}

		[Address(RVA="0x110E77C", Offset="0x110E77C", VA="0x110E77C")]
		private void InternalUpdate()
		{
		}

		[Address(RVA="0x110E634", Offset="0x110E634", VA="0x110E634", Slot="8")]
		public override void Shutdown()
		{
		}

		[Address(RVA="0x110E4D0", Offset="0x110E4D0", VA="0x110E4D0")]
		[Attribute(Name="AsyncStateMachineAttribute", RVA="0x1089F48", Offset="0x1089F48")]
		private void StartBattleThread()
		{
		}

		[Address(RVA="0x110E740", Offset="0x110E740", VA="0x110E740", Slot="9")]
		public override void Update()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D48", Offset="0x1050D48")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset="0x10")]
			public LocalBattle <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action<bool> finished;

			[Address(RVA="0x110EE08", Offset="0x110EE08", VA="0x110EE08")]
			public <>c__DisplayClass5_0()
			{
			}

			[Address(RVA="0x110F870", Offset="0x110F870", VA="0x110F870")]
			internal void <InternalInit>b__0(bool success)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D58", Offset="0x1050D58")]
		private struct <StartBattleThread>d__7 : IAsyncStateMachine
		{
			[FieldOffset(Offset="0x0")]
			public int <>1__state;

			[FieldOffset(Offset="0x8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[FieldOffset(Offset="0x28")]
			public LocalBattle <>4__this;

			[FieldOffset(Offset="0x30")]
			private TaskAwaiter <>u__1;

			[Address(RVA="0xEFCE50", Offset="0xEFCE50", VA="0xEFCE50", Slot="4")]
			private void MoveNext()
			{
			}

			[Address(RVA="0xEFCE58", Offset="0xEFCE58", VA="0xEFCE58", Slot="5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private enum State
		{
			[FieldOffset(Offset="0x0")]
			Uninitialized,
			[FieldOffset(Offset="0x0")]
			Initialized,
			[FieldOffset(Offset="0x0")]
			Running
		}
	}
}