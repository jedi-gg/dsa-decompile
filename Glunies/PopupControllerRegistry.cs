using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Zenject;

namespace Glunies
{
	public class PopupControllerRegistry : IDispatchHandler<DPopupControllerAction>, IDispatchHandler, IDispatchHandler<DPopupRequestAction>, ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063D8C", Offset="0x1063D8C")]
		[FieldOffset(Offset="0x10")]
		private DiContainer _diContainer;

		[Attribute(Name="InjectAttribute", RVA="0x1063D9C", Offset="0x1063D9C")]
		[FieldOffset(Offset="0x18")]
		private DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1063DAC", Offset="0x1063DAC")]
		[FieldOffset(Offset="0x20")]
		private FeatureLockController _featureLockController;

		[Attribute(Name="InjectAttribute", RVA="0x1063DBC", Offset="0x1063DBC")]
		[FieldOffset(Offset="0x28")]
		private ContextualMessageController _contextualMessageController;

		[FieldOffset(Offset="0x30")]
		private List<APopupController> _activePopups;

		[FieldOffset(Offset="0x38")]
		private List<APopupController> _iterationList;

		public LogCategory LogCategory
		{
			[Address(RVA="0x1529F28", Offset="0x1529F28", VA="0x1529F28", Slot="6")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x152ACC0", Offset="0x152ACC0", VA="0x152ACC0")]
		public PopupControllerRegistry()
		{
		}

		[Address(RVA="0x152A864", Offset="0x152A864", VA="0x152A864")]
		public bool CanShow(Type popupControllerType, bool showLockedMessage)
		{
			return new bool();
		}

		[Address(RVA="0x152A22C", Offset="0x152A22C", VA="0x152A22C")]
		public void CloseAllPopups()
		{
		}

		[Address(RVA="0x152A650", Offset="0x152A650", VA="0x152A650")]
		public ReadOnlyCollection<DPopupHistory> CreateHistoryFromActivePopups()
		{
			return null;
		}

		[Address(RVA="0x152A8E4", Offset="0x152A8E4", VA="0x152A8E4", Slot="4")]
		public void HandleDispatchAction(DPopupControllerAction action)
		{
		}

		[Address(RVA="0x152A9B4", Offset="0x152A9B4", VA="0x152A9B4", Slot="5")]
		public void HandleDispatchAction(DPopupRequestAction action)
		{
		}

		[Address(RVA="0x1529F30", Offset="0x1529F30", VA="0x1529F30")]
		public void Initialize()
		{
		}

		[Address(RVA="0x152AB40", Offset="0x152AB40", VA="0x152AB40")]
		private APopupController Instantiate(Type popupControllerType)
		{
			return null;
		}

		[Address(RVA="0x152A2DC", Offset="0x152A2DC", VA="0x152A2DC")]
		public void Restore(ReadOnlyCollection<DPopupHistory> history, Action completed)
		{
		}

		[Address(RVA="0x152A9C4", Offset="0x152A9C4", VA="0x152A9C4")]
		private void Show(Type popupControllerType, Action completed = // 
		// Current member / type: System.Void Glunies.PopupControllerRegistry::Show(System.Type,System.Action,Glunies.ITransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void Show(System.Type,System.Action,Glunies.ITransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x1529F68", Offset="0x1529F68", VA="0x1529F68")]
		public void Shutdown()
		{
		}

		[Address(RVA="0x152A0B4", Offset="0x152A0B4", VA="0x152A0B4")]
		public void TickUpdate()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050DA8", Offset="0x1050DA8")]
		private sealed class <>c__DisplayClass12_0
		{
			[FieldOffset(Offset="0x10")]
			public PopupControllerRegistry <>4__this;

			[FieldOffset(Offset="0x18")]
			public Action completed;

			[Address(RVA="0x152ACB8", Offset="0x152ACB8", VA="0x152ACB8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Address(RVA="0x152AD50", Offset="0x152AD50", VA="0x152AD50")]
			internal void <Show>b__0()
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050D98", Offset="0x1050D98")]
		private sealed class <>c__DisplayClass6_0
		{
			[FieldOffset(Offset="0x10")]
			public DPopupHistory popupHistory;

			[FieldOffset(Offset="0x20")]
			public PopupControllerRegistry <>4__this;

			[Address(RVA="0x152A648", Offset="0x152A648", VA="0x152A648")]
			public <>c__DisplayClass6_0()
			{
			}

			[Address(RVA="0x152ADE0", Offset="0x152ADE0", VA="0x152ADE0")]
			internal void <Restore>b__0(Action executed)
			{
			}
		}
	}
}