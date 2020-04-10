using DG.Tweening;
using DG.Tweening.Core;
using Gamedata;
using Glunies;
using Il2CppDummyDll;
using Serverproto;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BattleMessageController : ILoggable<LogCategory>, IDispatchHandler<DBattleMsgAction<BattleLib_UpdateResult.Types.BattleMessage>>, IDispatchHandler, IDispatchHandler<DViewShownAction>, IDispatchHandler<DViewHiddenAction>, IDispatchHandler<DTutorialMessageBubbleViewAction>, IDispatchHandler<DBattleUnitsControllerAction>, IDispatchHandler<DBattleFullscreenInputAction>
{
	[FieldOffset(Offset="0x0")]
	private const float TIMESCALE_RAMP_DOWN_DURATION_S = 2f;

	[Attribute(Name="InjectAttribute", RVA="0x1053A10", Offset="0x1053A10")]
	[FieldOffset(Offset="0x10")]
	private DiContainer _diContainer;

	[Attribute(Name="InjectAttribute", RVA="0x1053A20", Offset="0x1053A20")]
	[FieldOffset(Offset="0x18")]
	private DispatchSystem _dispatch;

	[Attribute(Name="InjectAttribute", RVA="0x1053A30", Offset="0x1053A30")]
	[FieldOffset(Offset="0x20")]
	private ViewController _viewController;

	[Attribute(Name="InjectAttribute", RVA="0x1053A40", Offset="0x1053A40")]
	[FieldOffset(Offset="0x28")]
	private GamedataDomainController _gamedataDc;

	[Attribute(Name="InjectAttribute", RVA="0x1053A50", Offset="0x1053A50")]
	[FieldOffset(Offset="0x30")]
	private LocalizationManager _locManager;

	[Attribute(Name="InjectAttribute", RVA="0x1053A60", Offset="0x1053A60")]
	[FieldOffset(Offset="0x38")]
	private BattleViewController _battleViewController;

	[Attribute(Name="InjectAttribute", RVA="0x1053A70", Offset="0x1053A70")]
	[FieldOffset(Offset="0x40")]
	private InputSystem _inputSystem;

	[Attribute(Name="InjectAttribute", RVA="0x1053A80", Offset="0x1053A80")]
	[FieldOffset(Offset="0x48")]
	private BattleUnitsController _unitsController;

	[Attribute(Name="InjectAttribute", RVA="0x1053A90", Offset="0x1053A90")]
	[FieldOffset(Offset="0x50")]
	private BattleAutoBattleController _autoBattleController;

	[FieldOffset(Offset="0x58")]
	private bool _isShutdown;

	[FieldOffset(Offset="0x60")]
	private Camera _camera;

	[FieldOffset(Offset="0x68")]
	private TutorialMessageBubbleView _messageBubbleView;

	[FieldOffset(Offset="0x70")]
	private TutorialPointAtView _pointAtView;

	[FieldOffset(Offset="0x78")]
	private SeekerView _seekerView;

	[FieldOffset(Offset="0x80")]
	private Queue<BattleLib_UpdateResult.Types.BattleMessage> _pendingMessages;

	[FieldOffset(Offset="0x88")]
	private uint _pauseRequestId;

	[FieldOffset(Offset="0x90")]
	private Sequence _pauseTween;

	[FieldOffset(Offset="0x98")]
	private bool _isMessageShowing;

	[FieldOffset(Offset="0xA0")]
	private BattleUnit _followUnit;

	[FieldOffset(Offset="0xA8")]
	private bool _tapFollowUnit;

	public bool IsMessageShowing
	{
		[Address(RVA="0x11132D0", Offset="0x11132D0", VA="0x11132D0")]
		get
		{
			return new bool();
		}
	}

	public LogCategory LogCategory
	{
		[Address(RVA="0x11132C8", Offset="0x11132C8", VA="0x11132C8", Slot="4")]
		get
		{
			return new LogCategory();
		}
	}

	[Address(RVA="0x1114C14", Offset="0x1114C14", VA="0x1114C14")]
	public BattleMessageController()
	{
	}

	[Address(RVA="0x11139FC", Offset="0x11139FC", VA="0x11139FC", Slot="5")]
	public void HandleDispatchAction(DBattleMsgAction<BattleLib_UpdateResult.Types.BattleMessage> action)
	{
	}

	[Address(RVA="0x111406C", Offset="0x111406C", VA="0x111406C", Slot="8")]
	public void HandleDispatchAction(DTutorialMessageBubbleViewAction action)
	{
	}

	[Address(RVA="0x1114154", Offset="0x1114154", VA="0x1114154", Slot="6")]
	public void HandleDispatchAction(DViewShownAction action)
	{
	}

	[Address(RVA="0x11141D4", Offset="0x11141D4", VA="0x11141D4", Slot="7")]
	public void HandleDispatchAction(DViewHiddenAction action)
	{
	}

	[Address(RVA="0x1114254", Offset="0x1114254", VA="0x1114254", Slot="9")]
	public void HandleDispatchAction(DBattleUnitsControllerAction action)
	{
	}

	[Address(RVA="0x1114278", Offset="0x1114278", VA="0x1114278", Slot="10")]
	public void HandleDispatchAction(DBattleFullscreenInputAction action)
	{
	}

	[Address(RVA="0x111377C", Offset="0x111377C", VA="0x111377C")]
	private void HideMessage()
	{
	}

	[Address(RVA="0x11132D8", Offset="0x11132D8", VA="0x11132D8")]
	public void Initialize(Action finished)
	{
	}

	[Address(RVA="0x111430C", Offset="0x111430C", VA="0x111430C")]
	private bool IsShutdown()
	{
		return new bool();
	}

	[Address(RVA="0x1114314", Offset="0x1114314", VA="0x1114314")]
	private void PauseBattle(bool smooth = true)
	{
	}

	[Address(RVA="0x1114B90", Offset="0x1114B90", VA="0x1114B90")]
	private void ResumeBattle()
	{
	}

	[Address(RVA="0x1113A8C", Offset="0x1113A8C", VA="0x1113A8C")]
	private void ShowMessage(BattleLib_UpdateResult.Types.BattleMessage message)
	{
	}

	[Address(RVA="0x1114428", Offset="0x1114428", VA="0x1114428")]
	private bool ShowPointAt(BattleMessage message, string pointAtIdOverride = // 
	// Current member / type: System.Boolean BattleMessageController::ShowPointAt(Gamedata.BattleMessage,System.String)
	// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
	// 
	// Product version: 2018.1.123.0
	// Exception in: System.Boolean ShowPointAt(Gamedata.BattleMessage,System.String)
	// 
	// Object reference not set to an instance of an object.
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
	//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
	//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
	// 
	// mailto: JustDecompilePublicFeedback@telerik.com


	[Address(RVA="0x1114818", Offset="0x1114818", VA="0x1114818")]
	private bool ShowPointAtUnit(BattleMessage message, byte unitId)
	{
		return new bool();
	}

	[Address(RVA="0x1113630", Offset="0x1113630", VA="0x1113630")]
	public void Shutdown()
	{
	}

	[Address(RVA="0x11138DC", Offset="0x11138DC", VA="0x11138DC")]
	public void TickUpdate()
	{
	}

	[Address(RVA="0x1114078", Offset="0x1114078", VA="0x1114078")]
	private void TryShowNextMessage()
	{
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B02C", Offset="0x104B02C")]
	[Serializable]
	private sealed class <>c
	{
		[FieldOffset(Offset="0x0")]
		public readonly static BattleMessageController.<>c <>9;

		[FieldOffset(Offset="0x8")]
		public static DOGetter<float> <>9__4_0;

		[FieldOffset(Offset="0x10")]
		public static Func<AView, bool> <>9__15_0;

		[Address(RVA="0x1114C88", Offset="0x1114C88", VA="0x1114C88")]
		static <>c()
		{
		}

		[Address(RVA="0x1114CEC", Offset="0x1114CEC", VA="0x1114CEC")]
		public <>c()
		{
		}

		[Address(RVA="0x1114CF4", Offset="0x1114CF4", VA="0x1114CF4")]
		internal float <Initialize>b__4_0()
		{
			return new float();
		}

		[Address(RVA="0x1114D54", Offset="0x1114D54", VA="0x1114D54")]
		internal bool <ShowMessage>b__15_0(AView view)
		{
			return new bool();
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFEC", Offset="0x104AFEC")]
	private sealed class <>c__DisplayClass4_0
	{
		[FieldOffset(Offset="0x10")]
		public BattleMessageController <>4__this;

		[FieldOffset(Offset="0x18")]
		public Action finished;

		[Address(RVA="0x1113628", Offset="0x1113628", VA="0x1113628")]
		public <>c__DisplayClass4_0()
		{
		}

		[Address(RVA="0x1114D88", Offset="0x1114D88", VA="0x1114D88")]
		internal void <Initialize>b__1(float val)
		{
		}

		[Address(RVA="0x1114E14", Offset="0x1114E14", VA="0x1114E14")]
		internal void <Initialize>b__2(Action executed)
		{
		}

		[Address(RVA="0x1114F74", Offset="0x1114F74", VA="0x1114F74")]
		internal void <Initialize>b__3(Action executed)
		{
		}

		[Address(RVA="0x11150D4", Offset="0x11150D4", VA="0x11150D4")]
		internal void <Initialize>b__4(Action executed)
		{
		}

		[Address(RVA="0x1115234", Offset="0x1115234", VA="0x1115234")]
		internal void <Initialize>b__5()
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104AFFC", Offset="0x104AFFC")]
	private sealed class <>c__DisplayClass4_1
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleMessageController.<>c__DisplayClass4_0 CS$<>8__locals1;

		[Address(RVA="0x1114F6C", Offset="0x1114F6C", VA="0x1114F6C")]
		public <>c__DisplayClass4_1()
		{
		}

		[Address(RVA="0x11152AC", Offset="0x11152AC", VA="0x11152AC")]
		internal void <Initialize>b__6(TutorialMessageBubbleView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B00C", Offset="0x104B00C")]
	private sealed class <>c__DisplayClass4_2
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleMessageController.<>c__DisplayClass4_0 CS$<>8__locals2;

		[Address(RVA="0x11150CC", Offset="0x11150CC", VA="0x11150CC")]
		public <>c__DisplayClass4_2()
		{
		}

		[Address(RVA="0x1115314", Offset="0x1115314", VA="0x1115314")]
		internal void <Initialize>b__7(TutorialPointAtView view)
		{
		}
	}

	[Attribute(Name="CompilerGeneratedAttribute", RVA="0x104B01C", Offset="0x104B01C")]
	private sealed class <>c__DisplayClass4_3
	{
		[FieldOffset(Offset="0x10")]
		public Action executed;

		[FieldOffset(Offset="0x18")]
		public BattleMessageController.<>c__DisplayClass4_0 CS$<>8__locals3;

		[Address(RVA="0x111522C", Offset="0x111522C", VA="0x111522C")]
		public <>c__DisplayClass4_3()
		{
		}

		[Address(RVA="0x111537C", Offset="0x111537C", VA="0x111537C")]
		internal void <Initialize>b__8(SeekerView view)
		{
		}
	}
}