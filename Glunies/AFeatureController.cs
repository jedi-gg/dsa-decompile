using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Glunies
{
	public abstract class AFeatureController : IDispatchHandler<DViewAction>, IDispatchHandler, ILoggable<LogCategory>
	{
		[Attribute(Name="InjectAttribute", RVA="0x1063FBC", Offset="0x1063FBC")]
		[FieldOffset(Offset="0x10")]
		protected DiContainer _container;

		[Attribute(Name="InjectAttribute", RVA="0x1063FCC", Offset="0x1063FCC")]
		[FieldOffset(Offset="0x18")]
		protected GameStateMachine _gameStateMachine;

		[Attribute(Name="InjectAttribute", RVA="0x1063FDC", Offset="0x1063FDC")]
		[FieldOffset(Offset="0x20")]
		protected DispatchSystem _dispatchSystem;

		[Attribute(Name="InjectAttribute", RVA="0x1063FEC", Offset="0x1063FEC")]
		[FieldOffset(Offset="0x28")]
		protected ViewController _viewController;

		[Attribute(Name="InjectAttribute", RVA="0x1063FFC", Offset="0x1063FFC")]
		[FieldOffset(Offset="0x30")]
		protected GameStateMachineNavigationTracker _stateHistoryTracker;

		[Attribute(Name="InjectAttribute", RVA="0x106400C", Offset="0x106400C")]
		[FieldOffset(Offset="0x38")]
		protected PopupControllerRegistry _popupControllerRegistry;

		[Attribute(Name="InjectAttribute", RVA="0x106401C", Offset="0x106401C")]
		[FieldOffset(Offset="0x40")]
		private SingleAssetRegistry _sceneAssetRegistry;

		[FieldOffset(Offset="0x48")]
		protected List<AStandardView> _views;

		[FieldOffset(Offset="0x50")]
		protected bool _featureInitialized;

		[FieldOffset(Offset="0x51")]
		protected bool _isShutdown;

		[FieldOffset(Offset="0x58")]
		private AFeatureScene _scene;

		[FieldOffset(Offset="0x60")]
		private GameObject[] _sceneRootObjects;

		public LogCategory LogCategory
		{
			[Address(RVA="0x14F4B18", Offset="0x14F4B18", VA="0x14F4B18", Slot="5")]
			get
			{
				return new LogCategory();
			}
		}

		[Address(RVA="0x14F57E8", Offset="0x14F57E8", VA="0x14F57E8")]
		protected AFeatureController()
		{
		}

		[Address(RVA="0x14F5408", Offset="0x14F5408", VA="0x14F5408", Slot="10")]
		protected virtual GameStateTransitionContext CreateContext()
		{
			return null;
		}

		[Address(RVA="0x1E4A894", Offset="0x1E4A894", VA="0x1E4A894")]
		protected AFeatureController.LoadViewJob<T> CreateLoadViewJob<T>(bool startActive = true)
		where T : AStandardView, new()
		{
			return null;
		}

		[Address(RVA="0x19A0E58", Offset="0x19A0E58", VA="0x19A0E58")]
		protected void EnterState<TState>(GameStateTransitionContext context = // 
		// Current member / type: System.Void Glunies.AFeatureController::EnterState(Glunies.GameStateTransitionContext)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void EnterState(Glunies.GameStateTransitionContext)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14F55A8", Offset="0x14F55A8", VA="0x14F55A8")]
		protected void FeatureInitializeFailed(string debugMessage)
		{
		}

		[Address(RVA="0x14F546C", Offset="0x14F546C", VA="0x14F546C", Slot="12")]
		protected virtual void FeatureInitializeFinish(GameStateTransitionContext context)
		{
		}

		[Address(RVA="0x14F5240", Offset="0x14F5240", VA="0x14F5240")]
		public GameStateTransitionContext GetCurrentContext()
		{
			return null;
		}

		[Address(RVA="0x14F53D8", Offset="0x14F53D8", VA="0x14F53D8", Slot="9")]
		protected virtual void HandleBackButton(AView view)
		{
		}

		[Address(RVA="0x14F52A0", Offset="0x14F52A0", VA="0x14F52A0", Slot="4")]
		public void HandleDispatchAction(DViewAction action)
		{
		}

		[Address(RVA="0x14F518C", Offset="0x14F518C", VA="0x14F518C")]
		public bool HandleNewContext(GameStateTransitionContext context)
		{
			return new bool();
		}

		[Address(RVA="0x14F5544", Offset="0x14F5544", VA="0x14F5544")]
		private void HideAllScrims()
		{
		}

		[Address(RVA="0x14F4B20", Offset="0x14F4B20", VA="0x14F4B20", Slot="6")]
		public virtual void Initialize(GameStateTransitionContext context)
		{
		}

		[Address(RVA="0x14F5464", Offset="0x14F5464", VA="0x14F5464", Slot="11")]
		protected virtual bool InternalHandleNewContext(GameStateTransitionContext context)
		{
			return new bool();
		}

		[Address(RVA="0x14F53D0", Offset="0x14F53D0", VA="0x14F53D0")]
		protected bool IsShutdown()
		{
			return new bool();
		}

		[Address(RVA="0x19A0F44", Offset="0x19A0F44", VA="0x19A0F44")]
		protected void LoadAndRegisterScene<T>(string sceneAsset, Action<T> sceneLoaded, Action sceneLoadFailed = // 
		// Current member / type: System.Void Glunies.AFeatureController::LoadAndRegisterScene(System.String,System.Action`1<T>,System.Action,System.Boolean)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void LoadAndRegisterScene(System.String,System.Action<T>,System.Action,System.Boolean)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x19A1108", Offset="0x19A1108", VA="0x19A1108")]
		protected void LoadAndRegisterView<T>(Action<T> viewLoaded, bool startActive = true)
		where T : AStandardView, new()
		{
		}

		[Address(RVA="0x14F5654", Offset="0x14F5654", VA="0x14F5654")]
		protected void ShowHud(DHudConfig? hudConfig = // 
		// Current member / type: System.Void Glunies.AFeatureController::ShowHud(System.Nullable`1<DHudConfig>)
		// File path: C:\Users\nesin\Downloads\Il2CppDumper-v6.1.8\DummyDll\Assembly-CSharp.dll
		// 
		// Product version: 2018.1.123.0
		// Exception in: System.Void ShowHud(System.Nullable<DHudConfig>)
		// 
		// Object reference not set to an instance of an object.
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 2040
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition , Boolean ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1617
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1916
		//    at Telerik.JustDecompiler.Languages.BaseImperativeLanguageWriter.Write(MethodDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseImperativeLanguageWriter.cs:line 1841
		//    at ..WriteInternal(IMemberDefinition ) in C:\Builds\556\Behemoth\ReleaseBranch Production Build NT\Sources\OpenSource\Cecil.Decompiler\Languages\BaseLanguageWriter.cs:line 447
		// 
		// mailto: JustDecompilePublicFeedback@telerik.com


		[Address(RVA="0x14F4B74", Offset="0x14F4B74", VA="0x14F4B74", Slot="7")]
		public virtual void Shutdown()
		{
		}

		[Address(RVA="0x14F5150", Offset="0x14F5150", VA="0x14F5150", Slot="8")]
		public virtual void TickUpdate()
		{
		}

		[Address(RVA="0x14F4D98", Offset="0x14F4D98", VA="0x14F4D98")]
		private void ValidateNoDanglingGameObjectsUnderSceneRoot()
		{
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050E98", Offset="0x1050E98")]
		private sealed class <>c__DisplayClass16_0<T>
		where T : AStandardView, new()
		{
			[FieldOffset(Offset="0x0")]
			public AFeatureController <>4__this;

			[FieldOffset(Offset="0x0")]
			public Action<T> viewLoaded;

			[Address(RVA="0x1BFEC74", Offset="0x1BFEC74", VA="0x1BFEC74")]
			public <>c__DisplayClass16_0()
			{
			}

			[Address(RVA="0x1BFECA0", Offset="0x1BFECA0", VA="0x1BFECA0")]
			internal void <LoadAndRegisterView>b__0(T view)
			{
			}
		}

		[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1050EA8", Offset="0x1050EA8")]
		private sealed class <>c__DisplayClass17_0<T>
		where T : AFeatureScene
		{
			[FieldOffset(Offset="0x0")]
			public AFeatureController <>4__this;

			[FieldOffset(Offset="0x0")]
			public bool startActive;

			[FieldOffset(Offset="0x0")]
			public Action<T> sceneLoaded;

			[FieldOffset(Offset="0x0")]
			public Action sceneLoadFailed;

			[Address(RVA="0x1BFED50", Offset="0x1BFED50", VA="0x1BFED50")]
			public <>c__DisplayClass17_0()
			{
			}

			[Address(RVA="0x1BFED7C", Offset="0x1BFED7C", VA="0x1BFED7C")]
			internal void <LoadAndRegisterScene>b__0(AssetHandle assetHandle)
			{
			}
		}

		protected class LoadViewJob<T> : IJob
		where T : AStandardView, new()
		{
			[FieldOffset(Offset="0x0")]
			private AFeatureController _controller;

			[FieldOffset(Offset="0x0")]
			private bool _startActive;

			[Address(RVA="0x1BFF01C", Offset="0x1BFF01C", VA="0x1BFF01C")]
			public LoadViewJob(AFeatureController controller, bool startActive = true)
			{
			}

			[Address(RVA="0x1BFF068", Offset="0x1BFF068", VA="0x1BFF068", Slot="4")]
			public void Execute(Action executed)
			{
			}

			[Attribute(Name="CompilerGeneratedAttribute", RVA="0x1051698", Offset="0x1051698")]
			private sealed class <>c__DisplayClass1_0
			{
				[FieldOffset(Offset="0x0")]
				public Action executed;

				[Address(RVA="0x1BFEFDC", Offset="0x1BFEFDC", VA="0x1BFEFDC")]
				public <>c__DisplayClass1_0()
				{
				}

				[Address(RVA="0x1BFF008", Offset="0x1BFF008", VA="0x1BFF008")]
				internal void <Execute>b__0(T view)
				{
				}
			}
		}
	}
}